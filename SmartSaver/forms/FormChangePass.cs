using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ePiggy.Authentication;
using ePiggy.Forms;
using ePiggy.Utilities;

namespace ePiggy.forms
{
    public partial class FormChangePass : Form
    {
        private readonly string _email;
        public Handler DataHandler { get; }
        public FormChangePass(string email, Handler dataHandler)
        {
            InitializeComponent();
            errorMessage.Text = "";
            _email = email;
            DataHandler = dataHandler;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var pass = password.Text;
            var passconfirm = confirmPassword.Text;
            if (!InputValidator.IsValidPasswordConfirm(this, pass, passconfirm)) return;
            UserAuth.ChangePassword(_email, pass);
            FormUtilities.ChangeForm(this, new FormLogIn(DataHandler));
        }

        public void ChangeErrorText(int id)
        {
            string text;
            switch (id)
            {
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
