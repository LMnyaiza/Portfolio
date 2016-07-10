using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical8_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int students;
            int count = 0;
            double avg, sum = 0;
            string name;
            string msg = "";

            Console.Write("Please enter the number of students in your class: ");
            students = int.Parse(Console.ReadLine());

            int[] marks = new int[students];

            msg += "NAME\t\tTEST MARK";
            msg += "\n====\t\t=========\n";

            while (count < students)
            {
                Console.Write("Please enter the name of student " + (count + 1) + ": ");
                name = Console.ReadLine();
                marks[count] = GetTestMark(name);
                msg += name + "\t\t" + marks[count] + "\n";
                sum += marks[count];
                count++;
            }

            Console.ReadLine();

            avg = sum / students;
            msg += "\nCLASS AVERAGE:\t" + avg.ToString("f2");

            MessageBox.Show(msg);
        }
        static int GetTestMark(string studentName)
        {
            int testMark;
            do
            {
                Console.Write("Please enter the test mark for {0}: ", studentName);
                testMark = int.Parse(Console.ReadLine());
                if (testMark < 0 || testMark > 100)
                    Console.WriteLine("INVALID TEST MARK. Please re-enter the mark between 0 and 100 below.");
            } while (testMark < 0 || testMark > 100);
            return testMark;
        }
    }
}
