using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DataManager;

namespace SmartSaver
{
    class DataTableConverter
    {
        private Data data;
        public DataTableConverter(Data data)
        {
            this.data = data;
        }

        public DataTable incomeTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Amount", typeof(double));
            dt.Columns.Add("Date", typeof(DateTime));

            var temp = data.Income;
            foreach(DataEntry data in temp)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date);
            }
            return dt;
        }

        public DataTable expensesTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Amount", typeof(double));
            dt.Columns.Add("Date", typeof(DateTime));

            var temp = data.Expenses;
            foreach (DataEntry data in temp)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date);
            }
            return dt;
        }


    }
         
}
