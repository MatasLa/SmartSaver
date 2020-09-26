using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;

namespace SmartSaver.forms.forms
{
    public partial class FormAddIncome : Form
    {
        private Data data;
        private DateTime dateTime;

        public FormAddIncome(Data data, DateTime dateTime)
        {
            this.data = data;
            this.dateTime = dateTime;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.AddIncome(Double.Parse(textBoxValue.Text), textBoxTitle.Text, dateTime, checkBoxMonthly.Checked);
            data.WriteIncomeToFile();
        }

        private void TextBoxValue_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxValue.Text, "  ^ [0-9]"))
            {
                textBoxValue.Text = "";
            }
        }
        private void TextBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
