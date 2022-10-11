using System;
using System.Globalization;


namespace Constructors {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco); // aqui tambem podemos atribuir um valor ao construtor

            Produto p2 = new Produto(nome, preco); // dessa forma padrinizada não permite-se mais após as atribuições, porém com construtor padrão formalizado pode-se utilizar o vazio

            Produto p3 = new Produto { // dessa forma padrinizada não permite-se mais após as atribuições
                Nome = "TV", 
                Preco = 500.0, 
                Quantidade = 20
            }; 

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
