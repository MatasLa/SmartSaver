using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances.goals
{
    public partial class GoalsForm : Form
    {
        private readonly Handler _handler;
        private List<Goal> _goals;

        private Form _goalForm1;
        private Form _goalForm2;
        private Form _goalForm3;
        private Form _goalForm4;
        private Form _goalForm5;
        private Form _expandedGoalForm;

        public GoalsForm(Handler handler)
        {
            InitializeComponent();
            _handler = handler;

            //_goals = _handler.Goals;
            _goals = new List<Goal>();

            Init();
        }

        private void Init()
        {
            DisplayGoals();
        }

        public void UpdateDisplay()
        {
            DisplayGoals();
        }

        private void DisplayGoals()
        {
            for (var i = 0; i < _goals.Count; i++)
            {
                DisplayMiniGoal(_goals[i], i + 1);
            }



        }

        #region Display Goal Previews

        private void DisplayMiniGoal(Goal goal, int position)
        {
            if (position < 1 || position > 5) throw new Exception("position out of range");
            switch (position)
            {
                case 1:
                    FormChanger.OpenChildForm(ref _goalForm1, new GoalForm(goal, _handler, this), panelGoal1);
                    break;
                case 2:
                    FormChanger.OpenChildForm(ref _goalForm2, new GoalForm(goal, _handler, this), panelGoal2);
                    break;
                case 3:
                    FormChanger.OpenChildForm(ref _goalForm3, new GoalForm(goal, _handler, this), panelGoal3);
                    break;
                case 4:
                    FormChanger.OpenChildForm(ref _goalForm4, new GoalForm(goal, _handler, this), panelGoal4);
                    break;
                case 5:
                    FormChanger.OpenChildForm(ref _goalForm5, new GoalForm(goal, _handler, this), panelGoal5);
                    break;
            }
        }

        #endregion

        public void DisplayExpandedGoal(Goal goal)
        {
            FormChanger.OpenChildForm(ref _expandedGoalForm, new ExpandedGoalForm(goal, _handler, this), panelMain);

        }

        private void AddGoalButtonClick(object sender, System.EventArgs e)
        {
            if (!OpenGoalDialog()) return;
            _goals.Add(new Goal());
            UpdateDisplay();
        }

        private bool OpenGoalDialog()
        {
            return new GoalDialogForm().ShowDialog() == DialogResult.OK;
        }

        private void panelGoal1_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show("");
        }

    }
}
