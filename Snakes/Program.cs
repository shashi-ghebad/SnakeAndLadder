using System;

namespace SnakeAndLader
{
	class Program
	{
		public const int NO_OF_PLAYERS = 1;
		public const int INITIAL_POSITION = 0;
		public const int NO_PLAY = 0;
		public const int LADDER = 1;
		public const int SNAKE = 2;
		public const int WINNING_POSITION = 100;
		static void Main(String[] args)
		{
			int curentPosition = INITIAL_POSITION;
			int moves = 0;
			Console.WriteLine("Welcome to snakes and ladders game");
			Console.WriteLine("now Start the game \nPlayer is at the starting position");
			while (curentPosition != WINNING_POSITION)
			{
				Random value = new Random();
				int valueOfDice = value.Next(1, 7);
				Console.WriteLine("Player rolled : " + valueOfDice);
				int actionTaken = value.Next(0, 3);
				if (actionTaken == NO_PLAY)
				{
					Console.WriteLine("No action taken");
				}
				else if (actionTaken == LADDER)
				{
					curentPosition += valueOfDice;
					if (curentPosition > WINNING_POSITION)
					{
						curentPosition -= valueOfDice;
					}
				}
				else
				{
					curentPosition -= valueOfDice;
					if (curentPosition < INITIAL_POSITION)
					{
						curentPosition = INITIAL_POSITION;
					}
				}
				moves++;
				Console.WriteLine("You Are At Position : " + curentPosition);
			}
			Console.WriteLine("You reached exact winning position in : " + moves + " moves");
		}
	}
}
