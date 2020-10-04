using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using EPiggy;

namespace DataManager
{
    public class DataTableConverter
    {
        private Data data;
        public DataTableConverter(Data data)
        {
            this.data = data;
        }

        public DataTable GenerateTable(EntryType entryType)//All entries
        {
            var dt = GenerateHeaders();
            if(entryType == EntryType.Income)
            {
                foreach (DataEntry data in data.Income)
                {
                    dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly);
                }
            }
            else if(entryType == EntryType.Expense)
            {
                foreach (DataEntry data in data.Expenses)
                {
                    dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly);
                }
            }
            return dt;
        }

        /*Takes list from DataFilter and creates income or expenses DataTable, used to get DataTable of filtered List*/
        public DataTable CustomTable(List<DataEntry> customList)
        {
            var dt = GenerateHeaders();
            foreach (DataEntry data in customList)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly);
            }

            return dt;
        }

        private DataTable GenerateHeaders()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Recurring", typeof(bool));
            return dt;
        }

        public DataTable IncomeTable()//All entries
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Recurring", typeof(bool));

            foreach(DataEntry data in data.Income)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly);
            }
            return dt;
        }

        public DataTable ExpensesTable()//All entries
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Recurring", typeof(bool));

            foreach (DataEntry data in data.Expenses)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly);
            }
            return dt;
        }


    }
         
}
