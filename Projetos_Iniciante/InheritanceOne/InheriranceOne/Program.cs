using InheriranceOne.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace InheriranceOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // trabalhando com modificadores de acesso

            /*

            BusinessAccount account = new BusinessAccount();

            Console.WriteLine(account.Balance);

            // account.Balance = 400;

            */

            /*

            // trabalhando com UpCasting e DownCasting

            Account acc = new Account(1010, "Johnny", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "João", 0.0, 500.00);

            // UpCasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1030, "Jaison", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1030, "Jaison", 0.0, 200.00);

            // DownCasting

            //BusinessAccount acc4 = acc2;  // devemos instanciar com o tipo da classe referente
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount)acc3; // Compilador enxerga um erro somente após a execução

            if (acc3 is BusinessAccount)  // teste de instancia de businessaccount
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;  // há duas maneiras de se instanciar (sintaxe alternativa)
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;  // há duas maneiras de se instanciar (sintaxe alternativa)
                SavingsAccount acc5 = acc3 as SavingsAccount;  // há duas maneiras de se instanciar (sintaxe alternativa)
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            */

            /*

            Account account = new Account(1001, "Gomes", 500.00);
            Account account1 = new SavingsAccount(1001, "Gomes", 500.00, 0.01);

            account.Withdraw(10);
            account1.Withdraw(10);

            Console.WriteLine(account.Balance);
            Console.WriteLine(account1.Balance);

            */

            // Trabalhando com classes abstratas (objetos)
            // nota - superclasses abstrata não pode ser instanciada, por outro lado, subclasses podem ser instanciadas

            
            //Account account = new Account(1001, "Gomes", 500.00);  //  não pode ser instanciada 
            //Account account1 = new SavingsAccount(1001, "Gomes", 500.00, 0.01); //  pode ser instanciada pois não é abstrada

            List<Account> list = new List<Account>();  // tipo como lista pode-se instanciar

            list.Add(new SavingsAccount(200, "johnny", 1000, 0.01));
            list.Add(new BusinessAccount(600, "jose", 1000, 0.04));
            list.Add(new SavingsAccount(500, "Joao", 4000, 0.04));
            list.Add(new BusinessAccount(300, "carlos", 1000, 0.03));
            list.Add(new BusinessAccount(300, "carlos", 1000, 0.03));

            double sum = 0;
            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account account in list)
            {
                account.Withdraw(10.00);
            }
            
            foreach (Account account in list)
            {
                Console.WriteLine("Updated balance for account " + account.Number + ": " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
