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
            var dc1 = new DataColumn("ID", typeof(int));
            var dc2 = new DataColumn("Title", typeof(string));
            var dc3 = new DataColumn("Amount", typeof(double));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);

            var temp = data.Income;
            foreach(DataEntry data in temp)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount);
            }
            return dt;
        }

        public DataTable expensesTable()
        {
            var dt = new DataTable();
            var dc1 = new DataColumn("ID", typeof(int));
            var dc2 = new DataColumn("Title", typeof(string));
            var dc3 = new DataColumn("Amount", typeof(double));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);

            var temp = data.Expenses;
            foreach (DataEntry data in temp)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount);
            }
            return dt;
        }


    }
         
}
