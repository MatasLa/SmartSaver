using System;
using System.Collections.Generic;
using System.Linq;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    public class DataCalculations
    {
        private readonly Data _data;
        public DataCalculations(Data data)
        {
            _data = data;
        }

        private SavingType _savingType;
        private const decimal SavingRatio = 1M;

        //Temporary hardcoded local parameters (should be taken from front-end later)
        private const decimal RegularSavingValue = 0.25M;
        private const decimal MaximalSavingValue = 0.5M;
        private const decimal MinimalSavingValue = 0.1M;

        //Kept these ratios in case we decide to change how we calculate things 
        //private const decimal HighRatio = 1M;
        //private const decimal MediumRatio = 2M;
        //private const decimal LowRatio = 3M;
        //private const decimal UnnecessaryRatio = 4M;

        // These two lists are updated but never used according to resharper
        private List<EntrySuggestion> IncomeOffers { get; } = new List<EntrySuggestion>();
        private List<EntrySuggestion> ExpensesOffers { get; } = new List<EntrySuggestion>();
        

        public static int CalculateProgress(decimal saved, decimal target)
        {
            if (saved < 0)
            {
                return 0;
            }
            if (target <= 0)
            {
                return 100;
            }
            var progress = (int)(saved * 100 / target);
            return progress > 100 ? 100 : progress;
        }

        public decimal GetTotalIncome()
        {
            return _data.Income.Sum(entry => entry.Amount);
        }

        public decimal GetTotalExpenses()
        {
            return _data.Expenses.Sum(entry => entry.Amount);
        }

        public decimal CheckBalance()/*Checks even future data*/
        {
            return GetTotalIncome() - GetTotalExpenses();
        }

        public bool IsBalancePositive()/*Same thing in DataFilter but by Date "IsBalancePositiveByDate"*/
        {
            return CheckBalance() >= 0;
        }

        //WIP
        public bool GetSuggestedExpensesOffers(Goal goal, SavingType savingType, List<EntrySuggestion> offerList)
        {
            _savingType = savingType;
            var savedAmount = 0M;
            var dataFilter = new DataFilter(_data);

            // for (var i = 2; i >= 5; i++) expression is always false, you probably meant i <=5 so I changed
            // so I notice that you're going from the most important expenses to the least important, probably 
            // you would want to go the other way around
            // also these hardcoded numbers are bad, so I switched to Importance enum
            for(var i = (int)Importance.Unnecessary; i >= (int)Importance.High; i++)
            {
                var expenses = dataFilter.GetExpenses((Importance)i);
                foreach (var entry in expenses)
                {
                    decimal amountAfterSaving;

                    switch (_savingType)
                    {
                        case SavingType.Minimal:
                            amountAfterSaving = entry.Amount * SavingRatio * (i - 1) * MinimalSavingValue;
                            break;
                        case SavingType.Regular:
                            amountAfterSaving = entry.Amount * SavingRatio * (i - 1) * RegularSavingValue;
                            break;
                        default:
                        {
                            var maximalSaving = (MaximalSavingValue * SavingRatio * (i - 1)) >= 1;
                            var temp = maximalSaving ? 1M : MaximalSavingValue;
                            amountAfterSaving = entry.Amount * temp;
                            break;
                        }
                    }
                    AddToExpensesOfferList(entry, amountAfterSaving, offerList);

                    savedAmount += entry.Amount - amountAfterSaving;
                    if(goal.Price <= savedAmount)
                    {
                        return true; //Saved enough
                    }
                }               
            }
            return false; //Didn't save enough
        }
        //

        public bool CheckGoal(Goal goal, SavingType savingType)
        {
            _savingType = savingType;
            if (IsBalancePositive())
            {
                //Goal goal = new Goal();
                return (CheckBalance() - goal.Price) >= 0 || GenerallySavingMoney();
            }

            return false;   //user already in debt(negative balance) without adding goal expenses
        }

        private bool GenerallySavingMoney()
        {
            foreach (var data in _data.Income)
            {
                ChoosingImportance(data, EntryType.Income);
            }
            foreach (var data in _data.Expenses)
            {
                ChoosingImportance(data, EntryType.Expense);
            }
            return true;
        }

        private bool ChoosingImportance(DataEntry dataEntry, EntryType entryType)
        {
            //Since at the moment you have the ratios set as nearly the Enum values, i switched to a shorter return expression
            return dataEntry.Importance == (int)Importance.Necessary 
                   || ImportanceBasedCalculation(dataEntry, SavingRatio * (dataEntry.Importance - 1), entryType);


            //switch (dataEntry.Importance)
            //{
            //    case (int)Importance.Necessary:
            //        return true; //importance of necessary - unchangable income

            //    case (int)Importance.High:
            //        return ImportanceBasedCalculation(dataEntry, SavingRatio * HighRatio, entryType);

            //    case (int)Importance.Medium:
            //        return ImportanceBasedCalculation(dataEntry, SavingRatio * MediumRatio, entryType);

            //    case (int)Importance.Low:
            //        return ImportanceBasedCalculation(dataEntry, SavingRatio * LowRatio, entryType);

            //    case (int)Importance.Unnecessary:
            //        return ImportanceBasedCalculation(dataEntry, SavingRatio * UnnecessaryRatio, entryType);

            //    default:
            //        return true;

            //}
        }

        // ImportanceBasedCalculation always returns true, doesn't really make sense for a method to always return true
        private bool ImportanceBasedCalculation(DataEntry data, decimal importanceBasedSavingRatio, EntryType entryType)
        {
              switch (_savingType)
              {
                  case SavingType.Minimal:
                      switch (entryType)
                      {
                          case EntryType.Income:
                              AddToIncomeOfferList(data, data.Amount * (MinimalSavingValue * importanceBasedSavingRatio));
                              break;
                          case EntryType.Expense:
                              AddToExpensesOfferList(data, data.Amount * (MinimalSavingValue * importanceBasedSavingRatio));
                              break;
                          default:
                              throw new ArgumentOutOfRangeException(nameof(entryType), entryType, null);
                      }
                      return true;
                  case SavingType.Maximal:
                  {
                      var maximalSaving = (MaximalSavingValue * importanceBasedSavingRatio) >= 1;

                      var temp = maximalSaving ? 1M : MaximalSavingValue;

                      switch (entryType)
                      {
                          case EntryType.Income:
                              AddToIncomeOfferList(data, data.Amount * temp);
                              break;
                          case EntryType.Expense:
                              AddToExpensesOfferList(data, data.Amount * temp);
                              break;
                          default:
                              throw new ArgumentOutOfRangeException(nameof(entryType), entryType, null);
                      }
                      return true;
                  }
                  case SavingType.Regular:
                      switch (entryType)
                      {
                          case EntryType.Income:
                              AddToIncomeOfferList(data, data.Amount * (RegularSavingValue * importanceBasedSavingRatio));
                              break;
                          case EntryType.Expense:
                              AddToExpensesOfferList(data, data.Amount * (RegularSavingValue * importanceBasedSavingRatio));
                              break;
                          default:
                              throw new ArgumentOutOfRangeException(nameof(entryType), entryType, null);
                      }
                      break;
                  default:
                      throw new ArgumentOutOfRangeException();
              }
              return true;
        }

        // Methods below should be moved to another class, because of Single Responsibility principle - these are not calculations

        private void AddToIncomeOfferList(DataEntry entry, decimal amountAfterSaving)
        {
            var newIncomeOffer = new EntrySuggestion(entry, amountAfterSaving);
            IncomeOffers.Add(newIncomeOffer);
        }

        private void AddToExpensesOfferList(DataEntry entry, decimal amountAfterSaving)
        {
            var newExpensesOffer = new EntrySuggestion(entry, amountAfterSaving);
            ExpensesOffers.Add(newExpensesOffer);
        }

        private static void AddToExpensesOfferList(DataEntry entry, decimal amountAfterSaving, List<EntrySuggestion> entrySuggestions)
        {
            var newExpensesOffer = new EntrySuggestion(entry, amountAfterSaving);
            entrySuggestions.Add(newExpensesOffer);
        }

        // Methods above should be moved to another class, because of Single Responsibility principle - these are not calculations
    }
}