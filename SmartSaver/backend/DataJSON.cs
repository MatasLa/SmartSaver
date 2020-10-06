using System;
using System.Text.Json;
using System.Diagnostics;
using System.IO;
using Utilities;

namespace DataManager
{
    public class DataJSON
    {
		private Data data;
		public DataJSON(Data data)
		{
			this.data = data;
		}

		/*Writing/reading JSON files*/
		public void WriteIncomeToFile()
		{
			File.WriteAllText("userIncome.json", "");
			using (StreamWriter sw = File.AppendText("userIncome.json"))
			{
				string output;
				foreach (DataEntry data in data.Income)
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
				foreach (DataEntry data in data.Expenses)
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
						data.Income.Add(dataEntry);
					}
					catch (Exception e)
					{
                        ExceptionHandler.Log(e.ToString());
					}

				}

				file.Close();
			}
			catch (FileNotFoundException f)
			{
				ExceptionHandler.Log(f.ToString());
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
						data.Expenses.Add(dataEntry);
					}
					catch (Exception e)
					{
						ExceptionHandler.Log(e.ToString());
					}
				}

				file.Close();
			}
			catch (FileNotFoundException f)
			{
				ExceptionHandler.Log(f.ToString());
			}
		}
	}
}
