using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ePiggy.DataManagement;
using ePiggy.Utilities;

namespace ePiggy.DataBase
{
    public class DatabaseUpdate
    {
        public static void RemoveGoal(int id)
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
        }
        
        public static void RemoveIncome(int id)
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
        }
        
        
        public static void RemoveIncome(DataEntry dataEntry)
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
        }

        
        public static void RemoveExpense(DataEntry dataEntry)
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
        }

        
        public static void RemoveExpense(int id)
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
        }
        
        public static bool EditGoal(int id, string title, decimal value)
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

        
        public static bool EditGoalPlaceInQueue(int id, int placeInQueue)
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
         public static bool EditIncomeItem(int id, decimal value)
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
        
        public static bool EditIncomeItem(int id, string value)
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
        
        public static bool EditIncomeItem(int id, DateTime date)
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
        
		public static bool EditIncomeItem(int id, bool isMonthly)
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
        
       public static bool EditIncomeItem(int id, int importance)
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
        
        public static bool EditIncomeItem(int id, string value, decimal amount, DateTime date, bool isMonthly, int importance)
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
        
        public static bool EditExpensesItem(int id, decimal value)
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
        
        public static bool EditExpensesItem(int id, string value)
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
        
        public static bool EditExpensesItem(int id, DateTime date)
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
        
        
        public static bool EditExpensesItem(int id, bool isMonthly)
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
        
        public static bool EditExpensesItem(int id, int importance)
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
        
        public static bool EditExpensesItem(int id, string value, decimal amount, DateTime date, bool isMonthly, int importance)
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
    }
}
