using System;
using System.Globalization;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // instante atual
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            // ticks nanosegundos passados desde a era atual
            Console.WriteLine(d1.Ticks);
            
            // data determinada
            DateTime d2 = new DateTime(1995, 8, 25);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(1995, 8, 25, 9, 30, 00);
            Console.WriteLine(d3);

            // data atual
            DateTime d4 = DateTime.Today;
            Console.WriteLine(d4);

            // horario universal
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d5);

            // convertendo do tipo string p/ datetime
            DateTime d6 = DateTime.Parse("2022-10-21");
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2022-10-21 20:23:59");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("21-10-2022");
            Console.WriteLine(d8);

            // personalizar o modelo dos dados
            DateTime d9 = DateTime.ParseExact("2022-10-21", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);

            DateTime d10 = DateTime.ParseExact("21/10/2022 02:18:35", "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);
        }
    }
}
