﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances.budget
{
    
    public partial class EntryForm : Form
    {
        public enum Type
        {
            Add,
            Edit
        }

        private readonly Type _type;

        private readonly Handler _handler;
        private readonly DataEntry _dataEntry;
        private readonly EntryType _entryType;
        private readonly Size _collapsedSize;
        private readonly Size _expandedSize;

        private string _errorMessage;
        private const string BadTitleErrorMessage = "Please enter a title";
        private const string BadNumberErrorMessage = "Please enter a valid number";
        private const string AddIncomeTitle = "Add Income";
        private const string AddExpenseTitle = "Add Expense";
        private const string EditIncomeTitle = "Edit Income";
        private const string EditExpenseTitle = "Edit Expense";
        private const string AddButtonText = "Add";
        private const string EditButtonText = "Edit";

        public EntryForm(DataEntry dataEntry, EntryType entryType, Handler handler, Type type)
        {
            InitializeComponent();

            _expandedSize = Size;
            _collapsedSize = new Size(Size.Width, Size.Height - monthCalendar.Size.Height - 25);

            _dataEntry = dataEntry ?? throw new Exception("Given null data entry");
            _entryType = entryType;
            _handler = handler;
            _type = type;

            SetCalendarTime();
            SetUpAddOrEdit();
            Collapse();
            Select();
        }

        private void SetCalendarTime()
        {
            monthCalendar.SelectionStart = _handler.Time;
        }

        #region Title setup
        private void SetUpAddOrEdit()
        {
            if (_type == Type.Add)
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
            if (_entryType == EntryType.Income)
            {
                Text = AddIncomeTitle;
                buttonOK.Text = AddButtonText;
            }
            else
            {
                Text = AddExpenseTitle;
                buttonOK.Text = AddButtonText;
            }
        }

        private void SetUpEdit()
        {
            if (_entryType == EntryType.Income)
            {
                Text = EditIncomeTitle;
                buttonOK.Text = EditButtonText;
            }
            else
            {
                Text = EditExpenseTitle;
                buttonOK.Text = EditButtonText;
            }
            Text += @" """ + _dataEntry.Title + @"""";
            textBoxTitle.Text = _dataEntry.Title;
            textBoxValue.Text = _dataEntry.Amount.ToString(CultureInfo.CurrentCulture);
            checkBoxMonthly.Checked = _dataEntry.IsMonthly;
        }
        #endregion

        #region Input Handling

        private void ReturnResult()
        {
            TakeInput();

            _handler.Time = monthCalendar.SelectionStart;

            DialogResult = DialogResult.OK;
        }

        private bool IsInputValid()
        {
            return InputValidator.IsCurrencyInputValid(textBoxValue.Text) && InputValidator.IsNameValid(textBoxTitle.Text);
        }

        private void TakeInput()
        {
            _dataEntry.Amount = decimal.Round(decimal.Parse(textBoxValue.Text), 2);
            _dataEntry.Title = textBoxTitle.Text;
            _dataEntry.IsMonthly = checkBoxMonthly.Checked;
            _dataEntry.Date = monthCalendar.SelectionStart;
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
                    buttonOK.PerformClick();
                    break;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
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
                    buttonOK.PerformClick();
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
            if (Size == _collapsedSize)
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
            Size = _collapsedSize;
            monthCalendar.Hide();
        }

        private void Expand()
        {
            Size = _expandedSize;
            monthCalendar.Show();
        }

        #endregion

        #region Errors
        private void ShowError()
        {
            CreateErrorMessage();
            MessageBox.Show(_errorMessage);
        }

        private void CreateErrorMessage()
        {
            if (InputValidator.IsNameValid(textBoxTitle.Text))
            {
                _errorMessage = BadNumberErrorMessage;
            }
            else if (InputValidator.IsCurrencyInputValid(textBoxValue.Text))
            {
                _errorMessage = BadTitleErrorMessage;
            }
            else
            {
                _errorMessage = BadTitleErrorMessage + "\n" + BadNumberErrorMessage;
            }
        } 
        #endregion
    }
}