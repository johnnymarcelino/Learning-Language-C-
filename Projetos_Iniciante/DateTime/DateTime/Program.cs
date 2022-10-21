using System;
using System.Globalization;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args) {
            /*
            
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

            */

            /*

            Console.WriteLine("****************************************");
            Console.WriteLine();

            DateTime d = new DateTime(1996, 10, 03, 09, 40, 58, 275);
            Console.WriteLine(d.ToLongDateString());

            Console.WriteLine();
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);


            string s1 = d.ToLongDateString();
            Console.WriteLine(s1);
            Console.WriteLine();
            string s2 = d.ToLongTimeString();
            Console.WriteLine(s2);
            string s3 = d.ToShortDateString();
            Console.WriteLine(s3);

            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            */

            /*
            // adiciona tempos as variaveis
            DateTime d = new DateTime(1996, 10, 03, 09, 40, 58, 275);

            DateTime d2 = d.AddDays(2);
            DateTime d3 = d.AddDays(24);
            Console.WriteLine();
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            /*
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);
            */

            // convertendo horaio no padrao utc ou gmt greenwitch -> datetime.kind

            /*
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 45, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 45, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 45);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to utc: " + d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to utc: " + d2.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to utc: " + d3.ToUniversalTime());

            */

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:42");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:42Z");

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // precisamos converter para utc primeiro para trazer em utc ou local
            Console.WriteLine(d2.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
