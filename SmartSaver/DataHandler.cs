using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager
{
    public class DataHandler
    {
        public DateTime Time { get; set; }
        public Data Data { get; }
        public DataTableConverter DataTableConverter { get; }
        public DataFilter DataFilter { get; }

        public DataHandler()
        {
            Time = DateTime.Now;
            Data = new Data();
            DataTableConverter = new DataTableConverter(Data);
            DataFilter = new DataFilter(Data);
            Data.ReadIncomeFromFile();
            Data.ReadExpensesFromFile();
        }

    }
}
