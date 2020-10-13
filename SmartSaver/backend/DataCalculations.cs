using ePiggy.utilities;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Configuration;
using System.Drawing.Text;
using System.Reflection.Metadata;

namespace DataManager
{
    public class DataCalculations
    {
        private Data data;
        public DataCalculations(Data data)
        {
            this.data = data;
        }
        
        //Temporary local string 
        private string SavingChoice;
        
        public List<OfferData> IncomeOffers { get; } = new List<OfferData>();
        public List<OfferData> ExpensesOffers { get; } = new List<OfferData>();
        public decimal CheckBalance()/*Checks even future data*/
        {
            decimal sum = 0;
            foreach (DataEntry data in data.Income)
            {
                sum += data.Amount;
            }
            foreach (DataEntry data in data.Expenses)
            {
                sum -= data.Amount;
            }
            return sum;
        }

        public bool IsBalancePositive()/*Same thing in DataFilter but by Date "IsBalancePositiveByDate"*/
        {
            if (CheckBalance() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckGoal(Goal goal)
        {
            if (IsBalancePositive())
            {
                //Goal goal = new Goal();
                if((CheckBalance() - goal.Price) >= 0)
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
            decimal savedAmount = 0;
            //Goal goal = new Goal();
            decimal neededAmount = (goal.Price - CheckBalance());
            
            while ((neededAmount - savedAmount) > 0) //while(can't afford goal)
            {   //todo: improve saving
                foreach (DataEntry data in data.Income)
                {
                    savedAmount += SwitchCalculation(data, savedAmount, EntryType.Income);
                }
                foreach (DataEntry data in data.Expenses)
                {
                    savedAmount += SwitchCalculation(data, savedAmount, EntryType.Expense);
                }

            }
            return true; // after having saved enough
        }

        private decimal SwitchCalculation(DataEntry data, decimal savedAmount, EntryType entryType)
        {
            switch (data.Importance)
            {
                case (int)Importance.Necessary:
                    return savedAmount; //importance of necessary - unchangable income

                case (int)Importance.High:
                    return ImportanceCalculation(data, savedAmount, 1M, entryType);                    

                case (int)Importance.Medium:
                    return ImportanceCalculation(data, savedAmount, 2M, entryType);

                case (int)Importance.Low:
                    return ImportanceCalculation(data, savedAmount, 3M, entryType);                 

                case (int)Importance.Unnecesary:
                    return ImportanceCalculation(data, savedAmount, 4M, entryType);

                default:
                    return savedAmount;

            }
        }
        
        private decimal ImportanceCalculation(DataEntry data, decimal savedAmount, decimal percentage, EntryType entryType)
        {
            if (SavingChoice == "Minimal")
            {
                savedAmount += (data.Amount * (0.1M * percentage));
                if(entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.ID, data.Amount * (0.1M * percentage));
                }
                else if(entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.ID, data.Amount * (0.1M * percentage));
                }
                return savedAmount;
            }

            else if (SavingChoice == "Maximal")
            {
                bool maximalSaving;
                decimal temp;

                if((0.5M * percentage) >= 1)
                {
                    maximalSaving = true;
                }
                else
                {
                    maximalSaving = false;
                }

                if (maximalSaving)
                {
                    temp = 1M;
                }
                else
                {
                    temp = 0.5M;
                }

                savedAmount += (data.Amount * temp);
                if (entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.ID, data.Amount * temp);
                }
                else if (entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.ID, data.Amount * temp);
                }
                return savedAmount;
            }

            else
            {
                savedAmount += (data.Amount * (0.25M * percentage));
                if(entryType == EntryType.Income)
                {
                    AddToIncomeOfferList(data.ID, data.Amount * (0.25M * percentage));
                }
                else if(entryType == EntryType.Expense)
                {
                    AddToExpensesOfferList(data.ID, data.Amount * (0.25M * percentage));
                }
                return savedAmount;
            }
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
