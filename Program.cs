using System;

namespace SnakeAndLadder
{
    class Program
    {
        public const int START_POINT = 0;
        public const int END_POINT = 100;
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome To Snake And Lader Problem \nEnter player name");
            string player1 = Console.ReadLine();
            int playerCurrentPosition = START_POINT;
            for (int noOfTimesDiceRolled = 1; playerCurrentPosition >= 0; noOfTimesDiceRolled++)
            {
                int diceRoll = DiceRoll();
                Console.WriteLine("You rolled: " + diceRoll);
                playerCurrentPosition = PlayerMovement(diceRoll, playerCurrentPosition);
                Console.WriteLine("Your position Number is : " + playerCurrentPosition);
                if (playerCurrentPosition >= 100)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                Console.ReadLine();
            }
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNum = random.Next(1, 7);
            return diceNum;
        }

        static int PlayerMovement(int numbRolled, int postionPlayer)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move)
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case SNAKE:
                    Console.WriteLine("You Are Bitten by Snake");
                    if (postionPlayer - numbRolled >= 0)
                    {
                        postionPlayer = postionPlayer - numbRolled;
                        break;
                    }
                    else
                    {
                        postionPlayer = START_POINT;
                        break;
                    }
                case LADDER:
                    Console.WriteLine("You Got Ladder");
                    postionPlayer = postionPlayer + numbRolled;
                    break;
            }
            return postionPlayer;
        }
    }
}