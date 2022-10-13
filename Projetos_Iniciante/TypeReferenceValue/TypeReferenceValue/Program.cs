using System;

namespace TypeReferenceValue {
    internal class Program {
        static void Main(string[] args) {
            Point p;
            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
            Console.WriteLine();

            // value nullable

            Nullable<double> x = null;
            //x = new Nullable<double>();
            Console.WriteLine(x.GetValueOrDefault()); // pegar o valor de X ou valor padrão da variavel X (o tipo da variavel)
            Console.WriteLine();
            Console.WriteLine();

            // outra forma de declarar valores nulos 
            double? a = null;
            double? b = 10.45;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(b.HasValue);
            Console.WriteLine("==================");

            if (a.HasValue) {
                Console.WriteLine(a.Value);
            }
            else {
                Console.WriteLine("a is null!");
            }
            if (b.HasValue) {
                Console.WriteLine(b.Value);
            }
            else {
                Console.WriteLine("y is null");
            }
            Console.WriteLine("========== Coalescência Nula ===========");

            // operador de coalescência nula

            double? c = null;
            double d = c ?? 15.12; // operador de coalescência nula => (??)
            double? e = 400;
            double f = e ?? 200;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}
