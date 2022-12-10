using Delegates.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Delegates
{
    internal class Program
    {



        static void Main(string[] args)
        {


            /*

            // trabalhando com delegate Action

                List<Products> list = new List<Products>();

                list.Add(new Products("Tv", 900.00));
                list.Add(new Products("Mouse", 50.00));
                list.Add(new Products("Tablet", 3500.00));
                list.Add(new Products("HD case", 80.00));

                Action<Products> act = UpdatePrice;  // dessa forma tambem funciona
                list.ForEach(act);  // dessa forma tambem funciona
                // ou podemos trabalhar com a expressao lambda
                Action<Products> act2 = p => { p.Price += p.Price * 0.1; };  // passar entre chaves pois tem que ser uma função void n retorna so atualiza
                list.ForEach(act2);  // dessa forma tambem funciona


                //list.ForEach(p => { p.Price += p.Price * 0.1; });  // recebe uma expressao lambda dentro da propria função
                list.ForEach(UpdatePrice);  // recebe um Action do tipo do objeto passado
                foreach (Products p in list)
                {
                    Console.WriteLine(p);
                }
            }

            public static void UpdatePrice(Products p)
            {
                p.Price += p.Price * 0.1;
            }

            */



            // trabalhando com delegate Func

            List<Products> list = new List<Products>();

            list.Add(new Products("Tv", 900.00));
            list.Add(new Products("Mouse", 50.00));
            list.Add(new Products("Tablet", 3500.00));
            list.Add(new Products("HD case", 80.00));

            // utilizando a função ou metodo puro para passar como objetovo

            Func<Products, string> func = NameUpper;  // passa o tipo e o resultado em qual tipo
            List<string> result = list.Select(func).ToList();

            // utilizando a expressão lambada para passar como objetovo
            Func<Products, string> func2 = p => p.Name.ToUpper();  // passa o tipo e o resultado em qual tipo
            List<string> result2 = list.Select(func2).ToList();

            // utilizando a expressão inline do lambda para passar como objetovo
            List<string> result3 = list.Select(p => p.Name.ToUpper()).ToList();

            List<string> result4 = list.Select(NameUpper).ToList();
            foreach (string item in result4)
            {
                Console.WriteLine(item);
            }

        }

        public static string NameUpper(Products products)
        {
            return products.Name.ToUpper();
        }

    }
}
