using System;
using System.Globalization;

namespace WHILE {
    internal class Program {
        static void Main(string[] args) {
            //Console.Write("Enter with a number: ");
            //double x = double.Parse(Console.ReadLine());
            double x;

            while (true) {
                Console.Write("Enter with any number: ");
                x = double.Parse(Console.ReadLine());
                if (x > 0) {
                    Console.WriteLine(Math.Sqrt(x).ToString("f3", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("This number is negative!");
                    break;
                }
            }
        }
    }
}
