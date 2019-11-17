//Blaine Smith
//11-16-2019
//Bellevue University
//Assignment 4.3
//This program will allow a user to enter a total number of books and days to receive the total fine for their past due books.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FineForOverdueBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            double underSeven = .10;
            double overSeven = .30;
            bool numberOfBooks;
            bool daysPast;

            Write("Enter in the number of book you have: ");
            int books;
            numberOfBooks = int.TryParse(ReadLine(), out books);

            Write("\nHow many days are these books past due: ");
            int days;
            daysPast = int.TryParse(ReadLine(), out days);

            OverDueCost(books, days, underSeven, overSeven);
        }


        static void OverDueCost(int book, int day, double under, double over)
        {
            double totalUnder = book * (day * under);
            double totalOver = book * (day * over) - totalUnder;

            if (day <= 7)
            {
                WriteLine("The total fine for {0} book(s),\nFor {1} days at {2:C2} a day is {3:C2}.", book, day, under, totalUnder);
            }
            else if (day > 7)
            {
                WriteLine("The total fine for {0} book(s),\nFor {1} days at {2:C2} a day is {3:C2}.", book, day, over, totalOver);
            }
        }
    }
}
