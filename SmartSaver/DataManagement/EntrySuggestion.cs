using System;

namespace ePiggy.DataManagement
{
    public class EntrySuggestion : IEquatable<EntrySuggestion>, IComparable
    {
        public DataEntry Entry { get; set; }
        public decimal Amount { get; set; }

        public EntrySuggestion(DataEntry entry, decimal suggestedAmount)
        {
            Entry = entry;
            Amount = suggestedAmount;
        }

        public bool Equals(EntrySuggestion other)
        {
            if (other is null)
            {
                return false;
            }

            return Entry == other.Entry && Amount == other.Amount;
        }

        public int CompareTo(object? obj)
        {
            return obj switch
            {
                null => 1,
                EntrySuggestion otherEntrySuggestion => Amount.CompareTo(otherEntrySuggestion.Amount),
                _ => throw new ArgumentException("Object is not a EntrySuggestion")
            };
        }
    }

}
