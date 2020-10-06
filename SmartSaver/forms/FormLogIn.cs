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

        private static readonly string resourceDirectoryQuotes = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources\textData\quotes.txt";
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
            int amount;
            try
            {
                string[] lines = File.ReadAllLines(resourceDirectoryQuotes);
                amount = lines.Length;
                var rand = new Random();
                quoteText.Text = lines[rand.Next(0, amount)];
            }
            catch(Exception e)
            {
                Debug.Write("\n" + e + "\n");
            }

            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }


       


        private void noAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChanger.ChangeForm(this, new FormRegister(DataHandler));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = emailInput.Text;
            var pass = passwordInput.Text;
            if (UserAuth.Login(email, pass))
            {
                FormChanger.ChangeForm(this, new FormMain(DataHandler));
            }
            else
            {
                errorMessage.Text = "Wrong e-mail or password!";
            }
        }

    }
    
}
