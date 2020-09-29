using System;
using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Diagnostics;
using System.Drawing;
using System.IO;
>>>>>>> dev
using System.Linq;

namespace DataManager
{
	public class DataEntry
	{

		/*Constructor*/
		public DataEntry(int id, double amount, string title, DateTime date, bool isMonthly)
		{
			ID = id;
			Amount = amount;
			Title = title;
			Date = date;
			IsMonthly = isMonthly;

		}

		public DataEntry()
		{
			ID = 0;
			Amount = 0;
			Title = "unnamed";
			Date = DateTime.Now;
			IsMonthly = false;

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
			get;
			set;
		}
        public DateTime Date
		{
			get;
			set;
		}
		public bool IsMonthly
		{
			get;
			set;
		}
	}

	/*Main data processing class*/
	public class Data
	{
		/*Lists that store income and expenses*/
		public List<DataEntry> Income { get; } = new List<DataEntry>();
		public List<DataEntry> Expenses { get; } = new List<DataEntry>();

		/*Methods that creates new instance of class and adds to List*/
		public void AddIncome(double value, string title, DateTime date, bool isMonthly)
		{
			Random rnd = new Random();//Since no database, IDs randomized between 100 and 201
			DataEntry newIncome = new DataEntry(rnd.Next(100, 200), value, title, date, isMonthly);
			Income.Add(newIncome);
		}

		public void AddExpense(double value, string title, DateTime date, bool isMonthly)
		{
			Random rnd = new Random();
			DataEntry newExpense = new DataEntry(rnd.Next(100, 201), value, title, date, isMonthly);
			Expenses.Add(newExpense);
		}

		public void RemoveIncome(int id)
		{
			Income.RemoveAt(id - 1);
		}

		public void RemoveExpense(int id)
		{
			Expenses.RemoveAt(id - 1);
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
		
		public bool EditIncomeItem(int id, DateTime date)
        {
			var temp = Income.FirstOrDefault(x => x.ID == id);
			temp.Date = date;
			return true;
		}

		public bool EditIncomeItem(int id, string value, double amount, DateTime date, bool isMonthly)
		{
			var temp = Income.FirstOrDefault(x => x.ID == id);
			temp.Title = value;
			temp.Amount = amount;
			temp.Date = date;
			temp.IsMonthly = isMonthly;
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
		public bool EditExpensesItem(int id, DateTime date)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			temp.Date = date;
			return true;
		}

		public bool EditExpensesItem(int id, string value, double amount, DateTime date, bool isMonthly)
		{
			var temp = Expenses.FirstOrDefault(x => x.ID == id);
			temp.Title = value;
			temp.Amount = amount;
			temp.Date = date;
			temp.IsMonthly = isMonthly;
			return true;
		}

	
<<<<<<< HEAD
=======

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

					sw.Write(output + "\n");
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

>>>>>>> dev
	}


}