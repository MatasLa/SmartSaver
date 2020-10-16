using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ePiggy.Auth;
using ePiggy.Utilities;

namespace ePiggy.Forms
{
    public partial class FormLogIn : Form

    {
        public Handler DataHandler { get; }
        /*Add when new logo exists
        private static readonly string resourceDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources";
        private Image logo = Image.FromFile(resourceDirectory + @"\logo inverted.png");*/

        private static readonly string ResourceDirectoryQuotes = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources\textData\quotes.txt";
        public FormLogIn(Handler dataHandler)
        {
            InitializeComponent();
            DataHandler = dataHandler;
            SetQuote();
            errorMessage.Text = "";
           // logoPic.Image = logo;
        }

        private void SetQuote()
        {
            try
            {
                var lines = File.ReadAllLines(ResourceDirectoryQuotes);
                var amount = lines.Length;
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
            FormUtilities.ChangeForm(this, new FormRegister(DataHandler));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = emailInput.Text;
            var pass = passwordInput.Text;
            if (UserAuth.Login(email, pass))
            {
                FormUtilities.ChangeForm(this, new FormMain(DataHandler));
            }
            else
            {
                errorMessage.Text = @"Wrong e-mail or password!";
            }
        }

    }
    
}
