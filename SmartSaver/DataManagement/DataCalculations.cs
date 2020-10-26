using System;
using System.Collections.Generic;
using System.Linq;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    public class DataCalculations
    {
        private readonly Data _data;
        private readonly DataFilter _dataFilter;
        private readonly DataTotalsCalculator _dataTotalsCalculator;
        public DataCalculations(Data data, DataFilter dataFilter, DataTotalsCalculator dataTotalsCalculator)
        {
            _data = data;
            _dataFilter = dataFilter;
            _dataTotalsCalculator = dataTotalsCalculator;
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
        public List<EntrySuggestion> IncomeOffers { get; } = new List<EntrySuggestion>();
        public List<EntrySuggestion> ExpensesOffers { get; } = new List<EntrySuggestion>();
        

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

        
        public bool IsBalancePositive()/*Same thing in DataFilter but by Date "IsBalancePositiveByDate"*/
        {
            return _dataTotalsCalculator.GetBalance() >= 0;
        }

        //WIP
        public bool GetSuggestedExpensesOffers(List<DataEntry> entryList, Goal goal, SavingType savingType, List<EntrySuggestion> offerList)
        {
            _savingType = savingType;
            var savedAmount = 0M;
            var groupedByImportance = _dataFilter.GroupByImportance(entryList);

            for(var i = (int)Importance.Unnecessary; i <= (int)Importance.High; i++)
            {
                var expenses = groupedByImportance[i].Entries;
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
                return (_dataTotalsCalculator.GetBalance() - goal.Price) >= 0 || GenerallySavingMoney();
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
            return dataEntry.Importance == (int)Importance.Necessary 
                   || ImportanceBasedCalculation(dataEntry, SavingRatio * (dataEntry.Importance - 1), entryType);

            //Worth keeping, if we ever want to adjust calculation ratios for balancing

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
        private bool ImportanceBasedCalculation(DataEntry dataEntry, decimal importanceBasedSavingRatio, EntryType entryType)
        {
              switch (_savingType)
              {
                  case SavingType.Minimal:
                      switch (entryType)
                      {
                          case EntryType.Income:
                              AddToIncomeOfferList(dataEntry, dataEntry.Amount * (MinimalSavingValue * importanceBasedSavingRatio));
                              break;
                          case EntryType.Expense:
                              AddToExpensesOfferList(dataEntry, dataEntry.Amount * (MinimalSavingValue * importanceBasedSavingRatio));
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
                              AddToIncomeOfferList(dataEntry, dataEntry.Amount * temp);
                              break;
                          case EntryType.Expense:
                              AddToExpensesOfferList(dataEntry, dataEntry.Amount * temp);
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
                              AddToIncomeOfferList(dataEntry, dataEntry.Amount * (RegularSavingValue * importanceBasedSavingRatio));
                              break;
                          case EntryType.Expense:
                              AddToExpensesOfferList(dataEntry, dataEntry.Amount * (RegularSavingValue * importanceBasedSavingRatio));
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
