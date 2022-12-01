using Interface2.Model.Entities;
using Interface2.Model.Enums;
using System;

namespace Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle() { Radious = 2.0, Color = Color.White };

            Shape s2 = new Rectagle() { Width = 3.5, Height = 4.2, Color = Color.White };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
