using System;

namespace Conv_Cast {
    internal class Program {
        static void Main(string[] args) {
            // Applying type cast

            //double y = 4.572f;
            //float x = (float)y;
            //Console.WriteLine(x);

            // Values "Truncated"

            //double a;
            //int b;

            //a = 5.1;
            //b = (int)a;
            //Console.WriteLine(b);

            //int a = 5;
            //int b = 2;

            //double result = (double) a / b;

            //Console.WriteLine(result);

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            //double n4 = (double)10 / 8;
            double n4 = 10.0 / 8;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            // calculating Delta x1 and x2

            double a = 1.0, b = -3.0, c = -4.0;

            //double delta = b * b - 4.0 * a * c;
            double delta = Math.Pow(b, 2) - 4 * a * c;
            
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"{delta:f2}");
            Console.WriteLine($"{x1:f2}");
            Console.WriteLine($"{x2:f2}");
        }
    }
}
