namespace ePiggy.DataManagement
{
    public class EntrySuggestion
    {
        public EntrySuggestion(DataEntry entry, decimal amount)
        {
            Entry = entry;
            Amount = amount;

        }

        public DataEntry Entry { get; set; }
        public decimal Amount { get; set; }
    }

}
