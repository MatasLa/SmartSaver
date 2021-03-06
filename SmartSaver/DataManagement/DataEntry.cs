﻿using System;

namespace ePiggy.DataManagement
{
	public class DataEntry : IComparable, IEquatable<DataEntry>
	{
        /*Properties*/
        public string Title {get; set; }
        public decimal Amount { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public bool IsMonthly { get; set; }
        public int Importance { get; set; }

		/*Constructors*/
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
			Id = id;
            UserId = userId;
        }

		public DataEntry()
		{
			Id = 0;
            UserId = 0;
			Amount = 0;
			Title = "unnamed";
			Date = DateTime.Now;
			IsMonthly = false;
			Importance = 0;
		}

        public int CompareTo(object obj)
        {
            return obj switch
            {
                null => 1,
                DataEntry otherEntry => Amount.CompareTo(otherEntry.Amount),
                _ => throw new ArgumentException("Object is not a DataEntry")
            };
        }

        public bool Equals(DataEntry other)
        {
            if (other is null)
            {
                return false;
            }

            return Amount == other.Amount;
        }
    }
}
