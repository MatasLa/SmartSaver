using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using ePiggy.DataManagement;
using ePiggy.Utilities;

namespace ePiggy
{
    public class Handler
    {
        public static IEnumerable<Importance> ImportanceList { get; } = Enum.GetValues(typeof(Importance)).Cast<Importance>().ToList();

        public DateTime Time { get; set; }

        public Data Data { get; }

        public DataFilter DataFilter { get; }

        public DataTotalsCalculator DataTotalsCalculator { get; }

        public JSONWriter DataJson{ get; }

        public SuggestionsCalculator DataCalculations { get; }

        public MonthlyUpdater MonthlyUpdater { get; }

        public static HttpClient HttpClient { get; } = new HttpClient();

        public static int UserId { get; set; }

        public Handler()
        {
            Data = new Data();
            DataFilter = new DataFilter(Data);
            DataTotalsCalculator = new DataTotalsCalculator(Data, DataFilter);
            DataCalculations = new SuggestionsCalculator(Data, DataFilter, DataTotalsCalculator);
            DataJson = new JSONWriter(Data);
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
