
using System;
using System.Runtime.InteropServices;

namespace Snakes_and_Ladder
{
    class Program
    {
        public static int diceRoll()
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 7);

            Console.WriteLine("The number on dice's face is " + diceRoll);
            return diceRoll;
        }

        public static int optionRoll()
        {
            Random rand = new Random();
            int optionRoll = rand.Next(0, 3);

            Console.WriteLine("The option is " + optionRoll);
            return optionRoll;
        }

        static void Main(string[] args)
        {
            int currentPosition = 0;
            int SNAKE = 0;
            int NO_PLAY = 1;
            int LADDER = 2;
            int diceCounter = 0;

            while (currentPosition <= 100)
            //for (int i = 0; i < 500; i++)
            {
                diceCounter++;
                int dice = diceRoll();
                int option = optionRoll();

                if (option == SNAKE)
                {
                    if (currentPosition - dice >= 0)
                    {
                        currentPosition = currentPosition - dice;
                    }
                    else
                    {
                        currentPosition = 0;
                    }
                }

                if (option == NO_PLAY)
                {
                    currentPosition = currentPosition + 0;
                }

                if (option == LADDER)
                {
                    if (currentPosition + dice < 100)
                    {
                        currentPosition = currentPosition + dice;
                    }

                    else if (currentPosition + dice > 100)
                    {
                        currentPosition = currentPosition + 0;
                    }
                    else
                    {
                        currentPosition = currentPosition + dice;
                        break;
                    }
                }
                Console.WriteLine("The final position is " + currentPosition);
                Console.WriteLine("");
            }
            Console.WriteLine("The dice was rolled " + diceCounter + " number of times");
        }
    }
}