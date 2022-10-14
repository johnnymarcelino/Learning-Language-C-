using System;
using System.Collections.Generic;
namespace Lists {
    internal class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();
            //List<string> list1 = new List<string>(args);
            //List<string> list2 = new List<string> { "Johnny", "Gabriel"};

            //list.Add(list[0]);
            list.Add("Johnny");
            list.Add("Ana");
            list.Add("João");
            list.Add("Ítallo");
            list.Add("Maria");
            list.Add("Bob");

            list.Insert(3, "Alex");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: " + list.Count);

            // EXPRESSÃO LAMBADA

            string s = list.Find(c => c[0] == 'A'); // QUERO O OBJETO (C) TAL QUE (C) É IGUAL A "B"
            Console.WriteLine("First 'A': " + s); // IMPRIME A PRIMEIRA LETRA DA POSIÇÃO

            // Não se pode utilizar aspas duplas pois é um booleano => nem char nem string, só (utf-16)
            string s2 = list.FindLast(x => x[0] == 'A');  // IMPRIME A ÚLTIMA LETRA DA POSIÇÃO
            Console.WriteLine("Last 'A': " + s2);

            // encontrar a primeira posição que começa com a letra "A"
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position is: " + pos1);

            // encontrar a primeira posição que começa com a letra "A"
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position is: " + pos2);

            // declara-se primeiro uma lista para armazanar os itens
            List<string> list2 = list.FindAll(item => item.Length == 3);
            Console.WriteLine("=====================");
            //Console.WriteLine(list2);

            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("==========================");

            list.Remove("Ana");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------");

            list.RemoveAll(item => item[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("=========================");

            // RemoveAll -> remove o elemento pela posição exata
            list.RemoveAt(2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            // RemoveRange -> remove os elementos de uma faixa
            list.RemoveRange(2, 2);
            foreach (string obj1 in list) {
                Console.WriteLine(obj1);
            }
        }

        // FUNÇÃO DE PREDICATO

        //static bool Test(string a) {
        //    return a[0] == 'A';
        //}
    }
}
