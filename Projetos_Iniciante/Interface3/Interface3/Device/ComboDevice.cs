using System;

namespace Interface3.Device
{
    internal class ComboDevice : Device, IScanner, IPrinter  // proibido herdar de duas superclasses -> conflito do diamante (ambiguidade)
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print" + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing" + document);

        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
