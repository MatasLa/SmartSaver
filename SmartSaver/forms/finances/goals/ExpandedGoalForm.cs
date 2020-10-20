using System;
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
            labelTitle.Text = Goal.Title;
            labelTarget.Text = NumberFormatter.FormatCurrency(Goal.Price);


            _target = Goal.Price;
            _saved = _handler.DataFilter.GetBalancesUntilToday();
            _progress = DataCalculations.CalculateProgress(_saved, _target);

            labelTitle.Text = Goal.Title;
            progressBar.Value = _progress;
        }

    }
}
