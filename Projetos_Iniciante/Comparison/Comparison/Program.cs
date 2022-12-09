using Comparison.Entities;
using System;
using System.Collections.Generic;

namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dessa forma viola o principio solid OCP, pois a classe product não fica fechada para alteração, pois temos o criterio de comparação

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //list.Sort();  // ordena por ordem alfabetica

            // utilizando o Comparison<T> == delegate
            //list.Sort(CompareProducts);  // referenciar a funçao sem parenteses => delegate em C# pois utiliza-se do typesafety | referencia metodo

            /*
            // funciona dessa maneira tambem passando a variavel como referencia do metodo
            Comparison<Product> comp = CompareProducts;

            // utilizando o Comparison<T> == delegate
            list.Sort(comp);  // referenciar a funçao sem parenteses => delegate em C# pois utiliza-se do typesafety | referencia metodo
            */


            //Trabalhando com a função lambda  --> | operador de função =>
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());  // --> função anonima lambda
            //list.Sort(comp);


            // ou podemos trabalhar com a função diretamete dentro do tipo da chamada ==> ou seja: InLine
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }
        
        /*
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        */
    }
}
