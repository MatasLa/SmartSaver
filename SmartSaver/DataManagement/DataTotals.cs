using System;
using System.Linq;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    public class DataTotals
    {
        private readonly Data _data;
        private readonly DataFilter _dataFilter;
        public DataTotals(Data data, DataFilter dataFilter)
        {
            _data = data;
            _dataFilter = dataFilter;
        }

        //INCOMES
        public decimal GetTotaledIncome()
        {
            return _data.Income.Sum(entry => entry.Amount);
        }

        public decimal GetTotaledIncome(DateTime date)
        {
            return _dataFilter.GetIncome(date).Sum(entry => entry.Amount);
        }

        public decimal GetTotaledIncome(Importance importance)
        {
            return _dataFilter.GetIncome(importance).Sum(entry => entry.Amount);
        }

        public decimal GetTotaledIncome(Importance importance, DateTime date)
        {
            return _dataFilter.GetIncome(importance, date).Sum(entry => entry.Amount);
        }

        //EXPENSES
        public decimal GetTotaledExpenses()
        {
            return _data.Expenses.Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpenses(DateTime date)
        {
            return _dataFilter.GetExpenses(date).Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpenses(Importance importance)
        {
            return _dataFilter.GetExpenses(importance).Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpenses(Importance importance, DateTime date)
        {
            return _dataFilter.GetExpenses(importance, date).Sum(entry => entry.Amount);
        }

        //BALANCE
        public decimal GetBalance()/*Checks even future data*/
        {
            return GetTotaledIncome() - GetTotaledExpenses();
        }

        public decimal GetBalance(DateTime date)/*Checks even future data*/
        {
            return GetTotaledIncome(date) - GetTotaledExpenses(date);
        }

        public decimal GetBalance(Importance importance)/*Checks even future data*/
        {
            return GetTotaledIncome(importance) - GetTotaledExpenses(importance);
        }

        public decimal GetBalance(Importance importance, DateTime date)
        {
            return GetTotaledIncome(importance, date) - GetTotaledExpenses(importance, date);
        }

        //UNTIL TODAY
        public decimal GetTotaledIncomeUntilToday()
        {
            return _dataFilter.GetIncomeUntilToday().Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpensesUntilToday()
        {
            return _dataFilter.GetExpensesUntilToday().Sum(entry => entry.Amount);
        }

        public decimal GetBalancesUntilToday()
        {
            return GetTotaledIncomeUntilToday() - GetTotaledExpensesUntilToday();
        }

        //UNTIL END OF THIS MONTH
        public decimal GetTotaledIncomeUntilEndOfThisMonth()
        {
            return _dataFilter.GetIncomeUntilEndOfThisMonth().Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpensesUntilEndOfThisMonth()
        {
            return _dataFilter.GetExpensesUntilEndOfThisMonth().Sum(entry => entry.Amount);
        }

        public decimal GetBalanceUntilEndOfThisMonth()
        {
            return GetTotaledIncomeUntilEndOfThisMonth() - GetTotaledExpensesUntilEndOfThisMonth();
        }
    }
}
