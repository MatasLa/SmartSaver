using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances
{
    public partial class EntryInfoForm : Form
    {
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

        private Handler _handler;

        public EntryInfoForm(DataEntry dataEntry, Handler handler)
        {
            InitializeComponent();
            DataEntry = dataEntry;
            _handler = handler;
            Init();

        }

        private void Init()
        {
            labelTitle.Text = DataEntry.Title;
            labelValue.Text = NumberFormatter.FormatCurrency(DataEntry.Amount);
            labelDate.Text = DataEntry.Date.ToString("d");
            labelRecurring.Text = DataEntry.IsMonthly.ToString();
        }

        private void ButtonEdit_Click(object sender, System.EventArgs e)
        {
            //WIP
            MessageBox.Show(DataEntry.ID.ToString());
        }
        private void ButtonDelete_Click(object sender, System.EventArgs e)
        {
            //WIP
            //MessageBox.Show(DataEntry.ID.ToString());
            _handler.Data.RemoveIncome(_dataEntry);
            this.Hide();
            this.Close();
        }
    }
}
