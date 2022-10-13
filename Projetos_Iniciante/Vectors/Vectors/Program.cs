using System;
using System.Globalization;

namespace Vectors {
    internal class Program {
        static void Main(string[] args) {

            // VECTORS PART I
            /*
            Problema exemplo 1:
            Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            Armazene as N alturas em um vetor. Em seguida, mostrar a altura média 
            dessas pessoas.
            */

            //PROJECT I

            /*
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("Average Height is: " + avg.ToString("f2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Average Height is: " + avg);
            */


            // VECTORS PART II
            /*
            Problema exemplo 2:
            Fazer um programa para ler um número inteiro N e os dados (nome e
            preço) de N Produtos. Armazene os N produtos em um vetor. Em
            seguida, mostrar o preço médio dos produtos.
            */

            // PROJECT II
            Console.WriteLine("How many products will you buy at market ? ");
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter with the name and price of the products");
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products[i] = new Product { Name = name, Price = price };
            }
            double priceAvarege = 0;
            for (int i = 0; i < products.Length; i++) {
                priceAvarege += products[i].Price;
            }
            Console.WriteLine("Average Price: " + (priceAvarege / n).ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
