using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DataManager
{
	class DataEntry
	{
		/*Fields*/
		private int id, amount;
		private string title;

		/*Constructor*/
		public DataEntry(int id, int amount, string title)
		{
			this.id = id;
			this.amount = amount;
			this.title = title;
		}

		/*Getters and Setters*/
		public string Title
		{
			get => title;
			set => title = value;
		}
		public int Amount
		{
			get => amount;
			set => amount = value;
		}
		public int ID
		{
			get => id; //Only setter, since we don't want to allow to modify id
		}
	}

	/*Main data processing class*/
	public class Data
	{
		/*Lists to store all user's incomes and expenses*/
		private List<DataEntry> income = new List<DataEntry>();//Both need a getter
		private List<DataEntry> expenses = new List<DataEntry>();

		/*Methods that creates new instance of class and adds to List*/
		public void AddIncome(int value, string title)
		{
			Random rnd = new Random();//Since no database, IDs randomized between 100 and 201
			DataEntry newIncome = new DataEntry(rnd.Next(100, 201), value, title);
			income.Add(newIncome);
		}

		public void AddExpense(int value, string title)
		{
			Random rnd = new Random();
			DataEntry newExpense = new DataEntry(rnd.Next(100, 201), value, title);
			expenses.Add(newExpense);
		}
		public bool EditIncomeItem(int id, int value)/*Returns true if success(item found), and false if failure*/
		{
			for(int i=0; i<income.Count;i++)
			{
				var temp = income[i];
				if(temp.ID == id)
				{
					temp.Amount = value;
					return true;
				}
			}
			return false;
		}
		public bool EditIncomeItem(int id, string value)
		{
			for (int i = 0; i < income.Count; i++)
			{
				var temp = income[i];
				if (temp.ID == id)
				{
					temp.Title = value;
					return true;
				}
			}
			return false;
		}

		public bool EditIncomeItem(int id, string value, int amount)
		{
			for (int i = 0; i < income.Count; i++)
			{
				var temp = income[i];
				if (temp.ID == id)
				{
					temp.Title = value;
					temp.Amount = amount;
					return true;
				}
			}
			return false;
		}
		public void WriteIncomeToFile()
		{
			File.WriteAllText("userIncome.json", "");
			using (StreamWriter sw = File.AppendText("userIncome.json"))
			{
				string output;
				bool firstIteration = true;
				foreach (DataEntry data in income)
				{
					if (firstIteration)
					{
						firstIteration = false;
						output = "";
					}
					else
					{
						output = ",\n";
					}
					output = output + "{\n\t\"id\": \"" + data.ID + "\",\n\t\"title\": \"" + data.Title + "\",\n\t\"value\": \"" + data.Amount + "\"\n}";
					sw.Write(output);
				}
			}
		}

		public void WriteExpensesToFile()
		{
			File.WriteAllText("userExpenses.json", "");
			using (StreamWriter sw = File.AppendText("userExpenses.json"))
			{
				string output;
				bool firstIteration = true;
				foreach (DataEntry data in expenses)
				{
					if (firstIteration)
					{
						firstIteration = false;
						output = "";
					}
					else
					{
						output = ",\n";
					}
					output = output + "{\n\t\"id\": \"" + data.ID + "\",\n\t\"title\": \"" + data.Title + "\",\n\t\"value\": \"" + data.Amount + "\"\n}";
					sw.Write(output);
				}
			}
		}

		public void ReadIncomeFromFile()/*JSON.NET?????     https://www.newtonsoft.com/json */
		{

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