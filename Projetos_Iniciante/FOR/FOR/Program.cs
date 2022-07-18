using System;

namespace FOR {
    internal class Program {
        static void Main(string[] args) {

            // Working with structure FOR

            Console.Write("How many integer numbers would you like to enter? ");
            double times = double.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i <= times; i++) {
                Console.Write($"Enter with the {i}º number: ");
                double numbers = double.Parse(Console.ReadLine());
                Console.WriteLine(numbers);
                sum += numbers;
            }
            Console.WriteLine($"The sum between the values is: {sum}");
        }
    }
}
