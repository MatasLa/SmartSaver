namespace ePiggy.DataManagement
{
    public class OfferData
    {
        public OfferData(DataEntry entry, decimal amount)
        {
            Entry = entry;
            Amount = amount;

        }

        public OfferData()
        {
            Amount = 0;
        }

        public DataEntry Entry
        {
            get;
            set;
        }

        public decimal Amount
        {
            get;
            set;
        }
    }

}
