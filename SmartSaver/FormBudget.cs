using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;

namespace SmartSaver
{
    public partial class FormBudget : Form
    {
        private DateTime currentTime = DateTime.Now;
        private DateTime dateTimeNow = DateTime.Today;
        public FormBudget()
        {
            InitializeComponent();
            SetDate();
        }

        private void SetDate()
        {
            
            SetMonths();
        }

        private void SetMonths()
        {
            textBoxCurrentMonth.Text = dateTimeNow.ToString("MMMM");
            buttonPreviousMonth.Text = "tets1";
            buttonNextMonth.Text = "tets1";

        }

        private void ChangeMonth()
        {

        }


        private void TestClick(object sender, EventArgs e)
        {
            Data data = new Data();
            data.ReadIncomeFromFile();
            List<DataEntry> incomes = data.Incomes;
            foreach (var income in incomes)
            {

                MessageBox.Show(income.Title.ToString());
            }

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
