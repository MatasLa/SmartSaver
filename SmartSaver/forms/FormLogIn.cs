using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ePiggy.Authentication;
using ePiggy.forms;
using ePiggy.forms.customforms;
using ePiggy.Utilities;

namespace ePiggy.Forms
{
    public partial class FormLogIn : Form

    {
        public Handler DataHandler { get; }

        private static readonly string ResourceDirectoryQuotes = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources\textData\quotes.txt";
        public FormLogIn(Handler dataHandler)
        {
            InitializeComponent();
            DataHandler = dataHandler;
            SetQuote();
            errorMessage.Text = "";
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

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }


        private void noAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtilities.ChangeForm(this, new FormRegister(DataHandler));
        }


        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var email = Prompt.ShowDialog("Enter your email:", "Forgot password");
            if (string.IsNullOrEmpty(email)) return;
            var sentCode = UserAuth.SendCode(email);
            try
            {
                var receivedCode = int.Parse(Prompt.ShowDialog("Enter receiver code:", "Forgot password"));
                if (receivedCode == sentCode)
                {
                    FormUtilities.ChangeForm(this, new FormChangePass(email, DataHandler));
                }
                errorMessage.Text = @"Wrong confirmation code!";
            }
            catch (Exception ex)
            {
                errorMessage.Text = @"Wrong confirmation code!";
                ExceptionHandler.Log(ex.ToString());
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
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
