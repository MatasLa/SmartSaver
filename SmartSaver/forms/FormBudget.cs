using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;

namespace SmartSaver
{
    //reikes padaryti
    public partial class FormBudget : Form
    {
        private DateTime displayedTime = DateTime.Now;
        // This will get the current PROJECT directory
        private static readonly string resourceDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\resources";
        private Image selectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonSelected.png");
        private Image selectedMorebutton = Image.FromFile(resourceDirectory + @"\moreButtonSelected.png");
        private Image unSelectedLessButton = Image.FromFile(resourceDirectory + @"\lessButtonUnselected.png");
        private Image unSelectedMoreButton = Image.FromFile(resourceDirectory + @"\moreButtonUnselected.png");

        Data data = new Data();
        DataTable incomeTable;
        public FormBudget()
        {
            InitializeComponent();
            DisplayDate();
            init();
        }

        public void init()
        {
            data.ReadIncomeFromFile();
            DataTableConverter converter = new DataTableConverter(data);
            incomeTable = converter.incomeTable();
            dataGridView.DataSource = incomeTable;
        }

        private void TestClick(object sender, EventArgs e)
        {

        }

        private void DisplayDate()
        {
            textBoxCurrentMonth.Text = displayedTime.ToString("MMM");
            textBoxCurrentYear.Text = displayedTime.Year.ToString();
        }

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            this.displayedTime = TimeManager.MoveToNextYear(displayedTime);
            DisplayDate();
        }

        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            this.displayedTime = TimeManager.MoveToPreviousYear(displayedTime);
            DisplayDate();
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            this.displayedTime = TimeManager.MoveToNextMonth(displayedTime);
            DisplayDate();
        }

        private void ButtonPreviousMonth_Click(object sender, EventArgs e)
        {
            this.displayedTime = TimeManager.MoveToPreviousMonth(displayedTime);
            DisplayDate();
        }
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

    }
}
