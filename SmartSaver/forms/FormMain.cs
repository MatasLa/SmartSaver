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
using EPiggy;
using Utilities;

namespace Forms
{
   
    public partial class FormMain : Form
    {
        public Handler DataHandler { get; }
        //we need to store the previous form to close it to open the new form
        private Form activeForm = null;

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
            label2.Text = DateTime.Now.ToString("D");
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

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                if (IsSameFormAlreadyOpen(childForm))
                {
                    if (activeForm is FinanceForm form 
                        && form.EntryType != ((FinanceForm)childForm).EntryType)
                    {
                        form.EntryType = ((FinanceForm)childForm).EntryType;
                    }
                    return;
                }
                else
                {
                    activeForm.Close();
                }
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

        private bool IsSameFormAlreadyOpen(object form)
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


        #region button event handlers

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
            //OpenChildForm(new FinanceForm(DataHandler, EntryType.Expense));
            FormChanger.OpenChildForm(ref activeForm, new FinanceForm(DataHandler, EntryType.Expense), panelMain);
        }

        private void ButtonIncome_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FinanceForm(DataHandler, EntryType.Income));
            FormChanger.OpenChildForm(ref activeForm, new FinanceForm(DataHandler, EntryType.Income), panelMain);
        }

        private void ButtonExpenses_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FinanceForm(DataHandler, EntryType.Expense));
            FormChanger.OpenChildForm(ref activeForm, new FinanceForm(DataHandler, EntryType.Expense), panelMain);
        }

        private void ButtonGoals_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormGoals());
            FormChanger.OpenChildForm(ref activeForm, new FormGoals(), panelMain);
        }

        private void ButtonSpending_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormSpending());
            FormChanger.OpenChildForm(ref activeForm, new FormSpending(), panelMain);
        }

        private void ButtonNetWorth_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormNetWorth());
            FormChanger.OpenChildForm(ref activeForm, new FormNetWorth(), panelMain);
        }

        private void ButtonIncomevExpenses_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormIncomevExpenses());
            FormChanger.OpenChildForm(ref activeForm, new FormIncomevExpenses(), panelMain);
        }

        private void ButtonGoalReport_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormGoalReports());
            FormChanger.OpenChildForm(ref activeForm, new FormGoalReports(), panelMain);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormHelp());
            FormChanger.OpenChildForm(ref activeForm, new FormHelp(), panelMain);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            FormChanger.ChangeForm(this, new FormLogIn(DataHandler));
        }

        private void MenuLogo_Click(object sender, EventArgs e)
        {
            FormChanger.CloseChildForm(ref activeForm);
        }

        #endregion

    }

}
