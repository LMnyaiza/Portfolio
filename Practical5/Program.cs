using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp1, temp2, temp3, temp4, temp5, temp6, temp7;
            int highest;
            int total;
            double avg;
            string msg = "";

            DateTime date1 = DateTime.Now.AddDays(-7);
            DateTime date2 = DateTime.Now.AddDays(-6);
            DateTime date3 = DateTime.Now.AddDays(-5);
            DateTime date4 = DateTime.Now.AddDays(-4);
            DateTime date5 = DateTime.Now.AddDays(-3);
            DateTime date6 = DateTime.Now.AddDays(-2);
            DateTime date7 = DateTime.Now.AddDays(-1);            

            Console.Write("Please enter the highest temperature for " + date1.ToString("dd/MM/yyyy") + ": ");
            temp1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the highest temperature for " + date2.ToString("dd/MM/yyyy") + ": ");
            temp2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the highest temperature for " + date3.ToString("dd/MM/yyyy") + ": ");
            temp3 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the highest temperature for " + date4.ToString("dd/MM/yyyy") + ": ");
            temp4 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the highest temperature for " + date5.ToString("dd/MM/yyyy") + ": ");
            temp5 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the highest temperature for " + date6.ToString("dd/MM/yyyy") + ": ");
            temp6 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the highest temperature for " + date7.ToString("dd/MM/yyyy") + ": ");
            temp7 = int.Parse(Console.ReadLine());
            Console.ReadLine();
            msg += "DATE\t\tTEMPERATURE";
            msg += "\n====\t\t==========";
            msg += "\n" + date1.ToString("dd/MM/yyyy") + "\t\t" + temp1;
            msg += "\n" + date2.ToString("dd/MM/yyyy") + "\t\t" + temp2;
            msg += "\n" + date3.ToString("dd/MM/yyyy") + "\t\t" + temp3;
            msg += "\n" + date4.ToString("dd/MM/yyyy") + "\t\t" + temp4;
            msg += "\n" + date5.ToString("dd/MM/yyyy") + "\t\t" + temp5;
            msg += "\n" + date6.ToString("dd/MM/yyyy") + "\t\t" + temp6;
            msg += "\n" + date7.ToString("dd/MM/yyyy") + "\t\t" + temp7;
            msg += "\n";

            highest = Math.Max(temp1, Math.Max(temp2, Math.Max(temp3, Math.Max(temp4, Math.Max(temp5, Math.Max(temp6, temp7))))));
            total = temp1 + temp2 + temp3 + temp4 + temp5 + temp6 + temp7;
            avg = (double)total / 7;

            msg += "\nHighest Temperature:\t" + highest;
            msg += "\nAverage Temperature:\t" + avg.ToString("f2");
            MessageBox.Show(msg);
        }
    }
}
