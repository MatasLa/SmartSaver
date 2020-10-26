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

        public DataTotalsCalculator DataTotalsCalculator { get; }

        public DataJson DataJson{ get; }

        public DataCalculations DataCalculations { get; }

        public MonthlyUpdater MonthlyUpdater { get; }

        public static HttpClient HttpClient = new HttpClient();
        public static int UserId { get; set; }


        public Handler()
        {
            HttpClient = new HttpClient();
            Data = new Data();
            DataTableConverter = new DataTableConverter(Data);
            DataFilter = new DataFilter(Data);
            DataTotalsCalculator = new DataTotalsCalculator(Data, DataFilter);
            DataCalculations = new DataCalculations(Data);
            DataJson = new DataJson(Data);
            MonthlyUpdater = new MonthlyUpdater(DataFilter, Data);

            //Init();
        }

        private void Init()
        {
            Time = DateTime.Now;
            ReadFromDb();
            MonthlyUpdater.UpdateMonthlyEntries(UserId);
        }

        private void ReadFromDb()
        {
            Data.ReadExpensesFromDb();
            Data.ReadIncomeFromDb();
            Data.ReadGoalsFromDb();
        }

        public void Update()
        {
            Time = DateTime.Today;
            ClearData();
            ReadFromDb();
            MonthlyUpdater.UpdateMonthlyEntries(UserId);
        }
        
        private void ClearData()
        {
            Data.Income.Clear();
            Data.Expenses.Clear();
            Data.GoalsList.Clear();
        }
        
    }
}
