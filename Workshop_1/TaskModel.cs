using System;
using System.Collections.Generic;
using System.IO;

namespace Workshop_1
{
	public class TaskModel
	{
		string _discription;
		DateTime _taskStart;
		DateTime _taskEnd;
		Nullable<bool> _isTaskImportawnt;
		Nullable<bool> _isTaskFullDay;


		List<string[]> taskModel = new List<string[]>();

		public TaskModel(string discription, DateTime taskStart, DateTime taskEnd, Nullable<bool> isTaskImportant, Nullable<bool> isTaskFullDay)
		{
			_discription = discription;
			_taskStart = taskStart;
			_taskEnd = taskEnd;
			_isTaskImportawnt = isTaskImportant;
			_isTaskFullDay = isTaskFullDay;
		}

		public void AddTask()
		{
			
		}
	}
}



/* 			c[0] = comment;
File.WriteAllLines(path, c);		
		Console.WriteLine("Zadanie zostało zapisane ");

		return comment;
		public TaskModel
		{
		taskList = new List<string>();
		}

		<float> taskList
	public string Zadanie { get; private set; }

string path = @"C:\Tasks\text.txt";
string[] c;

//		public TaskModel(string zadanie)
//		{
//			Zadanie = zadanie;
//		}


public void AddTask()
{
	Console.WriteLine("napisz treść zadania:");
	string zadanie = Console.ReadLine();
}



public void ShowTasks()
{
	Console.WriteLine($"{Zadanie}");*/
