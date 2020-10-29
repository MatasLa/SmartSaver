using System;
using System.Collections.Generic;
using System.Data;
using ePiggy.DataManagement;

namespace ePiggy.Utilities
{
    public static class DataTableConverter
    {
        public static DataTable GenerateSuggestionTable(IEnumerable<EntrySuggestion> entrySuggestions)
        {
            var dt = GenerateSuggestionTableHeaders();

            foreach (var dataOffer in entrySuggestions)
            {
                dt.Rows.Add(dataOffer.Entry.Id, dataOffer.Entry.Title, dataOffer.Entry.Amount,
                    dataOffer.Entry.Date, dataOffer.Entry.Importance, dataOffer.Entry.IsMonthly, dataOffer.Amount);
            }

            return dt;
        }

        private static DataTable GenerateSuggestionTableHeaders()
        {
            var dt = GenerateEntryTableHeaders();
            dt.Columns.Add("Suggested Amount", typeof(decimal));
            return dt;
        }

        /*Takes list from DataFilter and creates income or expenses DataTable, used to get DataTable of filtered List*/
        public static DataTable GenerateEntryTable(IEnumerable<DataEntry> entryList)
        {
            var dt = GenerateEntryTableHeaders();
            foreach (var dataEntry in entryList)
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
