using System;
using System.Collections.Generic;
using System.Text;

namespace InheriranceOne.Entities
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Trabalhando com UpCasting e DownCasting

        /*

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance -= amount;
        }

        */

        // Trabalhando com Sobreposição/Sobrescrito, palavra virtual, override e base - subclasses

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount)
        {
            Balance -= amount;
        }


    }
}
