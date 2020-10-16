using System;
using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances.goals
{
    public partial class GoalDialogForm : Form
    {
        private readonly Handler _handler;
        private readonly Goal _goal;


        private string _errorMessage;
        private const string BadTitleErrorMessage = "Please enter a title";
        private const string BadNumberErrorMessage = "Please enter a valid number";

        public GoalDialogForm(Goal goal, Handler handler)
        {
            InitializeComponent();
            _goal = goal ?? throw new Exception("Given null goal");
            _handler = handler;
            Select();
        }


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

        #endregion

        #region Input Handling

        private void ReturnResult()
        {
            TakeInput();

            DialogResult = DialogResult.OK;
        }

        private bool IsInputValid()
        {
            if (textBoxValue.Text.Length == 0)
            {
                return InputValidator.IsNameValid(textBoxTitle.Text);
            }
            return InputValidator.IsCurrencyInputValid(textBoxValue.Text) && InputValidator.IsNameValid(textBoxTitle.Text);
        }

        private void TakeInput()
        {
            _goal.Title = textBoxTitle.Text;

            if (textBoxValue.Text.Length == 0) return;
            
                _goal.Price = decimal.Round(decimal.Parse(textBoxValue.Text), 2);


            //_goal.Date = monthCalendar.SelectionStart;
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
            switch (e.KeyChar)
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
