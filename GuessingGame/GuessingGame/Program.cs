//Blaine Smith
//11-13-2019
//Bellevue University
//Assignment 3.2
//This program allows a user to guess a randomly generated number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();

            int guess;
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 11);
            Write(randomNumber);
            Write("Guess a number between 1 - 10");
            


            do
            {
                Write("Enter your guess: ");
                guess = int.Parse(ReadLine());
                if (guess > randomNumber)
                {
                    WriteLine("\nYou guessed High");
                }
                else if (guess < randomNumber)
                {
                    WriteLine("\nYou guessed Low");
                }
                else
                {
                    WriteLine("\nYou guessed Correctly");
                }
            } while (guess != randomNumber);

        }
    }
}
