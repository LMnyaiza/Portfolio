using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical8_Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAnswer;
            int randomNumber;
            Random number = new Random();
            randomNumber = number.Next(1, 11);
            
            Console.Write("Please enter your guess: ");
            userAnswer = int.Parse(Console.ReadLine());

            while (userAnswer != randomNumber)
            {
                if (userAnswer > randomNumber)
                    Console.WriteLine("WRONG! Your guess was too high. Please guess again.");
                else
                    Console.WriteLine("WRONG! Your guess was too low. Please guess again.");
                Console.Write("Please enter your guess: ");
                userAnswer = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("CONGRATULATIONS! Your guess was correct.");
            Console.ReadLine();
        }
    }
}
