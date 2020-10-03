using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using EPiggy;
using Utilities;

namespace Forms
{
    //kol kas padaryta taip, kad jei perduodi null arba tuscia DataEntry, tai kurs nauja, o jei nera tuscias (t.y. id != 0), tada editins
    public partial class EntryForm : Form
    {
        private DataEntry dataEntry;
        private EntryType entryType;

        private string errorMessage;
        private readonly string badTitleErrorMessage = "Please enter a title";
        private readonly string badNumberErrorMessage = "Please enter a valid number";
        private readonly string addIncomeTitle = "Add Income";
        private readonly string addExpenseTitle = "Add Expense";
        private readonly string editIncomeTitle = "Edit Income";
        private readonly string editExpenseTitle = "Edit Expense";

        public EntryForm(DataEntry dataEntry, EntryType entryType)
        {
            InitializeComponent();
            if (dataEntry is null)
            {
                throw new Exception("Given null data entry");
            }
            this.dataEntry = dataEntry;
            this.entryType = entryType;
            SetUpAddOrEdit();
            Select();
        }


        #region Initialization
        private void SetUpAddOrEdit()
        {
            if (dataEntry.ID == 0)
            {
                SetUpAdd();
            }
            else
            {
                SetUpEdit();
            }
        }

        private void SetUpAdd()
        {
            switch (entryType)
            {
                case EntryType.Income:
                    Text = addIncomeTitle;
                    break;
                case EntryType.Expense:
                    Text = addExpenseTitle;
                    break;
            }
        }

        private void SetUpEdit()
        {
            switch (entryType)
            {
                case EntryType.Income:
                    Text = editIncomeTitle;
                    break;
                case EntryType.Expense:
                    Text = editExpenseTitle;
                    break;
            }
            Text += " \"" + dataEntry.Title + "\"";
            textBoxTitle.Text = dataEntry.Title;
            textBoxValue.Text = dataEntry.Amount.ToString();
            checkBoxMonthly.Checked = dataEntry.IsMonthly;
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
        #endregion

        #region Input Handling
        private bool IsInputValid()
        {
            if (InputValidator.IsCurrencyInputValid(textBoxValue.Text) && InputValidator.IsNameValid(textBoxValue.Text))
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
            dataEntry.Amount = Decimal.Round(Decimal.Parse(textBoxValue.Text), 2);
            dataEntry.Title = textBoxTitle.Text;
            dataEntry.IsMonthly = checkBoxMonthly.Checked;
        }

        private void CreateErrorMessage()
        {
            if (InputValidator.IsNameValid(textBoxTitle.Text))
            {
                errorMessage = badNumberErrorMessage;
            }
            else if (InputValidator.IsCurrencyInputValid(textBoxValue.Text))
            {
                errorMessage = badTitleErrorMessage;
            }
            else
            {
                errorMessage = badTitleErrorMessage + "\n" + badNumberErrorMessage;
            }
        } 
        #endregion

        #region Event Handlers
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
            if (e.KeyChar == (char)Keys.Escape)
            {
                Select();
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void EntryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                buttonCancel.PerformClick();
            }
        } 
        #endregion

    }
}
