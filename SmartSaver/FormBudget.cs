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
        public FormBudget()
        {
            InitializeComponent();


        }

        private void TestClick(object sender, EventArgs e)
        {
            MessageBox.Show("SUcces");
            Data data = new Data();
            data.AddIncome(600, "Salary");
            data.AddIncome(150, "Stocks");



            data.WriteIncomeToFile();
            data.
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
