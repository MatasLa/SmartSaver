using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataManager
{
	/*Requires datamanager object, methods filter data by provided criteria*/
    public class DataFilter
    {
        private readonly Data _data;
        public DataFilter(Data data)
        {
            this._data = data;
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

		public decimal GetBalanceByDate(DateTime dateTime)
        {
			var sum = GetIncomeByDate(dateTime).Sum(data => data.Amount);
            return GetExpensesByDate(dateTime).Aggregate(sum, (current, data) => current - data.Amount);
		}

		public bool IsBalancePositiveByDate(DateTime dateTime)
        {
            return GetBalanceByDate(dateTime) >= 0;
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

		public List<DataEntry> GetReccuringIncome()
		{
			var temp = _data.Income.Where(x => x.IsMonthly).ToList();
			return temp;
		}

		public List<DataEntry> GetReccuringExpenses()
		{
			var temp = _data.Expenses.Where(x => x.IsMonthly).ToList();
			return temp;
		}
	}
}
