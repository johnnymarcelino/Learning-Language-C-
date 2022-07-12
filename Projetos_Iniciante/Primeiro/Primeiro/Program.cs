using System;

namespace Primeiro {
    internal class Program {
        static void Main(string[] args) {
            // My first Hello World in C#
            Console.WriteLine("Hello World!");
            // Conceptions of datatypes in .NET C#
            // --> SByte x = 100;
            // Conceptions of datatypes in C#
            SByte n1 = 127;
            // set of 4 bytes
            int n2 = 1000;
            int n3 = 2147483647;
            // set of 8 bytes
            long n4 = 21474836484L;
            //n1+=200;
            Console.WriteLine(n2);
            Console.WriteLine(n1);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n4+n3+n2+n1);
            //Console.WriteLine(x);

        }
    }
}