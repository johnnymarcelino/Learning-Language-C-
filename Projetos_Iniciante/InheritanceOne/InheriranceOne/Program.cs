using InheriranceOne.Entities;
using System;

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

        }
    }
}
