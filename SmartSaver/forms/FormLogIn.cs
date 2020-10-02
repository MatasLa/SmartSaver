using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DataManager;
using SmartSaver;

namespace Forms
{
    public partial class FormLogIn : Form

    {
        public Handler DataHandler { get; }
        /*Add when new logo exists
        private static readonly string resourceDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources";
        private Image logo = Image.FromFile(resourceDirectory + @"\logo inverted.png");*/
        public FormLogIn(Handler dataHandler)
        {
            InitializeComponent();
            DataHandler = dataHandler;
            SetQoute();
            errorMessage.Text = "";
           // logoPic.Image = logo;
        }

        private void SetQoute()
        {
            qouteText.Text = "“Money is a terrible master but an excellent servant.” —P.T.Barnum";
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }


       


        private void noAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister register = new FormRegister(DataHandler);
            register.ShowDialog();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = emailInput.Text;
            var pass = passwordInput.Text;
            if (UserAuth.Login(email, pass))
            {
                this.Hide();
                FormMain main = new FormMain(DataHandler);
                main.ShowDialog();
                this.Close();
            }
            else
            {
                errorMessage.Text = "Wrong e-mail or password!";
            }
        }

    }
    
}
