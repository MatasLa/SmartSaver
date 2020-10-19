using System;

namespace ePiggy.Utilities
{
    public static class TimeManager
    {
        private static readonly DateTime TwoMonthsAhead = DateTime.Today.AddMonths(2);

        public static int DifferenceInMonths(DateTime first, DateTime second)
        {
            return Math.Abs(((first.Year - second.Year) * 12) + first.Month - second.Month);
        }

        public static DateTime ChangeYear(DateTime dateTime, int newYear)
        {
            var temp = dateTime.AddYears(newYear - dateTime.Year);
            return temp >= TwoMonthsAhead ? dateTime : temp;
        }

        public static DateTime ChangeMonth(DateTime dateTime, int newMonth)
        {
            var temp = dateTime.AddMonths(newMonth - dateTime.Month);
            return temp >= TwoMonthsAhead ? dateTime : temp;
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
