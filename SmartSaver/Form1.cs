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
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelFinancesSubMenu.Visible = false;
            panelReportsSubMenu.Visible = false;
        }

        private void ButtonFinances_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFinancesSubMenu);
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelReportsSubMenu);
        }

        private void ButtonBudget_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBudget());
        }

        private void ButtonIncome_Click(object sender, EventArgs e)
        {
            openChildForm(new FormIncome());

        }

        private void ButtonExpenses_Click(object sender, EventArgs e)
        {
            openChildForm(new FormExpenses());
        }

        private void ButtonGoals_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGoals());
        }

        private void ButtonSpending_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSpending());
        }


        private void ButtonNetWorth_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNetWorth());
        }

        private void ButtonIncomevExpenses_Click(object sender, EventArgs e)
        {
            openChildForm(new FormIncomevExpenses());
        }

        private void ButtonGoalReport_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGoalReports());
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHelp());
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuLogo_Click(object sender, EventArgs e)
        {
            CloseChildForm();
        }


        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //we need to store the previous form to close it to open the new form
        private Form activeForm = null;
        private void openChildForm (Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            //it will behave like a control
            childForm.TopLevel = false;
            // make the form the up the whole panel
            childForm.Dock = DockStyle.Fill;
            //add the form to the list of the controls in the container panel
            panelMain.Controls.Add(childForm);
            // associate the form with the container panel
            panelMain.Tag = childForm;
            // to hide the logo
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }
    }
}
