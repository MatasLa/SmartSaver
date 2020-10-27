using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ePiggy.Utilities;

namespace ePiggy.Forms.Reports
{
    public partial class FormIncomeVExpenses : Form
    {
        private readonly Handler _handler;
        private Size _defaultSize = new Size(400, 400);
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
            var income = _handler.DataTotalsCalculator.GetTotaledIncome();
            var expenses = _handler.DataTotalsCalculator.GetTotaledExpenses();
            var postFix = "total";
            var valuesList = new List<decimal> { income, expenses };
            var namesList = new List<string> { "Income, " + postFix, "Expenses, " + postFix };
            var colorsList = new List<string> { "85bb65", "eb5244" };
            pictureBoxTotal.Image = GraphDrawer.DrawMultipleVarPieChart(valuesList, namesList, colorsList, _defaultSize);
        }

        private void ShowIncomesExpensesPreviousMonthPieChart()
        {
            var previousMonth = TimeManager.MoveToPreviousMonth(DateTime.Today);
            var income = _handler.DataTotalsCalculator.GetTotaledIncome(previousMonth);
            var expenses = _handler.DataTotalsCalculator.GetTotaledExpenses(previousMonth);
            var postFix = previousMonth.ToString("MMMM");
            var valuesList = new List<decimal> { income, expenses };
            var namesList = new List<string> { "Income, " + postFix, "Expenses, " + postFix };
            var colorsList = new List<string> { "85bb65", "eb5244" };
            pictureBoxPrevious.Image = GraphDrawer.DrawMultipleVarPieChart(valuesList, namesList, colorsList, _defaultSize);
        }

        private void ShowIncomesExpensesCurrentMonthPieChart()
        {
            var income = _handler.DataTotalsCalculator.GetTotaledIncome(DateTime.Today);
            var expenses = _handler.DataTotalsCalculator.GetTotaledExpenses(DateTime.Today);
            var postFix = DateTime.Today.ToString("MMMM");
            var valuesList = new List<decimal> { income, expenses };
            var namesList = new List<string> { "Income, " + postFix, "Expenses, " + postFix };
            var colorsList = new List<string> { "85bb65", "eb5244" };
            pictureBoxCurrent.Image = GraphDrawer.DrawMultipleVarPieChart(valuesList, namesList, colorsList, _defaultSize);
        }
    }
}
