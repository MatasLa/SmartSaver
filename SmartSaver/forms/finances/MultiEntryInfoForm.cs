using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances
{
    public partial class MultiEntryInfoForm : Form
    {

        private List<DataEntry> _entries;
        public List<DataEntry> Entries
        {
            get => _entries;
            set
            {
                _entries = value;
                Init();
            }
        }

        private readonly Handler _handler;

        public MultiEntryInfoForm(List<DataEntry> entries, Handler handler)
        {
            InitializeComponent();
            Entries = entries;
            _handler = handler;
            Init();

        }

        private void Init()
        {
            //WIP
            var value = Entries.Sum(dataEntry => dataEntry.Amount);
            labelTotalValue.Text = NumberFormatter.FormatCurrency(value) + Entries.Count.ToString();
            //labelTitle.Text = DataEntry.Title;
            //labelValueText.Text = NumberFormatter.FormatCurrency(DataEntry.Amount);
        }
    }
}
