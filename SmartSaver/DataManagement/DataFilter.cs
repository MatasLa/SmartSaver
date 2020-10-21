using System;
using System.Collections.Generic;
using System.Linq;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    /*Requires DataManager object, methods filter data by provided criteria*/
    public class DataFilter
    {
        private readonly Data _data;
        public DataFilter(Data data)
        {
            this._data = data;
        }



        #region This should be moved

        #region Totaled Income

        public decimal GetTotaledIncome()
        {
            return _data.Income.Sum(entry => entry.Amount);
        }

        public decimal GetTotaledIncome(DateTime date)
        {
            return GetIncome(date).Sum(entry => entry.Amount);
        }

        public decimal GetTotaledIncome(Importance importance)
        {
            return GetIncome(importance).Sum(entry => entry.Amount);
        }

        public decimal GetTotaledIncome(Importance importance, DateTime date)
        {
            return GetIncome(importance, date).Sum(entry => entry.Amount);
        }

        #endregion

        #region Totaled Expenses

        public decimal GetTotaledExpenses()
        {
            return _data.Expenses.Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpenses(DateTime date)
        {
            return GetExpenses(date).Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpenses(Importance importance)
        {
            return GetExpenses(importance).Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpenses(Importance importance, DateTime date)
        {
            return GetExpenses(importance, date).Sum(entry => entry.Amount);
        }

        #endregion

        #region Balance
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

        #endregion

        #region Until Today

        public decimal GetTotaledIncomeUntilToday()
        {
            return GetIncomeUntilToday().Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpensesUntilToday()
        {
            return GetExpensesUntilToday().Sum(entry => entry.Amount);
        }

        public decimal GetBalancesUntilToday()
        {
            return GetTotaledIncomeUntilToday() - GetTotaledExpensesUntilToday();
        }

        #endregion

        #region Until End Of This Month

        public decimal GetTotaledIncomeUntilEndOfThisMonth()
        {
            return GetIncomeUntilEndOfThisMonth().Sum(entry => entry.Amount);
        }

        public decimal GetTotaledExpensesUntilEndOfThisMonth()
        {
            return GetExpensesUntilEndOfThisMonth().Sum(entry => entry.Amount);
        }

        public decimal GetBalanceUntilEndOfThisMonth()
        {
            return GetTotaledIncomeUntilEndOfThisMonth() - GetTotaledExpensesUntilEndOfThisMonth();
        }

        #endregion

        #endregion



        public List<DataEntry> GetIncome(decimal amount) // higher than parameter amount
        {
            var temp = _data.Income.Where(x => x.Amount >= amount).ToList();
            return temp;
        }

        public List<DataEntry> GetIncome(DateTime dateTime) //by date
        {
            var temp = _data.Income.Where(x => (x.Date.Year == dateTime.Year) && (x.Date.Month == dateTime.Month)).ToList();
            return temp;
        }

        public List<DataEntry> GetIncome(Importance importance, DateTime dateTime)
        {
            var temp = _data.Income.Where(x => x.Importance == (int)importance
                                               && x.Date.Year == dateTime.Year && x.Date.Month == dateTime.Month).ToList();
            return temp;
        }

        public List<DataEntry> GetIncome(DateTime from, DateTime to)
        {
            var temp = _data.Income.Where(x => (x.Date >= from) && (x.Date <= to)).ToList();
            return temp;
        }

        public List<DataEntry> GetIncome(Importance importance)
        {
            var temp = _data.Income.Where(x => x.Importance == (int)importance).ToList();
            return temp;
        }

        public List<DataEntry> GetIncome(bool isMonthly = true)
        {
            var temp = _data.Income.Where(x => x.IsMonthly == isMonthly).ToList();
            return temp;
        }

        public List<DataEntry> GetIncomeUntilToday()
        {
            var temp = _data.Income.Where(x => x.Date <= DateTime.Today).ToList();
            return temp;
        }

        public List<DataEntry> GetIncomeUntilEndOfThisMonth()
        {
            var today = DateTime.Today;
            var temp = _data.Income.Where(x => (x.Date.Year <= today.Year) && (x.Date.Month <= today.Month)).ToList();
            return temp;
        }

      /*  public List<DataEntry> GetIncome(DateTime from)//from some date until today
        {
            var today = DateTime.Today;
            var temp = _data.Income.Where(x => (x.Date >= from) && (x.Date <= today)).ToList();
            return temp;
        }*/ 
        public List<DataEntry> GetExpenses(decimal amount) //higher than amount
        {
            var temp = _data.Expenses.Where(x => x.Amount >= amount).ToList();
            return temp;
        }

        public List<DataEntry> GetExpenses(DateTime dateTime)//by date
        {
            var temp = _data.Expenses.Where(x => (x.Date.Year == dateTime.Year) && (x.Date.Month == dateTime.Month)).ToList();
            return temp;
        }

        public List<DataEntry> GetExpenses(bool isMonthly = true)
        {
            var temp = _data.Expenses.Where(x => x.IsMonthly == isMonthly).ToList();
            return temp;
        }

         public List<DataEntry> GetExpenses(DateTime from, DateTime to)
         {
            var temp = _data.Expenses.Where(x => (x.Date >= from) && (x.Date <= to)).ToList();
            return temp;
         }

        public List<DataEntry> GetExpenses(Importance importance)
        {
          var temp = _data.Expenses.Where(x => x.Importance == (int)importance).ToList();
          return temp;
        }

        public List<DataEntry> GetExpenses(Importance importance, DateTime dateTime)
        {
          var temp = _data.Expenses.Where(x => x.Importance == (int)importance && x.Date.Year == dateTime.Year && x.Date.Month == dateTime.Month).ToList();
          return temp;
        }

        public List<DataEntry> GetExpensesUntilToday()
        {
            var temp = _data.Expenses.Where(x => x.Date <= DateTime.Today).ToList();
            return temp;
        }

        public List<DataEntry> GetExpensesUntilEndOfThisMonth()
        {
            var today = DateTime.Today;
            var temp = _data.Expenses.Where(x => (x.Date.Year <= today.Year) && (x.Date.Month <= today.Month)).ToList();
            return temp;
        }

    

       /* public List<DataEntry> GetExpenses(DateTime from)//from some date until today
        {
            var today = DateTime.Today;
            var temp = _data.Expenses.Where(x => (x.Date >= from) && (x.Date <= today)).ToList();
            return temp;
        }*/

    }
}
