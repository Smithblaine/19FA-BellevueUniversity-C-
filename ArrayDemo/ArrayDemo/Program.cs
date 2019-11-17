//Blaine Smith
//11-16-2019
//Bellevue University
//Assignment 4.2
//This program allows a user to store a set of numbers and will allow the user to print a standard and reverse order along with picking which number to see.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int stopFlag = 4;
            int [] userTen = new int [10];
            bool userInput;
            int userChoice = 0;
            int position = 0;

            WriteLine("Please enter in 10 numbers: ");

                for (int i = 0; i <= 9; i++)
                {
                    Write("\nEnter in your " + "{0} " + "digit: ", i+1);
                    int number;
                    userInput = int.TryParse(ReadLine(), out number);

                    if (userInput == false)
                    {
                        Write("Please enter in a valid number: ");
                        userInput = int.TryParse(ReadLine(), out number);
                    }
                    userTen[i] = number;
                }

            while (userChoice != stopFlag)
            {
                WriteLine("\n(1) to view the list in order from the first to last position in the stored array\n"+
                            "(2) to view the list in order from the last to first position\n"+
                            "(3) to choose a specific position to view\n" +
                            "(4) to quit the application");

                userChoice = int.Parse(ReadLine());

                switch (userChoice)
                {
                    case 1:

                        for (int i = 0; i < userTen.Length; i++)
                        {
                            Write(userTen[i] + "  ");
                        }
                        break;
                    case 2:

                        Array.Reverse(userTen);
                        for (int i = 0; i < userTen.Length; i++)
                        {
                            Write(userTen[i] + "  ");
                        }
                        Array.Reverse(userTen);
                        break;
                    case 3:

                        Write("Enter in the number position you would like to see (0-9): ");
                        position = int.Parse(ReadLine());
                        WriteLine("The number you have choosen to see is: {0}", userTen[position]);
                        break;
                    case 4:
                    
                        break;
                }
            }
            


        }
    }
}
