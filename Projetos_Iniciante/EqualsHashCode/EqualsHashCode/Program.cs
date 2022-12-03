using EqualsHashCode.Entities;
using System;

namespace EqualsHashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@email.com" };

            Client b = new Client { Name = "João", Email = "joao@email.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);  // comparação por referencia de memoria
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
