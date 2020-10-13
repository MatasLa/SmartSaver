using System;
using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances.goals
{
    public partial class GoalForm : Form
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

        public GoalForm(Goal goal, Handler handler, GoalsForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _handler = handler;
            Goal = goal ?? throw new Exception("Given null goal");


            Init();
        }

        private void Init()
        {
            _target = Goal.Price;
            _saved = _handler.DataFilter.GetBalance();
            _progress = CalculateProgress(_saved, _target);

            labelTitle.Text = Goal.Title;
            labelDate.Text = @"Deadline: " + DateTime.Today.ToString("d");
            labelProgress.Text =
                NumberFormatter.FormatCurrency(_saved) + @" of " + NumberFormatter.FormatCurrency(_target);
            DisplayProgressBar();
        }


        private void DisplayProgressBar()
        {
           progressBar.Value = _progress >= 100 ? progressBar.Maximum : _progress;
        }

        #region Calculation to be moved elsewhere

        private static int CalculateProgress(decimal saved, decimal target)
        {
            return (int)(saved * 100 / target);
        }

        #endregion

        #region Click Handling

        private void ButtonRemoveGoal_Click(object sender, EventArgs e)
        {
            _parentForm.RemoveGoal(Goal);
            _parentForm.UpdateDisplay();
        }

        private void GoalForm_Click(object sender, EventArgs e)
        {
            _parentForm.DisplayExpandedGoal(_goal);
        }

        #endregion
    }
}
