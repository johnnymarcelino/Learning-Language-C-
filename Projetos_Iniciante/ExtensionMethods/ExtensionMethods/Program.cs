using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 12, 8, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
