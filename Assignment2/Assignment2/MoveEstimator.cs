//Blaine Smith
//10-31-2019
//Bellevue University
//Assignment 1.3
//This program shows the use of variables while using those variable to output data that a user has entered into the system.

using System;
using static System.Console;

namespace Assignment2
{
    class MoveEstimator
    {
        static void Main(string[] args)
        {
            int perMile = 2;
            int baseRateCharge = 200;
            int perHour = 150;
            int miles;
            int hours;
            int total;

            WriteLine("Welcome to Malcolm Movers");
            Write("\nHow many miles will you be moving away from your current location:  ");

            miles = int.Parse(ReadLine());

            Write("\nHow many hours will you be in need of our services?  ");

            hours = int.Parse(ReadLine());

            total = baseRateCharge + (perMile * miles) + (perHour * hours);

            WriteLine("Your total comes to : {0:C} ", total);
        }
    }
}
