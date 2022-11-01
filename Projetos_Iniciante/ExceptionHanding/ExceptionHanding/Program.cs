using System;
using System.IO;
using ExceptionHanding.Entities;
using ExceptionHanding.Entities.Exceptions;

namespace ExceptionHanding
{
    class Program
    {
        static void Main(string[] args)
        {
            // LEARNING ABOUT EXCEPTIONS HANDING

            /*

            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());

            //    int result = n1 / n2;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("ERROR!");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Format Error!" + e.Message);
            //}

            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
            */


            // PROBLEMA EXEMPLO:

            /*

            Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
            de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
            dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
            novamente a reserva com os dados atualizados. O programa não deve aceitar dados
            inválidos para a reserva, conforme as seguintes regras:
            - Alterações de reserva só podem ocorrer para datas futuras
            - A data de saída deve ser maior que a data de entrada

            */

            /*

            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            

            if (checkOut <= checkIn)
            {
                //Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Error in reservation: Check-out date must be after check-ing date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Resevation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

             */
            // solução "ruim" - lógica do programa prejudicada

            /*

            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                Console.WriteLine("Resarvation dates for updates must be future dates");
            }
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Check-out date must be after check-in date");
            }

            */

            // solução mais eficiente, porém, prejudica a semântica - delegou a tarefa para a classe proprietária

            /*

            string error = reservation.UpdateDates(checkIn, checkOut);

            if (error != null)
            {
                Console.WriteLine("Error in reservation: " + error);
            }
            else
            {
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }

            */

            // solução personalizada (ideal) - tratamentos de exceções - Application Exception

            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)  // evitar quebrar o programa com os tratamentos personalizados
            {
                Console.WriteLine("Error in reservation: " + e.Message); 
            }
            catch (FormatException e)  // evitar quebrar o programa com os tratamentos personalizados
            {
                Console.WriteLine("Format Error! " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }
        }
    }
}
