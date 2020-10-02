using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

namespace DataManager
{
	public class DataEntry
	{

		/*Constructor*/
		public DataEntry(int id, double amount, string title, DateTime date, bool isMonthly, int importance)
		{
			ID = id;
			Amount = amount;
			Title = title;
			Date = date;
			IsMonthly = isMonthly;
			Importance = importance;
		}

		public DataEntry()
		{
			ID = 0;
			Amount = 0;
			Title = "unnamed";
			Date = DateTime.Now;
			IsMonthly = false;
			Importance = 0;
		}

		/*Getters and Setters*/
		public string Title
		{
			get;
			set;
		}
		public double Amount
		{
			get;
			set;
		}
		public int ID
		{
			get;
			set;
		}
        public DateTime Date
		{
			get;
			set;
		}
		public bool IsMonthly
		{
			get;
			set;
		}
		public int Importance
        {
			get;
			set;
        }
	}

	/*Main data processing class*/
	public class Data
	{
		/*Lists that store income and expenses*/
		public List<DataEntry> Income { get; } = new List<DataEntry>();
		public List<DataEntry> Expenses { get; } = new List<DataEntry>();

		/*Methods that creates new instance of class and adds to List*/
		public void AddIncome(double value, string title, DateTime date, bool isMonthly, int importance)
		{
			Random rnd = new Random();//Since no database, IDs randomized between 100 and 201
			DataEntry newIncome = new DataEntry(rnd.Next(100, 200), value, title, date, isMonthly, importance);
			Income.Add(newIncome);
		}

		public void AddExpense(double value, string title, DateTime date, bool isMonthly, int importance)
		{
			Random rnd = new Random();
			DataEntry newExpense = new DataEntry(rnd.Next(100, 201), value, title, date, isMonthly, importance);
			Expenses.Add(newExpense);
		}

		public void RemoveIncome(int id)
		{
			var index = Income.FindIndex(x => x.ID == id);
			Income.RemoveAt(index);
		}

		public void RemoveExpense(int id)
		{
			var index = Expenses.FindIndex(x => x.ID == id);
			Income.RemoveAt(index);
		}

		/*Methods that allows to edit different parts of already existing entrys*/
		public bool EditIncomeItem(int id, double value)/*Returns true if success(item found), and false if failure*/
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Amount = value;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool EditIncomeItem(int id, string value)
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Title = value;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool EditIncomeItem(int id, DateTime date)
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Date = date;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool EditIncomeItem(int id, bool isMonthly)
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.IsMonthly = isMonthly;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool EditIncomeItem(int id, int importance)
        {
			var temp = Income.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Importance = importance;
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool EditIncomeItem(int id, string value, double amount, DateTime date, bool isMonthly, int importance)
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Title = value;
				temp.Amount = amount;
				temp.Date = date;
				temp.IsMonthly = isMonthly;
				temp.Importance = importance;
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public bool EditExpensesItem(int id, double value)/*Returns true if success(item found), and false if failure*/
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Amount = value;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool EditExpensesItem(int id, string value)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Title = value;
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool EditExpensesItem(int id, DateTime date)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Date = date;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool EditExpensesItem(int id, bool isMonthly)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.IsMonthly = isMonthly;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool EditExpensesItem(int id, int importance)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Importance = importance;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool EditExpensesItem(int id, string value, double amount, DateTime date, bool isMonthly, int importance)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			if (temp != null)
			{
				temp.Title = value;
				temp.Amount = amount;
				temp.Date = date;
				temp.IsMonthly = isMonthly;
				temp.Importance = importance;
				return true;
			}
			else
			{
				return false;
			}
			
		}

	}


}