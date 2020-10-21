using System;
using System.Collections.Generic;
using System.Text;

namespace ePiggy.DataManagement
{
    public class ImportanceGroup
    {
        public string Importance{get; set; }
        public List<DataEntry> Entries { get; set; }
    }
}
