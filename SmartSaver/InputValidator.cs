using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Utilities
{
    public class InputValidator
    {
        public static bool IsCurrencyInputValid(string str)
        {
            double value;
            if (Double.TryParse(str, NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out value))
            {
                if (Math.Round(value, 2) == value)
                {
                    return true;
                    //Too many decimals
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        public static bool IsNameValid(string str)
        {
            //for now if not empty, later could add specific requirments
            if(str.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
