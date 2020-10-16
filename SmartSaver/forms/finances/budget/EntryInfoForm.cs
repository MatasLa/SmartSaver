using System.Windows.Forms;
using ePiggy.DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances.budget
{
    public partial class EntryInfoForm : Form
    {
        public enum Type
        {
            Blank,
            Filled
        }


        private DataEntry _dataEntry;
        public DataEntry DataEntry
        {
            get => _dataEntry;
            set
            {
                _dataEntry = value;
                Init();
            }
        }

        private readonly Handler _handler;
        private readonly FinanceForm _parentForm;

        public EntryInfoForm(DataEntry dataEntry, Handler handler, FinanceForm financeForm)
        {
            InitializeComponent();
            DataEntry = dataEntry;
            _handler = handler;
            _parentForm = financeForm;
            Init();

        }

        private void Init()
        {
            labelTitle.Text = DataEntry.Title;
            labelValue.Text = NumberFormatter.FormatCurrency(DataEntry.Amount);
            labelDate.Text = DataEntry.Date.ToString("d");
            labelRecurring.Text = DataEntry.IsMonthly.ToString();
            labelImportance.Text = DataEntry.Importance.ToString();
        }

        private void ButtonEdit_Click(object sender, System.EventArgs e)
        {
            if(!_parentForm.EditEntryWithEntryForm(DataEntry)) return;
            _parentForm.UpdateDisplay();
            _parentForm.OpenEntryInfoForm(DataEntry);
        }

        private void ButtonDelete_Click(object sender, System.EventArgs e)
        {
            _handler.Data.RemoveIncome(_dataEntry);
            _parentForm.UpdateDisplay();
        }

    }
}
