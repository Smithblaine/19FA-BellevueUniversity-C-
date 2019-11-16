//Blaine Smith
//11-13-2019
//Bellevue University
//Assignment 3.3
//This program allows the user to enter in multiple temperatures and the program will return the average and total number of numbers that were added
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DailyTemps
{
    class Program
    {
        static void Main(string[] args)
        {

            int userStop = -999;
            int counter = 0;
            int userInput = 0;
            int total = 0;

            Write ("Enter the in a valid temperature from -20 to 130 \nTo exit enter (-999)\n");

            do
            {
                Write("\nEnter Temperature: ");
                userInput = int.Parse(ReadLine());

                if (userInput < -20 || userInput > 130)
                {
                    WriteLine("Please enter a number between -20 and 130 degrees");
                }
                else if (userInput == userStop)
                {
                    break;
                }
                else
                {
                    total += userInput;
                    counter++;
                }
            } while (userInput != userStop);

            WriteLine("\nAverage of Temperatures : {0}\nNumber of Temperatures entered {1}", total/counter, counter);
        }

    }
}
