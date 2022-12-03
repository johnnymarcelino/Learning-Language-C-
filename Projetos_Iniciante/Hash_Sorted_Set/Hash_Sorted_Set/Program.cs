using System;
using System.Collections.Generic;

namespace Hash_Sorted_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("tv"));

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

        }
    }
}
