using System;
using System.Globalization;


namespace Encapsulation {
    class Program {
        static void Main(string[] args) {
            
            Produto produto = new Produto("TV", 500.0, 10);

            Console.WriteLine(produto.ToString());
            produto.Nome = "TV 4K"; // atribuição com o metodo get e set com definições de propreties com função

            Console.WriteLine(produto.ToString());

            //produto.Preco = 45.2; // não é permitido alterar pois é uma propeties

            //produto.Nome(Console.ReadLine());

            //produto.Nome = 54.0

            //Console.WriteLine(produto.GetNome()); // com o metodo criado get
            //Console.WriteLine(produto.GetQuantidade()); metodo com função sem get e set
            //Console.WriteLine(produto.GetPreco()); // metodo com função sem get e set
            Console.WriteLine(produto.Quantidade);
            Console.WriteLine(produto.Preco);
        }
    }
}
