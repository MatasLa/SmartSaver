using System;
using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances.goals
{
    public partial class GoalForm : Form
    {
        private Handler _handler;
        private Goal _goal;
        private readonly GoalsForm _parentForm;

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
            Goal = goal;
            _handler = handler;
            _parentForm = parentForm;
            Init();
        }

        private void Init()
        {
            var random = new Random();
            var value = random.Next(0, 100);
            progressBar.Value = value;
            //labelProgress.Text = 

            var temp = (decimal) (random.NextDouble() + 0.1) * 10;
            var current = value * temp;
            var total = 100 * temp;

            labelProgress.Text =
                NumberFormatter.FormatCurrency(current) + " of " + NumberFormatter.FormatCurrency(total);



        }



        private void GoalForm_Click(object sender, EventArgs e)
        {
            _parentForm.DisplayExpandedGoal(_goal);
        }
    }
}
