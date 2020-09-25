using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataManager
{
	public class DataEntry
	{

		/*Constructor*/
		public DataEntry(int id, double amount, string title)
		{
			ID = id;
			Amount = amount;
			Title = title;
		}

		public DataEntry()
		{
			ID = 0;
			Amount = 0;
			Title = "unnamed";

		}

		/*Getters and Setters*/
		public string Title
		{
			get;
			set;
		}
		public double Amount
		{
			get;
			set;
		}
		public int ID
		{
			get; //Only setter, since we don't want to allow to modify id
		}
	}

	/*Main data processing class*/
	public class Data
	{
		/*Lists that store income and expenses*/
		public List<DataEntry> Income { get; } = new List<DataEntry>();
        public List<DataEntry> Expenses { get; } = new List<DataEntry>();

		/*Methods that creates new instance of class and adds to List*/
		public void AddIncome(double value, string title)
		{
			Random rnd = new Random();//Since no database, IDs randomized between 100 and 201
			DataEntry newIncome = new DataEntry(rnd.Next(100, 201), value, title);
			Income.Add(newIncome);
		}

		public void AddExpense(double value, string title)
		{
			Random rnd = new Random();
			DataEntry newExpense = new DataEntry(rnd.Next(100, 201), value, title);
			Expenses.Add(newExpense);
		}

		/*Methods that allows to edit different parts of already existing entrys*/
		public bool EditIncomeItem(int id, double value)/*Returns true if success(item found), and false if failure*/
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			temp.Amount = value;
			return true;
			//return false;
		}
		public bool EditIncomeItem(int id, string value)
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			temp.Title = value;
			return true;
		}

		public bool EditIncomeItem(int id, string value, double amount)
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			temp.Title = value;
			temp.Amount = amount;
			return true;
		}
		public bool EditExpensesItem(int id, double value)/*Returns true if success(item found), and false if failure*/
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			temp.Amount = value;
			return true;
		}
		public bool EditExpensesItem(int id, string value)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			temp.Title = value;
			return true;
		}

		public bool EditExpensesItem(int id, string value, double amount)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			temp.Title = value;
			temp.Amount = amount;
			return true;
		}

		/*Writing/reading JSON files*/
		public void WriteIncomeToFile()
		{
			File.WriteAllText("userIncome.json", "");
			using (StreamWriter sw = File.AppendText("userIncome.json"))
			{
				string output;
				foreach (DataEntry data in Income)
				{
					output = JsonSerializer.Serialize(data);
					
					sw.Write(output +"\n");
				}
			}
		}



		public void WriteExpensesToFile()
		{
			File.WriteAllText("userExpenses.json", "");
			using (StreamWriter sw = File.AppendText("userExpenses.json"))
			{
				string output;
				foreach (DataEntry data in Income)
				{
					output = JsonSerializer.Serialize(data);

					sw.Write(output + "\n");
				}
			}
		}

		public void ReadIncomeFromFile()
		{
			string line;
			try
			{
				System.IO.StreamReader file = new System.IO.StreamReader("userIncome.json");

				while ((line = file.ReadLine()) != null)
				{
					try
					{
						var dataEntry = JsonSerializer.Deserialize<DataEntry>(line);//TRY CATCH
						Income.Add(dataEntry);
					}catch(Exception e)
					{
						Debug.Write(e);
					}

				}

				file.Close();
			}
			catch(FileNotFoundException f)
			{
				Debug.Write(f);
			}
			

		}

		public void ReadExpensesFromFile()
		{
			string line;
			try
			{
				System.IO.StreamReader file = new System.IO.StreamReader("userExpenses.json");
				while ((line = file.ReadLine()) != null)
				{

					try
					{
						var dataEntry = JsonSerializer.Deserialize<DataEntry>(line);//TRY CATCH
						Expenses.Add(dataEntry);
					}
					catch (Exception e)
					{
						Debug.Write(e);
					}
				}

				file.Close();
			}
			catch (FileNotFoundException f)
			{
				Debug.Write(f);
			}
			

			

		}

		//Only for testing purposes, DELETE AFTER DONE TESTING!
		/*public void test()    
		{
			Data data = new Data();
            data.AddIncome(600, "Salary");
            data.AddIncome(150, "Stocks");
            data.WriteIncomeToFile();
		}*/

	}


}