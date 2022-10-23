using EnumProgram.Entities;
using EnumProgram.Entities.Enums;
using System;
using System.Runtime.InteropServices;

namespace EnumProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // convertendo do tipo enumerado para string
            string txt = OrderStatus.PendingPayment.ToString();

            // convertendo do tipo string para o tipo enumerado 
            OrderStatus status = Enum.Parse<OrderStatus>("Delivere"); // parametrização do orderstatus (do tipo da enumeração)

            Console.WriteLine(txt);
            Console.WriteLine(status);
        }
    }
}
