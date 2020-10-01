using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DataManager;

namespace Forms
{
     public class DataForm : Form
    {
        public Handler DataHandler { get;}
        protected Data data;
        protected DataTableConverter dataTableConverter;
        protected DataFilter dataFilter;

        public DataForm(Handler dataHandler)
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
