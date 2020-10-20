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

        public DataTable GenerateEntryTable(EntryType entryType)//All entries
        {
            var dt = GenerateEntryTableHeaders();
            switch (entryType)
            {
                case EntryType.Income:
                {
                    foreach (var data in _data.Income)
                    {
                        dt.Rows.Add(data.Id, data.Title, data.Amount, data.Date, data.Importance, data.IsMonthly);
                    }
                    break;
                }
                case EntryType.Expense:
                {
                    foreach (var data in _data.Expenses)
                    {
                        dt.Rows.Add(data.Id, data.Title, data.Amount, data.Date, data.Importance, data.IsMonthly);
                    }
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(entryType), entryType, null);
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
