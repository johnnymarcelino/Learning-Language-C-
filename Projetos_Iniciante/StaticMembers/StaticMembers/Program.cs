using System;
using System.Globalization;

namespace StaticMembers {
    internal class Program {

        static void Main(string[] args) {

            Console.Write("Enter with the value of radious: ");
            double radious = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circumference(radious);
            double volum = Calculator.Volume(radious);

            Console.WriteLine("Circumference: " + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volum.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Value of PI: " + Calculator.Pi.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
