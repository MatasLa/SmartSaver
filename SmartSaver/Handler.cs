using System;
using System.Net.Http;
using ePiggy.backend.calculations;
using ePiggy.backend.dataHandling;
using ePiggy.utilities;

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

        public static HttpClient HttpClient = new HttpClient();
        public static int UserId { get; set; }


        public Handler()
        {
            Time = DateTime.Now;
            HttpClient = new HttpClient();
            Data = new Data();
            DataTableConverter = new DataTableConverter(Data);
            DataFilter = new DataFilter(Data);
            DataCalculations = new DataCalculations(Data);
            DataJSON = new DataJSON(Data);
            //Data.ReadIncomeFromDb();
            //Data.ReadExpensesFromDb();
            //DataJSON.ReadIncomeFromFile();
            //DataJSON.ReadExpensesFromFile();
        }

        public void ClearData()
        {
            Data.Income.Clear();
            Data.Expenses.Clear();
            Data.GoalsList.Clear();
            Data.ReadExpensesFromDb();
            Data.ReadIncomeFromDb();
            Data.ReadGoalsFromDb();
        }
        
    }
}
