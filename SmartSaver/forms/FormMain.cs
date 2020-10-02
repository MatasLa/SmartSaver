using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;
using Forms;
using SmartSaver;
using Utilities;

namespace Forms
{
   
    public partial class FormMain : Form
    {
        public Handler DataHandler { get; }

        public FormMain(Handler dataHandler)
        {
            InitializeComponent();
            CustomizeDesign();
            DataHandler = dataHandler;
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
            if (activeForm is FinanceForm form)
            {
                form.EntryType = EntryType.Expense;
            }
            else
            {
                OpenChildForm(new FinanceForm(DataHandler, EntryType.Expense));
            }
        }

        private void ButtonIncome_Click(object sender, EventArgs e)
        {
            if (activeForm is FinanceForm form)
            {
                form.EntryType = EntryType.Income;
            }
            else
            {
                OpenChildForm(new FinanceForm(DataHandler, EntryType.Income));
            }
        }

        private void ButtonExpenses_Click(object sender, EventArgs e)
        {
            if (activeForm is FinanceForm form)
            {
                form.EntryType = EntryType.Expense;
            }
            else
            {
                OpenChildForm(new FinanceForm(DataHandler, EntryType.Expense));
            }
        }

        private void ButtonGoals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGoals());
        }

        private void ButtonSpending_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSpending());
        }


        private void ButtonNetWorth_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNetWorth());
        }

        private void ButtonIncomevExpenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormIncomevExpenses());
        }

        private void ButtonGoalReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGoalReports());
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHelp());
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
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else
            {
                if (!IsSameFormAlreadyOpen(childForm))
                {
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
            }
        }

        private bool IsSameFormAlreadyOpen(Form form)
        {
            if(activeForm.GetType() == form.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
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
