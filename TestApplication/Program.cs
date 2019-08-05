using System;
using System.Threading;

namespace TestApplication
{
	class Program
	{
		private const string picture =
			"000001111000000000000000000111\n" +
			"000001111000000000000000000111\n" +
			"000001111000000000000000000111\n" +
			"000001111000000000000000000111\n" +
			"000001111000000000000000000111\n" +
			"000001111000000000000000000111\n";

		static void Main(string[] args)
		{
			Console.Title = "New game";

			int x = 0, y = 0;


			for (int i = 0; i < picture.Length; i++)
			{
				Console.Write(picture[i]);
				Thread.Sleep(50);
			}

			ConsoleKey key;
			while ((key = Console.ReadKey(false).Key) != ConsoleKey.Escape)
			{
				switch (key)
				{
					case ConsoleKey.RightArrow:
						x++;
						break;
					case ConsoleKey.LeftArrow:
						x--;
						break;
					case ConsoleKey.UpArrow:
						y--;
						break;
					case ConsoleKey.DownArrow:
						y++;
						break;
				}
				Console.SetCursorPosition(x, y);
				Console.Write('0');
			}

			Console.WriteLine("End");
			Console.ReadKey();
		}

		static void DoWork(int number)
		{
			if (number > 5)
			{
				Console.WriteLine("Number is greater than 5");
			}
			else if (number < 3)
			{
				Console.WriteLine();
			}
			else if (number < 0)
			{
				Console.WriteLine();
			}
		}
	}
}
