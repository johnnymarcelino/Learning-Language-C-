using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1

            /*
            
            DateTime dt = new DateTime(2022, 12, 8, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            */

            // Part 2

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
