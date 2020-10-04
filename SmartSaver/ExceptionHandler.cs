namespace DataManager
{
    class ExceptionHandler
    {
        public void Log(string error)
        {
            System.IO.File.WriteAllText(@"Errors.txt", error);
        }
    }
}
