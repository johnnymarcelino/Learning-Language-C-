using System;
using System.Collections.Generic;
using System.Text;

namespace Interface3.Device
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)  // sobrescrita torno-se implementação da classe Device
        {
            Console.WriteLine("Printer Processing: " + document);
        }

        public void Print(string document)  // metodo torno-se implementação da interface IPrinter
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
