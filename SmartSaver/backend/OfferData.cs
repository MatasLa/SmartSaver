using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager
{
    public class OfferData
    {
        public OfferData(int id, decimal amount)
        {
            ID = id;
            Amount = amount;

        }

        public OfferData()
        {
            ID = 0;
            Amount = 0;
        }

        public int ID
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
