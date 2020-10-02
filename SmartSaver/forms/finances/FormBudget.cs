using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using Forms;
using Utilities;
using System.Drawing.Text;

namespace FormBudget
{
    //reikes padaryti
    public partial class FormBudget : Form
    {
        // This will get the current PROJECT directory
        private static readonly string resourceDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources";
        private Image selectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonSelected.png");
        private Image selectedMorebutton = Image.FromFile(resourceDirectory + @"\moreButtonSelected.png");
        private Image unSelectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonUnselected.png");
        private Image unSelectedMoreButton = Image.FromFile(resourceDirectory + @"\moreButtonUnselected.png");
        private Handler Handler { get; }
        private Data data;
        private DataTableConverter dataTableConverter;
        private DataFilter dataFilter;

        private DataTable expenseTable;
        public FormBudget(Handler handler)
        {
            InitializeComponent();
            Handler = handler;
            data = handler.Data;
            dataTableConverter = handler.DataTableConverter;
            dataFilter = handler.DataFilter;
            Init();
        }
        public void Init()
        {
            UpdateDisplay();
        }

        #region Experimental
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView.SelectedRows[0].Cells["ID"].Value.ToString());
        }
        #endregion

        #region Button Logic

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            Handler.Time = TimeManager.MoveToNextYear(Handler.Time);
            UpdateDisplay();
        }

        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            Handler.Time = TimeManager.MoveToPreviousYear(Handler.Time);
            UpdateDisplay();
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            Handler.Time = TimeManager.MoveToNextMonth(Handler.Time);
            UpdateDisplay();
        }

        private void ButtonPreviousMonth_Click(object sender, EventArgs e)
        {
            Handler.Time = TimeManager.MoveToPreviousMonth(Handler.Time);
            UpdateDisplay();
        }

        private void ButtonAddIncome_Click(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();
            if (new AddEntryForm(dataEntry, "Add Income").ShowDialog() == DialogResult.OK)
            {
                data.AddIncome(dataEntry.Amount, dataEntry.Title, Handler.Time, dataEntry.IsMonthly);
                Handler.DataJSON.WriteIncomeToFile();
                DisplayTable();
                DisplayBalance();
            }
        }

        private void ButtonAddExpense_Click(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();
            if(new AddEntryForm(dataEntry, "Add Expense").ShowDialog() == DialogResult.OK)
            {
                data.AddExpense(dataEntry.Amount, dataEntry.Title, Handler.Time, dataEntry.IsMonthly);
                Handler.DataJSON.WriteExpensesToFile();
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
            expenseTable = dataTableConverter.CustomTable(dataFilter.GetExpensesByDate(Handler.Time));
            dataGridView.DataSource = expenseTable;
            dataGridView.Columns[0].Visible = false;
        }

        private void DisplayBalance()
        {
            var balance = dataFilter.GetBalanceByDate(Handler.Time);
            textBoxBalance.BackColor = textBoxBalance.BackColor;
            if (dataFilter.IsBalancePositiveByDate(Handler.Time))
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
            textBoxCurrentMonth.Text = Handler.Time.ToString("MMM");
            textBoxCurrentYear.Text = Handler.Time.Year.ToString();
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
