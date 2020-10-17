using System;
using System.Collections.Generic;
using System.Text;
using ePiggy.Utilities;

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
        public void UpdateMonthlyEntries(int userId) //eina per visus
        {
            var entriesInc = _dataFilter.GetRecurringIncome();
            var entriesExp = _dataFilter.GetRecurringExpenses();

            foreach (var entry in entriesInc)
            {
                var entryDate = entry.Date;
                var todayDate = DateTime.Today.Date;
                var differenceInMonths = ((entryDate.Year - todayDate.Year) * 12) + entryDate.Month - todayDate.Month;

                UpdateMonthlyIncome(entry, differenceInMonths, userId);
            }

            foreach (var entry in entriesExp)
            {
                var entryDate = entry.Date;
                var todayDate = DateTime.Today.Date;
                var differenceInMonths = ((entryDate.Year - todayDate.Year) * 12) + entryDate.Month - todayDate.Month;

                UpdateMonthlyExpense(entry, differenceInMonths, userId);
            }
        }

        private void UpdateMonthlyIncome(DataEntry entry, int months, int userId)
        {
            for (var i = 0; i < months; i++)
            {
                var nextMonth = TimeManager.MoveToNextMonth(entry.Date);
                _data.AddIncome(userId, entry.Amount, entry.Title, nextMonth, true, entry.Importance);
                _data.EditIncomeItem(entry.Id, false);
            }
        }

        private void UpdateMonthlyExpense(DataEntry entry, int months, int userId)
        {
            for (var i = 0; i < months; i++)
            {
                var nextMonth = TimeManager.MoveToNextMonth(entry.Date);
                _data.AddExpense(userId, entry.Amount, entry.Title, nextMonth, true, entry.Importance);
                _data.EditExpensesItem(entry.Id, false);
            }
        }

    }
}
