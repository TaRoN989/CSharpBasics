using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            int numberOfAttempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have chosen a number between 1 and 100. Can you guess what it is?");

            while (userGuess != numberToGuess)
            {
                numberOfAttempts++;
                Console.Write("Enter your guess: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userGuess))
                {

                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {numberOfAttempts} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("Thank you for playing the Number Guessing Game!");
            Console.ReadKey();
        }
    }
}
