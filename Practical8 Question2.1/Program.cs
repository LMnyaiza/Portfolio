using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical8_Question2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number;
            int sum = 0;
            string msg = "";

            msg += "NUMBERS\n=======\n";

            while (count < 5)
            {
                Console.Write("Please enter any number: ");
                number = int.Parse(Console.ReadLine());
                sum += number;
                msg += number + "\n";
                count++;
            }

            msg += "\nSUM OF NUMBERS: " + sum;

            Console.ReadLine();

            MessageBox.Show(msg);            
        }
    }
}
