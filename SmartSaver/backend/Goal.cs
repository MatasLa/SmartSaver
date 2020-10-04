using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class Goal
    {
        private int id;
        private string title;
        private double price;

        public int ID
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public double Price
        {
            get; set;
        }

        public void SetGoalFromWeb(string itemName)
        {
            try
            {
                Task.Run(() => InternetParser.GetHTMLAsync(itemName)).Wait();

                System.IO.StreamReader file = new System.IO.StreamReader("priceInfo.txt");
                string line;
                Title = file.ReadLine();
                var pricestr = file.ReadLine();
                var Price = Convert.ToDouble(pricestr, System.Globalization.CultureInfo.InvariantCulture);
                file.Close();
            }catch(Exception e)
            {

            }
           

            
        }
    }
}
