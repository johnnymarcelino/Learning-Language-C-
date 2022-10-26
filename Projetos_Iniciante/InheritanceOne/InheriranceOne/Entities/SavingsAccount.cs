using System;
using System.Collections.Generic;
using System.Text;

namespace InheriranceOne.Entities
{
    internal class SavingsAccount : Account
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

        public override void Withdraw(double amount)  // override usado nas subclasses
        {
            //Balance -= amount;
            base.Withdraw(amount);  // invocar o método comum da superclasse
            Balance -= 2.0;
        }
    }
}
