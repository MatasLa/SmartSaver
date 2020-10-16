﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace ePiggy.DataManager
{
    public class DataCalculations
    {
        private Data data;
        public DataCalculations(Data data)
        {
            this.data = data;
        }
        
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

        //Code below is still very much WIP
        public bool CheckGoal(Goal goal)
        {
            if (IsBalancePositive())
            {
               // Goal goal = new Goal();
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
            {   //todo: implement saving, export the categories/things needed to save on
                foreach (var data in data.Income)
                {
                    switch (data.Importance)
                    {
                        case 1:
                            break; //importance of 1 - unchangable income
                        case 2:
                            savedAmount += (data.Amount * 0.25M);
                            AddToIncomeOfferList(data.Id, data.Amount * 0.25M);
                            break;
                        case 3:
                            savedAmount += (data.Amount * 0.5M);
                            AddToIncomeOfferList(data.Id, data.Amount * 0.5M);
                            break;
                        case 4:
                            savedAmount += (data.Amount * 0.75M);
                            AddToIncomeOfferList(data.Id, data.Amount * 0.75M);
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
                            savedAmount += (data.Amount * 0.25M);
                            AddToExpensesOfferList(data.Id, data.Amount * 0.25M);
                            break;
                        case 3:
                            savedAmount += (data.Amount * 0.5M);
                            AddToExpensesOfferList(data.Id, data.Amount * 0.5M);
                            break;
                        case 4:
                            savedAmount += (data.Amount * 0.75M);
                            AddToExpensesOfferList(data.Id, data.Amount * 0.75M);
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
            OfferData newIncomeOffers = new OfferData(id, amount);
            IncomeOffers.Add(newIncomeOffers);
        }
    }
}