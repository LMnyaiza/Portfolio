using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical2_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double rate = 0;
            string tempRate;
            double hours;
            double overtime;
            double pay;
            double overtimePay;

            Console.Write("Please enter the employee's name: ");
            name = Console.ReadLine();
            Console.Write("Please enter the employee's hourly rate: ");

            tempRate = Console.ReadLine();
            if (tempRate.Contains('.'))
                tempRate = tempRate.Replace('.', ',');
            rate = double.Parse(tempRate);                           
            
            Console.Write("Please enter the number of normal hours worked: ");
            hours = double.Parse(Console.ReadLine());
            Console.Write("Please enter the number of overtime hours worked: ");
            overtime = double.Parse(Console.ReadLine());

            Console.WriteLine("\nPAYSLIP FOR: " + name + "\n");
            Console.WriteLine("Normal Hours Worked: " + hours);
            Console.WriteLine("Overtime Hours Worked: " + overtime);
            Console.WriteLine("TOTAL HOURS WORKED: " + Math.Round((overtime + hours), 2));

            Console.WriteLine();

            pay = hours * rate;
            overtimePay = overtime * (rate * 1.5);

            Console.WriteLine("Normal Pay: {0:c2}",pay);
            Console.WriteLine("Overtime Pay: {0:c2}", overtimePay);
            Console.WriteLine("TOTAL PAY: {0:c2}", pay + overtimePay);
            Console.ReadLine();
        }
    }
}
