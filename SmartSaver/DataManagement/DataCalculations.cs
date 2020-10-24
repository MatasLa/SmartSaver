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
        private const decimal _savingRatio = 1M;

        //Temporary hardcoded local parameters (should be taken from front-end later)
        private const decimal _regularSavingValue = 0.25M;
        private const decimal _maximalSavingValue = 0.5M;
        private const decimal _minimalSavingValue = 0.1M;
        

        private List<OfferData> IncomeOffers { get; } = new List<OfferData>();
        private List<OfferData> ExpensesOffers { get; } = new List<OfferData>();



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
        public bool GetSuggestedExpensesOffers(Goal goal, SavingType savingType, List<OfferData> offerList)
        {
            _savingType = savingType;
            var savedAmount = 0M;
            var dataFilter = new DataFilter(_data);
            
            for (int i = 2; i >= 5; i++)
            {
                List<DataEntry> expenses = dataFilter.GetExpenses((Importance)i);
                foreach (DataEntry entry in expenses)
                {
                    decimal amountAfterSaving;

                    if (_savingType == SavingType.Minimal)
                    {
                        amountAfterSaving = entry.Amount * _savingRatio * (i - 1) * _minimalSavingValue;
                    }
                    else if (_savingType == SavingType.Regular)
                    {
                        amountAfterSaving = entry.Amount * _savingRatio * (i - 1) * _regularSavingValue;
                    }
                    else
                    {
                        decimal temp;
                        var maximalSaving = (_maximalSavingValue * _savingRatio * (i - 1)) >= 1;
                        if (maximalSaving)
                        {
                            temp = 1M; //Hardcoded 1, due to nature of maximal saving theory
                        }
                        else
                        {
                            temp = _maximalSavingValue;
                        }
                        amountAfterSaving = entry.Amount * temp;
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
                if ((CheckBalance() - goal.Price) >= 0)
                {
                    return true;    //can already buy this month
                }
                else
                {
                    return GenerallySavingMoney(); //needs saving
                }
            }
            else
            {
                return false;   //user already in debt(negative balance) without adding goal expenses
            }
        }

        private bool GenerallySavingMoney()
        {
            foreach (DataEntry data in _data.Income)
            {
                ChoosingImportance(data, EntryType.Income);
            }
            foreach (DataEntry data in _data.Expenses)
            {
                ChoosingImportance(data, EntryType.Expense);
            }
            return true;
        }

        private bool ChoosingImportance(DataEntry data, EntryType entryType)
        {
            switch (data.Importance)
            {
                case (int)Importance.Necessary:
                    return true; //importance of necessary - unchangable income

                case (int)Importance.High:
                    return ImportanceBasedCalculation(data, _savingRatio, entryType);

                case (int)Importance.Medium:
                    return ImportanceBasedCalculation(data, _savingRatio * 2, entryType);

                case (int)Importance.Low:
                    return ImportanceBasedCalculation(data, _savingRatio * 3, entryType);

                case (int)Importance.Unnecessary:
                    return ImportanceBasedCalculation(data, _savingRatio * 4, entryType);

                default:
                    return true;

            }
        }

        private bool ImportanceBasedCalculation(DataEntry data, decimal importanceBasedSavingRatio, EntryType entryType)
        {
              if (_savingType == SavingType.Minimal)
            {
                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data, data.Amount * (_minimalSavingValue * importanceBasedSavingRatio));
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data, data.Amount * (_minimalSavingValue * importanceBasedSavingRatio));
                }
                return true;
            }

            else if (_savingType == SavingType.Maximal)
            {
                decimal temp;

                var maximalSaving = (_maximalSavingValue * importanceBasedSavingRatio) >= 1;

                if (maximalSaving)
                {
                    temp = 1M; //Hardcoded 1, due to nature of maximal saving theory
                }
                else
                {
                    temp = _maximalSavingValue;
                }

                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data, data.Amount * temp);
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data, data.Amount * temp);
                }
                return true;
            }

            else if (_savingType == SavingType.Regular)
            {
                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data, data.Amount * (_regularSavingValue * importanceBasedSavingRatio));
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data, data.Amount * (_regularSavingValue * importanceBasedSavingRatio));
                }
            }
            return true;
        }

        private void AddToIncomeOfferList(DataEntry entry, decimal amountAfterSaving)
        {
            OfferData newIncomeOffer = new OfferData(entry, amountAfterSaving);
            IncomeOffers.Add(newIncomeOffer);
        }
        private void AddToExpensesOfferList(DataEntry entry, decimal amountAfterSaving)
        {
            OfferData newExpensesOffer = new OfferData(entry, amountAfterSaving);
            ExpensesOffers.Add(newExpensesOffer);
        }
        private void AddToExpensesOfferList(DataEntry entry, decimal amountAfterSaving, List<OfferData> expensesOfferlist)
        {
            OfferData newExpensesOffer = new OfferData(entry, amountAfterSaving);
            expensesOfferlist.Add(newExpensesOffer);
        }
    }
}