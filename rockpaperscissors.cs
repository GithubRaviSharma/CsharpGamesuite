
/*using System;

namespace Program
{
    class rockpaperscissors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** This is a rock/paper/scissors game - You will get 5 chances - Press Enter to start **");
            Console.ReadLine();
            int i = 0;
            int computerpoints = 0;
            int userpoints = 0;
            while (i < 5)
            {
                Console.WriteLine("\nRock! Paper! Scissors - What do you want to Play?");
                Console.Write("Your move: ");
                string userinput = Console.ReadLine();
                string[] moves = { "Rock", "Paper", "Scissors" };
                Random random = new Random();
                int randomIndex = random.Next(0, 3);
                string computerMove = moves[randomIndex];
                Console.WriteLine("Computer Move: " + computerMove);
                if (userinput == computerMove)
                {
                    Console.WriteLine("It's a tie both You and the Computer played " + userinput);
                    Console.WriteLine("Computer Points - " + computerpoints + " & User Points - " + userpoints);
                    i++;

                }
                else if (userinput == "Paper" && computerMove == "Scissors")
                {
                    Console.WriteLine("You lose! Try Again ");
                    computerpoints += 1;
                    Console.WriteLine("Computer Points - " + computerpoints + " & User Points - " + userpoints);
                    i++;
                }
                else if (userinput == "Paper" && computerMove == "Rock")
                {
                    Console.WriteLine("Congratulations! You win!");
                    userpoints += 1;
                    Console.WriteLine("Computer Points - " + computerpoints + " & User Points - " + userpoints);
                    i++;
                }
                else if (userinput == "Rock" && computerMove == "Scissors")
                {
                    Console.WriteLine("Congratulations! You win!");
                    userpoints += 1;
                    Console.WriteLine("Computer Points - " + computerpoints + " & User Points - " + userpoints);
                    i++;
                }
                else if (userinput == "Rock" && computerMove == "Paper")
                {
                    Console.WriteLine("You lose! Try Again");
                    computerpoints += 1;
                    Console.WriteLine("Computer Points - " + computerpoints + " & User Points - " + userpoints);
                    i++;
                }
                else if (userinput == "Scissors" && computerMove == "Paper")
                {
                    Console.WriteLine("Congratulations! You win!");
                    userpoints += 1;
                    Console.WriteLine("Computer Points - " + computerpoints + " & User Points - " + userpoints);
                    i++;
                }
                else if (userinput == "Scissors" && computerMove == "Rock")
                {
                    Console.WriteLine("You lose! Try Again");
                    computerpoints += 1;
                    Console.WriteLine("Computer Points - " + computerpoints + " & " +
                        "User Points - " + userpoints);
                    i++;
                }
                else
                {
                    Console.WriteLine("\nInvalid Input - Note you can only Choose b/w - Rock/Paper/Scissors");
                }
            }
                if(computerpoints > userpoints)
                {
                    Console.WriteLine("\nComputer wins! as Overall points are / Computer Points - " + computerpoints + " & Userpoints - " + (userpoints));
                }
                else if (computerpoints == userpoints)
                {
                Console.WriteLine("\nWould you believe it , It's a tie! as overall points are / Computer Points - " + computerpoints + " & Userpoints - " + (userpoints));
                }
                else
                {
                    Console.WriteLine("\nYou win! as overall points are / Computer Points - " + computerpoints + " & Userpoints - " + (userpoints));
                }
                Console.WriteLine("\nPress Enter to exit the game");
                Console.ReadLine();
        }
    }
}
*/