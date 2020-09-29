using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SmartSaver.forms
{
    public partial class FormStart : Form
    {
        Thread th;
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new FormMain());
        }
    }
}
