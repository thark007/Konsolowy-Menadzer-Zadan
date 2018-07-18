using System;
using System.Collections.Generic;
using System.IO;

namespace Workshop_1
{
	public class TaskModel
	{
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
