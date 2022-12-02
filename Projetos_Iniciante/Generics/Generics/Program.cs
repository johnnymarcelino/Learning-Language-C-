using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService printservice = new PrintService();

            Console.WriteLine("How many values ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printservice.AddValue(x);
            }

            printservice.Print();
            Console.WriteLine();
            Console.WriteLine("First: " + printservice.First());
        }
    }
}
