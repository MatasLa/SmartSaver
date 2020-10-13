using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using EPiggy;
using ePiggy.utilities;

namespace DataManager
{
    public class DataTableConverter
    {
        private readonly Data _data;
        public DataTableConverter(Data data)
        {
            this._data = data;
        }

        public DataTable GenerateTable(EntryType entryType)//All entries
        {
            var dt = GenerateHeaders();
            if(entryType == EntryType.Income)
            {
                foreach (var data in _data.Income)
                {
                    dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly, data.Importance);
                }
            }
            else if(entryType == EntryType.Expense)
            {
                foreach (var data in _data.Expenses)
                {
                    dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly, data.Importance);
                }
            }
            return dt;
        }

        /*Takes list from DataFilter and creates income or expenses DataTable, used to get DataTable of filtered List*/
        public DataTable CustomTable(List<DataEntry> customList)
        {
            var dt = GenerateHeaders();
            foreach (var dataEntry in customList)
            {
                dt.Rows.Add(dataEntry.ID, dataEntry.Title, dataEntry.Amount, dataEntry.Date, dataEntry.IsMonthly, dataEntry.Importance);
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
            dt.Columns.Add("Importance", typeof(int));
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
            dt.Columns.Add("Importance", typeof(int));

            foreach(var data in _data.Income)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly, data.Importance);
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
            dt.Columns.Add("Importance", typeof(int));

            foreach (var data in _data.Expenses)
            {
                dt.Rows.Add(data.ID, data.Title, data.Amount, data.Date, data.IsMonthly, data.Importance);
            }
            return dt;
        }


    }
         
}
