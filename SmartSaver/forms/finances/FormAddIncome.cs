using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using Utilities;

namespace Forms
{
    public partial class FormAddIncome : Form
    {
        //butu fainai padaryti inheretence normalesni, bet designeris neveikia

        private Handler handler;
        private double value;
        private string title;
        private string errorMessage;
        private string badTitleErrorMessage = "Please enter a title";
        private string badNumberErrorMessage = "Please enter a valid number";

        public FormAddIncome(Handler handler)
        {
            InitializeComponent();
            Select();
            this.handler = handler;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                handler.Data.AddIncome(value, title, date: handler.Time, isMonthly: checkBoxMonthly.Checked);
                handler.DataJSON.WriteIncomeToFile();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private bool IsInputValid()
        {
            if (InputValidator.IsNameValid(textBoxTitle.Text) && InputValidator.IsNameValid(textBoxValue.Text))
            {
                TakeInput();
                return true;
            }
            else 
            {
                CreateErrorMessage();
                return false;
            }
        }

        private void TakeInput()
        {
            value = Double.Parse(textBoxValue.Text, System.Globalization.CultureInfo.CurrentCulture);
            title = textBoxTitle.Text;
        }

        private void CreateErrorMessage()
        {
            if(InputValidator.IsNameValid(textBoxTitle.Text))
            {
                errorMessage = badNumberErrorMessage;
            } 
            else if (InputValidator.IsNameValid(textBoxValue.Text))
            {
                errorMessage = badTitleErrorMessage;
            }
            else
            {
                errorMessage = badTitleErrorMessage + "\n" + badNumberErrorMessage;
            }
        }

        private void TextBoxValue_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxValue.Text, "  ^ [0-9]"))
            {
                textBoxValue.Text = "";
            }
        }

        private void TextBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
