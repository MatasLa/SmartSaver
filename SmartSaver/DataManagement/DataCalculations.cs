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


        public List<OfferData> IncomeOffers { get; } = new List<OfferData>();
        public List<OfferData> ExpensesOffers { get; } = new List<OfferData>();

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
                    return SavingMoney(goal); //needs saving
                }
            }
            else
            {
                return false;   //user already in debt(negative balance) without adding goal expenses
            }
        }

        private bool SavingMoney(Goal goal)
        {
            var savedAmount = 0M;
            //Goal goal = new Goal();
            var neededAmount = (goal.Price - CheckBalance());
            
            while ((neededAmount - savedAmount) > 0) //while(can't afford goal)
            {
                foreach (DataEntry data in data.Income)
                {
                    savedAmount += ChoosingImportance(data, savedAmount, EntryType.Income);
                }
                foreach (DataEntry data in data.Expenses)
                {
                    savedAmount += ChoosingImportance(data, savedAmount, EntryType.Expense);
                }

            }
            return true; // after having saved enough
        }

        private decimal ChoosingImportance(DataEntry data, decimal savedAmount, EntryType entryType)
        {
            switch (data.Importance)
            {
                case (int)Importance.Necessary:
                    return savedAmount; //importance of necessary - unchangable income

                case (int)Importance.High:
                    return ImportanceBasedCalculation(data, savedAmount, savingRatio, entryType);

                case (int)Importance.Medium:
                    return ImportanceBasedCalculation(data, savedAmount, savingRatio * 2, entryType);

                case (int)Importance.Low:
                    return ImportanceBasedCalculation(data, savedAmount, savingRatio * 3, entryType);

                case (int)Importance.Unnecessary:
                    return ImportanceBasedCalculation(data, savedAmount, savingRatio * 4, entryType);

                default:
                    return savedAmount;

            }
        }

        private decimal ImportanceBasedCalculation(DataEntry data, decimal savedAmount, decimal savingRatio, EntryType entryType)
        {
            if (SavingChoice == SavingType.Minimal)
            {
                savedAmount += (data.Amount * (minimalSavingValue * savingRatio));
                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.Id, data.Amount * (minimalSavingValue * savingRatio));
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.Id, data.Amount * (minimalSavingValue * savingRatio));
                }
                return savedAmount;
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

                savedAmount += (data.Amount * temp);
                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.Id, data.Amount * temp);
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.Id, data.Amount * temp);
                }
                return savedAmount;
            }

            else if (SavingChoice == SavingType.Regular)
            {
                savedAmount += (data.Amount * (regularSavingValue * savingRatio));
                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.Id, data.Amount * (regularSavingValue * savingRatio));
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.Id, data.Amount * (regularSavingValue * savingRatio));
                }
                return savedAmount;
            }
            return savedAmount;
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