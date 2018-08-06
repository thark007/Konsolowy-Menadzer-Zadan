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
		static void Main(string[] args)
		{
			var mainMenu = new MainManu();
			var taskModel = new TaskModel("", DateTime.Now, DateTime.MaxValue, false, false);

			string Task = "";

			do
			{
				mainMenu.showMenu();
				Task = Console.ReadLine().ToUpper();
				if ((Task == "ADD") || (Task == "SHOW") || (Task == "REMOVE") || (Task == "SAVE") || (Task == "LOAD"))
				{
					if (Task == "ADD")
					{
						taskModel.AddTask();
					}

					if (Task == "SHOW")
					{
						taskModel.ShowTask();
					}

					if (Task == "REMOVE")
					{
						taskModel.RemoveTask();
					}

					if (Task == "SAVE")
					{
						taskModel.SaveFile();
					}

					if (Task == "LOAD")
					{
						taskModel.LoadFile();
					}

					mainMenu.backToMenu();
				}
				else
				{
					if (Task != "EXIT")
					{
						ConsoleEx.WriteLine("Niepoprawne polecenie", ConsoleColor.Red);
						mainMenu.backToMenu();
					}
				}
			} while (Task != "EXIT");
		}
	}
}




