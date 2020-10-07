using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager
{
	public class DataEntry
	{

		/*Constructor*/
		public DataEntry(int id, int userId, decimal amount, string title, DateTime date, bool isMonthly, int importance)
		{
			ID = id;
            UserId = userId;
			Amount = amount;
			Title = title;
			Date = date;
			IsMonthly = isMonthly;
			Importance = importance;
		}

		public DataEntry()
		{
			ID = 0;
            UserId = 0;
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

		public decimal Amount
		{
			get;
			set;
		}

		public int ID
		{
			get;
			set;
		}

        public int UserId
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
}
