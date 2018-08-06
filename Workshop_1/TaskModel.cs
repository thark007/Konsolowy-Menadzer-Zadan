using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Workshop_1
{
	public class TaskModel
	{
		public List<string> taskModelList = new List<string>();
		string path = @"C:\Users\Dorota\Documents\GitHub\Warsztat_1\1_Workshop\Konsolowy-Menadzer-Zadan\Workshop_1\Tasks.csv";

		public string description;
		public DateTime taskStart;
		public DateTime taskEnd;
		public bool isTaskImportant;
		public bool isTaskFullDay;

		public TaskModel(string description, DateTime taskStart, DateTime taskEnd, bool isTaskImportant, bool isTaskFullDay)
		{
			this.description = description;
			this.taskStart = taskStart;
			this.taskEnd = taskEnd;
			this.isTaskImportant = isTaskImportant;
			this.isTaskFullDay = isTaskFullDay;
		}

		public void AddTask()
		{
			Console.WriteLine("Wpisz opis zadania");
			string discription = Console.ReadLine();

			Console.WriteLine("Kiedy chcesz rozpocząć zadanie: dd-mm-yyyy");
			DateTime taskStart = new DateTime();
			bool KeepLoop = true;
			do
			{
				try
				{
					string dateTimeString = Console.ReadLine();
					taskStart = DateTime.ParseExact(dateTimeString, "dd-mm-yyyy", CultureInfo.InvariantCulture);
					KeepLoop = false;
				}
				catch (FormatException exception)
				{
					ConsoleEx.WriteLine("zły format daty, wpisz w formacie dd-mm-yyyy", ConsoleColor.Red);
					Console.WriteLine(exception.Message);
				}

			} while (KeepLoop);

			Console.WriteLine("Kiedy chcesz zakończyć zadanie");
			DateTime taskEnd = new DateTime();
			do
			{
				KeepLoop = true;
				try
				{
					string dateTimeString = Console.ReadLine();
					taskEnd = DateTime.ParseExact(dateTimeString, "dd-mm-yyyy", CultureInfo.InvariantCulture);
					KeepLoop = false;
				}
				catch (FormatException e)
				{
					ConsoleEx.WriteLine("zły format daty, wpisz w formacie dd-mm-yyyy", ConsoleColor.Red);
					Console.WriteLine(e.Message);
				}
			} while (KeepLoop);

			Console.WriteLine("Jeśli zadanie jest ważne wpisz: TAK");
			string Importance = Console.ReadLine();
			bool importance = false;
			if (Importance.ToLower() == "tak")
			{
				importance = true;
			}
			bool duracy;

			if (taskStart == taskEnd)
			{
				duracy = true;
			}
			else
			{
				duracy = false;
			}

			TaskModel taskModel = new TaskModel(discription, taskStart, taskEnd, importance, duracy);
			string task = $"{discription},{taskStart},{taskEnd},{importance},{duracy}";
			Console.Clear();
			taskModelList.Add(task);
			Console.WriteLine(task);
			ConsoleEx.WriteLine("Zadanie Dodane!", ConsoleColor.Green);
		}
		public void ShowTask()
		{
			List<string> list = taskModelList;
			int size = taskModelList.Count;
			if (size == 0)
			{
				ConsoleEx.WriteLine("Nie ma żadnych zadań", ConsoleColor.Red);
			}
			else
			{
				for (int i = 0; i < list.Count; i++)
				{
					string description = list[i].ToString();
					string info = $"{i + 1}. {description}";
					Console.WriteLine(info);
				}
			}
		}
		public void RemoveTask()
		{
			ShowTask();
			if (taskModelList.Count > 0)
			{
				Console.WriteLine("Wpisz nr zadania, które chcesz usunąć:");
				try
				{
					int position = Convert.ToInt32(Console.ReadLine());
					taskModelList.RemoveAt(position - 1);
					Console.Clear();
					ConsoleEx.WriteLine($"Pozycja nr {position} została usunięta", ConsoleColor.Green);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}
		public void SaveFile()
		{
			var csv = new StringBuilder();
			for (int i = 0; i < taskModelList.Count; i++)
			{
				var first = taskModelList[i].ToString();
				csv.AppendLine(first);
			}
			try
			{
				File.AppendAllText(path, $"{csv.ToString()} ");
				Console.Clear();
				ConsoleEx.WriteLine("Wszystkie zadania zapisane", ConsoleColor.Green);
			}
			catch (Exception e)
			{
				ConsoleEx.WriteLine(e.Message, ConsoleColor.Red);
			}
		}
		public void LoadFile()
		{
			List<string> result = new List<string>();
			try
			{
				string s = File.ReadAllText(path);
				ConsoleEx.WriteLine(s, ConsoleColor.Yellow);
			}
			catch (Exception e)
			{
				ConsoleEx.WriteLine(e.Message, ConsoleColor.Red);
			}
		}
	}
}
