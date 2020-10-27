using System;
using System.Collections.Generic;
using System.Linq;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    /*Requires DataManager object, methods filter data by provided criteria*/
    public class DataFilter
    {
        private readonly Data _data;
        public DataFilter(Data data)
        {
            _data = data;
        }

        public QueueList<ImportanceGroup> GroupByImportance()//should return queue where least important are first
        { 
            var enumList = Enum.GetValues(typeof(Importance)).Cast<Importance>().ToList();
            //enumList.Reverse();
            var queue = new QueueList<ImportanceGroup>();
            
            var temp = enumList.GroupJoin(_data.Expenses,
                importance => importance,
                entry => (Importance)entry.Importance,
                 (importance, entries) =>
                                new ImportanceGroup()
                                {
                                    Importance = (int) importance,
                                    Entries = entries.Select(entry => entry).ToList()
                                });
            foreach (var entry in temp)
            {
                queue.Add(entry);
            }

            return queue;
        }
        public QueueList<ImportanceGroup> GroupByImportance(List<DataEntry> customList)//should return queue where least important are first
        {
            var enumList = Enum.GetValues(typeof(Importance)).Cast<Importance>().ToList();
            //enumList.Reverse();
            var queue = new QueueList<ImportanceGroup>();

            var temp = enumList.GroupJoin(customList,
                importance => importance,
                entry => (Importance)entry.Importance,
                (importance, entries) =>
                    new ImportanceGroup()
                    {
                        Importance = (int) importance,
                        Entries = entries.Select(entry => entry).ToList()
                    });
            foreach (var entry in temp)
            {
                queue.Add(entry);
            }

            return queue;
        }

        public List<DataEntry> GetIncome(decimal amount) // higher than parameter amount
        {
            return _data.Income.Where(x => x.Amount >= amount).ToList();
        }

        public List<DataEntry> GetIncome(DateTime dateTime) //by date
        {
            return _data.Income.Where(x => (x.Date.Year == dateTime.Year) && (x.Date.Month == dateTime.Month)).ToList();
        }

        public List<DataEntry> GetIncome(Importance importance, DateTime dateTime)
        {
            return _data.Income.Where(x => x.Importance == (int)importance
                                               && x.Date.Year == dateTime.Year && x.Date.Month == dateTime.Month).ToList();
        }

        public List<DataEntry> GetIncome(DateTime from, DateTime to)
        {
            return _data.Income.Where(x => (x.Date >= from) && (x.Date <= to)).ToList();
        }

        public List<DataEntry> GetIncome(Importance importance)
        {
            return _data.Income.Where(x => x.Importance == (int)importance).ToList();
        }

        public List<DataEntry> GetIncome(bool isMonthly = true)
        {
            var temp =
                    (from income in _data.Income
                    where income.IsMonthly == isMonthly
                    select income).ToList();
            //var temp = _data.Income.Where(x => x.IsMonthly == isMonthly).ToList();
            return temp;
        }

        public List<DataEntry> GetIncomeUntilToday()
        {
            return _data.Income.Where(x => x.Date <= DateTime.Today).ToList();
        }

        public List<DataEntry> GetIncomeUntilEndOfThisMonth()
        {
            var today = DateTime.Today;
            return _data.Income.Where(x => (x.Date.Year <= today.Year) && (x.Date.Month <= today.Month)).ToList();
        }

      /*  public List<DataEntry> GetIncome(DateTime from)//from some date until today
        {
            var today = DateTime.Today;
            var temp = _data.Income.Where(x => (x.Date >= from) && (x.Date <= today)).ToList();
            return temp;
        }*/
        public List<DataEntry> GetExpenses(decimal amount) //higher than amount
        {
            return _data.Expenses.Where(x => x.Amount >= amount).ToList();
        }

        public List<DataEntry> GetExpenses(DateTime dateTime)//by date
        {
            return _data.Expenses.Where(x => (x.Date.Year == dateTime.Year) && (x.Date.Month == dateTime.Month))
                .ToList();
        }

        public List<DataEntry> GetExpenses(bool isMonthly = true)
        {
            var temp =
                 (from expense in _data.Expenses
                 where expense.IsMonthly == isMonthly
                 select expense).ToList();
            //var temp = _data.Expenses.Where(x => x.IsMonthly == isMonthly).ToList();
            return temp;
        }

         public List<DataEntry> GetExpenses(DateTime from, DateTime to)
         {
            return _data.Expenses.Where(x => (x.Date >= from) && (x.Date <= to)).ToList();
         }

        public List<DataEntry> GetExpenses(Importance importance)
        {
            return _data.Expenses.Where(x => x.Importance == (int)importance).ToList();
        }

        public List<DataEntry> GetExpenses(Importance importance, DateTime dateTime)
        { 
            return _data.Expenses.Where(x =>
                    x.Importance == (int) importance && x.Date.Year == dateTime.Year && x.Date.Month == dateTime.Month)
                    .ToList();
        }

        public List<DataEntry> GetExpensesUntilToday()
        {
            return _data.Expenses.Where(x => x.Date <= DateTime.Today).ToList();
        }

        public List<DataEntry> GetExpensesUntilEndOfThisMonth()
        {
            var today = DateTime.Today;
            return _data.Expenses.Where(x => (x.Date.Year <= today.Year) && (x.Date.Month <= today.Month)).ToList();
        }

    

       /* public List<DataEntry> GetExpenses(DateTime from)//from some date until today
        {
            var today = DateTime.Today;
            var temp = _data.Expenses.Where(x => (x.Date >= from) && (x.Date <= today)).ToList();
            return temp;
        }*/

    }
}
