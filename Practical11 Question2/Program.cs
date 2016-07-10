using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical11_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, answer = 0;
            char choice, calculation = '&';

            number1 = GetNumber("Please enter a number: ");
            number2 = GetNumber("Please enter a second number: ");

            Console.Clear();

            choice = GetMenuChoice();

            Console.Clear();

            if (choice == 'A')
            {
                answer = Add(number1, number2);
                calculation = '+';
            }
            else if (choice == 'D')
            {
                answer = Divide(number1, number2);
                calculation = '/';
            }
            else if (choice == 'M')
            {
                answer = Multiply(number1, number2);
                calculation = 'x';
            }
            else if (choice == 'R')
            {
                answer = Remainder(number1, number2);
                calculation = '%';
            }
            else if (choice == 'S')
            {
                answer = Subtract(number1, number2);
                calculation = '-';
            }
            else
            {
                ;
            }

            if (choice != 'X')
                Display(number1, number2, answer, calculation);
            else
                Console.ReadLine();
        }
        static double GetNumber(string prompt) 
        { 
            Console.Write(prompt);      
            return double.Parse(Console.ReadLine()); 
        }          
        static char GetMenuChoice() 
        {      
            char menuChoice = ' ';
            bool validChoice = false;
            while (validChoice == false)
            {          
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("====");
                Console.WriteLine("A) Add");
                Console.WriteLine("D) Divide");
                Console.WriteLine("M) Multiply");
                Console.WriteLine("R) Remainder");
                Console.WriteLine("S) Subtract");
                Console.WriteLine("X) Exit");
                Console.Write("\nPlease enter your choice (A,D,M,R,S, or X): ");
                menuChoice = char.Parse(Console.ReadLine());
                switch(menuChoice)
                {
                    case 'a':
                    case 'A':
                        menuChoice = 'A';
                        validChoice = true;
                        break;
                    case 'd':
                    case 'D':
                        menuChoice = 'D';
                        validChoice = true;
                        break;
                    case 'm':
                    case 'M':
                        menuChoice = 'M';
                        validChoice = true;
                        break;
                    case 'r':
                    case 'R':
                        menuChoice = 'R';
                        validChoice = true;
                        break;
                    case 's':
                    case 'S':
                        menuChoice = 'S';
                        validChoice = true;
                        break;
                    case 'x':
                    case 'X':
                        menuChoice = 'X';
                        validChoice = true;
                        break;
                    default : 
                        validChoice = false;
                        break;
                }
            } // end while loop   
            return menuChoice; 
        }   
        static double Add(double number1, double number2)
        {
            return number1 + number2;
        }  
        static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }  
        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }  
        static double Remainder(double number1, double number2)
        {
            return number1 % number2;
        }  
        static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }  
        static void Display(double number1, double number2, double answer, char calculation)
        {
            Console.Clear();
            Console.WriteLine("{0} {1} {2} = {3}", number1, calculation, number2, answer);
            Console.Write("\nPlease press ENTER to continue...");
            Console.ReadLine();
        }
    }
}