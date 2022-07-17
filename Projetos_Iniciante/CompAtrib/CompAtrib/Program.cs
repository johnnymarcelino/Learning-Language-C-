using System;

namespace CompAtrib {
    internal class Program {
        static void Main(string[] args) {
            // Comparatives Operators

            //int a = 10;
            //bool c1 = a < 10;
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine("==============");

            //bool c5 = a <= 10;
            //bool c6 = a >= 10;
            //bool c7 = a == 10;
            //bool c8 = a != 10;
            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8);

            // Boolean Operators
            // Operators AND and OR --> (&& and ||)
            // Precede majors are ! && ||

            bool c1 = 2 > 3 || 4 != 5; // True
            bool c2 = 3 > 4 && 4 == 4; // False
            bool c3 = !(5 > 5) && 4 == 4; // True

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c4);
        }
    }
}
