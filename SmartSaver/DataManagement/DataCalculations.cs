using System.Collections.Generic;
using System.Linq;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    public class DataCalculations
    {
        private Data data;
        public DataCalculations(Data data)
        {
            this.data = data;
        }

        //Temporary hardcoded local parameters (should be taken from front-end later)
        private SavingType SavingChoice;
        private decimal regularSavingValue = 0.25M;
        private decimal maximalSavingValue = 0.5M;
        private decimal minimalSavingValue = 0.1M;
        private decimal savingRatio = 1M;


        private List<OfferData> IncomeOffers { get; } = new List<OfferData>();
        private List<OfferData> ExpensesOffers { get; } = new List<OfferData>();



        public decimal GetTotalIncome()
        {
            return data.Income.Sum(entry => entry.Amount);
        }

        public decimal GetTotalExpenses()
        {
            return data.Expenses.Sum(entry => entry.Amount);
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
        public bool GetSuggestedExpensesOffers(List<DataEntry> entryList, SavingType saving, Goal goal, List<OfferData> offerList)
        {
            offerList = new List<OfferData>();

            var dataFilter = new DataFilter(data);

            for (int i = 5; i > 1; i--)
            {
                List<DataEntry> expenses = dataFilter.GetExpenses((Importance)i);

            }

            //offerListas = kazkas;

            return true;
        }
        //

        public bool CheckGoal(Goal goal)
        {
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
            //Goal goal = new Goal();
            
            foreach (DataEntry data in data.Income)
            {
                ChoosingImportance(data, EntryType.Income);
            }
            foreach (DataEntry data in data.Expenses)
            {
                ChoosingImportance(data, EntryType.Expense);
            }
            return true; // after having saved enough
        }

        private bool ChoosingImportance(DataEntry data, EntryType entryType)
        {
            switch (data.Importance)
            {
                case (int)Importance.Necessary:
                    return true; //importance of necessary - unchangable income

                case (int)Importance.High:
                    return ImportanceBasedCalculation(data, savingRatio, entryType);

                case (int)Importance.Medium:
                    return ImportanceBasedCalculation(data, savingRatio * 2, entryType);

                case (int)Importance.Low:
                    return ImportanceBasedCalculation(data, savingRatio * 3, entryType);

                case (int)Importance.Unnecessary:
                    return ImportanceBasedCalculation(data, savingRatio * 4, entryType);

                default:
                    return true;

            }
        }

        private bool ImportanceBasedCalculation(DataEntry data, decimal savingRatio, EntryType entryType)
        {
            if (SavingChoice == SavingType.Minimal)
            {
                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.Id, data.Amount * (minimalSavingValue * savingRatio));
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.Id, data.Amount * (minimalSavingValue * savingRatio));
                }
                return true;
            }

            else if (SavingChoice == SavingType.Maximal)
            {
                decimal temp;

                var maximalSaving = (maximalSavingValue * savingRatio) >= 1;

                if (maximalSaving)
                {
                    temp = 1M; //Hardcoded 1, due to nature of maximal saving theory
                }
                else
                {
                    temp = maximalSavingValue;
                }

                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.Id, data.Amount * temp);
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.Id, data.Amount * temp);
                }
                return true;
            }

            else if (SavingChoice == SavingType.Regular)
            {
                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.Id, data.Amount * (regularSavingValue * savingRatio));
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.Id, data.Amount * (regularSavingValue * savingRatio));
                }
            }
            return true;
        }

        private void AddToIncomeOfferList(int id, decimal amount)
        {
            OfferData newIncomeOffers = new OfferData(id, amount);
            IncomeOffers.Add(newIncomeOffers);
        }
        private void AddToExpensesOfferList(int id, decimal amount)
        {
            OfferData newExpensesOffers = new OfferData(id, amount);
            ExpensesOffers.Add(newExpensesOffers);
        }
    }
}