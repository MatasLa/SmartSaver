using System.Collections.Generic;
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
        private enum Importance
        {
            Necessary = 1,
            High,
            Medium,
            Low,
            Unnecesary,
        };
        
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
        //Code below is still very much WIP
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
                    switch (data.Importance)
                    {
                        case (int)Importance.Necessary:
                            break; //importance of necessary - unchangable income

                        case (int)Importance.High:
                            savedAmount += (data.Amount * 0.25M);
                            AddToIncomeOfferList(data.ID, data.Amount * 0.25M);
                            break;

                        case (int)Importance.Medium:
                            savedAmount += (data.Amount * 0.5M);
                            AddToIncomeOfferList(data.ID, data.Amount * 0.5M);
                            break;

                        case (int)Importance.Low:
                            savedAmount += (data.Amount * 0.75M);
                            AddToIncomeOfferList(data.ID, data.Amount * 0.75M);
                            break;

                        case (int)Importance.Unnecesary:
                            savedAmount += (data.Amount);
                            AddToIncomeOfferList(data.ID, data.Amount);
                            break;

                    }
                }
                foreach (DataEntry data in data.Expenses)
                {
                    switch (data.Importance)
                    {
                        case (int)Importance.Necessary:
                            break; //importance of necessary - unavoidable expense

                        case (int)Importance.High:
                            savedAmount += (data.Amount * 0.25M);
                            AddToExpensesOfferList(data.ID, data.Amount * 0.25M);
                            break;

                        case (int)Importance.Medium:
                            savedAmount += (data.Amount * 0.5M);
                            AddToExpensesOfferList(data.ID, data.Amount * 0.5M);
                            break;

                        case (int)Importance.Low:
                            savedAmount += (data.Amount * 0.75M);
                            AddToExpensesOfferList(data.ID, data.Amount * 0.75M);
                            break;

                        case (int)Importance.Unnecesary:
                            savedAmount += (data.Amount);
                            AddToIncomeOfferList(data.ID, data.Amount);
                            break;
                    }
                }

            }
            return true; // after having saved enough
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
