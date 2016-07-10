using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer1, userAnswer2, userAnswer3;
            int mark = 0;
            bool isCorrect = false;
            const int NUMBER_OF_QUESTIONS = 3;
            const string QUESTION1 = "Which country hosted the 2010 FIFA World Cup? ";
            const string QUESTION2 = "Which movie won the Best Picture award at the 2011 Oscar awards? ";
            const string QUESTION3 = "Who won the award for Best R&B Male Vocals at the 2011 Grammy awards? ";
            string[] answer1 = { "South Africa", "south africa", "South africa", "south Africa"};
            string[] answer2 = { "The king's Speech", "the king's Speech", "The kings Speech", "the kings Speech", "The king's speech", "The kings speech", "The King's Speech", "The Kings Speech" };
            string[] answer3 = { "Usher", "usher"};


            Console.Title = "PLEASE ANSWER ALL QUESTIONS";
            Console.WriteLine("PLEASE ANSWER ALL OF THE TEST QUESTIONS BELOW:");
            Console.WriteLine("=============================================");
            Console.Write("1) " + QUESTION1);
            userAnswer1 = Console.ReadLine();
            Console.Write("2) " + QUESTION2);
            userAnswer2 = Console.ReadLine();
            Console.Write("3) " + QUESTION3);
            userAnswer3 = Console.ReadLine();

            Console.Clear();            
            Console.Title = "YOUR RESULTS";
            Console.WriteLine("TEST MEMO:");
            Console.WriteLine("=========");
            Console.WriteLine("\n");
            Console.WriteLine("QUESTION 1");
            Console.WriteLine("==========");
            Console.WriteLine("Question: " + QUESTION1);
            Console.WriteLine("Correct Answer: " + answer1[0]);
            Console.WriteLine("Your Answer: " + userAnswer1);
            for (int i = 0; i < answer1.Length; i++)
            {
                if (userAnswer1 == answer1[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Result: Correct");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    mark++;
                    isCorrect = true;
                }
            }
            if (isCorrect == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: Incorrect");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine("\n");
            Console.WriteLine("QUESTION 2");
            Console.WriteLine("==========");
            Console.WriteLine("Question: " + QUESTION2);
            Console.WriteLine("Correct Answer: " + answer2[0]);
            Console.WriteLine("Your Answer: " + userAnswer2);
            for (int i = 0; i < answer2.Length; i++)
            {
                if (userAnswer2 == answer2[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Result: Correct");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    mark++;
                    isCorrect = true;
                }
            }
            if (isCorrect == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: Incorrect");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("\n");
            Console.WriteLine("QUESTION 3");
            Console.WriteLine("==========");
            Console.WriteLine("Question: " + QUESTION3);
            Console.WriteLine("Correct Answer: " + answer3[0]);
            Console.WriteLine("Your Answer: " + userAnswer3);
            for (int i = 0; i < answer3.Length; i++)
            {
                if (userAnswer3 == answer3[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Result: Correct");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    mark++;
                }
            }
            if (isCorrect == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: Incorrect");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
            Console.WriteLine("You got {0} questions correct out of {1}", mark, NUMBER_OF_QUESTIONS);
            Console.ReadLine();
        }
    }
}
