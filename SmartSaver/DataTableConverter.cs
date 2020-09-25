using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DataManager
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

            foreach(DataEntry data in data.Income)
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

            foreach (DataEntry data in data.Expenses)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date);
            }
            return dt;
        }


    }
         
}
