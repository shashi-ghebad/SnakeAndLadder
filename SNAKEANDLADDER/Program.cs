using System;

namespace SnakeAndLadder
{
    class Program
    {
        public const int START_POINT = 0;
        public const int END_POINT = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome To Snake And Lader Problem \nEnter player name");
            string player1 = Console.ReadLine();
            int diceRoll = DiceRoll();
            Console.WriteLine("Dice Roll : " + diceRoll);
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNum = random.Next(1, 7);
            return diceNum;
        }
    }
}