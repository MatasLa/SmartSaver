using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataManager
{
	/*Requires datamanager object, methods filter data by provided criteria*/
    public class DataFilter
    {
        private Data data;
        public DataFilter(Data data)
        {
            this.data = data;
        }

		public List<DataEntry> GetIncomeHigherThan(double amount)
		{
			List<DataEntry> temp = data.Income.Where(x => x.Amount >= amount).ToList();
			return temp;
		}

		public List<DataEntry> GetExpensesHigherThan(double amount)
		{
			List<DataEntry> temp = data.Income.Where(x => x.Amount >= amount).ToList();
			return temp;
		}

		public double GetBalanceByDate(DateTime dateTime)
        {
			double sum = 0;
			foreach (DataEntry data in GetIncomeByDate(dateTime))
			{
				sum += data.Amount;
			}
			foreach (DataEntry data in GetExpensesByDate(dateTime))
			{
				sum -= data.Amount;
			}
			return sum;
		}

		public bool IsBalancePositiveByDate(DateTime dateTime)
        {
			if(GetBalanceByDate(dateTime) >= 0)
            {
				return true;
            }
			else
            {
				return false;
            }
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
