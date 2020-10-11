﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class Goal
    {
        private int id;
        private string title;
        private decimal price;
        private int placeInQueue;

        public int ID
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public decimal Price
        {
            get; set;
        }

        public int PlaceInQueue
        {
            get; set;
        }

        public Goal(int id, string title, decimal price, int placeInQueue)
            :this(title, price, placeInQueue)
        {
            ID = id;
            PlaceInQueue = placeInQueue;
        }

        public Goal(string title, decimal price, int placeInQueue)
        {
            Title = title;
            Price = price;
        }

        public Goal(string title, int placeInQueue)
        {
            SetGoalFromWeb(title);
            PlaceInQueue = placeInQueue;
        }

        public Goal()
        {
            ID = 0;
            Title = "unnamed";
            Price = 0;
        }

        public void SetGoalFromWeb(string itemName)
        {
            try
            {
                Task.Run(() => InternetParser.GetHTMLAsync(itemName)).Wait();

                System.IO.StreamReader file = new System.IO.StreamReader("priceInfo.txt");
                string line;
                Title = file.ReadLine();
                var pricestr = file.ReadLine();
                var Price = Convert.ToDouble(pricestr, System.Globalization.CultureInfo.InvariantCulture);
                file.Close();
            }catch(Exception e)
            {

            }
        }

        public void SetGoal(string itemName, decimal price)
        {
            Title = itemName;
            Price = price;
        }
    }
}
