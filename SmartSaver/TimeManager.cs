using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    class TimeManager
    {
        public static DateTime ChangeYear(DateTime dateTime, int newYear)
        {
            return dateTime.AddYears(newYear - dateTime.Year);
        }

        public static DateTime ChangeMonth(DateTime dateTime, int newMonth)
        {
            return dateTime.AddMonths(newMonth - dateTime.Month);
        }

        public static DateTime MoveToNextMonth(DateTime dateTime)
        {
            return ChangeMonth(dateTime, dateTime.Month + 1);
        }

        public static DateTime MoveToPreviousMonth(DateTime dateTime)
        {
            return ChangeMonth(dateTime, dateTime.Month - 1);
        }

        public static DateTime MoveToNextYear(DateTime dateTime)
        {
            return ChangeYear(dateTime, dateTime.Year + 1);
        }

        public static DateTime MoveToPreviousYear(DateTime dateTime)
        {
            return ChangeYear(dateTime, dateTime.Year - 1);

        }
    }
}
