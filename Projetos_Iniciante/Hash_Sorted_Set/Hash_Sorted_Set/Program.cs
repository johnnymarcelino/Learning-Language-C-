using System;
using System.Collections.Generic;

namespace Hash_Sorted_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("tv"));

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            */

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10};

            //PrintCollection(s);

            // união de conjuntos
            SortedSet<int> c = new SortedSet<int>(a);  // instanciando já com os elementos do conjunto a
            c.UnionWith(b);  // união inserindo todos os elementos de b que não estejam em c, não pode ter repetição - conj não aceita repetição
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        // criado uma nova função pós main static para imprimir o conjunto

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
