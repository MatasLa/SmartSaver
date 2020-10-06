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
using System.Linq;

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

        private Form activeForm;

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
                Init();
            } 
        }

        public FinanceForm(Handler handler, EntryType entryType)
        {
            InitializeComponent();
            this.handler = handler;
            data = handler.Data;
            dataTableConverter = handler.DataTableConverter;
            dataFilter = handler.DataFilter;
            _entryType = entryType;
            Init();
        }

        private void Init()
        {
            SetTitles();
            UpdateDisplay();
            FormChanger.CloseChildForm(ref activeForm);
            Select();
        }

        #region Entry handling

        private bool GetDataEntryFromSelectedRow(out DataEntry dataEntry)
        {
            var value = dataGridView.SelectedRows[0].Cells["ID"].Value;
            if (value is DBNull)
            {
                dataEntry = new DataEntry();
                return false;
            }

            int id = (int)value;

            switch (EntryType)
            {
                case EntryType.Income:
                    dataEntry = data.Income.FirstOrDefault(x => x.ID == id);
                    break;
                case EntryType.Expense:
                default:
                    dataEntry = data.Expenses.FirstOrDefault(x => x.ID == id);
                    break;
            }
            return true;

        }

        private void EditEntry(DataEntry dataEntry)
        {
            if (new EntryForm(dataEntry, EntryType, handler).ShowDialog() == DialogResult.OK)
            {
                switch (EntryType)
                {
                    case EntryType.Income:
                        data.EditIncomeItem(dataEntry.ID, dataEntry.Title, dataEntry.Amount, dataEntry.Date, dataEntry.IsMonthly);
                        handler.DataJSON.WriteIncomeToFile();
                        break;
                    case EntryType.Expense:
                        data.EditExpensesItem(dataEntry.ID, dataEntry.Title, dataEntry.Amount, dataEntry.Date, dataEntry.IsMonthly);
                        handler.DataJSON.WriteExpensesToFile();
                        break;
                }
                UpdateDisplay();
            }
        }

        private void AddEntry()
        {
            DataEntry dataEntry = new DataEntry();
            if (new EntryForm(dataEntry, EntryType, handler).ShowDialog() == DialogResult.OK)
            {
                switch (EntryType)
                {
                    case EntryType.Income:
                        data.AddIncome(dataEntry.Amount, dataEntry.Title, dataEntry.Date, dataEntry.IsMonthly);
                        handler.DataJSON.WriteIncomeToFile();
                        break;
                    case EntryType.Expense:
                        data.AddExpense(dataEntry.Amount, dataEntry.Title, dataEntry.Date, dataEntry.IsMonthly);
                        handler.DataJSON.WriteExpensesToFile();
                        break;
                }
                UpdateDisplay();
            }
        }

        #endregion

        #region Mouse Click Handling

        private void PanelTop_Click(object sender, EventArgs e)
        {
            FormChanger.CloseChildForm(ref activeForm);
        }

        private void ButtonAddEntry_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataEntry dataEntry;

            if (!GetDataEntryFromSelectedRow(out dataEntry))
            {
                AddEntry();
                return;
            }

            EditEntry(dataEntry);
        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataEntry dataEntry;

            if (!GetDataEntryFromSelectedRow(out dataEntry))
            {
                return;
            }

            FormChanger.OpenChildForm(ref activeForm, new EntryInfoForm(dataEntry, handler), splitContainer.Panel2);
        }


        #endregion

        #region Data Display

        public void UpdateDisplay()
        {
            DisplayDate();
            DisplayTable();
            DisplayBalance();
            DisplayTotalBalance();
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

            dataGridView.Columns["Amount"].DefaultCellStyle.Format = "c";
            dataGridView.Columns["Date"].DefaultCellStyle.Format = "dd (dddd)";
        }
    
        private void DisplayBalance()
        {
            var balance = dataFilter.GetBalanceByDate(handler.Time);
            labelBalance.BackColor = labelBalance.BackColor;
            if (balance >= Decimal.Zero)
            {
                labelBalance.ForeColor = Color.Green;
            }
            else
            {
                labelBalance.ForeColor = Color.Red;
            }
            labelBalance.Text = NumberFormatter.FormatCurrency(balance);
        }

        private void DisplayTotalBalance()
        {
            var balance = handler.DataCalculations.CheckBalance();
            labelTotalBalanceValue.BackColor = labelBalance.BackColor;
            if (balance >= Decimal.Zero)
            {
                labelTotalBalanceValue.ForeColor = Color.Green;
            }
            else
            {
                labelTotalBalanceValue.ForeColor = Color.Red;
            }
            labelTotalBalanceValue.Text = NumberFormatter.FormatCurrency(balance);
        }

        private void DisplayDate()
        {
            labelMonth.Text = handler.Time.ToString("MMM");
            labelYear.Text = handler.Time.Year.ToString();
        }

        public void SetTitles()
        {
            switch (_entryType)
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
        #endregion

        #region Time Button Click Handling

        private void LabelYear_Click(object sender, EventArgs e)
        {
            handler.Time = DateTime.Now;
            UpdateDisplay();
        }

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
