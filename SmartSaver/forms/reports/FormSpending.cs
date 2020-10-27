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

            foreach (var importance in from importance in Handler.ImportanceList
                let value = _handler.DataTotalsCalculator.GetTotaledExpenses(importance, month)
                where value > 0 select importance)
            {
                valuesList.Add(_handler.DataTotalsCalculator.GetTotaledExpenses(importance, month));
                namesList.Add(importance.ToString());
            }

            pictureBox.Image =
                GraphDrawer.DrawMultipleVarPieChart(valuesList, namesList, GraphDrawer.ColorsList, GraphDrawer.DefaultSize);
        }


        private void ShowSpending(PictureBox pictureBox)
        {
            var valuesList = new List<decimal>();
            var namesList = new List<string>();

            foreach (var importance in from importance in Handler.ImportanceList
                                       let value = _handler.DataTotalsCalculator.GetTotaledExpenses(importance)
                                       where value > 0 select importance)
            {
                valuesList.Add(_handler.DataTotalsCalculator.GetTotaledExpenses(importance));
                namesList.Add(importance.ToString());
            }

            pictureBox.Image =
                GraphDrawer.DrawMultipleVarPieChart(valuesList, namesList, GraphDrawer.ColorsList, GraphDrawer.DefaultSize);
        }

    }
}
