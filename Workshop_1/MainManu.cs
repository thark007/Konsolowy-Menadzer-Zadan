using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_1
{
	class MainManu
	{
		public void showMenu()
		{
		ConsoleEx.WriteLine("KONSOLOWY MANAGER ZADAŃ", ConsoleColor.DarkYellow);
		Console.WriteLine("Wpisz co chcesz zrobić: ");
		Console.WriteLine("wpisz \'ADD\'   aby dodać zadanie");
		Console.WriteLine("wpisz \'SHOW\'   aby pokazać nowe zadania");
		Console.WriteLine("wpisz \'REMOVE\' aby usunąć zadanie");
		Console.WriteLine("wpisz \'SAVE\'   aby zapisać zadanie");
		Console.WriteLine("wpisz \'LOAD\'   aby wczytać zadania");
		Console.WriteLine("wpisz \'EXIT\'   aby wyjść z programu");
		}
		public void backToMenu()
		{
			Console.WriteLine("Naciśnij 'Enter' aby wrócić do Menu");
			Console.ReadLine();
			Console.Clear();
		}
    }
}
