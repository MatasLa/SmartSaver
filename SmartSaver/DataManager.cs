using System;
using System.Collections;
using System.IO;

namespace DataManager
{
	struct DataEntry
	{
		public int id, value;
		public string title;

		public DataEntry(int id, int value, string title)/*Testing purposes*/
		{
			this.id = id;
			this.value = value;
			this.title = title;
		}
	}

	public class Data
	{
		private ArrayList income = new ArrayList();/*Both need a getter*/
		private ArrayList expenses = new ArrayList();

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
					output = output + "{\n\t\"id\": \"" + data.id + "\",\n\t\"title\": \"" + data.title + "\",\n\t\"value\": \"" + data.value + "\"\n}";
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
					output = output + "{\n\t\"id\": \"" + data.id + "\",\n\t\"title\": \"" + data.title + "\",\n\t\"value\": \"" + data.value + "\"\n}";
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
			DataEntry entry = new DataEntry(57, 200, "Internetas");
			DataEntry entry1 = new DataEntry(87, 150, "Kuras");
			income.Add(entry);
			income.Add(entry1);
			WriteIncomeToFile();
		}*/
		
	}


}