using System;
using System.Globalization;

namespace CLASS_02 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine(args.Length);

            Product p = new Product();

            Console.WriteLine("Enter with the products data: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity storage: ");
            p.Quantidade = int.Parse(Console.ReadLine());

        }
    }
}
