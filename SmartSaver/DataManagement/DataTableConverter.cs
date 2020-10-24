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
            _data = data;
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
            var dt = GenerateEntryTableHeaders();
            dt.Columns.Add("Suggested Amount", typeof(decimal));
            return dt;
        }

        public DataTable GenerateEntryTable(EntryType entryType)//All entries
        {
            var dt = GenerateEntryTableHeaders();
            var dataEntries = entryType == EntryType.Expense ? _data.Expenses : _data.Income;
            foreach (var data in dataEntries)
            {
                dt.Rows.Add(data.Id, data.Title, data.Amount, data.Date, data.Importance, data.IsMonthly);
            }
            return dt;
        }

        /*Takes list from DataFilter and creates income or expenses DataTable, used to get DataTable of filtered List*/
        public static DataTable GenerateEntryTable(List<DataEntry> customList)
        {
            var dt = GenerateEntryTableHeaders();
            foreach (var dataEntry in customList)
            {
                dt.Rows.Add(dataEntry.Id, dataEntry.Title, dataEntry.Amount, dataEntry.Date, dataEntry.Importance, dataEntry.IsMonthly);
            }
            return dt;
        }

        private static DataTable GenerateEntryTableHeaders()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Importance", typeof(Importance));
            dt.Columns.Add("Recurring", typeof(bool));
            return dt;
        }
    }
}
