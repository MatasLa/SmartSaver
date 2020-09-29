using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver
{
    public class InputValidator
    {
        public static bool IsNumberValid(string str, out double value)
        {
            if (Double.TryParse(str, out value))
            {
                return true;
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
