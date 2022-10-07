using System;
using System.Globalization;

namespace CLASS {
    internal class Program {
        static void Main(string[] args) {

            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter with the measures of the triangle X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Enter with the measures of the triangle Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"The area of the triangle X is {areaX.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"The area of the triangle Y is {areaY.ToString("F2", CultureInfo.InvariantCulture)}");
            if (areaX > areaY) {
                Console.WriteLine($"This area is the biggest: {areaX.ToString("F2", CultureInfo.InvariantCulture)} -> triangle X");
            }
            else {
                Console.WriteLine($"This area is the biggest {areaY.ToString("F2", CultureInfo.InvariantCulture)} -> triangle Y");
            }
        }
    }
}
