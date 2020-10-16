using System;
using System.Collections.Generic;
using System.Linq;

namespace ePiggy.DataManagement
{
	/*Requires datamanager object, methods filter data by provided criteria*/
    public class DataFilter
    {
        private Data data;
        public DataFilter(Data data)
        {
            this.data = data;
		}

		/*Arno kodas*/

        public decimal GetTotaledIncome()
        {
            return data.Income.Sum(entry => entry.Amount);
		}

        public decimal GetTotaledIncome(DateTime date)
        {
			return GetIncomeByDate(date).Sum(entry => entry.Amount);
		}

        public decimal GetTotaledExpenses()
        {
            return data.Expenses.Sum(entry => entry.Amount);
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
			List<DataEntry> temp = data.Income.Where(x => x.Amount >= amount).ToList();
			return temp;
		}

		public List<DataEntry> GetExpensesHigherThan(decimal amount)
		{
			List<DataEntry> temp = data.Expenses.Where(x => x.Amount >= amount).ToList();
			return temp;
		}

		public List<DataEntry> GetIncomeByDate(DateTime dateTime)
		{
			List<DataEntry> temp = data.Income.Where(x => (x.Date.Year == dateTime.Year) && (x.Date.Month == dateTime.Month)).ToList();
			return temp;
		}

		public List<DataEntry> GetExpensesByDate(DateTime dateTime)
		{
			List<DataEntry> temp = data.Expenses.Where(x => (x.Date.Year == dateTime.Year) && (x.Date.Month == dateTime.Month)).ToList();
			return temp;
		}

		public List<DataEntry> GetReccuringIncome()
		{
			List<DataEntry> temp = data.Income.Where(x => x.IsMonthly).ToList();
			return temp;
		}

		public List<DataEntry> GetReccuringExpenses()
		{
			List<DataEntry> temp = data.Expenses.Where(x => x.IsMonthly).ToList();
			return temp;
		}
	}
}
