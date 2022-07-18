using System;

namespace Functions {
    internal class Program {
        static void Main(string[] args) {

            // Working with Functions

            Console.WriteLine("Enter with three numbers");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double result = Maior(n1, n2, n3);
            Console.WriteLine($"Bigger = {result}");

            }
        static int Maior(int a, int b, int c) {
            int big;
            if (a > b && a > c) {
                big = a;
            }
            else if (b > c) {
                big = b;
            }
            else {
                big = c;
            }
            return big;
        }
    }
}
