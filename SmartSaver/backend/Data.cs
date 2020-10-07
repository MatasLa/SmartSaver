using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using DataBases;

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

        public void RemoveGoal(int id)
        {
            var index = Goals.FindIndex(x => x.ID == id);
            Goals.RemoveAt(index);
		}

        public void AddIncome(int userid, decimal value, string title, DateTime date, bool isMonthly, int importance)
        {
            var db = new DatabaseContext();
            var income = new Incomes { UserId = userid, Amount = value, Date = date, IsMonthly = isMonthly, Title = title, Importance = importance };
            db.Add(income);
            db.SaveChanges();
            int id = income.Id;
            DataEntry newIncome = new DataEntry(id, userid, value, title, date, isMonthly, importance);
            Income.Add(newIncome);
        }

        public void AddExpense(int userid, decimal value, string title, DateTime date, bool isMonthly, int importance)
        {
            var db = new DatabaseContext();
            var expense = new Expenses { UserId = userid, Amount = value, Date = date, IsMonthly = isMonthly, Title = title, Importance = importance };
            db.Add(expense);
            db.SaveChanges();
            int id = expense.Id;
            DataEntry newExpense = new DataEntry(id, userid, value, title, date, isMonthly, importance);
            Expenses.Add(newExpense);
        }

        public void RemoveIncome(int id)
        {
            var db = new DatabaseContext();
            var index = db.Incomes.FirstOrDefault(x => x.Id == id);
            db.Incomes.Remove(index);
            db.SaveChanges();
            //Income.RemoveAt(index);
        }

        public void RemoveExpense(int id)
        {
            var db = new DatabaseContext();
            var index = db.Expenses.FirstOrDefault(x => x.Id == id);
            db.Expenses.Remove(index);
            db.SaveChanges();
            //Expenses.RemoveAt(index);
        }

		/*Methods that allows to edit different parts of already existing entries*/
		public bool EditIncomeItem(int id, decimal value)/*Returns true if success(item found), and false if failure*/
		{

			var db = new DatabaseContext();
			var temp = db.Incomes.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Amount = value;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditIncomeItem(int id, string value)
		{
			var db = new DatabaseContext();
			var temp = db.Incomes.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Title = value;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditIncomeItem(int id, DateTime date)
		{
			var db = new DatabaseContext();
			var temp = db.Incomes.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Date = date;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditIncomeItem(int id, bool isMonthly)
		{
			var db = new DatabaseContext();
			var temp = db.Incomes.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.IsMonthly = isMonthly;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditIncomeItem(int id, int importance)
		{
			var db = new DatabaseContext();
			var temp = db.Incomes.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Importance = importance;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditIncomeItem(int id, string value, decimal amount, DateTime date, bool isMonthly, int importance)
		{
			var db = new DatabaseContext();
			var temp = db.Incomes.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Title = value;
				temp.Amount = amount;
				temp.Date = date;
				temp.IsMonthly = isMonthly;
				temp.Importance = importance;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditExpensesItem(int id, decimal value)/*Returns true if success(item found), and false if failure*/
		{
			var db = new DatabaseContext();
			var temp = db.Expenses.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Amount = value;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditExpensesItem(int id, string value)
		{
			var db = new DatabaseContext();
			var temp = db.Expenses.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Title = value;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool EditExpensesItem(int id, DateTime date)
		{
			var db = new DatabaseContext();
			var temp = db.Expenses.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Date = date;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditExpensesItem(int id, bool isMonthly)
		{
			var db = new DatabaseContext();
			var temp = db.Expenses.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.IsMonthly = isMonthly;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditExpensesItem(int id, int importance)
		{
			var db = new DatabaseContext();
			var temp = db.Expenses.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Importance = importance;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool EditExpensesItem(int id, string value, decimal amount, DateTime date, bool isMonthly, int importance)
		{
			var db = new DatabaseContext();
			var temp = db.Expenses.FirstOrDefault(x => x.Id == id);
			if (temp != null)
			{
				temp.Title = value;
				temp.Amount = amount;
				temp.Date = date;
				temp.IsMonthly = isMonthly;
				temp.Importance = importance;
				db.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}
        public void ReadIncomeFromDb()
        {
            using (var context = new DatabaseContext())
            {
                var incomes = context.Incomes; // define query
                foreach (var income in incomes) // query executed and data obtained from database
                {
                    DataEntry newIncome = new DataEntry(income.Id, income.UserId, income.Amount, income.Title, income.Date, income.IsMonthly, income.Importance);
                    Income.Add(newIncome);
                }
            }
        }
        public void ReadExpensesFromDb()
        {
            using (var context = new DatabaseContext())
            {
                var expenses = context.Expenses; // define query
                foreach (var expense in expenses) // query executed and data obtained from database
                {
                    DataEntry newExpense = new DataEntry(expense.Id, expense.UserId, expense.Amount, expense.Title, expense.Date, expense.IsMonthly, expense.Importance);
                    Expenses.Add(newExpense);
                }
            }
        }
	}
}