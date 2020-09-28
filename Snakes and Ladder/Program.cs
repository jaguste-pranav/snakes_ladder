using System;

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
            int currentPositionPlayer1 = 0;
            int currentPositionPlayer2 = 0;
            int SNAKE = 0;
            int NO_PLAY = 1;
            int LADDER = 2;
            int diceCounter = 0;

            while (currentPositionPlayer1 <= 100 || currentPositionPlayer2 <= 100)
            {
                diceCounter++;
                int dicePlayer1 = diceRoll();
                int optionPlayer1 = optionRoll();

                int dicePlayer2 = diceRoll();
                int optionPlayer2 = optionRoll();

                if (optionPlayer1 == SNAKE)
                {
                    if (currentPositionPlayer1 - dicePlayer1 >= 0)
                    {
                        currentPositionPlayer1 = currentPositionPlayer1 - dicePlayer1;
                    }
                    else
                    {
                        currentPositionPlayer1 = 0;
                    }
                }

                if (optionPlayer1 == NO_PLAY)
                {
                    currentPositionPlayer1 = currentPositionPlayer1 + 0;
                }

                if (optionPlayer1 == LADDER)
                {
                    if (currentPositionPlayer1 + dicePlayer1 < 100)
                    {
                        currentPositionPlayer1 = currentPositionPlayer1 + dicePlayer1;
                    }

                    else if (currentPositionPlayer1 + dicePlayer1 > 100)
                    {
                        currentPositionPlayer1 = currentPositionPlayer1 + 0;
                    }
                    else
                    {
                        currentPositionPlayer1 = currentPositionPlayer1 + dicePlayer1;
                        Console.WriteLine("Player 1 has won!!");
                        break;
                    }
                }
                Console.WriteLine("The final position for player 1 is " + currentPositionPlayer1);

                if (optionPlayer2 == SNAKE)
                {
                    if (currentPositionPlayer2 - dicePlayer2 >= 0)
                    {
                        currentPositionPlayer2 = currentPositionPlayer2 - dicePlayer2;
                    }
                    else
                    {
                        currentPositionPlayer2 = 0;
                    }
                }

                if (optionPlayer2 == NO_PLAY)
                {
                    currentPositionPlayer2 = currentPositionPlayer2 + 0;
                }

                if (optionPlayer2 == LADDER)
                {
                    if (currentPositionPlayer2 + dicePlayer2 < 100)
                    {
                        currentPositionPlayer2 = currentPositionPlayer2 + dicePlayer2;
                    }

                    else if (currentPositionPlayer2 + dicePlayer2 > 100)
                    {
                        currentPositionPlayer2 = currentPositionPlayer2 + 0;
                    }

                    else
                    {
                        currentPositionPlayer2 = currentPositionPlayer2 + dicePlayer2;
                        Console.WriteLine("Player 2 has won!!");
                        break;
                    }

                }
                Console.WriteLine("The final position for player 2 is " + currentPositionPlayer2);
                Console.WriteLine("");

            }
            Console.WriteLine("The dice was rolled " + diceCounter + " number of times");


        }
    }
}