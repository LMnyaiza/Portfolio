using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical2_Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            string title;
            string name;
            string lastName;
            string jobTitle;
            string company;
            string tel;
            string cell;
            string fax;
            string email;

            Console.Title = "Data Required to Generate Business Card";
            Console.WriteLine("PLEASE ENTER THE REQUIRED DATA BELOW:");
            Console.WriteLine("====================================");
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("First name: ");
            name = Console.ReadLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();
            Console.Write("Job title: ");
            jobTitle = Console.ReadLine();
            Console.Write("Company: ");
            company = Console.ReadLine();
            Console.Write("Telephone number: ");
            tel = Console.ReadLine();
            Console.Write("Cellphone number: ");
            cell = Console.ReadLine();
            Console.Write("Fax number: ");
            fax = Console.ReadLine();
            Console.Write("E-mail: ");
            email = Console.ReadLine();
            Console.ReadLine();

            Console.Clear();
            Console.Title = "Your business Card";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title + " " + name + " " + lastName);
            Console.WriteLine(jobTitle);
            Console.WriteLine(company);
            Console.WriteLine("\n");
            Console.WriteLine("Office: " + tel);
            Console.WriteLine("Cell: " + cell);
            Console.WriteLine("Fax: " + fax);
            Console.WriteLine("E-mail: " + email);
            Console.ReadLine();
        }
    }
}
