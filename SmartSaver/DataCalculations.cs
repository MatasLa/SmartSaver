namespace DataManager
{
    class DataCalculations
    {
        private Data data;
        public DataCalculations(Data data)
        {
            this.data = data;
        }

        public decimal CheckBalance()
        {
            decimal sum = 0;
            foreach (DataEntry data in data.Income)
            {
                sum += data.Amount;
            }
            foreach (DataEntry data in data.Expenses)
            {
                sum -= data.Amount;
            }
            return sum;
        }
        public bool IsBalancePositive()
        {
            if (CheckBalance() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
