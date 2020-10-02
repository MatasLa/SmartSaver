using Forms;

namespace DataManager
{
    class DataCalculations
    {
        private Data data;
        public DataCalculations(Data data)
        {
            this.data = data;
        }

        public double CheckBalance()
        {
            double sum = 0;
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
        //Preferably dont use code below this comment yet, names and functionality might change, this is a rough idea
        public bool CheckGoal()
        {
            if (IsBalancePositive())
            {
                Goal goal = new Goal();
                if((CheckBalance() - goal.price) >= 0)
                {
                    return true;    //can already buy this month
                }
                else
                {
                    return SavingMoney(); //not in debt, but needs saving
                }
            }
            else
            {
                return false;   //user already in debt without adding goal expenses
            }
        }
        public bool SavingMoney()
        {
            var savedAmount = 0;
            Goal goal = new Goal();
            var neededAmount = (goal.price - CheckBalance());
            while ((neededAmount - savedAmount) > 0) //while(can't afford goal)
            {   //todo: implement saving, export the categories/things needed to save on
                
                //saving happening (savedAmount going up)

            }
            return true; // after having saved enough
        }
    }
}
