using System;
using System.Collections.Generic;
using System.Text;

namespace InheriranceOne.Entities
{
    sealed class SavingsAccount : Account  // classe selada - limitada para utilizar em outras classes; comum internal ou apenas class
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // Trabalhando com Sobreposição/Sobrescrito, palavra virtual, override e base - subclasses

        /*
        public override void Withdraw(double amount)  // override usado nas subclasses - sobreposto (override)
        {
            //Balance -= amount;
            base.Withdraw(amount);  // invocar o método comum da superclasse
            Balance -= 2.0;
        }

        */


        public sealed override void Withdraw(double amount)  // override usado nas subclasses - sobreposto (override) e selada (sealed)
        {
            //Balance -= amount;
            base.Withdraw(amount);  // invocar o método comum da superclasse
            Balance -= 2.0;
        }

    }
}
