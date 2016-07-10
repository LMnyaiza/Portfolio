using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical10_Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfStudents;            
            string subjectCode;
            string msg = "", caption = "MARKS FOR ONT1000";            
            int fail = 0, pass = 0, distinction = 0;

            Console.Title = "Student Marks";

            noOfStudents = GetNoOfStudents();
            subjectCode = GetSubjectCode();
            Console.Clear();

            string[] names = new string[noOfStudents];
            int[] marks = new int[noOfStudents];

            for (int number = 0; number < noOfStudents; number++)
            {
                names[number] = GetStudentName(number + 1);
                marks[number] = GetStudentMark(names[number]);
            }

            msg += "NAME\tMARK\tRESULT\n====\t====\t======\n";
            for (int i = 0; i < names.Length; i++)
            {
                msg += names[i] + "\t" + marks[i] + "\t";
                if (marks[i] < 40)
                {
                    msg += "Fail";
                    fail++;
                }
                else if (marks[i] < 75)
                {
                    msg += "Pass";
                    pass++;
                }
                else
                {
                    msg += "Pass with Distinction";
                    distinction++;
                }
                msg += "\n";
            }

            msg += "\n\nNumber of students:\t\t" + noOfStudents;
            msg += "\nSubject code:\t\t" + subjectCode;
            
            msg += "\n\nFailed:\t\t\t" + fail;
            msg += "\nPassed:\t\t\t" + pass;
            msg += "\nPassed with distinction:\t" + distinction;

            msg += "\n\nLowest mark:\t\t" + GetLowestMark(marks);
            msg += "\nHighest mark:\t\t" + GetHighestMark(marks);

            msg += "\n\nClass average:\t\t" + GetStudentAverage(marks).ToString("f2");           

            MessageBox.Show(msg, caption);

            Console.ReadLine();
        }
        static int GetNoOfStudents() 
        { 
            Console.Write("Please enter the number of students in this class: "); 
            return int.Parse(Console.ReadLine()); 
        }
        static int GetLowestMark(int[] marks)
        {
            int lowestMark = 100;

            for (int low = 0; low < marks.Length; low++)
            {
                if (marks[low] < lowestMark)
                    lowestMark = marks[low];
            }
            return lowestMark;
        }
        static int GetHighestMark(int[] marks)
        {
            int highestMark = 0;

            for (int high = 0; high < marks.Length; high++)
            {
                if (marks[high] > highestMark)
                    highestMark = marks[high];
            }
            return highestMark;
        }
        static double GetStudentAverage(int[] marks)
        {
            double average = 0, sum = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            average = sum / marks.Length;
            return average; 
        }
        static string GetSubjectCode() 
        { 
            Console.Write("Please enter the subject code: "); 
            return Console.ReadLine(); 
        }
        static string GetStudentName(int count) 
        { 
            Console.Write("Please enter the name of student {0}: ", count); 
            return Console.ReadLine(); 
        }
        static int GetStudentMark(string studentName)
        {
            int testMark;
            do 
            { 
                Console.Write("Please enter the test mark for {0}: ", studentName); 
                testMark = int.Parse(Console.ReadLine()); 
                if (testMark < 0 || testMark > 100)
                    Console.WriteLine("INVALID TEST MARK. Please re-enter below.");
            } while (testMark < 0 || testMark > 100); Console.WriteLine();
            return testMark;
        }
    }
}
