using Forms;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace DataManager
{
    public class OfferData
    {
        public OfferData(int id, double amount)
        {
            ID = id;
            Amount = amount;

        }
        public OfferData()
        {
            ID = 0;
            Amount = 0;
        }
        public int ID
        {
            get;
            set;
        }
        public double Amount
        {
            get;
            set;
        }
    }
    class DataCalculations
    {
        private Data data;
        public DataCalculations(Data data)
        {
            this.data = data;
        }
        
        
        public List<OfferData> IncomeOffers { get; } = new List<OfferData>();
        public List<OfferData> ExpensesOffers { get; } = new List<OfferData>();
        public double CheckBalance()
        {
            double sum = 0;
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
        public bool IsBalancePositive()
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
        //Code below is still very much WIP
        public bool CheckGoal()
        {
            if (IsBalancePositive())
            {
                Goal goal = new Goal();
                if((CheckBalance() - goal.price) >= 0)
                {
                    return true;    //can already buy this month
                }
                else
                {
                    return SavingMoney(); //needs saving
                }
            }
            else
            {
                return false;   //user already in debt(negative balance) without adding goal expenses
            }
        }
        
        private bool SavingMoney()
        {
            double savedAmount = 0;
            Goal goal = new Goal();
            double neededAmount = (goal.price - CheckBalance());
            
            while ((neededAmount - savedAmount) > 0) //while(can't afford goal)
            {   //todo: implement saving, export the categories/things needed to save on
                foreach (DataEntry data in data.Income)
                {
                    switch (data.Importance)
                    {
                        case 1:
                            break; //importance of 1 - unchangable income
                        case 2:
                            savedAmount += (data.Amount * 0.25);
                            AddToIncomeOfferList(data.ID, data.Amount * 0.25);
                            break;
                        case 3:
                            savedAmount += (data.Amount * 0.5);
                            AddToIncomeOfferList(data.ID, data.Amount * 0.5);
                            break;
                        case 4:
                            savedAmount += (data.Amount * 0.75);
                            AddToIncomeOfferList(data.ID, data.Amount * 0.75);
                            break;
                    }
                }
                foreach (DataEntry data in data.Expenses)
                {
                    switch (data.Importance)
                    {
                        case 1: //importance of 1 - necessary expense
                            break;
                        case 2:
                            savedAmount += (data.Amount * 0.25);
                            AddToExpensesOfferList(data.ID, data.Amount * 0.25);
                            break;
                        case 3:
                            savedAmount += (data.Amount * 0.5);
                            AddToExpensesOfferList(data.ID, data.Amount * 0.5);
                            break;
                        case 4:
                            savedAmount += (data.Amount * 0.75);
                            AddToExpensesOfferList(data.ID, data.Amount * 0.75);
                            break;
                    }
                }

            }
            return true; // after having saved enough
        }
        private void AddToIncomeOfferList(int id, double amount)
        {
            OfferData newIncomeOffers = new OfferData(id, amount);
            IncomeOffers.Add(newIncomeOffers);
        }
        private void AddToExpensesOfferList(int id, double amount)
        {
            OfferData newIncomeOffers = new OfferData(id, amount);
            IncomeOffers.Add(newIncomeOffers);
        }
    }
}
