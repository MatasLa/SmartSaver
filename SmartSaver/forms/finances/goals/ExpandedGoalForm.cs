using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using ePiggy.DataManagement;
using ePiggy.Utilities;

namespace ePiggy.Forms.Finances.Goals
{
    public partial class ExpandedGoalForm : Form
    {
        private readonly Handler _handler;
        private Goal _goal;
        private readonly GoalsForm _parentForm;

        private decimal _target;
        private decimal _saved;
        private int _progress;

        public Goal Goal
        {
            get => _goal;
            set
            {
                _goal = value;
                Init();
            }
        }

        public ExpandedGoalForm(Goal goal, Handler handler, GoalsForm parentForm)
        {
            InitializeComponent();

            _goal = goal ?? throw new Exception("Given null goal");
            _handler = handler;
            _parentForm = parentForm;

            Init();
        }

        private void Init()
        {
            _target = Goal.Price;
            _saved = _handler.DataTotalsCalculator.GetBalancesUntilToday();
            _progress = DataCalculations.CalculateProgress(_saved, _target);


            labelTitle.Text = Goal.Title;
            labelTarget.Text =
                NumberFormatter.FormatCurrency(_saved) + @" of " + NumberFormatter.FormatCurrency(_target);
            progressBar.Value = _progress;

            DisplayTable();
        }

        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        private void DisplayTable()
        {
            var entrySuggestions = new List<EntrySuggestion>();
            var entries = _handler.DataFilter.GetExpensesUntilEndOfThisMonth();
            _handler.DataCalculations.GetSuggestedExpensesOffers(entries, _goal, SavingType.Regular, entrySuggestions);

            dataGridView.DataSource = _handler.DataTableConverter.GenerateSuggestionTable(entrySuggestions);

            dataGridView.Columns["ID"].Visible = false;
            dataGridView.Columns["Amount"].DefaultCellStyle.Format = "c";
            dataGridView.Columns["Date"].DefaultCellStyle.Format = "d";
        }
    }
}
