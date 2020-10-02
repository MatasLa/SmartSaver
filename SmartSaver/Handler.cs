using SmartSaver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager
{
    public class Handler
    {
        public DateTime Time { get; set; }

        public Data Data { get; }

        public DataTableConverter DataTableConverter { get; }

        public DataFilter DataFilter { get; }

        public DataJSON DataJSON { get; }

        public Handler()
        {
            Time = DateTime.Now;
            Data = new Data();
            DataTableConverter = new DataTableConverter(Data);
            DataFilter = new DataFilter(Data);
            DataJSON = new DataJSON(Data);
            DataJSON.ReadIncomeFromFile();
            DataJSON.ReadExpensesFromFile();
        }

    }
}
