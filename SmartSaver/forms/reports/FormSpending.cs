using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ePiggy.Utilities;

namespace ePiggy.Forms.Reports
{
    public partial class FormSpending : Form
    {
        private readonly Handler _handler;
        private readonly Size _defaultSize = new Size(400,400);
        private readonly List<string> _colorsList = new List<string> { "009933", "ff3300", "ff9900", "669900", "0099cc" };
        private List<Importance> _importanceList = Enum.GetValues(typeof(Importance)).Cast<Importance>().ToList();
        public FormSpending(Handler handler)
        {
            InitializeComponent();

            _handler = handler;

            ShowCharts();
        }

        private void ShowCharts()
        {
            ShowSpendingPreviousMonth();
            ShowSpendingCurrentMonth();
            ShowSpendingTotal();
        }

        private void ShowSpendingTotal()
        {
            ShowSpending(pictureBoxTotal);
        }

        private void ShowSpendingPreviousMonth()
        {
            var previousMonth = TimeManager.MoveToPreviousMonth(DateTime.Today);
            labelPrevious.Text = previousMonth.ToString("MMMM");
            ShowSpending(previousMonth, pictureBoxPrevious);
        }

        private void ShowSpendingCurrentMonth()
        {
            labelCurrent.Text = DateTime.Today.ToString("MMMM");
            ShowSpending(DateTime.Today, pictureBoxCurrent);
        }

        private void ShowSpending(DateTime month, PictureBox pictureBox)
        {
            var valuesList = new List<decimal>();
            var namesList = new List<string>();

            foreach (var importance in from importance in _importanceList
                let value = _handler.DataTotalsCalculator.GetTotaledExpenses(importance, month)
                where value > 0 select importance)
            {
                valuesList.Add(_handler.DataTotalsCalculator.GetTotaledExpenses(importance, month));
                namesList.Add(importance.ToString());
            }

            pictureBox.Image =
                GraphDrawer.DrawMultipleVarPieChart(valuesList, namesList, _colorsList, _defaultSize);
        }


        private void ShowSpending(PictureBox pictureBox)
        {
            var valuesList = new List<decimal>();
            var namesList = new List<string>();

            foreach (var importance in from importance in _importanceList
                let value = _handler.DataTotalsCalculator.GetTotaledExpenses(importance)
                where value > 0
                select importance)
            {
                valuesList.Add(_handler.DataTotalsCalculator.GetTotaledExpenses(importance));
                namesList.Add(importance.ToString());
            }

            pictureBox.Image =
                GraphDrawer.DrawMultipleVarPieChart(valuesList, namesList, _colorsList, _defaultSize);
        }

    }
}
