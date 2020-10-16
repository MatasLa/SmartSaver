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

		/*Arno kodas*/

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

		/* baigiasi Arno kodas */

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
