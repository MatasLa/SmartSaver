using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ePiggy.DataBase;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
	/*Main data processing class*/
	public class Data
	{
		/*Lists that store income and expenses*/
		public List<DataEntry> Income { get; } = new List<DataEntry>();
		public List<DataEntry> Expenses { get; } = new List<DataEntry>();
		public List<Goal> GoalsList { get; } = new List<Goal>();

        /*Methods that creates new instance of class and adds to List*/
        /*GOALS*/

        /*for all add methods db method should be moved and shouldreturn int id*/
        public bool AddGoal(int userid, string title, decimal value)//manual
        {
            if (GoalsList.Count >= 10)//if 10 entries already in, does not allow to add
            {
                return false;
            }
            var id = DatabaseUpdater.AddGoal(userid, title, value);
            var newGoal = new Goal(title, value) {Id = id};
            GoalsList.Add(newGoal);
            return true;
        }

        public bool AddGoal(int userid, string title)//parsing from internet
        {
            if (GoalsList.Count >= 10)//if 10 entries already in, does not allow to add
            {
                return false;
            }
            var newGoal = new Goal(title);
            var price = newGoal.Price;
            var parsedTitle = newGoal.Title;
            var id = DatabaseUpdater.AddGoal(userid, parsedTitle, price);
            newGoal.Id = id;
            GoalsList.Add(newGoal);
            return true;
		}

		/*INCOMES*/
        public void AddIncome(int userid, decimal value, string title, DateTime date, bool isMonthly, int importance)
        {
            var id = DatabaseUpdater.AddIncome(userid, value, title, date, isMonthly, importance);
            var newIncome = new DataEntry(id, userid, value, title, date, isMonthly, importance);
            Income.Add(newIncome);
        }


		/*EXPENSES*/
        public void AddExpense(int userid, decimal value, string title, DateTime date, bool isMonthly, int importance)
        {
            var id = DatabaseUpdater.AddExpense(userid, value, title, date, isMonthly, importance);
            var newExpense = new DataEntry(id, userid, value, title, date, isMonthly, importance);
            Expenses.Add(newExpense);
        }


		/*Methods for removal*/

        /*Methods that should be left here - normal, methods that are old and left only to copy code of db - commented*/

        public void RemoveGoal(int id)
        {
            var goal = GoalsList.FirstOrDefault(x => x.Id == id);
            if (goal == null) return;
            GoalsList.Remove(goal);
            DatabaseUpdater.RemoveGoal(id);
        }


        public void RemoveIncome(int id)
        {
            Debug.WriteLine("RemoveIncome(int id)");
            var income = Income.FirstOrDefault(x => x.Id == id);
            if (income == null) return;
            Income.Remove(income);
            DatabaseUpdater.RemoveIncome(id);
        }

        public void RemoveIncome(DataEntry dataEntry)
        {
            Debug.WriteLine("RemoveIncome(DataEntry dataEntry)");
            Income.Remove(dataEntry);
            DatabaseUpdater.RemoveIncome(dataEntry);
        }
        

        public void RemoveExpense(DataEntry dataEntry)
        {
            Expenses.Remove(dataEntry);
            DatabaseUpdater.RemoveExpense(dataEntry);
        }
        

        public void RemoveExpense(int id)
        {
            var dataEntry = Expenses.FirstOrDefault(x => x.Id == id);
            if (dataEntry == null) return;
            Expenses.Remove(dataEntry);
            DatabaseUpdater.RemoveExpense(id);
        }
        

		public void RemoveIncomes(List<DataEntry> entries)
        {
            DatabaseUpdater.RemoveIncomes(entries);
            Income.RemoveAll(l => entries.Contains(l));
        }

        public void RemoveIncomes(List<int> idList)
		{
            foreach (var id in idList)
            {
                RemoveIncome(id);
            }
		}


        public void RemoveExpenses(List<DataEntry> entries)
        {
            foreach (var entry in entries)
            {
                RemoveExpense(entry.Id);
            }
        }

        public void RemoveExpenses(List<int> idList)
        {
            foreach (var id in idList)
            {
                RemoveExpense(id);
            }
        }

        /*Methods that allows to edit different parts of already existing entries*/
        public bool EditGoal(int id, string title, decimal value)
        {
            var temp = GoalsList.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Title = title;
            temp.Price = value;
            return DatabaseUpdater.EditGoal(id, title, value);

        }

        /* public bool EditGoalPlaceInQueue(int id, int placeInQueue)
         {
             var temp = GoalsList.FirstOrDefault(x => x.Id == id);
             if (temp == null)
             {
                 return false;
             }
             temp.PlaceInQueue = placeInQueue;
             return DatabaseUpdate.EditGoalPlaceInQueue(id, placeInQueue);
         }*/


        public bool EditIncomeItem(int id, decimal value)
        {
            var temp = Income.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Amount = value;
            return DatabaseUpdater.EditIncomeItem(id, value);
        }


        public bool EditIncomeItem(int id, string value)
        {
            var temp = Income.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Title = value;
            return DatabaseUpdater.EditIncomeItem(id, value);
        }



        public bool EditIncomeItem(int id, DateTime date)
        {
            var temp = Income.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Date = date;
            return DatabaseUpdater.EditIncomeItem(id, date);
        }


        public bool EditIncomeItem(int id, bool isMonthly)
        {
            var temp = Income.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.IsMonthly = isMonthly;
            return DatabaseUpdater.EditIncomeItem(id, isMonthly);
        }
        

        public bool EditIncomeItem(int id, int importance)
        {
            var temp = Income.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Importance = importance;
            return DatabaseUpdater.EditIncomeItem(id, importance);
        }
       

        public bool EditIncomeItem(int id, string value, decimal amount, DateTime date, bool isMonthly, int importance)
        {
            var temp = Income.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Title = value;
            temp.Amount = amount;
            temp.Date = date;
            temp.IsMonthly = isMonthly;
            temp.Importance = importance;
            return DatabaseUpdater.EditIncomeItem(id, value, amount, date, isMonthly, importance);
        }
        

        public bool EditExpensesItem(int id, decimal value)
        {
            var temp = Expenses.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Amount = value;
            return DatabaseUpdater.EditExpensesItem(id, value);
        }
        

        public bool EditExpensesItem(int id, string value)
        {
            var temp = Expenses.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Title = value;
            return DatabaseUpdater.EditExpensesItem(id, value);
        }
        

        public bool EditExpensesItem(int id, DateTime date)
        {
            var temp = Expenses.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Date = date;
            return DatabaseUpdater.EditExpensesItem(id, date);
        }
        

        public bool EditExpensesItem(int id, bool isMonthly)
        {
            var temp = Expenses.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.IsMonthly = isMonthly;
            return DatabaseUpdater.EditExpensesItem(id, isMonthly);
        }
        
        public bool EditExpensesItem(int id, int importance)
        {
            var temp = Expenses.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Importance = importance;
            return DatabaseUpdater.EditExpensesItem(id, importance);
        }
        
        public bool EditExpensesItem(int id, string value, decimal amount, DateTime date, bool isMonthly, int importance)
        {
            var temp = Expenses.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                return false;
            }
            temp.Title = value;
            temp.Amount = amount;
            temp.Date = date;
            temp.IsMonthly = isMonthly;
            temp.Importance = importance;
            return DatabaseUpdater.EditExpensesItem(id, value, amount, date, isMonthly, importance);
        }

        
        public void ReadIncomeFromDb()
        {
            using var context = new DatabaseContext();
            var incomes = context.Incomes; // define query
            foreach (var income in incomes.Where(x => x.UserId == Handler.UserId)) // query executed and data obtained from database
            {
                var newIncome = new DataEntry(income.Id, income.UserId, income.Amount, income.Title, income.Date, income.IsMonthly, income.Importance);
                Income.Add(newIncome);
            }
        }
        public void ReadExpensesFromDb()
        {
            using var context = new DatabaseContext();
            var expenses = context.Expenses; // define query
            foreach (var expense in expenses.Where(x => x.UserId == Handler.UserId)) // query executed and data obtained from database
            {
                var newExpense = new DataEntry(expense.Id, expense.UserId, expense.Amount, expense.Title, expense.Date, expense.IsMonthly, expense.Importance);
                Expenses.Add(newExpense);
            }
        }

		public void ReadGoalsFromDb()
        {
            using var context = new DatabaseContext();
            var goals = context.Goals; // define query
            foreach (var goal in goals.Where(x => x.UserId == Handler.UserId)) // query executed and data obtained from database
            {
                var newGoal = new Goal(goal.Id, goal.UserId, goal.Title, goal.Price);
                GoalsList.Add(newGoal);
            }
        }
		public bool GetDataEntryById(int id, out DataEntry dataEntry, EntryType entryType)
        {
            switch (entryType)
            {
				case EntryType.Income:
                    dataEntry = Income.FirstOrDefault(x => x.Id == id);
					return dataEntry is { };
				case EntryType.Expense:
                    dataEntry = Expenses.FirstOrDefault(x => x.Id == id);
                    return dataEntry is { };
                default:
                    throw new ArgumentOutOfRangeException(nameof(entryType), entryType, null);
            }
		}

        public bool GetListOfDataEntriesById(IEnumerable<int> idArray, List<DataEntry> list, EntryType entryType)
        {
            foreach (var id in idArray)
			{
                if (!GetDataEntryById(id, out var dataEntry, entryType)) return false;
                list.Add(dataEntry);
            }
            return true;
		}

	}
}



