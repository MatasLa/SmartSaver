﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using SmartSaver.forms;

namespace FormIncome
{
    //reikes padaryti
    public partial class FormIncome : Form
    {
        // This will get the current PROJECT directory
        private static readonly string resourceDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources";
        private Image selectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonSelected.png");
        private Image selectedMorebutton = Image.FromFile(resourceDirectory + @"\moreButtonSelected.png");
        private Image unSelectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonUnselected.png");
        private Image unSelectedMoreButton = Image.FromFile(resourceDirectory + @"\moreButtonUnselected.png");
        private DataHandler DataHandler { get; }
        protected Data data;
        protected DataTableConverter dataTableConverter;
        protected DataFilter dataFilter;

        private DataTable incomeTable;

        public FormIncome(DataHandler dataHandler)
        {
            InitializeComponent();
            DataHandler = dataHandler;
            data = dataHandler.Data;
            dataTableConverter = dataHandler.DataTableConverter;
            dataFilter = dataHandler.DataFilter;
            Init();
        }

        public void Init()
        {
            UpdateDisplay();
        }

        #region Experimental
        private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            using (FormAddIncome formAddIncome = new FormAddIncome(data, DataHandler.Time))
            {
                if (formAddIncome.ShowDialog() == DialogResult.OK)
                {
                    DisplayTable();
                }
                DisplayTable();
            }

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView.SelectedRows[0].Cells["ID"].Value.ToString());
        }
        #endregion

        #region Button Logic

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            DataHandler.Time = TimeManager.MoveToNextYear(DataHandler.Time);
            UpdateDisplay();
        }


        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            DataHandler.Time = TimeManager.MoveToPreviousYear(DataHandler.Time);
            UpdateDisplay();
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            DataHandler.Time = TimeManager.MoveToNextMonth(DataHandler.Time);
            UpdateDisplay();
        }

        private void ButtonPreviousMonth_Click(object sender, EventArgs e)
        {
            DataHandler.Time = TimeManager.MoveToPreviousMonth(DataHandler.Time);
            UpdateDisplay();
        }


        private void ButtonAddIncome_Click(object sender, EventArgs e)
        {
            using (FormAddIncome formAddIncome = new FormAddIncome(data, DataHandler.Time))
            {
                if (formAddIncome.ShowDialog() == DialogResult.OK)
                {
                    DisplayTable();
                    DisplayBalance();
                }
            }

        }

        private void ButtonAddExpense_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Data Display
        public void UpdateDisplay()
        {
            DisplayDate();
            DisplayTable();
            DisplayBalance();
        }

        public void DisplayTable()
        {
            incomeTable = dataTableConverter.CustomTable(dataFilter.GetIncomeByDate(DataHandler.Time));
            dataGridView.DataSource = incomeTable;

            dataGridView.Columns[0].Visible = false;
        }

        private void DisplayBalance()
        {
            var balance = dataFilter.GetBalanceByDate(DataHandler.Time);
            textBoxBalance.BackColor = textBoxBalance.BackColor;
            if (data.IsBalancePositive())
            {
                textBoxBalance.ForeColor = Color.Green;
            }
            else
            {
                textBoxBalance.ForeColor = Color.Red;
            }
            textBoxBalance.Text = balance.ToString();
        }

        private void DisplayDate()
        {
            textBoxCurrentMonth.Text = DataHandler.Time.ToString("MMM");
            textBoxCurrentYear.Text = DataHandler.Time.Year.ToString();
            #endregion
        }
        #region Button Image Swapping

        private void buttonNextMonth_MouseEnter(object sender, EventArgs e)
        {
            buttonNextMonth.Image = selectedMorebutton;
        }

        private void ButtonNextMonth_MouseLeave(object sender, EventArgs e)
        {
            buttonNextMonth.Image = unSelectedMoreButton;
        }

        private void ButtonPreviousMonth_MouseEnter(object sender, EventArgs e)
        {
            buttonPreviousMonth.Image = selectedLessButton;
        }

        private void ButtonPreviousMonth_MouseLeave(object sender, EventArgs e)
        {
            buttonPreviousMonth.Image = unSelectedLessButton;
        }

        private void ButtonNextYear_MouseEnter(object sender, EventArgs e)
        {
            buttonNextYear.Image = selectedMorebutton;
        }

        private void ButtonNextYear_MouseLeave(object sender, EventArgs e)
        {
            buttonNextYear.Image = unSelectedMoreButton;
        }

        private void ButtonPreviousYear_MouseEnter(object sender, EventArgs e)
        {
            buttonPreviousYear.Image = selectedLessButton;
        }

        private void ButtonPreviousYear_MouseLeave(object sender, EventArgs e)
        {
            buttonPreviousYear.Image = unSelectedLessButton;
        }

        #endregion
    }
}
