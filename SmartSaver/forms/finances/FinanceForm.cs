using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using Utilities;
using EPiggy;

namespace Forms
{
    public partial class FinanceForm : Form
    {
        private readonly Handler handler;
        private readonly Data data;
        private readonly DataTableConverter dataTableConverter;
        private readonly DataFilter dataFilter;
        private DataTable dataTable;

        private readonly Image selectedLessButton = new Bitmap(ePiggy.Properties.Resources.lessButtonSelected);
        private readonly Image selectedMorebutton = new Bitmap(ePiggy.Properties.Resources.moreButtonSelected);
        private readonly Image unSelectedLessButton = new Bitmap(ePiggy.Properties.Resources.lessButtonUnselected);
        private readonly Image unSelectedMoreButton = new Bitmap(ePiggy.Properties.Resources.moreButtonUnselected);

        private readonly string incomeFormTitle = "Income";
        private readonly string expensesFormTitle = "Expenses";
        private readonly string addIncomeButtonTitle = "Add Income";
        private readonly string addExpensesButtonTitle = "Add Expense";

        private EntryType _entryType;
        public EntryType EntryType 
        { 
            get 
            {
                return _entryType;
            } 
            set 
            {
                _entryType = value;
                UpdateDisplay();
            } 
        }

        public FinanceForm(Handler handler, EntryType entryType)
        {
            InitializeComponent();
            this.handler = handler;
            data = handler.Data;
            dataTableConverter = handler.DataTableConverter;
            dataFilter = handler.DataFilter;
            this._entryType = entryType;
            Init();
        }

        private void Init()
        {
            SetTitles();
            UpdateDisplay();
        }

        public void SetTitles()
        {
            switch(_entryType)
            {
                case EntryType.Income:
                    this.Text = incomeFormTitle;
                    buttonAddEntry.Text = addIncomeButtonTitle;
                    break;
                case EntryType.Expense:
                    this.Text = expensesFormTitle;
                    buttonAddEntry.Text = addExpensesButtonTitle;
                    break;
            }
        }


        #region Experimental

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView.SelectedRows[0].Cells["ID"].Value.ToString());
        }
        #endregion

        #region Button Logic


        private void ButtonAddEntry_Click(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();
            if (new AddEntryForm(dataEntry, this._entryType).ShowDialog() == DialogResult.OK)
            {
                switch (_entryType)
                {
                    case EntryType.Income:
                        data.AddIncome(dataEntry.Amount, dataEntry.Title, handler.Time, dataEntry.IsMonthly);
                        handler.DataJSON.WriteIncomeToFile();
                        break;
                    case EntryType.Expense:
                        data.AddExpense(dataEntry.Amount, dataEntry.Title, handler.Time, dataEntry.IsMonthly);
                        handler.DataJSON.WriteExpensesToFile();
                        break;
                }
                DisplayTable();
                DisplayBalance();
            }
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
            switch(EntryType)
            {
                case EntryType.Income:
                    dataTable = dataTableConverter.CustomTable(dataFilter.GetIncomeByDate(handler.Time));
                    break;
                case EntryType.Expense:
                    dataTable = dataTableConverter.CustomTable(dataFilter.GetExpensesByDate(handler.Time));
                    break;
            }
            dataGridView.DataSource = dataTable;
            dataGridView.Columns[0].Visible = false;
        }
    
        private void DisplayBalance()
        {
            var balance = Math.Round(dataFilter.GetBalanceByDate(handler.Time), 2);
            textBoxBalance.BackColor = textBoxBalance.BackColor;
            if (dataFilter.IsBalancePositiveByDate(handler.Time))
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
            textBoxCurrentMonth.Text = handler.Time.ToString("MMM");
            textBoxCurrentYear.Text = handler.Time.Year.ToString();
        }
        #endregion

        #region Time Button Logic
        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            handler.Time = TimeManager.MoveToNextYear(handler.Time);
            UpdateDisplay();
        }

        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            handler.Time = TimeManager.MoveToPreviousYear(handler.Time);
            UpdateDisplay();
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            handler.Time = TimeManager.MoveToNextMonth(handler.Time);
            UpdateDisplay();
        }

        private void ButtonPreviousMonth_Click(object sender, EventArgs e)
        {
            handler.Time = TimeManager.MoveToPreviousMonth(handler.Time);
            UpdateDisplay();
        }
        #endregion

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
