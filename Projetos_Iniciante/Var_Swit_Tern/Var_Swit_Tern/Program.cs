using System;
using System.Globalization;

namespace Var_Swit_Tern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // estudo da palavra VAR

            var x = 10;
            var y = 20.00;
            var z = "Maria";

            // utilização de tipos de dados para ser informado pela idle
            var w = z;
            //int w = z;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */


            // Estudo do Switch-case

            /*
            This method is about if-else in chain

            int wee = int.Parse(Console.ReadLine());
            string day;

            if (wee == 1) {
                day = "Sunday";
            }
            else if (wee == 2) {
                day = "Monday";
            }
            else if (wee == 3) {
                day = "Tuesday";
            }
            else if (wee == 4) {
                day = "Whenesday";
            }
            else if (wee == 5) {
                day = "Thursday";
            }
            else if (wee == 6) {
                day = "Friday";
            }
            else if (wee == 7) {
                day = "Saturday";
            }
            else {
                day = "Invalid value";
            }

            Console.WriteLine("Day: " + day);
            */

            // And this method is about switch-case
            
            /*
            int wee = int.Parse(Console.ReadLine());
            string day;

            switch (wee) {
                case 1: 
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Whenesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);
            */

            // And this method is about ternary condition

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // On the method if-else
            /*
            double discont;

            if (price < 20.0) {
                discont = price * 0.1;
            }
            else {
                discont = (price * 0.05);
            }
            */

            // On the method ternary

            double discont = (price < 20.0) ? discont = price * .1 : discont = price * .05;

            Console.WriteLine("Discont: " + discont);
        }
    }
}
