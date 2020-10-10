using System.Windows.Forms;
using ePiggy.forms.finances;

namespace ePiggy.utilities
{
    public static class FormChanger
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
                //kazkaip noreciau sita pakeisti, kad butu platesnio naudojimo
                if (IsSameFormAlreadyOpen(activeForm, childForm))
                {
                    switch (activeForm)
                    {
                        case FinanceForm financeForm when financeForm.EntryType != ((FinanceForm)childForm).EntryType:
                            financeForm.EntryType = ((FinanceForm)childForm).EntryType;
                            break;
                        case EntryInfoForm entryInfoForm:
                            entryInfoForm.DataEntry = ((EntryInfoForm)childForm).DataEntry;
                            break;
                        case MultiEntryInfoForm multiEntryInfoForm:
                            multiEntryInfoForm.Entries = ((MultiEntryInfoForm)childForm).Entries;
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

        public static void ShowSubMenu(Control control)
        {
            control.Visible = control.Visible == false;
        }
    }
}
