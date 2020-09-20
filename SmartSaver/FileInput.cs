using System;
using System.IO;

namespace DataManager
{
	public class FileReader/*Class that reads from files and uses that data*/
	{
		private int[] income;/*Different index of array member - different source*/
		private int[] expenses;


		public int CalculateMonthlySavings()/*Reads income and expenses from file and outputs balance at the end of the month to file*/
		{
			ReadIncome();
			ReadExpenses();
			int balance = 0;
			foreach(int num in income)
			{
				balance += num;
			}
			foreach(int num in expenses)
			{
				balance -= num;
			}

			File.WriteAllText("result.txt", balance + "");
			return balance;
		}
		private void ReadIncome()/*Reads income from file and parses to int array*/
		{
			int i = 0;
			string[] dataFromFile = File.ReadAllLines("userIncome.txt");
			income = new int[dataFromFile.Length];
			foreach(string line in dataFromFile)
			{
				try
				{
					income[i] = Int32.Parse(line);
					i++;
				}
				catch(FormatException e)
				{
					Console.WriteLine(e.Message);
				}
				
			}
		}

		private void ReadExpenses()/*Reads expenses from file and parses to int array*/
		{
			int i = 0;
			string[] dataFromFile = File.ReadAllLines("userExpenses.txt");
			expenses = new int[dataFromFile.Length];
			foreach (string line in dataFromFile)
			{
				try
				{
					expenses[i] = Int32.Parse(line);
					i++;
				}
				catch (FormatException e)
				{
					Console.WriteLine(e);
				}

			}
		}
	}

	public class UserInput/*Class that takes user input, from UI ant outputs it to file*/
	{
		private int[] income;

		public void WriteNewIncomeToFile(int[] input)
		{
			string output;
			foreach(int num in input)
			{
				output = output + input + "\n";
			}
			File.WriteAllText("userIncome.txt", output);
		}
	}
}