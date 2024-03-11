/*
using System;

namespace Program
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                string thewordtoguess = "Ravi";
                int i = 0;
                string userinputoftheword;
                Console.WriteLine("** This is the guessing Game - You will only get 10 chances - Press Enter to continue **");
                Console.ReadLine();
                Console.WriteLine("Hint --> The word starts with the letter '{0}'.", thewordtoguess[0]);
                while (i < 10)
                {
                    Console.WriteLine("Enter your guess: ");
                    userinputoftheword = Console.ReadLine();

                    if (thewordtoguess == userinputoftheword)
                    {
                        Console.WriteLine("Congratulations! You guessed the word Right on your Chance-" + (i + 1) + ".");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Oops! Wrong guess you wasted your Chance-" + (i + 1) + ". Try Again!");
                        i++;
                    }
                }

                if (i == 10)
                {
                    Console.WriteLine("\nYou lose! You exhausted all your chances.");
                }

                Console.ReadLine();
            }
            catch(Exception any)
            {
                Console.WriteLine(any.Message);
            }
        }
    }
}
*/
