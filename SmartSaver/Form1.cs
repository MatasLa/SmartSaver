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
        private readonly int collapsedMenuWidth = 75;
        private readonly int expandedMenuWidth = 250;
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelFinancesSubMenu.Visible = false;
            panelReportsSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }

        private void ButtonFinances_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFinancesSubMenu);
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelReportsSubMenu);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void PanelFinancesSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonBudget_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
            OpenBudget();
        }

        private void ButtonIncome_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void PanelReportsSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonSpending_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonExpenses_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        private void ButtonGoals_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        private void ButtonNetWorth_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        private void ButtonIncomevExpenses_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void ButtonGoalReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

        }

        private void ButtonCollapse_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Size.Width == expandedMenuWidth)
            {
                panelSideMenu.Size = new Size(collapsedMenuWidth, panelSideMenu.Size.Height);
            } else
            {
                panelSideMenu.Size = new Size(expandedMenuWidth, panelSideMenu.Size.Height);
            }
        }

        private void OpenHelp()
        {

        }

        private void OpenBudget()
        {

        }

        
    }
}