/*Legacy methods, just in case*/
/*
 public void AddMonthlyIncome(int userid, decimal value, string title, DateTime date, bool isMonthly, int importance)
        {
            var dateUse = date;
            var db = new DatabaseContext();
            var rotations = isMonthly ? 12 : 1;
            for (var i = 0; i < rotations; i++)
            {
                var income = new Incomes { UserId = userid, Amount = value, Date = dateUse, IsMonthly = isMonthly, Title = title, Importance = importance };
                db.Add(income);
                db.SaveChanges();
                var id = income.Id;
                var newIncome = new DataEntry(id, userid, value, title, dateUse, isMonthly, importance);
                Income.Add(newIncome);
                dateUse = dateUse.AddMonths(1);
            }
        }

 public void AddMonthlyExpense(int userid, decimal value, string title, DateTime date, bool isMonthly, int importance)
        {
            var db = new DatabaseContext();
            var dateUse = date;
            var rotations = isMonthly ? 12 : 1;
            for (var i = 0; i < rotations; i++)
            {
                var expense = new Expenses { UserId = userid, Amount = value, Date = dateUse, IsMonthly = isMonthly, Title = title, Importance = importance };
                db.Add(expense);
                db.SaveChanges();
                var id = expense.Id;
                var newExpense = new DataEntry(id, userid, value, title, dateUse, isMonthly, importance);
                Expenses.Add(newExpense);
                dateUse = dateUse.AddMonths(1);
            }
        }

*/