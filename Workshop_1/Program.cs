using System;
using System.Collections.Generic;

namespace Workshop_1
{
	class Program
	{
		static void Main(string[] args)
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
					//taskModel.AddTask();
					//TaskModel taskModel = new TaskModel();
					//Console.WriteLine(taskModebl.AddTask(Task));
				}

				if (Task == "Skasuj zadanie")
				{
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
	}
}




