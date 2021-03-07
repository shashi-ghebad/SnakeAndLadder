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
			int playerOnePosition = INITIAL_POSITION;
			int playerTwoPosition = INITIAL_POSITION;
			bool firstPlayer = true;
			Console.WriteLine("===Hello!!Welcome to Snake Ladder Game!!===");
			Console.WriteLine("Both players are at the starting position");
			while (playerOnePosition != WINNING_POSITION && playerTwoPosition != WINNING_POSITION)
			{
				if (firstPlayer)
				{
					Random value = new Random();
					int diceValue = value.Next(1, 7);
					Console.WriteLine("First Player rolled Dice: " + diceValue);
					int actionTaken = value.Next(0, 3);
					if (actionTaken == NO_PLAY)
					{
						firstPlayer = false;
					}
					else if (actionTaken == LADDER)
					{
						playerOnePosition += diceValue;
						if (playerOnePosition > WINNING_POSITION)
						{
							playerOnePosition -= diceValue;
						}
					}
					else
					{
						firstPlayer = false;
						playerOnePosition -= diceValue;
						if (playerOnePosition < INITIAL_POSITION)
						{
							playerOnePosition = INITIAL_POSITION;
						}
					}
				}
				else
				{
					Random random = new Random();
					int diceValue = random.Next(1, 7);
					Console.WriteLine("Second Player rolled Dice : " + diceValue);
					int actionTaken = random.Next(0, 3);
					if (actionTaken == NO_PLAY)
					{
						firstPlayer = true;
					}
					else if (actionTaken == LADDER)
					{
						playerTwoPosition += diceValue;
						if (playerTwoPosition > WINNING_POSITION)
						{
							playerTwoPosition -= diceValue;
						}
					}
					else
					{
						firstPlayer = true;
						playerTwoPosition -= diceValue;
						if (playerTwoPosition < INITIAL_POSITION)
						{
							playerTwoPosition = INITIAL_POSITION;
						}
					}
				}
			}
			if (playerOnePosition == WINNING_POSITION)
			{
				Console.WriteLine("Player 1 won the game");
			}
			else
			{
				Console.WriteLine("Player 2 won the game");
			}
		}
	}
}
