using System;
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
            var income = _handler.DataTotals.GetTotaledIncome();
            var expenses = _handler.DataTotals.GetTotaledExpenses();
            pictureBoxTotal.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }

        private void ShowIncomesExpensesPreviousMonthPieChart()
        {
            var previousMonth = TimeManager.MoveToPreviousMonth(DateTime.Today);
            var income = _handler.DataTotals.GetTotaledIncome(previousMonth);
            var expenses = _handler.DataTotals.GetTotaledExpenses(previousMonth);
            pictureBoxPrevious.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }

        private void ShowIncomesExpensesCurrentMonthPieChart()
        {
            var income = _handler.DataTotals.GetTotaledIncome(DateTime.Today);
            var expenses = _handler.DataTotals.GetTotaledExpenses(DateTime.Today);
            pictureBoxCurrent.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }
    }
}
