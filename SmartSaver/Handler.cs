﻿using DataManager;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ePiggy
{
    public class Handler
    {
        public DateTime Time { get; set; }

        public Data Data { get; }

        public DataTableConverter DataTableConverter { get; }

        public DataFilter DataFilter { get; }

        public DataJSON DataJSON { get; }

        public DataCalculations DataCalculations { get; }

        public static int UserId { get; set; }

        public static HttpClient HttpClient { get; set; }

        public Handler()
        {
            Time = DateTime.Now;
            HttpClient = new HttpClient();
            Data = new Data();
            DataTableConverter = new DataTableConverter(Data);
            DataFilter = new DataFilter(Data);
            DataCalculations = new DataCalculations(Data);
            DataJSON = new DataJSON(Data);
            Data.ReadIncomeFromDb();
            Data.ReadExpensesFromDb();
            //DataJSON.ReadIncomeFromFile();
            //DataJSON.ReadExpensesFromFile();
        }
        
    }
}
