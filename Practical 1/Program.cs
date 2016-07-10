using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            // variation of the readline method
            //ConsoleKeyInfo keyInfo = Console.ReadLine();
            //if (keyInfo.KeyChar == 'a')
            //    Console.Write("Do this");
            //else
            //    Console.Write("Do that");

            int i = 4;
            int x;

            Console.WriteLine(++i + ++i);
            Console.ReadLine();

            x = ++i + ++i; // + ++i;

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
