using System;

namespace Time_Span {
    internal class Program {
        static void Main(string[] args) {

            /*
            
            TimeSpan t1 = new TimeSpan(1, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine("nano: " + t3);
            Console.WriteLine();

            // "FROM" retorna em dias horas minutos etc

            TimeSpan t4 = TimeSpan.FromDays(1.5);
            TimeSpan t5 = TimeSpan.FromHours(1.5);
            TimeSpan t6 = TimeSpan.FromMinutes(1.5);
            TimeSpan t7 = TimeSpan.FromSeconds(1.5);
            TimeSpan t8 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t9 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);

            */

            /*

            // retorno de valores nos respectivos dados de chamada com timespan

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            */

            // operaçoes com timespan em soma subtraçao multiplicação etc
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan sub = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan mult2 = t1.Multiply(2.0);
            TimeSpan mult3 = sum.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(mult2);
            Console.WriteLine(mult3);
            Console.WriteLine(div);
        }
    }
}
