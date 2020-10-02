namespace DataManager
{
    static class ExceptionHandler
    {
        public static void Log(string error)
        {
            System.IO.File.WriteAllText(@"Errors.txt", error + "\n");
        }
    }
}
