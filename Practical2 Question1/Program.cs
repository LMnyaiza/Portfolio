using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical2_Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write("Please enter number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(number1 + " + " +  number2 + " = " + (number1 + number2));
            Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
            Console.ReadLine();
        }
    }
}
