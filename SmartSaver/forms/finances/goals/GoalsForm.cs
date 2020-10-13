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
            //_goals = new List<Goal>();

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
                DisplayMiniGoal(_goals[i], i);
            }
            if (_goals.Count > 4) return;
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
                    FormChanger.OpenChildForm(ref _goalForm0, new GoalForm(goal, _handler, this), panelGoal0);
                    break;
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
            }
        }

        private void CloseMiniGoalForm(int position)
        {
            if (position < 0 || position > 4) throw new Exception("position out of range");
            switch (position)
            {
                case 0:
                    FormChanger.CloseChildForm(ref _goalForm0);
                    break;
                case 1:
                    FormChanger.CloseChildForm(ref _goalForm1);
                    break;
                case 2:
                    FormChanger.CloseChildForm(ref _goalForm2);
                    break;
                case 3:
                    FormChanger.CloseChildForm(ref _goalForm3);
                    break;
                case 4:
                    FormChanger.CloseChildForm(ref _goalForm4);
                    break;
            }
        }

        private void CloseExpandedForm()
        {
            FormChanger.CloseChildForm(ref _expandedGoalForm);
        }

        public void DisplayExpandedGoal(Goal goal)
        {
            FormChanger.OpenChildForm(ref _expandedGoalForm, new ExpandedGoalForm(goal, _handler, this), panelMain);

        }

        #endregion

        private void AddGoalButtonClick(object sender, EventArgs e)
        {
            var goal = new Goal();
            if (!OpenGoalDialog(goal)) return;
            _handler.Data.AddGoal(Handler.UserId, goal.Title, goal.Price, 0);
            //_handler.Data.AddGoal(Handler.UserId, goal.Title, 0);
            UpdateDisplay();
        }

        public void RemoveGoal(Goal goal)
        {
            //WIP
            //CHECK STUFF
            _handler.Data.RemoveGoal(goal.ID);
            //_goals.Remove(goal);

        }

        private bool OpenGoalDialog(Goal goal)
        {
            return new GoalDialogForm(goal, _handler).ShowDialog() == DialogResult.OK;
        }
        
    }
}
