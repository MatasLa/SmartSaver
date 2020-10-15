using System;
using System.Drawing;
using System.Windows.Forms;
using ePiggy.backend;
using ePiggy.utilities;

namespace ePiggy.forms.reports
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
            var income = _handler.DataFilter.GetTotaledIncome();
            var expenses = _handler.DataFilter.GetTotaledExpenses();
            pictureBoxTotal.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }

        private void ShowIncomesExpensesPreviousMonthPieChart()
        {
            var previousMonth = TimeManager.MoveToPreviousMonth(DateTime.Today);
            var income = _handler.DataFilter.GetTotaledIncome(previousMonth);
            var expenses = _handler.DataFilter.GetTotaledExpenses(previousMonth);
            pictureBoxPrevious.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }

        private void ShowIncomesExpensesCurrentMonthPieChart()
        {
            var income = _handler.DataFilter.GetTotaledIncome(DateTime.Today);
            var expenses = _handler.DataFilter.GetTotaledExpenses(DateTime.Today);
            pictureBoxCurrent.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }
    }
}
