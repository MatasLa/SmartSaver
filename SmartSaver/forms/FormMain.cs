using System;
using System.Windows.Forms;
using ePiggy.Forms.Auth;
using ePiggy.Forms.Finances.Budget;
using ePiggy.Forms.Finances.Goals;
using ePiggy.Forms.Reports;
using ePiggy.Utilities;

namespace ePiggy.Forms
{
   
    public partial class FormMain : Form
    {
        private Handler Handler { get; }
        //we need to store the previous form to close it to open the new form
        private Form _activeForm;

        public FormMain(Handler handler)
        {
            InitializeComponent();
            CustomizeDesign();
            Handler = handler;
            Handler.Update();
        }

        private void CustomizeDesign()
        {
            panelFinancesSubMenu.Visible = false;
            panelReportsSubMenu.Visible = false;
            label2.Text = DateTime.Now.ToString("D");
        }

        private void SaveOnClose(object sender, FormClosedEventArgs e)
        {
            Handler.DataJson.WriteIncomeToFile();
            Handler.DataJson.WriteExpensesToFile();
        }

        #region button event handlers

        private void ButtonFinances_Click(object sender, EventArgs e)
        {
            FormUtilities.ShowOrHideControl(panelFinancesSubMenu);
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            FormUtilities.ShowOrHideControl(panelReportsSubMenu);
        }

        private void ButtonIncome_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new FinanceForm(Handler, EntryType.Income), panelMain);
        }

        private void ButtonExpenses_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new FinanceForm(Handler, EntryType.Expense), panelMain);
        }

        private void ButtonGoals_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new GoalsForm(Handler), panelMain);
        }

        private void ButtonSpending_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new FormSpending(Handler), panelMain);
        }

        private void ButtonNetWorth_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new FormNetWorth(), panelMain);
        }

        private void ButtonIncomeVExpenses_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new FormIncomeVExpenses(Handler), panelMain);
        }

        private void ButtonGoalReport_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new FormGoalReports(), panelMain);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new FormHelp(), panelMain);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            FormUtilities.ChangeForm(this, new FormLogIn(Handler));
        }

        private void MenuLogo_Click(object sender, EventArgs e)
        {
            FormUtilities.CloseChildForm(ref _activeForm);
        }

        #endregion

    }

}
