using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ePiggy.DataManagement;
using ePiggy.Utilities;

namespace ePiggy.Forms.Finances.Budget
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
        }

        #region Entry handling

        public bool AddEntryWithEntryForm(DataEntry entry)
        {
            if (!OpenEntryForm(entry, EntryForm.Type.Add)) return false;
            AddEntry(entry);
            return true;
        }

        public bool EditEntryWithEntryForm(DataEntry entry)
        {
            if (!OpenEntryForm(entry, EntryForm.Type.Edit)) return false;
            EditEntry(entry);
            return true;
        }

        private void AddEntry(DataEntry entry)
        {
            if (EntryType == EntryType.Income)
            {
                if (entry.IsMonthly)
                {
                    _data.AddMonthlyIncome(Handler.UserId, entry.Amount, entry.Title, entry.Date, entry.IsMonthly, 1);
                }
                else
                {
                    _data.AddIncome(Handler.UserId, entry.Amount, entry.Title, entry.Date, entry.IsMonthly, 1);
                }
            }
            else
            {
                if (entry.IsMonthly)
                {
                    _data.AddMonthlyExpense(Handler.UserId, entry.Amount, entry.Title, entry.Date, entry.IsMonthly, 1);
                }
                else
                {
                    _data.AddExpense(Handler.UserId, entry.Amount, entry.Title, entry.Date, entry.IsMonthly, 1);
                }
            }
        }

        private void EditEntry(DataEntry entry)
        {
            if (EntryType == EntryType.Income)
            {
                _data.EditIncomeItem(entry.Id, entry.Title, entry.Amount, entry.Date, entry.IsMonthly, 1);
            }
            else
            {
                _data.EditExpensesItem(entry.Id, entry.Title, entry.Amount, entry.Date, entry.IsMonthly, 1);
            }
        }

        private void DeleteEntry(DataEntry entry)
        {
            if (EntryType == EntryType.Income)
            {
                _data.RemoveIncome(entry.Id);
            }
            else
            {
                _data.RemoveExpense(entry.Id);
            }
        }

        private void DeleteEntries(List<DataEntry> entries)
        {
            if (EntryType == EntryType.Income)
            {
                _data.RemoveIncomes(entries);
            }
            else
            {
                _data.RemoveExpenses(entries);
            }
        }

        #endregion

        #region Table stuff

        private bool GetSelectedEntry(out DataEntry dataEntry)
        {
            dataEntry = new DataEntry();
            var value = dataGridView.SelectedRows[0].Cells["ID"].Value;
            if (value is DBNull) return false;
            var id = (int) value;
            return _data.GetDataEntryById(id, out dataEntry, EntryType);
        }

        private bool GetSelectedEntries(out List<DataEntry> entries)
        {
            entries = new List<DataEntry>();
            var idList = new List<int>();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                var value = row.Cells["ID"].Value;
                if (value is null) continue;
                idList.Add((int)value);
            }
            return _data.GetListOfDataEntriesById(idList, entries, EntryType);
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView.ClearSelection();
            CloseSideForm();
        }


        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (GetSelectedEntry(out var entry))
                {
                    OpenEntryInfoForm(entry);
                }
                else
                {
                    FormUtilities.OpenChildForm(ref _activeForm, new EntryForm(new DataEntry(), EntryType, _handler, EntryForm.Type.Add), splitContainer.Panel2);
                }
            } 
            else if (dataGridView.SelectedRows.Count > 1)
            {
                if (GetSelectedEntries(out var entries))
                {
                    OpenMultiEntryInfoForm(entries);
                }
            }
        }

        private int GetSelectedRowCount()
        {
            return dataGridView.SelectedRows.Count;
        }

        #endregion

        #region Side Form Changing

        public void CloseSideForm()
        {
            FormUtilities.CloseChildForm(ref _activeForm);
        }

        private void OpenMultiEntryInfoForm(List<DataEntry> entries)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new MultiEntryInfoForm(entries, _handler), splitContainer.Panel2);
        }

        public void OpenEntryInfoForm(DataEntry entry)
        {
            FormUtilities.OpenChildForm(ref _activeForm, new EntryInfoForm(entry, _handler, this), splitContainer.Panel2);
        }

        private bool OpenEntryForm(DataEntry entry, EntryForm.Type entryFormType)
        {
            return new EntryForm(entry, EntryType, _handler, entryFormType).ShowDialog() == DialogResult.OK;
        }

        #endregion

        #region Key Press Handling

        private void DataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.D) return;
            if (GetSelectedRowCount() == 1)
            {
                if (!GetSelectedEntry(out var entry)) return;
                DeleteEntry(entry);
            }
            else if (GetSelectedRowCount() > 1)
            {
                if (!GetSelectedEntries(out var entries)) return;
                DeleteEntries(entries);
            }
            UpdateDisplay();
        }

        #endregion

        #region Mouse Click Handling

        private void PanelTop_Click(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            FormUtilities.CloseChildForm(ref _activeForm);
        }

        private void ButtonAddEntry_Click(object sender, EventArgs e)
        {
            if (!AddEntryWithEntryForm(new DataEntry())) return;
            UpdateDisplay();
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

        private void DisplayTable()
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
            var balance = _dataFilter.GetBalance(_handler.Time);
            FormUtilities.DisplayCurrencyTextWithColor(labelBalance, balance);
        }

        private void DisplayTotalBalance()
        {
            var balance = _handler.DataFilter.GetBalance();
            FormUtilities.DisplayCurrencyTextWithColor(labelTotalBalanceValue, balance);
        }

        private void DisplayDate()
        {
            labelMonth.Text = _handler.Time.ToString("MMM");
            labelYear.Text = _handler.Time.Year.ToString();
        }

        private void SetTitles()
        {
            if (EntryType == EntryType.Income)
            {
                Text = IncomeFormTitle;
                buttonAddEntry.Text = AddIncomeButtonTitle;
            }
            else
            {
                Text = ExpensesFormTitle;
                buttonAddEntry.Text = AddExpensesButtonTitle;
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
