using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Utilities
{
    public class NumberFormatter
    {
        public static string FormatCurrency(decimal value)
        {
            var cultureInfo = CultureInfo.CurrentCulture;
            var numberFormat = cultureInfo.NumberFormat;
            string pattern = null;
            if (value >= Decimal.Zero)
            {
                switch (numberFormat.CurrencyPositivePattern)
                {
                    case 0:
                        pattern = "{0}{1:N" + numberFormat.CurrencyDecimalDigits + "}";
                        break;
                    case 1:
                        pattern = "{1:N" + numberFormat.CurrencyDecimalDigits + "}{0}";
                        break;
                    case 2:
                        pattern = "{0} {1:N" + numberFormat.CurrencyDecimalDigits + "}";
                        break;
                    case 3:
                        pattern = "{1:N" + numberFormat.CurrencyDecimalDigits + "} {0}";
                        break;
                }
            }
            else
            {
                value = -value;
                switch (numberFormat.CurrencyNegativePattern)
                {
                    case 0:
                        pattern = "({0}{1:N" + numberFormat.CurrencyDecimalDigits + "})";
                        break;
                    case 1:
                        pattern = "-{0}{1:N" + numberFormat.CurrencyDecimalDigits + "}";
                        break;
                    case 2:
                        pattern = "{0}-{1:N" + numberFormat.CurrencyDecimalDigits + "}";
                        break;
                    case 3:
                        pattern = "{0}{1:N" + numberFormat.CurrencyDecimalDigits + "}-";
                        break;
                    case 4:
                        pattern = "({1:N" + numberFormat.CurrencyDecimalDigits + "}{0})";
                        break;
                    case 5:
                        pattern = "-{1:N" + numberFormat.CurrencyDecimalDigits + "}{0}";
                        break;
                    case 6:
                        pattern = "{1:N" + numberFormat.CurrencyDecimalDigits + "}-{0}";
                        break;
                    case 7:
                        pattern = "{1:N" + numberFormat.CurrencyDecimalDigits + "}{0}-";
                        break;
                    case 8:
                        pattern = "-{1:N" + numberFormat.CurrencyDecimalDigits + "} {0}";
                        break;
                    case 9:
                        pattern = "-{0} {1:N" + numberFormat.CurrencyDecimalDigits + "}";
                        break;
                    case 10:
                        pattern = "{1:N" + numberFormat.CurrencyDecimalDigits + "} {0}-";
                        break;
                    case 11:
                        pattern = "{0} {1:N" + numberFormat.CurrencyDecimalDigits + "}-";
                        break;
                    case 12:
                        pattern = "{0} -{1:N" + numberFormat.CurrencyDecimalDigits + "}";
                        break;
                    case 13:
                        pattern = "{1:N" + numberFormat.CurrencyDecimalDigits + "}- {0}";
                        break;
                    case 14:
                        pattern = "({0} {1:N" + numberFormat.CurrencyDecimalDigits + "})";
                        break;
                    case 15:
                        pattern = "({1:N" + numberFormat.CurrencyDecimalDigits + "} {0})";
                        break;
                }
            }
            string formattedValue = String.Format(cultureInfo, pattern, numberFormat.CurrencySymbol, value);
            return formattedValue;
        }
    }
}
