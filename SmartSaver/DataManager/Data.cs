using System;
using System.Collections.Generic;
using System.Linq;
using DataBases;
using ePiggy.utilities;

namespace ePiggy.DataManager
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
        public bool AddGoal(int userid, string title, decimal value, int placeInQueue)//manual
        {
            if (GoalsList.Count >= 10) return false;//if 10 entries already in, does not allow to add
            var db = new DatabaseContext();
            var goal = new Goals {UserId = userid, Title = title, Price = value, PlaceInQueue = placeInQueue};
            db.Add(goal);
            db.SaveChanges();
            var id = goal.Id;
            var newGoal = new Goal(title, value, placeInQueue) {ID = id};
            GoalsList.Add(newGoal);
            return true;
        }

        public bool AddGoal(int userid, string title, int placeInQueue)//parsing from internet
        {
			if (GoalsList.Count >= 10) return false;//if 10 entries already in, does not allow to add
            var newGoal = new Goal(title, placeInQueue);
            var price = newGoal.Price;
            var parsedTitle = newGoal.Title;
			var db = new DatabaseContext();
            var goal = new Goals { UserId = userid, Title = parsedTitle, Price = price, PlaceInQueue = placeInQueue };
            db.Add(goal);
            db.SaveChanges();
            var id = goal.Id;
            newGoal.ID = id;
            GoalsList.Add(newGoal);
            return true;
		}

		/*INCOMES*/
        public void AddIncome(int userid, decimal value, string title, DateTime date, bool isMonthly, int importance)
        {
            var db = new DatabaseContext();
            var income = new Incomes { UserId = userid, Amount = value, Date = date, IsMonthly = isMonthly, Title = title, Importance = importance };
            db.Add(income);
            db.SaveChanges();
            var id = income.Id;
            var newIncome = new DataEntry(id, userid, value, title, date, isMonthly, importance);
            Income.Add(newIncome);
        }

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

		/*EXPENSES*/
        public void AddExpense(int userid, decimal value, string title, DateTime date, bool isMonthly, int importance)
        {
            var db = new DatabaseContext();
            var expense = new Expenses { UserId = userid, Amount = value, Date = date, IsMonthly = isMonthly, Title = title, Importance = importance };
            db.Add(expense);
            db.SaveChanges();
            var id = expense.Id;
            var newExpense = new DataEntry(id, userid, value, title, date, isMonthly, importance);
            Expenses.Add(newExpense);
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

		/*Methods for removal*/

        public void RemoveGoal(int id)
        {
            var db = new DatabaseContext();
            try
            {
                var index = db.Goals.FirstOrDefault(x => x.Id == id);
                db.Goals.Remove(index ?? throw new InvalidOperationException());
                db.SaveChanges();
			}
            catch (InvalidOperationException ex)
            {
                ExceptionHandler.Log(ex.ToString());
            }
            var goal = GoalsList.FirstOrDefault(x => x.ID == id);
            GoalsList.Remove(goal);
        }

       

		public void RemoveIncome(int id)
        {
            var db = new DatabaseContext();
            try
            {
                var index = db.Incomes.FirstOrDefault(x => x.Id == id);
                db.Incomes.Remove(index ?? throw new InvalidOperationException());
                db.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
				ExceptionHandler.Log(ex.ToString());
            }
            var dataEntry = Income.FirstOrDefault(x => x.Id == id);
            Income.Remove(dataEntry);
		}

        public void RemoveIncome(DataEntry dataEntry)
        {
            var db = new DatabaseContext();
            try
            {
                var index = db.Incomes.FirstOrDefault(x => x.Id == dataEntry.Id);
                db.Incomes.Remove(index ?? throw new InvalidOperationException());
                db.SaveChanges();
            }
            catch(InvalidOperationException ex)
            {
				ExceptionHandler.Log(ex.ToString());
            }
            

            Income.Remove(dataEntry);
        }

        public void RemoveExpense(DataEntry dataEntry)
        {
            var db = new DatabaseContext();
            try
            {
                var index = db.Expenses.FirstOrDefault(x => x.Id == dataEntry.Id);
                db.Expenses.Remove(index ?? throw new InvalidOperationException());
                db.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                ExceptionHandler.Log(ex.ToString());
            }
            

            Expenses.Remove(dataEntry);
        }

        public void RemoveExpense(int id)
        {
            var db = new DatabaseContext();
            try
            {
                var index = db.Expenses.FirstOrDefault(x => x.Id == id);
                db.Expenses.Remove(index ?? throw new InvalidOperationException());
                db.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                ExceptionHandler.Log(ex.ToString());
            }
            

            var dataEntry = Expenses.FirstOrDefault(x => x.Id == id);
            Expenses.Remove(dataEntry);
        }

		public void RemoveIncomes(List<DataEntry> entries)
        {
            foreach (var entry in entries)
            {
                RemoveIncome(entry.Id);
            }
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
            var db = new DatabaseContext();
            var temp = db.Goals.FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                temp.Title = title;
                temp.Price = value;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
		}

        public bool EditGoalPlaceInQueue(int id, int placeInQueue)
        {
            var db = new DatabaseContext();
            var temp = db.Goals.FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                temp.PlaceInQueue = placeInQueue;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
		}
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
                var newGoal = new Goal(goal.Id, goal.UserId, goal.Title, goal.Price, goal.PlaceInQueue);
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