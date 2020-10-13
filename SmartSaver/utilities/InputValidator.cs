using System.Globalization;

namespace ePiggy.utilities
{
    public class InputValidator
    {
        public static bool IsCurrencyInputValid(string str)
        {
            if (decimal.TryParse(str, NumberStyles.Any, CultureInfo.CurrentCulture, out var value))
            {
                return decimal.Round(value, 2) == value;
            }

            return false;
        }
        
        public static bool IsNameValid(string str)
        {
            //for now if not empty
            return str.Length != 0;
        }
    }
}
