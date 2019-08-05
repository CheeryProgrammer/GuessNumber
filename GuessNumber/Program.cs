using System;
using GuessNumberGameEngine;

namespace GuessNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			GreetAndStartGame();

			Game game = new Game(256, 512, 10);
			
			while (game.IsGuessing())
			{
				int response = AskForSuccess(game.GetSuggestion(), game.GetAttemptsCount());

				if (response == 0)
				{
					Console.WriteLine("Cool! Thank you");
					return;
				}

				game.CorrectSuggestion(response);
			}

			Console.WriteLine("Are you cheating me?!");
		}

		private static int AskForSuccess(int suggestion, int attemptsRemain)
		{
			Console.WriteLine($"Is it {suggestion}? (Only {attemptsRemain - 1} attempts remain).");
			Console.WriteLine($"[0] - yes!  [1] - my number is greater  [2] - my number is less");
			string userResponse = Console.ReadLine();
			if (userResponse == "0")
				return 0;
			if (userResponse == "1")
				return 1;
			if (userResponse == "2")
				return 2;

			return 0;
			/*
			 return int.Parse(userResponse);
			 */
		}

		private static void GreetAndStartGame()
		{
			Console.WriteLine("Hello. Welcome to Guess Number!!!");
			Console.WriteLine("Please, guess a number from 1 to 1023 and press Enter");
			Console.WriteLine("I will try to guess in 10 attempts.");
			Console.ReadLine();
		}
	}
}
