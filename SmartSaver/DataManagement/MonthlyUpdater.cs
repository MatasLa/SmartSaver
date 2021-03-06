﻿using System;
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
            var entriesInc = _dataFilter.GetIncome(isMonthly:true);
            var entriesExp = _dataFilter.GetExpenses(isMonthly: true);
            var todayDate = DateTime.Today.Date;

            foreach (var entry in entriesInc)
            {
                var entryDate = entry.Date;
                var differenceInMonths = TimeManager.DifferenceInMonths(laterTime:todayDate, earlierTime:entryDate);
                if (differenceInMonths > 0) UpdateMonthlyIncome(entry, differenceInMonths, userId);

            }

            foreach (var entry in entriesExp)
            {
                var entryDate = entry.Date;
                var differenceInMonths = TimeManager.DifferenceInMonths(laterTime:todayDate, earlierTime:entryDate);
                if (differenceInMonths > 0) UpdateMonthlyExpense(entry:entry,months: differenceInMonths,userId: userId);
            }
        }

        private void UpdateMonthlyIncome(DataEntry entry, int months, int userId)
        {
            var nextMonth = entry.Date;//assigning current entry data
            for (var i = 0; i < (months - 1); i++)// one less since last one has to keep isMonthly = true;
            {
                nextMonth = TimeManager.MoveToNextMonth(dateTime:nextMonth);//Adding new entry for each month according to date difference
                _data.AddIncome(userId, entry.Amount, entry.Title, nextMonth, isMonthly:false, entry.Importance);
            }

            /*Adding last entry, which has to keep isMonthly*/
            nextMonth = TimeManager.MoveToNextMonth(nextMonth);
            _data.AddIncome(userId, entry.Amount, entry.Title, nextMonth, isMonthly:true, entry.Importance);
            _data.EditIncomeItem(entry.Id, isMonthly:false);//Moved here since no point to edit in each cycle rotation
        }

        private void UpdateMonthlyExpense(DataEntry entry, int months, int userId)
        {
            var nextMonth = entry.Date;
            for (var i = 0; i < (months - 1); i++)
            {
                nextMonth = TimeManager.MoveToNextMonth(nextMonth);
                _data.AddExpense(userId, entry.Amount, entry.Title, nextMonth, isMonthly:false, entry.Importance);
            }

            nextMonth = TimeManager.MoveToNextMonth(nextMonth);
            _data.AddExpense(userId, entry.Amount, entry.Title, nextMonth, isMonthly:true, entry.Importance);
            _data.EditExpensesItem(entry.Id, isMonthly:false);
        }

    }
}
