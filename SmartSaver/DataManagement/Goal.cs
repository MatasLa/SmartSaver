﻿using System;
using System.IO;
using System.Threading.Tasks;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    public class Goal : IEquatable<Goal>, IComparable
    {
        private static readonly string ResourceDirectoryParsedGoal = Directory.GetParent(Environment.CurrentDirectory)
                                                                         .Parent?.Parent?.FullName +
                                                                     @"\resources\textData\parsedGoal.txt";
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }


        public Goal(int id, int userId, string title, decimal price)
            :this(title, price)
        {
            Id = id;
            UserId = userId;
        }

        public Goal(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public Goal(string title)
        {
            SetGoalFromWeb(title);

        }

        public Goal()
        {
            Id = 0;
            UserId = 0;
            Title = "unnamed";
            Price = 0;
        }

        public void SetGoalFromWeb(string itemName)
        {
            try
            {
                Task.Run(() => InternetParser.ReadPriceFromCamel(itemName)).Wait();

                var file = new StreamReader(ResourceDirectoryParsedGoal);
                file.ReadLine();
                Title = file.ReadLine();
                var priceString = file.ReadLine();
                Price = Convert.ToDecimal(priceString, System.Globalization.CultureInfo.CurrentCulture);
                file.Close();
            }
            catch (Exception e)
            {
                ExceptionHandler.Log(e.ToString());
            }
        }

        public void SetGoal(string itemName, decimal price)
        {
            Title = itemName;
            Price = price;
        }

        public bool Equals(Goal other)
        {
            if (other is null)
            {
                return false;
            }

            return Price == other.Price;
        }

        public int CompareTo(object? obj)
        {
            return obj switch
            {
                null => 1,
                Goal otherGoal => Price.CompareTo(otherGoal.Price),
                _ => throw new ArgumentException("Object is not a Goal")
            };
        }
    }
}
