using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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

        private const string Saved = "Already saved up for this, congratulations!";
        private const string CanSave = "Can Save up for this goal";
        private const string CannotSave = "Can't save up for this goal";

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

            SetComboBoxSelections();
            Init();
        }

        private void Init()
        {
            _target = Goal.Price;
            _saved = _handler.DataTotalsCalculator.GetBalancesUntilToday();
            _progress = SuggestionsCalculator.CalculateProgress(_saved, _target);


            labelTitle.Text = Goal.Title;
            labelTarget.Text =
                NumberFormatter.FormatCurrency(_saved) + @" of " + NumberFormatter.FormatCurrency(_target);
            progressBar.Value = _progress;

            DisplayTable((SavingType)comboBoxSavingType.SelectedIndex);
        }

        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        private void DisplayTable(SavingType savingType)
        {
            if (_progress >= 100)
            {
                labelCanSave.Text = Saved;
                dataGridView.DataSource = null;
            }
            else
            {
                var entrySuggestions = new List<EntrySuggestion>();
                var entries = _handler.DataFilter.GetExpensesUntilEndOfThisMonth();
                labelCanSave.Text = _handler.DataCalculations.GetSuggestedExpensesOffers(entries, _goal, savingType, entrySuggestions) ? CanSave : CannotSave;

                dataGridView.DataSource = DataTableConverter.GenerateSuggestionTable(entrySuggestions);

                dataGridView.Columns["ID"].Visible = false;
                dataGridView.Columns["Amount"].DefaultCellStyle.Format = "c";
                dataGridView.Columns["Date"].DefaultCellStyle.Format = "d";
            }
        }

        private void SetComboBoxSelections()
        {
            var names = Enum.GetNames(typeof(SavingType));
            var objects = names.Cast<object>().ToArray();
            comboBoxSavingType.Items.AddRange(objects);
            comboBoxSavingType.SelectedIndex = 1;
        }

        private void ComboBoxSelections_SelectedIndexChanged(object sender, EventArgs e)
        {
            var savingType = comboBoxSavingType.SelectedIndex;
            DisplayTable((SavingType)savingType);
        }
    }
}
