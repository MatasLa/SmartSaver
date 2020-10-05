using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Forms
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
                    if (activeForm is FinanceForm financeForm
                        && financeForm.EntryType != ((FinanceForm)childForm).EntryType)
                    {
                        financeForm.EntryType = ((FinanceForm)childForm).EntryType;
                    }
                    else if (activeForm is EntryInfoForm entryInfoForm)
                    {
                        entryInfoForm.DataEntry = ((EntryInfoForm)childForm).DataEntry;
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
            panel.Controls.Add(childForm);

            // associate the form with the container panel
            panel.Tag = childForm;
            // to hide the logo
            childForm.BringToFront();
            childForm.Show();
        }

        private static bool IsSameFormAlreadyOpen(object activeForm, object newForm)
        {
            if (activeForm.GetType() == newForm.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CloseChildForm(ref Form activeForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }
    }
}
