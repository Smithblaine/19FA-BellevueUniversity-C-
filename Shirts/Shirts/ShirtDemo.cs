//Blaine Smith
//11-24-2019
//Bellevue University
//Assignment 5.3
//This program shows the useage of using objects and displaying each objects parameters to the user.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Shirts
{
    class ShirtDemo
    {
        static void Main(string[] args)
        {
            Shirt shirt1, shirt2, shirt3, shirt4;

            shirt1 = new Shirt();
            shirt2 = new Shirt();
            shirt3 = new Shirt();
            shirt4 = new Shirt();

            shirt1.Size = "XS";
            shirt1.Color = "PINK";
            shirt1.Material = "COTTON";

            shirt2.Size = "L";
            shirt2.Color = "BLUE";
            shirt2.Material = "POLYESTER";

            shirt3.Size = "XXL";
            shirt3.Color = "TEAL";
            shirt3.Material = "COTON/POLYESTER";

            shirt4.Size = "XXXL";
            shirt4.Color = "RED";
            shirt4.Material = "POLYESTER";

            Display(shirt1, shirt2, shirt3, shirt4);
            WriteLine();
            Display(shirt1, shirt2);
        }

        public static void Display(params Shirt [] shirts)
        {
            WriteLine("{0, -12}{1, -10}{2, -6}","Size", "Color", "Material");
            foreach (Shirt shirt in shirts)
            {
                WriteLine(" {0, -11}{1, -10}{2, -6}", shirt.Size, shirt.Color,shirt.Material);
            }
        }
    }

    class Shirt
    {
        public string Material
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public string Size
        {
            get;
            set;
        }
    }
}
