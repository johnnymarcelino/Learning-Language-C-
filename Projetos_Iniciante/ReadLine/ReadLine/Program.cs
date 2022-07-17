using System;
using System.Globalization;

namespace ReadLine {
    internal class Program {
        static void Main(string[] args) {

            // Comand ReadLine

            //string fhrase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //Console.WriteLine("You entered: ");
            //Console.WriteLine(fhrase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            // Reserved Word

            // string s = Console.ReadLine();
            //string[] vet = Console.ReadLine().Split(' ');

            // string[] vet = s.Split(" ");
            // string[] vet = Console.ReadLine.Split(" ");
            //string p1 = vet[0];
            //string p2 = vet[1];
            //string p3 = vet[2];
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            // Comand ReadLine - Part 2

            //int n1 = int.Parse(Console.ReadLine());
            //char n2 = char.Parse(Console.ReadLine());
            //double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //string[] vet = Console.ReadLine().Split(" ");

            //Console.WriteLine("Your name is: " + vet[0]);
            //Console.WriteLine("Your genre is: " + vet[1]);
            //Console.WriteLine("You are: " + vet[2] + " years old");
            //Console.WriteLine("You are: " + vet[2] + " meters");

            string[] vet = Console.ReadLine().Split(" ");

            string name = vet[0];
            int age = int.Parse(vet[1]);
            char genre = char.Parse(vet[2]);
            double tall = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"You are: {age} years old");
            Console.WriteLine($"Your genre is {genre}");
            Console.WriteLine($"You are {tall.ToString("f2", CultureInfo.InvariantCulture)} tall");

            //Console.WriteLine("You typed: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
