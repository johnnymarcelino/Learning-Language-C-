using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            // Define the query
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Define the query
            // with lists 
            List<int> result2 = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10).ToList();  // tolist cause IEnumerable don't convert to list

            // Define the query
            // with IEnumerable
            IEnumerable<int> result3 = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10); // IEnumerable is generic in to a lista for multiple collections

            // Execute the query
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}
