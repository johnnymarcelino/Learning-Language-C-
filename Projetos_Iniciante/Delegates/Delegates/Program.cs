using Delegates.Entities;
using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {

        // trabalhando com delegate Action


        static void Main(string[] args)
        {
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
    }
}
