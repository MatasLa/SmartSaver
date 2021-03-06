﻿using System;
using System.Windows.Forms;
using ePiggy.DataManagement;
using ePiggy.Utilities;

namespace ePiggy.Forms.Finances.Goals
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
            _saved = _handler.DataTotalsCalculator.GetBalancesUntilToday();
            _progress = DataCalculations.CalculateProgress(_saved, _target);

            labelTitle.Text = Goal.Title;
            labelProgress.Text =
                NumberFormatter.FormatCurrency(_saved) + @" of " + NumberFormatter.FormatCurrency(_target);
            progressBar.Value = _progress;
        }

        #region Calculation of progress bar

        #endregion

        #region Click Handling

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            _parentForm.EditGoalWithDialog(Goal);
            _parentForm.UpdateDisplay();
        }

        private void ButtonRemoveGoal_Click(object sender, EventArgs e)
        {
            _parentForm.RemoveGoal(Goal);
            _parentForm.UpdateDisplay();
        }

        private void GoalForm_Click(object sender, EventArgs e)
        {
            _parentForm.DisplayExpandedGoal(Goal);
        }

        #endregion

    }
}
