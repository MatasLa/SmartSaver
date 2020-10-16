using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ePiggy.DataManagement;
using ePiggy.Utilities;

namespace ePiggy.Forms.Finances.Goals
{
    public partial class GoalsForm : Form
    {
        private readonly Handler _handler;
        private readonly List<Goal> _goals;

        private Form _goalForm0;
        private Form _goalForm1;
        private Form _goalForm2;
        private Form _goalForm3;
        private Form _goalForm4;
        private Form _expandedGoalForm;

        public GoalsForm(Handler handler)
        {
            InitializeComponent();
            _handler = handler;

            _goals = _handler.Data.GoalsList;

            Init();
        }

        private void Init()
        {
            UpdateDisplay();
        }

        #region Display

        public void UpdateDisplay()
        {
            DisplayGoals();
            CloseExpandedForm();
        }

        private void DisplayGoals()
        {
            for (var i = 0; i < _goals.Count; i++)
            {
                if (i > 4) return;
                DisplayMiniGoal(_goals[i], i);
            }
            if (_goals.Count > 4) return; // If somehow we get more goals we just stop showing them
            for (var i = _goals.Count; i <= 4; i++)
            {
                CloseMiniGoalForm(i);
            }
        }


        private void DisplayMiniGoal(Goal goal, int position)
        {
            if (position < 0 || position > 4) throw new Exception("position out of range");
            switch (position)
            {
                case 0:
                    FormUtilities.OpenChildForm(ref _goalForm0, new GoalForm(goal, _handler, this), panelGoal0);
                    break;
                case 1:
                    FormUtilities.OpenChildForm(ref _goalForm1, new GoalForm(goal, _handler, this), panelGoal1);
                    break;
                case 2:
                    FormUtilities.OpenChildForm(ref _goalForm2, new GoalForm(goal, _handler, this), panelGoal2);
                    break;
                case 3:
                    FormUtilities.OpenChildForm(ref _goalForm3, new GoalForm(goal, _handler, this), panelGoal3);
                    break;
                case 4:
                    FormUtilities.OpenChildForm(ref _goalForm4, new GoalForm(goal, _handler, this), panelGoal4);
                    break;
            }
        }

        private void CloseMiniGoalForm(int position)
        {
            if (position < 0 || position > 4) throw new Exception("position out of range");
            switch (position)
            {
                case 0:
                    FormUtilities.CloseChildForm(ref _goalForm0);
                    break;
                case 1:
                    FormUtilities.CloseChildForm(ref _goalForm1);
                    break;
                case 2:
                    FormUtilities.CloseChildForm(ref _goalForm2);
                    break;
                case 3:
                    FormUtilities.CloseChildForm(ref _goalForm3);
                    break;
                case 4:
                    FormUtilities.CloseChildForm(ref _goalForm4);
                    break;
            }
        }

        private void CloseExpandedForm()
        {
            FormUtilities.CloseChildForm(ref _expandedGoalForm);
        }

        public void DisplayExpandedGoal(Goal goal)
        {
            FormUtilities.OpenChildForm(ref _expandedGoalForm, new ExpandedGoalForm(goal, _handler, this), panelMain);

        }

        #endregion

        private void AddGoalButtonClick(object sender, EventArgs e)
        {
            var goal = new Goal();
            if (!OpenGoalDialog(goal)) return;
            if (goal.Price == 0)
            {
                _handler.Data.AddGoal(Handler.UserId, goal.Title, 0);
            }
            else
            {
                _handler.Data.AddGoal(Handler.UserId, goal.Title, goal.Price, 0);
            }
            //_handler.Data.AddGoal(Handler.UserId, goal.Title, 0);
            UpdateDisplay();
        }

        public void RemoveGoal(Goal goal)
        {
            _handler.Data.RemoveGoal(goal.Id);
        }

        private bool OpenGoalDialog(Goal goal)
        {
            return new GoalDialogForm(goal, _handler).ShowDialog() == DialogResult.OK;
        }
        
    }
}
