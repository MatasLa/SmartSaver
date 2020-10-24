namespace ePiggy.DataManagement
{
    public class EntrySuggestion
    {
        public EntrySuggestion(DataEntry entry, decimal amount)
        {
            Entry = entry;
            Amount = amount;

        }

        public EntrySuggestion()
        {
            Amount = 0;
            Entry = new DataEntry();
        }

        public DataEntry Entry { get; set; }
        public decimal Amount { get; set; }
    }

}
