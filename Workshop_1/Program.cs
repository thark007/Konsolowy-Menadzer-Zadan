using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Workshop_1
{
	class Program
	{
		static List<TaskModel> taskModelList = new List<TaskModel>();
		static void Main(string[] args)
		{
			Program program = new Program();
			program.TaskLoop();
		}
		public void TaskLoop()
		{
			string Task = "";
			Console.WriteLine("Wpisz co chcesz zrobić: ");
			Console.WriteLine("wpisz \'dodaj zadanie\' aby dodać zadanie");
			Console.WriteLine("wpisz \'usuń zadanie\' aby usunąć zadanie");
			Console.WriteLine("wpisz \'zapisz zadanie\' aby zapisać zadanie");
			Console.WriteLine("wpisz \'wczytaj zadania\' aby wczytać zadania");
			Console.WriteLine("wpisz \'exit\' aby wyjść z programu");
			do
			{


				Task = Console.ReadLine();
				//TaskModel taskModel = new TaskModel();

				if (Task == "Dodaj zadanie".ToLower())
				{

					AddTask();
					//TaskModel taskModel = new TaskModel();
					//Console.WriteLine(taskModebl.AddTask(Task));
				}

				if (Task == "Usuń zadanie".ToLower())
				{
					RemoveTask();
				}
				if (Task == "Zapisz zadanie".ToLower())
				{
					SaveFile();
				}
				/*Console.WriteLine("które zadanie chcesz usunąć:");
				string zadanie = Console.ReadLine();
				taskList.RemoveAt(0);
			}

			if (Task == "Pokaż zadania")
			{
				foreach (TaskModel taskModel in taskList)
				{
					taskModel.ShowTasks();
				}
			}*/

			} while (Task != "exit");
		}
		public void AddTask()
		{
			Console.WriteLine("Wpisz opis zadania");
			string descripion = Console.ReadLine();
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
				catch (FormatException exception)
				{
					Console.WriteLine("zły format daty, wpisz w formacie dd-mm-yyyy");
				}
			} while (KeepLoop);
			Console.WriteLine("Jeśli zadanie jest ważne wpisz: TAK");
			string Importance = Console.ReadLine();
			bool importance = false;
			if (Importance.ToLower() == "tak")
			{
				importance = true;
			}
			Console.WriteLine("Jeśli zadanie zajmie Ci więcej niż jeden dzień wpisz: TAK");
			string Duracy = Console.ReadLine();
			bool duracy = false;
			if (Duracy.ToLower() == "tak")
			{
				duracy = true;
			}
			TaskModel taskModel = new TaskModel(descripion, taskStart, taskEnd, importance, duracy);
			taskModelList.Add(taskModel);
		}
		public void RemoveTask()
		{
			List<TaskModel> list = taskModelList;
			Console.WriteLine("Wpisz nr zadania, które chcesz usunąć:");
			int size = taskModelList.Count;
			if ( size == 0)
			{
				Console.WriteLine("Nie ma żadnych zadań");
			}
			for (int i = 0; i < list.Count; i++)
			{

					string _discription = list[i]._discription;
					string info = $"{i + 1}. {_discription}";
					Console.WriteLine(info);

			}
			int position = Convert.ToInt32(Console.ReadLine());
			taskModelList.RemoveAt(position - 1);
			Console.WriteLine($"Pozycja nr {position} została usunięta");

		}
		public void SaveFile()
		{
			var csv = new StringBuilder();
			for(int i = 0; i < taskModelList.Count; i++)
			{
				var first = taskModelList[i]._discription;
				csv.AppendLine(first);
			}
			File.WriteAllText("C:\\NowyFolder\\Text.csv", csv.ToString());
		}
	}

}




