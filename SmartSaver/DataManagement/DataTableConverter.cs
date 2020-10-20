using System;
using System.Collections.Generic;
using System.Data;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    public class DataTableConverter
    {
        private readonly Data _data;
        public DataTableConverter(Data data)
        {
            this._data = data;
        }

        public DataTable GenerateOfferTable(List<OfferData> dataOffers)
        {
            var dt = GenerateOfferTableHeaders();

            foreach (var dataOffer in dataOffers)
            {
                //dt.Rows.Add(dataOffer.Entry.Id, dataOffer.Entry.Title, dataOffer.Entry.Amount,
                //    dataOffer.Entry.Date, dataOffer.Entry.IsMonthly, dataEntry.Entry.Importance, dataOffer.Amount);
            }

            return dt;
        }

        private DataTable GenerateOfferTableHeaders()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Suggested Amount", typeof(decimal));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Recurring", typeof(bool));
            dt.Columns.Add("Importance", typeof(Importance));
            return dt;
        }

        public DataTable GenerateTable(EntryType entryType)//All entries
        {
            var dt = GenerateHeaders();
            if(entryType == EntryType.Income)
            {
                foreach (var data in _data.Income)
                {
                    dt.Rows.Add(data.Id, data.Title, data.Amount, data.Date, data.IsMonthly, data.Importance);
                }
            }
            else if(entryType == EntryType.Expense)
            {
                foreach (var data in _data.Expenses)
                {
                    dt.Rows.Add(data.Id, data.Title, data.Amount, data.Date, data.IsMonthly, data.Importance);
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
                dt.Rows.Add(dataEntry.Id, dataEntry.Title, dataEntry.Amount, dataEntry.Date, dataEntry.IsMonthly, dataEntry.Importance);
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
                dt.Rows.Add(data.Id, data.Title, data.Amount, data.Date, data.IsMonthly, data.Importance);
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
                dt.Rows.Add(data.Id, data.Title, data.Amount, data.Date, data.IsMonthly, data.Importance);
            }
            return dt;
        }


    }
         
}
