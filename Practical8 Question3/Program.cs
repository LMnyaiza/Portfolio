using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical8_Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args.ToString());
            //Console.WriteLine(args.Length);
            //Console.WriteLine(args.GetType());

            double num1, num2, answer;
            string userAnswer;

            Console.Write("Please enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            num2 = int.Parse(Console.ReadLine());
            
            do
            {
                Console.Clear();
                userAnswer = Menu();
                if (userAnswer == "A" || userAnswer == "a")
                {
                    Console.Clear();
                    answer = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + answer);
                    Console.WriteLine("Please press ENTER to continue...");
                    Console.ReadLine();
                }
                else if (userAnswer == "D" || userAnswer == "d")
                {
                    Console.Clear();
                    answer = num1 / num2;
                    Console.WriteLine(num1 + " / " + num2 + " = " + answer);
                    Console.WriteLine("Please press ENTER to continue...");
                    Console.ReadLine();
                }
                else if (userAnswer == "M" || userAnswer == "m")
                {
                    Console.Clear();
                    answer = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + answer);
                    Console.WriteLine("Please press ENTER to continue...");
                    Console.ReadLine();
                }
                else if (userAnswer == "R" || userAnswer == "r")
                {
                    Console.Clear();
                    answer = num1 % num2;
                    Console.WriteLine(num1 + " % " + num2 + " = " + answer);
                    Console.WriteLine("Please press ENTER to continue...");
                    Console.ReadLine();
                }
                else if (userAnswer == "S" || userAnswer == "s")
                {
                    Console.Clear();
                    answer = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + answer);
                    Console.WriteLine("Please press ENTER to continue...");
                    Console.ReadLine();
                }
            } while (userAnswer != "X" && userAnswer != "x");

            Console.ReadLine();
        }
        static string Menu()
        {
            string instruction;
            Console.WriteLine("MENU\n====");
            Console.WriteLine("A) Add\nD) Divide\nM) Multiply\nR) Remainder\nS) Subtract\nX) Exit\n");
            Console.Write("Please enter your choice (A,D,M,R,S, or X): ");
            instruction = Console.ReadLine();
            return instruction;
        }
    }
}
