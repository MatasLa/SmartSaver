using System;

namespace ePiggy.DataManagement
{
    public class EntrySuggestion : IEquatable<EntrySuggestion>, IComparable
    {
        public DataEntry Entry { get; set; }
        public decimal SuggestedAmount { get; set; }

        public EntrySuggestion(DataEntry entry, decimal suggestedAmount)
        {
            Entry = entry;
            SuggestedAmount = suggestedAmount;
        }

        public bool Equals(EntrySuggestion other)
        {
            if (other is null)
            {
                return false;
            }

            return Entry == other.Entry && SuggestedAmount == other.SuggestedAmount;
        }

        public int CompareTo(object? obj)
        {
            return obj switch
            {
                null => 1,
                EntrySuggestion otherEntrySuggestion => SuggestedAmount.CompareTo(otherEntrySuggestion.SuggestedAmount),
                _ => throw new ArgumentException("Object is not a EntrySuggestion")
            };
        }
    }

}
