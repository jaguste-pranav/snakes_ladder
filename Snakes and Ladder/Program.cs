using System;

namespace Snakes_and_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 7);

            Console.WriteLine("The number on dice's face is " + diceRoll);
        }
    }
}