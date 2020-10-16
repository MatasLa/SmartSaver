using System;
using System.Text.Json;
using System.IO;
using System.Linq;
using ePiggy.utilities;

namespace ePiggy.DataManager
{
    public class DataJson
    {
		private readonly Data _data;
		public DataJson(Data data)
		{
			this._data = data;
		}

		/*Writing/reading JSON files*/
		public void WriteIncomeToFile()
		{
			File.WriteAllText("userIncome.json", "");
            using var sw = File.AppendText("userIncome.json");
            foreach (var output in _data.Income.Select(data => JsonSerializer.Serialize(data)))
            {
                sw.Write(output + "\n");
            }
        }

		public void WriteExpensesToFile()
		{
			File.WriteAllText("userExpenses.json", "");
            using var sw = File.AppendText("userExpenses.json");
            foreach (var output in _data.Expenses.Select(data => JsonSerializer.Serialize(data)))
            {
                sw.Write(output + "\n");
            }
        }

		public void ReadIncomeFromFile()
		{
            try
			{
				var file = new StreamReader("userIncome.json");

                string line;
                while ((line = file.ReadLine()) != null)
				{
					try
					{
						var dataEntry = JsonSerializer.Deserialize<DataEntry>(line);//TRY CATCH
						_data.Income.Add(dataEntry);
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
            try
			{
				var file = new StreamReader("userExpenses.json");
                string line;
                while ((line = file.ReadLine()) != null)
				{

					try
					{
						var dataEntry = JsonSerializer.Deserialize<DataEntry>(line);//TRY CATCH
						_data.Expenses.Add(dataEntry);
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
