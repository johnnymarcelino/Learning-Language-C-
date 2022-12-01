
using System;
using System.Xml;

namespace Interface3.Device
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner Processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
