using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DataManager;

namespace SmartSaver.forms
{
     public class DataForm : Form
    {
        public DataHandler DataHandler { get;}
        protected Data data;
        protected DataTableConverter dataTableConverter;
        protected DataFilter dataFilter;

        public DataForm(DataHandler dataHandler)
        {
            DataHandler = dataHandler;
            data = dataHandler.Data;
            dataTableConverter = dataHandler.DataTableConverter;
            dataFilter = dataHandler.DataFilter;
        }

        private DataForm()
        {
            
        }
    }
}
