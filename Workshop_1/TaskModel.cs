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

		public string _discription;
		public DateTime _taskStart;
		public DateTime _taskEnd;
		public bool _isTaskImportant;
		public bool _isTaskFullDay;

		public TaskModel(string discription, DateTime taskStart, DateTime taskEnd, bool isTaskImportant, bool isTaskFullDay)
		{
			_discription = discription;
			_taskStart = taskStart;
			_taskEnd = taskEnd;
			_isTaskImportant = isTaskImportant;
			_isTaskFullDay = isTaskFullDay;
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
					Console.WriteLine("zły format daty, wpisz w formacie dd-mm-yyyy");
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
			Console.WriteLine("Naciśnij dowolny klawisz aby wrócić do Menu");
			Console.ReadLine();
			Console.Clear();

		}
		public void RemoveTask()
		{
			List<string> list = taskModelList;
			Console.WriteLine("Wpisz nr zadania, które chcesz usunąć:");
			int size = taskModelList.Count;
			if (size == 0)
			{
				ConsoleEx.WriteLine("Nie ma żadnych zadań", ConsoleColor.Red);
			}
			else
			{
				for (int i = 0; i < list.Count; i++)
				{

					string _discription = list[i].ToString();
					string info = $"{i + 1}. {_discription}";
					Console.WriteLine(info);
				}

				int position = Convert.ToInt32(Console.ReadLine());
				taskModelList.RemoveAt(position - 1);
				Console.Clear();
				ConsoleEx.WriteLine($"Pozycja nr {position} została usunięta", ConsoleColor.Green);
				Console.WriteLine("Naciśnij dowolny klawisz aby wrócić do Menu");
				Console.ReadLine();
				Console.Clear();
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
				string path = @"C:\Users\Dorota\Documents\GitHub\Warsztat_1\1_Workshop\Konsolowy-Menadzer-Zadan\Workshop_1\Tasks.csv";
				File.AppendAllText(path, $"{csv.ToString()} ");
				Console.Clear();
				ConsoleEx.WriteLine("Wszystkie zadania zapisane", ConsoleColor.Green);
				Console.WriteLine("Naciśnij dowolny klawisz aby wrócić do Menu");
				Console.ReadLine();
				Console.Clear();
			}
			catch (Exception e)
			{
				ConsoleEx.WriteLine(e.Message, ConsoleColor.Red);
			}
		}

		public void LoadFile()
		{
			List<string> result = new List<string>();
			string path = @"C:\Users\Dorota\Documents\GitHub\Warsztat_1\1_Workshop\Konsolowy-Menadzer-Zadan\Workshop_1\Tasks.csv";
			try
			{
				string s = File.ReadAllText(path);
				Console.WriteLine(s);
			}
			catch (Exception e)
			{
				ConsoleEx.WriteLine(e.Message, ConsoleColor.Red);
			}
		}

	}

}

