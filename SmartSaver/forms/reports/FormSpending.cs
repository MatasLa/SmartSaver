using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
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
            ShowSpending(pictureBoxPrevious, previousMonth);
        }

        private void ShowSpendingCurrentMonth()
        {
            labelCurrent.Text = DateTime.Today.ToString("MMMM");
            ShowSpending(pictureBoxCurrent, DateTime.Today);
        }

        private void ShowSpending(PictureBox pictureBox, DateTime? month = null)
        {
            var valuesList = new List<decimal>();
            var namesList = new List<string>();

            foreach (var importance in Handler.ImportanceList)
            {
                var value = month is null ? _handler.DataTotalsCalculator.GetTotaledExpenses(importance) : _handler.DataTotalsCalculator.GetTotaledExpenses(importance, (DateTime) month);
                if (value <= 0) continue;
                valuesList.Add(value);
                namesList.Add(importance.ToString());
            }
            FormUtilities.CreateAndDisplayPieChart(pictureBox, valuesList, namesList, GraphDrawer.DefaultColorsList, GraphDrawer.DefaultSize);
        }

    }
}
