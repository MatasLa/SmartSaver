using System;
using System.Collections.Generic;
using System.Text;

namespace ePiggy.DataManagement
{
    public class MonthlyUpdater
    {
        private readonly DataFilter _dataFilter;
        private readonly Data _data;


        public MonthlyUpdater(DataFilter dataFilter, Data data)
        {
            _dataFilter = dataFilter;
            _data = data;
        }
            private void UpdateMonthlyEntries() //eina per visus
        {
            var entriesInc = _dataFilter.GetAllMonthlyEntries();

            foreach (var entry in incomes)
            {
                while (entry.date.month != DateTime.Today.Month)
                {
                    UpdateMonthlyEntry(entry);
                }
            }
        }
    }
}
