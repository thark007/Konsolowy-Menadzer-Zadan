using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_1
{
    class ConsoleEx
    {
		public static void WriteLine(string text, ConsoleColor consoleColor)
		{
			Console.ForegroundColor = consoleColor;
			Console.WriteLine(text);
			Console.ResetColor();
		}

		public static void Write(string text, ConsoleColor consoleColor)
		{
			Console.ForegroundColor = consoleColor;
			Console.WriteLine(text);
			Console.ResetColor();
		}

		internal static void WriteLine(string v)
		{
			throw new NotImplementedException();
		}
	}
}
