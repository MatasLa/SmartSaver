﻿namespace ePiggy.Utilities
{
    static class ExceptionHandler
    {
        public static void Log(string error = "Undefined exception")
        {
            System.IO.File.WriteAllText(@"Errors.txt", error + "\n");
        }
    }
}
