using InheriranceOne.Entities;
using System;

namespace InheriranceOne
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount();

            Console.WriteLine(account.Balance);

            // account.Balance = 400;
        }
    }
}
