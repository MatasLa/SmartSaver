using System.Collections.Generic;

namespace ePiggy.DataManagement
{
    public class ImportanceGroup
    {
        public string Importance { get; set; }
        public List<DataEntry> Entries { get; set; }
    }
}
