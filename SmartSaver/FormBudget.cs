using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using TimeManager;

namespace TimeManager
{
    public partial class FormBudget : Form
    {
        private DateTime displayedTime = DateTime.Now;

        public FormBudget()
        {
            InitializeComponent();
            DisplayDate();
        }

        private void TestClick(object sender, EventArgs e)
        {
            Data data = new Data();
            data.ReadIncomeFromFile();
            List<DataEntry> incomes = data.Income;
            foreach (var income in incomes)
            {

                MessageBox.Show(income.Title.ToString());
            }

        }

        private void DisplayDate()
        {
            textBoxCurrentMonth.Text = displayedTime.ToString("MMMM");
            textBoxCurrentYear.Text = displayedTime.Year.ToString();

        }

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            this.displayedTime = TimeManager.MoveToNextYear(displayedTime);
            DisplayDate();
        }

        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            this.displayedTime = TimeManager.MoveToPreviousYear(displayedTime);
            DisplayDate();
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            this.displayedTime = TimeManager.MoveToNextMonth(displayedTime);
            DisplayDate();
        }

        private void ButtonPreviousMonth_Click(object sender, EventArgs e)
        {
            this.displayedTime = TimeManager.MoveToPreviousMonth(displayedTime);
            DisplayDate();
        }
    }
}
