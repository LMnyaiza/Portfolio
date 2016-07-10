using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical6_Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string breed;
            double weight;
            double price;

            Console.Title = "Barking Lot Doggie Day Care";
            Console.WriteLine("BRAKING LOT DOGGIE DAY CARE");
            Console.WriteLine("============================");
            Console.WriteLine("Please enter the following:");
            Console.Write("Dog's name:\t");
            name = Console.ReadLine();
            Console.Write("Dog's breed:\t");
            breed = Console.ReadLine();
            Console.Write("Dog's weight (kg):");
            weight = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("BRAKING LOT DOGGIE DAY CARE");
            Console.WriteLine("============================");
            Console.WriteLine("Bill for:\t" + name + "(" + breed + ")");
            Console.WriteLine("Weight:\t" + weight.ToString("f2") + "kg");

            if (weight <= 8)
                price = 10;
            else if (weight <= 18)
                price = 15;
            else if (weight <= 19)
                price = 20;
            else
                price = 25;

            Console.WriteLine("Day care rate:\t" + price.ToString("c2"));
            Console.ReadLine();
        }
    }
}
