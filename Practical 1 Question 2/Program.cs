using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_1_Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int currentAge;
            int yearBorn;
            int currentYear = DateTime.Now.Year;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("What age will you turn this year: ");
            //Console.Write("How old are you this year: ");
            currentAge = int.Parse(Console.ReadLine());
            
            yearBorn = currentYear - currentAge;

            Console.WriteLine("{0}, you were born in {1}.", name , yearBorn);
            Console.ReadLine();
        }
    }
}
