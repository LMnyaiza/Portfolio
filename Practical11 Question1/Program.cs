using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical11_Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            string subjectCode;
            string msg = "", caption = "MARKS FOR ONT1000";
            string[] names = new string[10];
            int[] marks = new int[10];
            int count = 0;
            int fail = 0, pass = 0, distinction = 0;

            Console.Title = "Student Marks";

            subjectCode = GetSubjectCode();
            Console.WriteLine();
            string studentName = null;

            while (studentName != "X")
            {
                names[count] = GetStudentName(count);
                studentName = names[count];
                if (studentName == "X")
                    break;
                marks[count] = GetStudentMark(names[count]);
                Console.WriteLine();
                count++;
            }

            msg += "NAME\tMARK\tRESULT\n====\t===\t======\n";
            for (int i = 0; i < count; i++)
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
                    msg += "Distinction";
                    distinction++;
                }
                msg += "\n"; 
            }

            msg += "\n\nNumber of students:\t\t" + count;
            msg += "\nSubject code:\t\t" + subjectCode;

            msg += "\n\nFailed:\t\t\t" + fail;
            msg += "\nPassed:\t\t\t" + pass;
            msg += "\nPassed with distinction:\t" + distinction;

            msg += "\n\nLowest mark:\t\t" + LowestMark(marks, count);
            msg += "\nHighest mark:\t\t" + HighestMark(marks, count);

            msg += "\n\nClass average:\t\t" + ClassAverage(marks, count).ToString("f2");

            if (count == 0)
                MessageBox.Show("No student results have been captured!");
            else
                MessageBox.Show(msg, caption);

            Console.ReadLine();
        }
        static string GetSubjectCode()
        {
            Console.Write("Please enter the subject code: ");
            return Console.ReadLine();
        }
        static string GetStudentName(int number)
        {
            Console.Write("Please enter the name of student {0} or Type -X- to stop: ", number + 1);
            return Console.ReadLine();
        }
        static int GetStudentMark(string name)
        {
            Console.Write("Please enter the test mark for {0}: ", name);
            return int.Parse(Console.ReadLine());
        }
        static int LowestMark(int[] marks, int students)
        {
            int lowestMark = 100;
            for (int i = 0; i < students; i++)
            {
                if (marks[i] < lowestMark)
                    lowestMark = marks[i];
            }
            return lowestMark;
        }
        static int HighestMark(int[] marks, int students)
        {
            int highestMark = 0;
            for (int i = 0; i < students; i++)
            {
                if (marks[i] > highestMark)
                    highestMark = marks[i];
            }
            return highestMark;
        }
        static double ClassAverage(int[] marks, int items)
        {
            double avg, sum = 0;            
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }            
            avg = sum / items;
            return avg;
        }
    }
}
