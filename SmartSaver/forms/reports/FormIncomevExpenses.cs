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
            var income = _handler.DataTotalsCalculator.GetTotaledIncome();
            var expenses = _handler.DataTotalsCalculator.GetTotaledExpenses();
            pictureBoxTotal.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }

        private void ShowIncomesExpensesPreviousMonthPieChart()
        {
            var previousMonth = TimeManager.MoveToPreviousMonth(DateTime.Today);
            var income = _handler.DataTotalsCalculator.GetTotaledIncome(previousMonth);
            var expenses = _handler.DataTotalsCalculator.GetTotaledExpenses(previousMonth);
            pictureBoxPrevious.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }

        private void ShowIncomesExpensesCurrentMonthPieChart()
        {
            var income = _handler.DataTotalsCalculator.GetTotaledIncome(DateTime.Today);
            var expenses = _handler.DataTotalsCalculator.GetTotaledExpenses(DateTime.Today);
            pictureBoxCurrent.Image = GraphDrawer.DrawIncomesExpensesPieChart(income, expenses);
        }
    }
}
