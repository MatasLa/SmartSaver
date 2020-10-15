using System;
using System.Windows.Forms;
using ePiggy.backend.auth;
using ePiggy.utilities;

namespace ePiggy.forms
{
    public partial class FormRegister : Form
    {
        public Handler DataHandler { get; }


        public FormRegister(Handler dataHandler)
        {
            InitializeComponent();
            DataHandler = dataHandler;
            errorMessage.Text = "";
        }

        
        private void backToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtilities.ChangeForm(this, new FormLogIn(DataHandler));
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var email = emailInput.Text;
            var pass = passwordInput1.Text;
            var passConfirm = passwordInput2.Text;
            if (!InputValidator.RegisterValidation(this, email, pass, passConfirm)) return;
            UserAuth.Registration(email: email, pass: pass);
            FormUtilities.ChangeForm(this, new FormMain(DataHandler));
        }

        public void ChangeErrorText(int id)
        {
            string text;
            switch (id)
            {
                case 0:
                    text = "Provided e-mail is not valid!";
                    break;
                case 1:
                    text = "Password must be at least 8 characters long";
                    break;
                case 2:
                    text = "Passwords did not match!";
                    break;
                case 3:
                    text = "Password must contain: 1 Uppercase letter,\n1 digit and 1 symbol!";
                    break;
                default:
                    text = "";
                    break;
            }
            errorMessage.Text = text;
        }
    }

        
}
