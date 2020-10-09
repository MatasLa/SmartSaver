using System;
using System.Data;
using System.Drawing;
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
        private bool _tableLoaded = false;

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
            RePaintDisplay();
        }

        private void labelMonth_MouseClick(object sender, MouseEventArgs e)
        {

            dataGridView.ClearSelection();
        }

        #region Entry handling

        private bool GetDataEntryFromSelectedRow(out DataEntry dataEntry)
        {
            dataEntry = new DataEntry();
            if (dataGridView.SelectedRows.Count == 0) return false;
            var value = dataGridView.SelectedRows[0].Cells["ID"].Value;
            if (value is DBNull)
            {
                return false;
            }

            var id = (int)value;

            return _data.GetDataEntryById(id, out dataEntry, EntryType);
        }

        private void GetSelectedDataEntries()
        {
            if (_tableLoaded)
            {
                //MessageBox.Show(dataGridView.SelectedRows.Count.ToString());
            }
            //MessageBox.Show(dataGridView.SelectedRows.Count.ToString());
            if (dataGridView.SelectedRows.Count > 1)
            {
                //MessageBox.Show(dataGridView.SelectedRows.Count.ToString());
            }
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

        #region Event Handlers

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView.ClearSelection();
            FormChanger.CloseChildForm(ref _activeForm);
        }

        private void dataGridView_MouseCaptureChanged(object sender, EventArgs e)
        {
            //dataGridView.
            //GetSelectedDataEntries();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //GetSelectedDataEntries();
            if (!GetDataEntryFromSelectedRow(out var dataEntry))
            {
                return;
            }

            FormChanger.OpenChildForm(ref _activeForm, new EntryInfoForm(dataEntry, _handler), splitContainer.Panel2);

        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //dataGridView.CurrentCell.Selected = false;
            //if (dataGridView.CurrentCell is null) return;
            //dataGridView.CurrentCell.Selected = false;
            //dataGridView.ClearSelection();
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.D) return;
            if (!GetDataEntryFromSelectedRow(out var dataEntry))
            {
                AddEntry();
                return;
            }

            DeleteEntry(dataEntry);
            RePaintDisplay();
        }

        private void PanelTop_Click(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            FormChanger.CloseChildForm(ref _activeForm);
        }

        private void ButtonAddEntry_Click(object sender, EventArgs e)
        {
            AddEntry();
            RePaintDisplay();
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!GetDataEntryFromSelectedRow(out var dataEntry))
            {
                AddEntry();
                return;
            }

            EditEntry(dataEntry);
            RePaintDisplay();
        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (!GetDataEntryFromSelectedRow(out var dataEntry))
            //{
            //    return;
            //}

            //FormChanger.OpenChildForm(ref _activeForm, new EntryInfoForm(dataEntry, _handler), splitContainer.Panel2);
        }


        #endregion

        #region Data Display

        private void RePaintDisplay()
        {
            DisplayDate();
            DisplayTable();
            DisplayBalance();
            DisplayTotalBalance();
            FormChanger.CloseChildForm(ref _activeForm);
        }

        private void DisplayTable()
        {
            _tableLoaded = false;
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

            //dataGridView.ClearSelection();
            //dataGridView.CurrentCell.Selected = false;
            //dataGridView.CurrentCell = null;
            _tableLoaded = true;
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

        private void SetTitles()
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
            RePaintDisplay();
        }

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            _handler.Time = TimeManager.MoveToNextYear(_handler.Time);
            RePaintDisplay();
        }

        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            _handler.Time = TimeManager.MoveToPreviousYear(_handler.Time);
            RePaintDisplay();
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            _handler.Time = TimeManager.MoveToNextMonth(_handler.Time);
            RePaintDisplay();
        }

        private void ButtonPreviousMonth_Click(object sender, EventArgs e)
        {
            _handler.Time = TimeManager.MoveToPreviousMonth(_handler.Time);
            RePaintDisplay();
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
