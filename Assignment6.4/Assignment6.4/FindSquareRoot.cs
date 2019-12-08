//Blaine Smith
//11-30-2019
//Bellevue University
//Assignment 6.3
//This program allows a user to enter a number and the program will then test the user input and respond accordingly.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Assignment6._3
{
    class FindSquareRoot
    {
        static void Main(string[] args)
        {
            double number;
            double sqrt;

            try
            {
                Write("Please Enter a number:  ");

                if (!double.TryParse(ReadLine(), out number))
                {
                    WriteLine("The number entered is not a double");
                }
                if (number < 0)
                {
                    throw (new ApplicationException("Number can not be negative."));
                }
                sqrt = Math.Sqrt(number);
            }
            catch (ApplicationException e)
            {
                WriteLine("Error: {0}", e.Message);
                sqrt = 0;
            }
            WriteLine("Square root is {0}", sqrt);
        }
    }
}
