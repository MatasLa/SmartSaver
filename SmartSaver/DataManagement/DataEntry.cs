using System;

namespace ePiggy.DataManagement
{
	public class DataEntry : IComparable
	{

		/*Constructor*/

        public DataEntry(decimal amount, string title, DateTime date, bool isMonthly, int importance)
        {
            Amount = amount;
            Title = title;
            Date = date;
            IsMonthly = isMonthly;
            Importance = importance;
        }

        public DataEntry(int id, int userId, decimal amount, string title, DateTime date, bool isMonthly, int importance)
            :this(amount, title, date, isMonthly, importance)
		{
			ID = id;
            UserId = userId;
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

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var otherEntry = obj as DataEntry;
            if (otherEntry != null)
                return this.Amount.CompareTo(otherEntry.Amount);
            else
                throw new ArgumentException("Object is not a DataEntry");
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
