using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, depth;
            double perimeter, surfaceArea, volume;

            Console.WriteLine("PLEASE ENTER THE REQUIRED DATA BELOW");
            Console.Write("Pool length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Pool width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Pool depth: ");
            depth = double.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("POOL DETAILS:");
            Console.WriteLine("============");
            Console.WriteLine("Length:\t\t" + length.ToString("f2"));
            Console.WriteLine("Width:\t\t" + width.ToString("f2"));
            Console.WriteLine("Depth:\t\t" + depth.ToString("f2"));
            
            perimeter = (length * 2) + (width * 2);
            surfaceArea = length * width;
            volume = length * width * depth;
            Console.WriteLine("Perimeter:\t" + perimeter.ToString("f2"));
            Console.WriteLine("Surface Area:\t" + surfaceArea.ToString("f2"));
            Console.WriteLine("Volume:\t\t" + volume.ToString("f2"));
            Console.ReadLine();
        }
    }
}
