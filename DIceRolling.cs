using System;

namespace DiceRolling
{
    class C#GameFinale
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** This is a Dice Rolling Game - You will be given 5 Chances - Press Enter to start **");
            Console.ReadLine();

            Console.Write("Enter your name: ");
            string nameuser = Console.ReadLine();
            Console.WriteLine("Welcome to The Game! " + nameuser + " would be playing against the Computer.");

            int computerpoints = 0;
            int userpoints = 0;
            int i = 0;

            // Create a single instance of the Random class outside the loop
            Random random = new Random();

            while (i < 5)
            {
                Console.WriteLine("\nPress Enter to Roll the dice:");
                Console.ReadLine();

                int userMove = random.Next(1, 7);
                Console.WriteLine("Your Move: " + userMove);
                PrintDice(userMove);

                int computerMove = random.Next(1, 7);
                Console.WriteLine("Computer Move: " + computerMove);
                PrintDice(computerMove);

                if (userMove > computerMove)
                {
                    Console.WriteLine("\nYou win! Let's GO!");
                    userpoints++;
                }
                else if (userMove < computerMove)
                {
                    Console.WriteLine("\nYou lose :(  / Try Again!");
                    computerpoints++;
                }
                else
                {
                    Console.WriteLine("\nIt's a tie! Cause Both You and the computer rolled " + userMove);
                }

                Console.WriteLine("Computer Points - " + computerpoints + " & Your Points - " + userpoints);
                i++;
            }

            if (computerpoints > userpoints)
            {
                Console.WriteLine("\nComputer wins! as Overall points are / Computer Points - " + computerpoints + " & Userpoints - " + (userpoints));
            }
            else if (computerpoints == userpoints)
            {
                Console.WriteLine("\nWould you believe it, It's a tie! as overall points are / Computer Points - " + computerpoints + " & Userpoints - " + (userpoints));
            }
            else
            {
                Console.WriteLine("\nYou win! as overall points are / Computer Points - " + computerpoints + " & Userpoints - " + (userpoints));
            }

            Console.WriteLine("\nThank You For Playing! Press Enter to exit the Game.");
            Console.ReadLine();
        }

        static void PrintDice(int diceValue)
        {
            // Create an array of dice faces using ASCII art
            string[] diceFaces =
            {
                "+-------+\n" +
                "|       |\n" +
                "|   *   |\n" +
                "|       |\n" +
                "+-------+",

                "+-------+\n" +
                "| *     |\n" +
                "|       |\n" +
                "|     * |\n" +
                "+-------+",

                "+-------+\n" +
                "| *     |\n" +
                "|   *   |\n" +
                "|     * |\n" +
                "+-------+",

                "+-------+\n" +
                "| *   * |\n" +
                "|       |\n" +
                "| *   * |\n" +
                "+-------+",

                "+-------+\n" +
                "| *   * |\n" +
                "|   *   |\n" +
                "| *   * |\n" +
                "+-------+",

                "+-------+\n" +
                "| *   * |\n" +
                "| *   * |\n" +
                "| *   * |\n" +
                "+-------+"
            };

            // Display the dice face for the given value
            if (diceValue >= 1 && diceValue <= 6)
            {
                Console.WriteLine(diceFaces[diceValue - 1]);
            }
        }
    }
}
