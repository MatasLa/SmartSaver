using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;

namespace ePiggy.forms.finances
{
    public partial class GoalForm : Form
    {
        private Handler _handler;
        private Goal _goal;

        public Goal Goal
        {
            get => _goal;
            set
            {
                _goal = value;
                Init();
            }
        }

        public GoalForm(Goal goal, Handler handler)
        {
            InitializeComponent();
            Goal = goal;
            _handler = handler;
            Init();
        }

        private void Init()
        {
            Random random = new Random();
            progressBar1.Value = random.Next(0,100);
        }

        private void GoalForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
