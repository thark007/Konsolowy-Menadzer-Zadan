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
			var taskModel = new TaskModel("",DateTime.Now,DateTime.MaxValue, false, false);

			string Task = "";

			do
			{
				mainMenu.showMenu();
				Task = Console.ReadLine().ToUpper();

				if (Task == "ADD")
				{
					taskModel.AddTask();
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

			} while (Task != "EXIT");
		}
	}
}




