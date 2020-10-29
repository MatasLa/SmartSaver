using System.Windows.Forms;
using ePiggy.Forms.Finances.Budget;
using ePiggy.Forms.Finances.Goals;

namespace ePiggy.Utilities
{
    public static class FormUtilities
    {
        public static void ChangeForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.ShowDialog();
            currentForm.Close();
        }

        public static void OpenChildForm(ref Form activeForm,  Form childForm, Panel panel)
        {
            if (activeForm != null)
            {
                if (IsSameFormAlreadyOpen(activeForm, childForm))
                {
                    switch (activeForm)
                    {
                        case FinanceForm form when form.EntryType != ((FinanceForm)childForm).EntryType:
                            form.EntryType = ((FinanceForm)childForm).EntryType;
                            break;
                        case EntryInfoForm form:
                            form.DataEntry = ((EntryInfoForm)childForm).DataEntry;
                            break;
                        case MultiEntryInfoForm form:
                            form.Entries = ((MultiEntryInfoForm)childForm).Entries;
                            break;
                        case GoalForm form:
                            form.Goal = ((GoalForm) childForm).Goal;
                            break;
                        case ExpandedGoalForm form:
                            form.Goal = ((ExpandedGoalForm)childForm).Goal;
                            break;
                    }

                    return;
                }
                activeForm.Close();
            }

            activeForm = childForm;
            //it will behave like a control
            childForm.TopLevel = false;
            // make the form the up the whole panel
            childForm.Dock = DockStyle.Fill;
            //add the form to the list of the controls in the container panel
            panel.Controls.Add(childForm);

            // associate the form with the container panel
            panel.Tag = childForm;
            // to hide the logo
            childForm.BringToFront();
            childForm.Show();
        }

        private static bool IsSameFormAlreadyOpen(object activeForm, object newForm)
        {
            return activeForm.GetType() == newForm.GetType();
        }

        public static void CloseChildForm(ref Form activeForm)
        {
            if (activeForm == null) return;
            activeForm.Close();
            activeForm = null;
        }

        public static void ShowOrHideControl(Control control)
        {
            control.Visible = !control.Visible;
        }

        public static void DisplayCurrencyTextWithColor(Label label, decimal value)
        {
            var currencyWithColor = NumberFormatter.FormatCurrencyWithColor(value);
            label.ForeColor = currencyWithColor.Color;
            label.Text = currencyWithColor.Number;
        }

        public static void DisplayCurrency(Label label, decimal value)
        {
            var strCurrency = NumberFormatter.FormatCurrency(value);
            label.Text = strCurrency;
        }
    }
}
