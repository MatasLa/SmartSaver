using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ePiggy.Utilities;

namespace ePiggy.Forms.Reports
{
    public partial class FormNetWorth : Form
    {
        private readonly Handler _handler;
        public FormNetWorth(Handler handler)
        {
            InitializeComponent();

            _handler = handler;

            ShowChart();
        }

        private void ShowChart()
        {
            const string name = "Your monthly balance";
            var oldestMonth = DateTime.Today.AddMonths(-6); ;

            var valueList = new List<decimal>();
            var namesList = new List<string>();
            var highestValue = 0M;

            while (oldestMonth <= TimeManager.OneMonthAhead)
            {
                var balance = _handler.DataTotalsCalculator.GetBalance(oldestMonth);
                if (balance > highestValue)
                {
                    highestValue = balance;
                }
                valueList.Add(balance);
                namesList.Add(oldestMonth.ToShortDateString());
                oldestMonth = TimeManager.MoveToNextMonth(oldestMonth);
            }

            var size = new Size(600,999);

            pictureBoxBarGraph.Image =
                GraphDrawer.DrawMultipleVarBarChart(name, valueList, namesList, (int)highestValue, size);
        }
    }
}
