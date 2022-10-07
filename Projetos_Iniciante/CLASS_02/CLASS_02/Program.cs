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
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity storage: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Products Datas: " + p);
            Console.WriteLine();

            Console.WriteLine("Enter the number of products to add on the storage");
            int qty = int.Parse(Console.ReadLine());
            p.AddProducts(qty);

            Console.WriteLine("Datas updated: " + p);
            Console.WriteLine();

            Console.WriteLine("Enter the number of products to remove on the storage");
            Console.WriteLine();
            qty = int.Parse(Console.ReadLine());
            p.RemoveProducts(qty);
            Console.WriteLine("Datas updated: " + p);
        }
    }
}
