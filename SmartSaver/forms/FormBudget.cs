using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using SmartSaver.forms.forms;

namespace SmartSaver.forms
{
    //reikes padaryti
    public partial class FormBudget : Form
    {
        private DateTime DisplayedTime { get; set; } = DateTime.Now;
        // This will get the current PROJECT directory
        private static readonly string resourceDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources";
        private Image selectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonSelected.png");
        private Image selectedMorebutton = Image.FromFile(resourceDirectory + @"\moreButtonSelected.png");
        private Image unSelectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonUnselected.png");
        private Image unSelectedMoreButton = Image.FromFile(resourceDirectory + @"\moreButtonUnselected.png");

        private Data Data { get; } = new Data();
        private DataTable incomeTable;
        private DataTableConverter dataTableConverter;
        private DataFilter dataFilter;
        public FormBudget()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            Data.ReadIncomeFromFile();
            dataTableConverter = new DataTableConverter(Data);
            dataFilter = new DataFilter(Data);
            UpdateDisplay();

        }

        public void DisplayTable()
        {

            incomeTable = dataTableConverter.CustomTable(dataFilter.GetIncomeByDate(DisplayedTime));
            dataGridView.DataSource = incomeTable;

            dataGridView.Columns[0].Visible = false;
;
            dataGridView1.DataSource = incomeTable;

            dataGridView1.Columns[0].Visible = false;
            //MessageBox.Show(dataFilter.GetIncomeByDate(DisplayedTime).Count.ToString());
        }

        private void TestClick(object sender, EventArgs e)
        {

        }

        public void UpdateDisplay()
        {
            DisplayDate();
            DisplayTable();
            DisplayBalance();
        }

        private void DisplayBalance()
        {
            var balance = Data.CheckBalance();
            Color color;
            if(Data.IsBalancePositive())
            {
                color = Color.Green;
            } else
            {
                color = Color.Red;
            }

        }

        private void DisplayDate()
        {
            textBoxCurrentMonth.Text = DisplayedTime.ToString("MMM");
            textBoxCurrentYear.Text = DisplayedTime.Year.ToString();
        }

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            this.DisplayedTime = TimeManager.MoveToNextYear(DisplayedTime);
            UpdateDisplay();
        }

        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            this.DisplayedTime = TimeManager.MoveToPreviousYear(DisplayedTime);
            UpdateDisplay();
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            this.DisplayedTime = TimeManager.MoveToNextMonth(DisplayedTime);
            UpdateDisplay();
        }

        private void ButtonPreviousMonth_Click(object sender, EventArgs e)
        {
            this.DisplayedTime = TimeManager.MoveToPreviousMonth(DisplayedTime);
            UpdateDisplay();
        }

        #region button logic

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

        private void ButtonAddIncome_Click(object sender, EventArgs e)
        {
            using(FormAddIncome formAddIncome = new FormAddIncome(Data, DisplayedTime))
            {
                if(formAddIncome.ShowDialog() == DialogResult.OK)
                {
                    DisplayTable();
                }
            }

        }

        private void ButtonAddExpense_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            using (FormAddIncome formAddIncome = new FormAddIncome(Data, DisplayedTime))
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
    }
}
