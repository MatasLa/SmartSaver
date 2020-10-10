using System;
using System.Windows.Forms;
using DataManager;
using ePiggy.forms.finances;
using ePiggy.forms.reports;
using ePiggy.utilities;

namespace ePiggy.forms
{
   
    public partial class FormMain : Form
    {
        public Handler Handler { get; }
        //we need to store the previous form to close it to open the new form
        private Form _activeForm;

        public FormMain(Handler handler)
        {
            InitializeComponent();
            CustomizeDesign();
            Handler = handler;
        }

        private void CustomizeDesign()
        {
            panelFinancesSubMenu.Visible = false;
            panelReportsSubMenu.Visible = false;
            label2.Text = DateTime.Now.ToString("D");
        }

        private void SaveOnClose(object sender, FormClosedEventArgs e)
        {
            Handler.DataJSON.WriteIncomeToFile();
            Handler.DataJSON.WriteExpensesToFile();
        }

        #region button event handlers

        private void ButtonFinances_Click(object sender, EventArgs e)
        {
            FormChanger.ShowSubMenu(panelFinancesSubMenu);
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            FormChanger.ShowSubMenu(panelReportsSubMenu);
        }

        private void ButtonIncome_Click(object sender, EventArgs e)
        {
            FormChanger.OpenChildForm(ref _activeForm, new FinanceForm(Handler, EntryType.Income), panelMain);
        }

        private void ButtonExpenses_Click(object sender, EventArgs e)
        {
            FormChanger.OpenChildForm(ref _activeForm, new FinanceForm(Handler, EntryType.Expense), panelMain);
        }

        private void ButtonGoals_Click(object sender, EventArgs e)
        {
            FormChanger.OpenChildForm(ref _activeForm, new FormGoals(Handler), panelMain);
        }

        private void ButtonSpending_Click(object sender, EventArgs e)
        {
            FormChanger.OpenChildForm(ref _activeForm, new FormSpending(), panelMain);
        }

        private void ButtonNetWorth_Click(object sender, EventArgs e)
        {
            FormChanger.OpenChildForm(ref _activeForm, new FormNetWorth(), panelMain);
        }

        private void ButtonIncomeVExpenses_Click(object sender, EventArgs e)
        {
            FormChanger.OpenChildForm(ref _activeForm, new FormIncomeVExpenses(), panelMain);
        }

        private void ButtonGoalReport_Click(object sender, EventArgs e)
        {
            FormChanger.OpenChildForm(ref _activeForm, new FormGoalReports(), panelMain);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            FormChanger.OpenChildForm(ref _activeForm, new FormHelp(), panelMain);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            FormChanger.ChangeForm(this, new FormLogIn(Handler));
        }

        private void MenuLogo_Click(object sender, EventArgs e)
        {
            FormChanger.CloseChildForm(ref _activeForm);
        }

        #endregion

    }

}
