using System;
using System.Collections.Generic;
using System.Linq;

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

        public decimal GetTotaledIncome()
        {
            return _data.Income.Sum(entry => entry.Amount);
		}

        public decimal GetTotaledIncome(DateTime date)
        {
			return GetIncomeByDate(date).Sum(entry => entry.Amount);
		}

        public decimal GetTotaledExpenses()
        {
            return _data.Expenses.Sum(entry => entry.Amount);
        }

		public decimal GetTotaledExpenses(DateTime date)
        {
            return GetExpensesByDate(date).Sum(entry => entry.Amount);
        }

		public decimal GetBalance()/*Checks even future data*/
        {
            return GetTotaledIncome() - GetTotaledExpenses();
		}

        public decimal GetBalance(DateTime date)/*Checks even future data*/
        {
            return GetTotaledIncome(date) - GetTotaledExpenses(date);
        }

		public bool IsBalancePositive()/*Same thing in DataFilter but by Date "IsBalancePositiveByDate"*/
        {
            return GetBalance() >= 0;
		}

        public bool IsBalancePositive(DateTime date)/*Same thing in DataFilter but by Date "IsBalancePositiveByDate"*/
        {
            return GetBalance(date) >= 0;
        }


		public List<DataEntry> GetIncomeHigherThan(decimal amount)
		{
			var temp = _data.Income.Where(x => x.Amount >= amount).ToList();
			return temp;
		}

		public List<DataEntry> GetExpensesHigherThan(decimal amount)
		{
			var temp = _data.Expenses.Where(x => x.Amount >= amount).ToList();
			return temp;
		}

		public List<DataEntry> GetIncomeByDate(DateTime dateTime)
		{
			var temp = _data.Income.Where(x => (x.Date.Year == dateTime.Year) && (x.Date.Month == dateTime.Month)).ToList();
			return temp;
		}

		public List<DataEntry> GetExpensesByDate(DateTime dateTime)
		{
			var temp = _data.Expenses.Where(x => (x.Date.Year == dateTime.Year) && (x.Date.Month == dateTime.Month)).ToList();
			return temp;
		}

		public List<DataEntry> GetRecurringIncome()
		{
			var temp = _data.Income.Where(x => x.IsMonthly).ToList();
			return temp;
		}

		public List<DataEntry> GetRecurringExpenses()
		{
			var temp = _data.Expenses.Where(x => x.IsMonthly).ToList();
			return temp;
		}

        public List<DataEntry> GetIncomeUntilToday()
        {
            var temp = _data.Income.Where(x => x.Date <= DateTime.Today).ToList();
            return temp;
        }

        public List<DataEntry> GetExpensesUntilToday()
        {
            var temp = _data.Expenses.Where(x => x.Date <= DateTime.Today).ToList();
            return temp;
        }

        public List<DataEntry> GetIncomeUntilEndOfThisMonth()
        {
            var today = DateTime.Today;
            var temp = _data.Income.Where(x => (x.Date.Year <= today.Year) && (x.Date.Month <= today.Month)).ToList();
            return temp;
        }

        public List<DataEntry> GetExpensesUntilEndOfThisMonth()
        {
            var today = DateTime.Today;
            var temp = _data.Expenses.Where(x => (x.Date.Year <= today.Year) && (x.Date.Month <= today.Month)).ToList();
            return temp;
        }

        public List<DataEntry> GetIncome(DateTime from, DateTime to)
        {
            var temp = _data.Income.Where(x => (x.Date >= from) && (x.Date <= to)).ToList();
            return temp;
        }

        public List<DataEntry> GetExpenses(DateTime from, DateTime to)
        {
            var temp = _data.Expenses.Where(x => (x.Date >= from) && (x.Date <= to)).ToList();
            return temp;
        }





	}
}
