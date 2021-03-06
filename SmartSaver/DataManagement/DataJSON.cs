﻿using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using ePiggy.Utilities;

namespace ePiggy.DataManagement
{
    public class DataJson
    {
		private readonly Data _data;
		public DataJson(Data data)
		{
			_data = data;
		}

		/*Writing/reading JSON files*/
		public void WriteIncomeToFile()
		{
            try
            {
                File.WriteAllText("userIncome.json", "");
                using var sw = File.AppendText("userIncome.json");
                foreach (var output in _data.Income.Select(data => JsonSerializer.Serialize(data)))
                {
                    sw.WriteLine(output);
                }
            }
            catch (Exception e)
            {
				ExceptionHandler.Log(e.ToString());
            }
			
        }

		public void WriteExpensesToFile()
		{
            try
            {
                File.WriteAllText("userExpenses.json", "");
                using var sw = File.AppendText("userExpenses.json");
                foreach (var output in _data.Expenses.Select(data => JsonSerializer.Serialize(data)))
                {
                    sw.WriteLine(output);
                }
            }
            catch (Exception e)
            {
				ExceptionHandler.Log(e.ToString());
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
