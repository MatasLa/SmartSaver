using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DataManager;
using SmartSaver;

namespace Forms
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
            FormChanger.ChangeForm(this, new FormLogIn(DataHandler));
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var email = emailInput.Text;
            var pass = passwordInput1.Text;
            var passConfirm = passwordInput2.Text;
            if (!UserAuth.IsValidEmail(email))
            {
                errorMessage.Text = "Provided e-mail is not valid!";
                return;
            }
            int passCheck = UserAuth.IsValidPassword(pass, passConfirm);
            switch(passCheck){
                case 0:
                    UserAuth.Registration(email: email, pass: pass);
                    FormChanger.ChangeForm(this, new FormMain(DataHandler));
                    break;
                case 1:
                    errorMessage.Text = "Password must be atleast 8 characters long";
                    break;
                case 2:
                    errorMessage.Text = "Passwords did not match!";
                    break;
            }
        }
    }

        
}
