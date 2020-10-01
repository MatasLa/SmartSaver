using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var email = emailInput.Text;
            var pass = passwordInput1.Text;
            var passConfirm = passwordInput2.Text;
            if (pass.Equals(passConfirm))
            {
                UserAuth.Registration(email: email, pass: pass);
                this.Hide();
                FormMain main = new FormMain(DataHandler);
                main.ShowDialog();
                this.Close();
            }
            else
            {
                //print that pass did not match
            }
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn login = new FormLogIn(DataHandler);
            login.ShowDialog();
            this.Close();
        }
    }
}
