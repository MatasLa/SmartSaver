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
        private static readonly string resourceDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources";
        private Image selectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonSelected.png");
        private Image unSelectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonUnselected.png");

        public FormRegister(Handler dataHandler)
        {
            InitializeComponent();
            DataHandler = dataHandler;
            backToLoginButton.Image = unSelectedLessButton;
            errorMessage.Text = "";
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
            if (pass.Length < 8)
            {
                errorMessage.Text = "Password must be atleast 8 characters long";
                return;
            }
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
                errorMessage.Text = "Passwords did not match!";
            }

        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn login = new FormLogIn(DataHandler);
            login.ShowDialog();
            this.Close();
        }

        private void backToLoginButton_MouseEnter(object sender, EventArgs e)
        {
            backToLoginButton.Image = selectedLessButton;
        }

        private void BackToLoginButton_MouseLeave(object sender, EventArgs e)
        {
            backToLoginButton.Image = unSelectedLessButton;
        }

        
    }

        
}
