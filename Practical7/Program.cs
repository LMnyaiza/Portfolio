using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width;
            int noOfDrawers;
            string woodType;
            double surfaceArea;
            double price = 200;

            Console.Title = "Rick Hammer Carpenters";
            Console.WriteLine("RICK HAMMER CARPENTERS");
            Console.WriteLine("======================");
            Console.WriteLine("Wood choices: Mahogany <M>");
            Console.WriteLine("\t\tOak (O)");
            Console.WriteLine("\t\tPine (P)");
            Console.WriteLine();
            Console.WriteLine("Please enter the requested information below and\na quote for a "
            + "custom built table will be generated.");
            Console.Write("Surface length:\t\t");
            length = double.Parse(Console.ReadLine());
            Console.Write("Surface width:\t\t");
            width = double.Parse(Console.ReadLine());
            Console.Write("Wood (M, O, or P):\t");
            woodType = Console.ReadLine();
            Console.Write("Number of drawers:\t");
            noOfDrawers = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("RICK HAMMER CARPENTERS");
            Console.WriteLine("======================");
            Console.WriteLine("Surface length:\t\t" + length.ToString("f2"));
            Console.WriteLine("Surface width:\t\t" + width.ToString("f2"));
            surfaceArea = length * width;
            Console.WriteLine("Surface area:\t\t" + surfaceArea.ToString("f2") + " square inches");

            if (woodType == "M")
                woodType = "Mahogany";
            else if (woodType == "O")
                woodType = "Oak";
            else
                woodType = "Pine";

            if (surfaceArea > 750)
                price += 50;

            if (woodType == "Mahogany")
                price += 150;
            else if (woodType == "Oak")
                price += 125;
           
            price += noOfDrawers * 30;

            Console.WriteLine("Type of wood:\t\t" + woodType);
            Console.WriteLine("Number of drawers:\t" + noOfDrawers);
            Console.WriteLine("TOTAL DUE:\t\t" + price.ToString("f2"));
            Console.ReadLine();
        }
    }
}
