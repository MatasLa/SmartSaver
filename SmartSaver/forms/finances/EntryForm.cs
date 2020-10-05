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

    //reikia padaryti, kad jeigu cia nustatau date, tai ir pasikeistu DataHandlerio data!!!
    public partial class EntryForm : Form
    {
        private Handler handler;
        private DataEntry dataEntry;
        private EntryType entryType;
        private readonly Size collapsedSize;
        private readonly Size expandedSize;

        private string errorMessage;
        private readonly string badTitleErrorMessage = "Please enter a title";
        private readonly string badNumberErrorMessage = "Please enter a valid number";
        private readonly string addIncomeTitle = "Add Income";
        private readonly string addExpenseTitle = "Add Expense";
        private readonly string editIncomeTitle = "Edit Income";
        private readonly string editExpenseTitle = "Edit Expense";

        public EntryForm(DataEntry dataEntry, EntryType entryType, Handler handler)
        {
            InitializeComponent();

            if (dataEntry is null)
            {
                throw new Exception("Given null data entry");
            }

            expandedSize = Size;
            collapsedSize = new Size(Size.Width, Size.Height - monthCalendar.Size.Height - 25);

            this.dataEntry = dataEntry;
            this.entryType = entryType;
            this.handler = handler;

            SetUpAddOrEdit();
            Collapse();
            Select();
        }

        #region Title setup
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
        #endregion

        #region Input Handling

        private void ReturnResult()
        {
            TakeInput();
            DialogResult = DialogResult.OK;
        }

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
            dataEntry.Date = monthCalendar.SelectionStart;

            ///// WIP
            
            handler.Time = monthCalendar.SelectionStart;

        }

        #endregion

        #region Keyboard Input Handling

        private void TextBoxValue_TextChanged(object sender, EventArgs e)
        {
            //WIP
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxValue.Text, "  ^ [0-9]"))
            {
                textBoxValue.Text = "";
            }
            //duodam regex chekeriui stringa ir nauja chara, 
            //jeigu geras charas stringa keiciam, jeigu negeras nekeiciam
        }

        private void TextBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //WIP
            switch (e.KeyChar)
            {
                case (char)Keys.Escape:
                    buttonCancel.PerformClick();
                    break;
                case (char)Keys.Enter:
                    buttonAdd.PerformClick();
                    break;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void UsualEscAndEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case (char)Keys.Escape:
                    buttonCancel.PerformClick();
                    break;
                case (char)Keys.Enter:
                    buttonAdd.PerformClick();
                    break;
            }
        }
        private void AddAndCancelKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Escape:
                    buttonCancel.PerformClick();
                    break;
            }
        }

        #endregion

        #region Button Click Events
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                ReturnResult();
            }
            else
            {
                ShowError();
            }
        }

        private void ButtonDate_Click(object sender, EventArgs e)
        {
            ChangeSize();
        } 
        #endregion

        #region Size Changing
        private void ChangeSize()
        {
            if (Size == collapsedSize)
            {
                Expand();
            }
            else
            {
                Collapse();
            }
        }

        private void Collapse()
        {
            Size = collapsedSize;
            monthCalendar.Hide();
        }

        private void Expand()
        {
            Size = expandedSize;
            monthCalendar.Show();
        }
        #endregion

        #region Errors
        private void ShowError()
        {
            CreateErrorMessage();
            MessageBox.Show(errorMessage);
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
    }
}
