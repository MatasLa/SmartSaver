using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ePiggy.Utilities;

namespace ePiggy.Forms.Reports
{
    public partial class FormIncomeVExpenses : Form
    {
        private readonly Handler _handler;
        public FormIncomeVExpenses(Handler handler)
        {
            InitializeComponent();

            _handler = handler;

            ShowCharts();
        }

        private void ShowCharts()
        {
            ShowIncomesExpensesPreviousMonthPieChart();
            ShowIncomesExpensesCurrentMonthPieChart();
            ShowIncomesExpensesTotalPieChart();
        }

        private void ShowIncomesExpensesTotalPieChart()
        {
            var income = _handler.DataTotalsCalculator.GetTotaledIncomeUntilEndOfThisMonth();
            var expense = _handler.DataTotalsCalculator.GetTotaledExpensesUntilEndOfThisMonth();
            ShowIncomesExpenses(income, expense, pictureBoxTotal);
        }

        private void ShowIncomesExpensesPreviousMonthPieChart()
        {
            var previousMonth = TimeManager.MoveToPreviousMonth(DateTime.Today);
            labelPrevious.Text = previousMonth.ToString("MMMM");
            var income = _handler.DataTotalsCalculator.GetTotaledIncome(previousMonth);
            var expense = _handler.DataTotalsCalculator.GetTotaledExpenses(previousMonth);
            ShowIncomesExpenses(income, expense, pictureBoxPrevious);
        }

        private void ShowIncomesExpensesCurrentMonthPieChart()
        {
            labelCurrent.Text = DateTime.Today.ToString("MMMM");
            var income = _handler.DataTotalsCalculator.GetTotaledIncome(DateTime.Today);
            var expense = _handler.DataTotalsCalculator.GetTotaledExpenses(DateTime.Today);
            ShowIncomesExpenses(income, expense, pictureBoxCurrent);
        }

        private static void ShowIncomesExpenses(decimal income, decimal expenses, PictureBox pictureBox)
        {
            var valuesList = new List<decimal>();
            var namesList = new List<string>();

            if (income > 0)
            {
                valuesList.Add(income);
                namesList.Add("Income");
            }
            if (expenses > 0)
            {
                valuesList.Add(expenses);
                namesList.Add("Expenses");
            }
            FormUtilities.CreateAndDisplayPieChart(pictureBox, valuesList, namesList, GraphDrawer.DefaultColorsList, GraphDrawer.DefaultSize);
        }
    }
}
