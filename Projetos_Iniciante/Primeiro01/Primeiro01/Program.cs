using System;

namespace Primeiro01 {
    internal class Program {
        static void Main(string[] args) {
            //// type boolean
            //bool complete = false;
            //// type character
            //Char gene = 'F';
            //char letter = '\u0041';
            //// type float
            //float n1 = 4.5f;
            //// type double
            //double n2 = 4.5d;
            //// type string
            //string name = "Johnny Gabriel";
            //// type object
            //object obj = "Johnny Marcelino";
            //object obj2 = 2.4;
            //// print on screen ==> Console.WriteLine(); 
            //Console.WriteLine(letter);
            //Console.WriteLine(complete);
            //Console.WriteLine(gene);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(name);
            //Console.WriteLine(obj);
            //Console.WriteLine(obj2);

            // Working with minimums and maximums values
            int n1 = int.MaxValue; // int.MaxValue;
            int n2 = int.MinValue; // int.MinValue;
            sbyte n3 = sbyte.MaxValue; // sbyte.MinValue;
            sbyte n4 = sbyte.MinValue; // sbtye.MaxValue;
            decimal n5 = decimal.MaxValue;

            // Print on the scren for the users
            Console.WriteLine("This is the maximum value of the decimal: " + n5);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
