using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using SmartSaver;
using Utilities;

namespace Forms
{
    public partial class AddEntryForm : Form
    {
        private DataEntry dataEntry;
        private EntryType entryType;
        private string errorMessage;
        private readonly string badTitleErrorMessage = "Please enter a title";
        private readonly string badNumberErrorMessage = "Please enter a valid number";
        private readonly string incomeTitle = "Add Income";
        private readonly string expenseTitle = "Add Expense";

        public AddEntryForm(DataEntry dataEntry, EntryType entryType)
        {
            InitializeComponent();
            this.dataEntry = dataEntry;
            this.entryType = entryType;
            SetTitle();
            Select();
        }

        private void SetTitle()
        {
            switch (entryType)
            {
                case EntryType.Income:
                    this.Text = incomeTitle;
                    break;
                case EntryType.Expense:
                    this.Text = expenseTitle;
                    break;
            }

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                TakeInput();
                DialogResult = DialogResult.OK;
            }
            else
            {
                CreateErrorMessage();
                MessageBox.Show(errorMessage);
            }
        }

        private bool IsInputValid()
        {
            if (InputValidator.IsNameValid(textBoxTitle.Text) && InputValidator.IsNameValid(textBoxValue.Text))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void TakeInput()
        {
            dataEntry.Amount = Math.Round(Double.Parse(textBoxValue.Text), 2);
            dataEntry.Title = textBoxTitle.Text;
            dataEntry.IsMonthly = checkBoxMonthly.Checked;
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
            //duodam regex chekeriui stringa ir nauja chara, 
            //jeigu geras charas stringa keiciam, jeigu negeras nekeiciam
        }

        private void TextBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
