using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelFinancesSubMenu.Visible = false;
            panelReportsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }

        private void buttonFinances_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFinancesSubMenu);
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportsSubMenu);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void panelFinancesSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBudget_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
            openBudget();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void panelReportsSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSpending_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        private void buttonGoals_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        private void buttonNetWorth_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        private void buttonIncomevExpenses_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void buttonGoalReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void openHelp()
        {

        }

        private void openBudget()
        {

        }

        
    }
}
