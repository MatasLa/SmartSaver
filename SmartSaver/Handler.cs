using System;
using System.Net.Http;
using ePiggy.DataManagement;

namespace ePiggy
{
    public class Handler
    {
        public DateTime Time { get; set; }

        public Data Data { get; }

        public DataTableConverter DataTableConverter { get; }

        public DataFilter DataFilter { get; }

        public DataJson DataJson{ get; }

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
            DataJson = new DataJson(Data);
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
