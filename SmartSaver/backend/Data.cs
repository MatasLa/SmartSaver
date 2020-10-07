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
	/*Main data processing class*/
	public class Data
	{
		/*Lists that store income and expenses*/
		public List<DataEntry> Income { get; } = new List<DataEntry>();
		public List<DataEntry> Expenses { get; } = new List<DataEntry>();
		public List<Goal> Goals { get; } = new List<Goal>();

		/*Methods that creates new instance of class and adds to List*/
		public void AddIncome(decimal value, string title, DateTime date, bool isMonthly, int importance)
		{
			var rnd = new Random();//Since no database, IDs randomized between 100 and 201
			var newIncome = new DataEntry(rnd.Next(100, 200), value, title, date, isMonthly, importance);
			Income.Add(newIncome);
		}

		public void AddExpense(decimal value, string title, DateTime date, bool isMonthly, int importance)
		{
			var rnd = new Random();
			var newExpense = new DataEntry(rnd.Next(100, 201), value, title, date, isMonthly, importance);
			Expenses.Add(newExpense);
		}

        public bool AddGoal(string title, decimal value)//manual
        {
            if (Goals.Count >= 10) return false;//if 10 entries already in, does not allow to add
            var goal = new Goal(title, value);
			Goals.Add(goal);
            return true;
        }

        public bool AddGoal(string title)//parsing from internet
        {
            if (Goals.Count >= 10) return false;//if 10 entries already in, does not allow to add
			var goal = new Goal(title, 0);
			goal.SetGoalFromWeb(title);
			Goals.Add(goal);
            return true;
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

		/*Methods that allows to edit different parts of already existing entries*/
		public bool EditIncomeItem(int id, decimal value)/*Returns true if success(item found), and false if failure*/
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

		public bool EditIncomeItem(int id, string value, decimal amount, DateTime date, bool isMonthly, int importance)
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
		
		public bool EditExpensesItem(int id, decimal value)/*Returns true if success(item found), and false if failure*/
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

		public bool EditExpensesItem(int id, string value, decimal amount, DateTime date, bool isMonthly, int importance)
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