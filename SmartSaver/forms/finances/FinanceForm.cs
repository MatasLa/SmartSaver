using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances
{
    public partial class FinanceForm : Form
    {
        private readonly Handler _handler;
        private readonly Data _data;
        private readonly DataTableConverter _dataTableConverter;
        private readonly DataFilter _dataFilter;
        private DataTable _dataTable;

        private readonly Image _selectedLessButton = new Bitmap(Properties.Resources.lessButtonSelected);
        private readonly Image _selectedMoreButton = new Bitmap(Properties.Resources.moreButtonSelected);
        private readonly Image _unSelectedLessButton = new Bitmap(Properties.Resources.lessButtonUnselected);
        private readonly Image _unSelectedMoreButton = new Bitmap(Properties.Resources.moreButtonUnselected);

        private const string IncomeFormTitle = "Income";
        private const string ExpensesFormTitle = "Expenses";
        private const string AddIncomeButtonTitle = "Add Income";
        private const string AddExpensesButtonTitle = "Add Expense";

        private Form _activeForm;

        private EntryType _entryType;
        public EntryType EntryType 
        { 
            get => _entryType;
            set 
            {
                _entryType = value;
                Init();
            } 
        }

        public FinanceForm(Handler handler, EntryType entryType)
        {
            InitializeComponent();
            _handler = handler;
            _data = handler.Data;
            _dataTableConverter = handler.DataTableConverter;
            _dataFilter = handler.DataFilter;
            _entryType = entryType;
            Init();
        }

        private void Init()
        {
            SetTitles();
            UpdateDisplay();
            FormChanger.CloseChildForm(ref _activeForm);
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

            var id = (int)value;

            dataEntry = EntryType switch
            {
                EntryType.Income => _data.Income.FirstOrDefault(x => x.ID == id),
                EntryType.Expense => _data.Expenses.FirstOrDefault(x => x.ID == id),
                _ => throw new ArgumentOutOfRangeException()
            };

            return true;

        }

        private void DeleteEntry(DataEntry dataEntry)
        {
            switch (EntryType)
            {
                case EntryType.Income:
                    _data.RemoveIncome(dataEntry.ID);
                    //_handler.DataJSON.WriteIncomeToFile();
                    break;
                case EntryType.Expense:
                    _data.RemoveExpense(dataEntry.ID);
                    //_handler.DataJSON.WriteExpensesToFile();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void EditEntry(DataEntry dataEntry)
        {
            if (new EntryForm(dataEntry, EntryType, _handler).ShowDialog() != DialogResult.OK) return;
            switch (EntryType)
            {
                case EntryType.Income:
                    _data.EditIncomeItem(dataEntry.ID, dataEntry.Title, dataEntry.Amount, dataEntry.Date, dataEntry.IsMonthly, 1);
                    //_handler.DataJSON.WriteIncomeToFile();
                    break;
                case EntryType.Expense:
                    _data.EditExpensesItem(dataEntry.ID, dataEntry.Title, dataEntry.Amount, dataEntry.Date, dataEntry.IsMonthly, 1);
                    //_handler.DataJSON.WriteExpensesToFile();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void AddEntry()
        {
            var dataEntry = new DataEntry();
            if (new EntryForm(dataEntry, EntryType, _handler).ShowDialog() != DialogResult.OK) return;
            switch (EntryType)
            {
                case EntryType.Income:
                    _data.AddIncome(Handler.UserId, dataEntry.Amount, dataEntry.Title, dataEntry.Date, dataEntry.IsMonthly, 1);
                    //_handler.DataJSON.WriteIncomeToFile();
                    break;
                case EntryType.Expense:
                    _data.AddExpense(Handler.UserId, dataEntry.Amount, dataEntry.Title, dataEntry.Date, dataEntry.IsMonthly, 1);
                    //_handler.DataJSON.WriteExpensesToFile();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Mouse Click Handling

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.D) return;
            if (!GetDataEntryFromSelectedRow(out var dataEntry))
            {
                AddEntry();
                return;
            }

            DeleteEntry(dataEntry);
            UpdateDisplay();
        }

        private void PanelTop_Click(object sender, EventArgs e)
        {
            FormChanger.CloseChildForm(ref _activeForm);
        }

        private void ButtonAddEntry_Click(object sender, EventArgs e)
        {
            AddEntry();
            UpdateDisplay();
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!GetDataEntryFromSelectedRow(out var dataEntry))
            {
                AddEntry();
                return;
            }

            EditEntry(dataEntry);
            UpdateDisplay();
        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!GetDataEntryFromSelectedRow(out var dataEntry))
            {
                return;
            }

            FormChanger.OpenChildForm(ref _activeForm, new EntryInfoForm(dataEntry, _handler), splitContainer.Panel2);
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
            _dataTable = EntryType switch
            {
                EntryType.Income => _dataTableConverter.CustomTable(_dataFilter.GetIncomeByDate(_handler.Time)),
                EntryType.Expense => _dataTableConverter.CustomTable(_dataFilter.GetExpensesByDate(_handler.Time)),
                _ => throw new ArgumentOutOfRangeException()
            };
            dataGridView.DataSource = _dataTable;
            dataGridView.Columns["ID"].Visible = false;
            dataGridView.Columns["Importance"].Visible = false;

            dataGridView.Columns["Amount"].DefaultCellStyle.Format = "c";
            dataGridView.Columns["Date"].DefaultCellStyle.Format = "dd (dddd)";
        }
    
        private void DisplayBalance()
        {
            var balance = _dataFilter.GetBalanceByDate(_handler.Time);
            labelBalance.BackColor = labelBalance.BackColor;
            labelBalance.ForeColor = balance >= decimal.Zero ? Color.Green : Color.Red;
            labelBalance.Text = NumberFormatter.FormatCurrency(balance);
        }

        private void DisplayTotalBalance()
        {
            var balance = _handler.DataCalculations.CheckBalance();
            labelTotalBalanceValue.BackColor = labelBalance.BackColor;
            labelTotalBalanceValue.ForeColor = balance >= decimal.Zero ? Color.Green : Color.Red;
            labelTotalBalanceValue.Text = NumberFormatter.FormatCurrency(balance);
        }

        private void DisplayDate()
        {
            labelMonth.Text = _handler.Time.ToString("MMM");
            labelYear.Text = _handler.Time.Year.ToString();
        }

        public void SetTitles()
        {
            switch (_entryType)
            {
                case EntryType.Income:
                    Text = IncomeFormTitle;
                    buttonAddEntry.Text = AddIncomeButtonTitle;
                    break;
                case EntryType.Expense:
                    Text = ExpensesFormTitle;
                    buttonAddEntry.Text = AddExpensesButtonTitle;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region Time Button Click Handling

        private void LabelYear_Click(object sender, EventArgs e)
        {
            _handler.Time = DateTime.Now;
            UpdateDisplay();
        }

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            _handler.Time = TimeManager.MoveToNextYear(_handler.Time);
            UpdateDisplay();
        }

        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            _handler.Time = TimeManager.MoveToPreviousYear(_handler.Time);
            UpdateDisplay();
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            _handler.Time = TimeManager.MoveToNextMonth(_handler.Time);
            UpdateDisplay();
        }

        private void ButtonPreviousMonth_Click(object sender, EventArgs e)
        {
            _handler.Time = TimeManager.MoveToPreviousMonth(_handler.Time);
            UpdateDisplay();
        }
        #endregion

        #region Button Image Swapping

        private void buttonNextMonth_MouseEnter(object sender, EventArgs e)
        {
            buttonNextMonth.Image = _selectedMoreButton;
        }

        private void ButtonNextMonth_MouseLeave(object sender, EventArgs e)
        {
            buttonNextMonth.Image = _unSelectedMoreButton;
        }

        private void ButtonPreviousMonth_MouseEnter(object sender, EventArgs e)
        {
            buttonPreviousMonth.Image = _selectedLessButton;
        }

        private void ButtonPreviousMonth_MouseLeave(object sender, EventArgs e)
        {
            buttonPreviousMonth.Image = _unSelectedLessButton;
        }

        private void ButtonNextYear_MouseEnter(object sender, EventArgs e)
        {
            buttonNextYear.Image = _selectedMoreButton;
        }

        private void ButtonNextYear_MouseLeave(object sender, EventArgs e)
        {
            buttonNextYear.Image = _unSelectedMoreButton;
        }

        private void ButtonPreviousYear_MouseEnter(object sender, EventArgs e)
        {
            buttonPreviousYear.Image = _selectedLessButton;
        }

        private void ButtonPreviousYear_MouseLeave(object sender, EventArgs e)
        {
            buttonPreviousYear.Image = _unSelectedLessButton;
        }

        #endregion

    }
}
