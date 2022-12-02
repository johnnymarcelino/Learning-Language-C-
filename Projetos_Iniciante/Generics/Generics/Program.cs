using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printservice = new PrintService<int>();

            Console.WriteLine("How many values ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printservice.AddValue(x);
            }

            // exemplo de typesafety:
            //int a = (int)printservice.First();  // sem o tipo generico, o codigo é compilado sem enxergar o problema de conversão
            int a = printservice.First();  // compilador ao saber que metodo first retorna um int, não precisa fazer o casting
            //string a = (string)printservice.First();  //  sem o tipo generico, o codigo é compilado sem enxergar o problema de conversão
            int b = a + 2;  // caso seja uma entrada do tipo string -> problema detectado
            Console.WriteLine(b);

            printservice.Print();
            Console.WriteLine();
            Console.WriteLine("First: " + printservice.First());
        }
    }
}
