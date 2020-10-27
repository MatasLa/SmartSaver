using System;
using System.Collections.Generic;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    public class DataCalculations
    {
        private readonly Data _data;
        private readonly DataFilter _dataFilter;
        private readonly DataTotalsCalculator _dataTotalsCalculator;

        private SavingType _savingType;

        //This might not be 1M in the future, that why we are keeping this
        private const decimal SavingRatio = 1M;
        private const decimal RegularSavingValue = 0.25M;
        private const decimal MaximalSavingValue = 0.5M;
        private const decimal MinimalSavingValue = 0.1M;

        private List<EntrySuggestion> IncomeOffers { get; } = new List<EntrySuggestion>();
        private List<EntrySuggestion> ExpensesOffers { get; } = new List<EntrySuggestion>();
        public DataCalculations(Data data, DataFilter dataFilter, DataTotalsCalculator dataTotalsCalculator)
        {
            _data = data;
            _dataFilter = dataFilter;
            _dataTotalsCalculator = dataTotalsCalculator;
            _savingType = SavingType.Regular;
        }

        

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

        
        public bool GetSuggestedExpensesOffers(List<DataEntry> entryList, Goal goal, SavingType savingType, List<EntrySuggestion> entrySuggestions)
        {
            _savingType = savingType;
            var savedAmount = 0M;
            var groupedByImportance = _dataFilter.GroupByImportance(entryList);

            for (var i = (int)Importance.Unnecessary; i > (int)Importance.Necessary; i--)
            {
                var expenses = groupedByImportance[i - 1].Entries;
                var ratio = (int) Importance.Unnecessary - i;
                foreach (var entry in expenses)
                {
                    decimal amountAfterSaving;

                    switch (_savingType)
                    {
                        case SavingType.Minimal:
                            amountAfterSaving = entry.Amount * SavingRatio * ratio * MinimalSavingValue;
                            break;
                        case SavingType.Regular:
                            amountAfterSaving = entry.Amount * SavingRatio * ratio * RegularSavingValue;
                            break;
                        case SavingType.Maximal:
                            var maximalSaving = MaximalSavingValue * SavingRatio * ratio >= 1;
                            var temp = maximalSaving ? 1M : MaximalSavingValue;
                            amountAfterSaving = entry.Amount * temp;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    AddToExpensesOfferList(entry, amountAfterSaving, entrySuggestions);

                    savedAmount += entry.Amount - amountAfterSaving;
                    if (goal.Price <= savedAmount)
                    {
                        return true; //Saved enough
                    }
                }               
            }
            return false; //Didn't save enough
        }

        public bool CheckGoal(Goal goal, SavingType savingType)
        {
            _savingType = savingType;
            if (_dataTotalsCalculator.GetBalance() >= 0)
            {
                //Goal goal = new Goal();
                return _dataTotalsCalculator.GetBalance() - goal.Price >= 0 || GenerallySavingMoney();
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
                              AddToIncomeOfferList(dataEntry, dataEntry.Amount * MinimalSavingValue * importanceBasedSavingRatio);
                              break;
                          case EntryType.Expense:
                              AddToExpensesOfferList(dataEntry, dataEntry.Amount * MinimalSavingValue * importanceBasedSavingRatio);
                              break;
                          default:
                              throw new ArgumentOutOfRangeException(nameof(entryType), entryType, null);
                      }
                      return true;
                  case SavingType.Maximal:
                  {
                      var maximalSaving = MaximalSavingValue * importanceBasedSavingRatio >= 1;

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
                              AddToIncomeOfferList(dataEntry, dataEntry.Amount * RegularSavingValue * importanceBasedSavingRatio);
                              break;
                          case EntryType.Expense:
                              AddToExpensesOfferList(dataEntry, dataEntry.Amount * RegularSavingValue * importanceBasedSavingRatio);
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

        private static void AddToExpensesOfferList(DataEntry entry, decimal amountAfterSaving, ICollection<EntrySuggestion> entrySuggestions)
        {
            var newExpensesOffer = new EntrySuggestion(entry, amountAfterSaving);
            entrySuggestions.Add(newExpensesOffer);
        }
    }
}
