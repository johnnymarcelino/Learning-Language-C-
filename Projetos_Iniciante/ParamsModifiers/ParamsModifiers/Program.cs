//using ParamsModifiers;
using System;

namespace ParamsModifiers {
    internal class Program {
        static void Main(string[] args) {


            /*
            int s1 = Calculator.Sum(new int[] { 10, 15 } );  // atribuindo valores aos vetores/lista
            int s2 = Calculator.Sum(new int[] { s1 + 1, 15, 20 });  // exemplo -> new type [] {}
            */

            /*
            int s3 = Calculator.Sum(10, 15 );  // utilização do modificador params
            int s4 = Calculator.Sum(13 + 1, 15, 20);  // utilização do modificador de parametro params

            Console.WriteLine(s3);
            Console.WriteLine(s4);
            */


            /*
            // modificador ref

            int a = 10;
            //Calculator.Triple(a); // sem a palavra ref n podemos chamar a função Triple
            Calculator.Triple(ref a); // com a palavra ref, podemos chamar a função Triple
            Console.WriteLine(a);
            */


            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
