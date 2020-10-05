﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DataManager;
using EPiggy;

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
            if (AuthValidator.RegisterValidation(form: this, email: email, pass: pass, passConfirm: passConfirm))
            {
                UserAuth.Registration(email: email, pass: pass);
                FormChanger.ChangeForm(this, new FormMain(DataHandler));
            }
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
                    text = "Password must be atleast 8 characters long";
                    break;
                case 2:
                    text = "Passwords did not match!";
                    break;
                default:
                    text = "";
                    break;
            }
            errorMessage.Text = text;
        }
    }

        
}
