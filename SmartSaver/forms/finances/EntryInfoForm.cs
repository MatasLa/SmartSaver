using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataManager;
using Utilities;

namespace Forms
{
    public partial class EntryInfoForm : Form
    {
        private DataEntry _dataEntry;
        public DataEntry DataEntry
        {
            get
            {
                return _dataEntry;
            }
            set
            {
                _dataEntry = value;
                Init();
            }
        }

        Handler handler;

        public EntryInfoForm(DataEntry dataEntry, Handler handler)
        {
            InitializeComponent();
            DataEntry = dataEntry;
            this.handler = handler;
            Init();

        }

        private void Init()
        {
            labelTitle.Text = DataEntry.Title;
            labelValue.Text = NumberFormatter.FormatCurrency(DataEntry.Amount);
            labelDate.Text = DataEntry.Date.ToString("d");
            labelRecurring.Text = DataEntry.IsMonthly.ToString();
        }
    }
}
