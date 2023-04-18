using System;
using System.Collections.Generic;
using System.Linq;


//Neste exemplo, a variável "x" é do tipo "int", que representa um número inteiro,
//enquanto a variável "s" é do tipo "string", que representa um texto.
//O tempo de execução aloca automaticamente memória para as variáveis "x" e "s",
//sem que o desenvolvedor precise se preocupar com isso.

// Exemplo de código em C# que ilustra o uso de tipos estáticos e a alocação automática de memória pelo tempo de execução:

namespace ExemploTipagemEGerenciamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10; // variável inteira
            string s = "olá"; // variável string

            Console.WriteLine("O valor de x é " + x);
            Console.WriteLine("A string s é " + s);
        }
    }
}

// Neste exemplo, o código fonte em C# é compilado usando o compilador da linguagem,
// que traduz o código para código de máquina que pode ser executado diretamente pelo computador.

// Exemplo de código em C# compilado:

namespace ExemploCompilacao
{
    class Program01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
        }
    }
}


//Exemplo de código em Python interpretado:


//Neste exemplo, o código fonte em Python é interpretado linha por linha
//pelo interpretador da linguagem, que executa o código em tempo de execução.

//print("Olá, mundo!")

// ------------------------------------------------------------------------ //

/*
    Trabalhando com LINQs 
*/

namespace LINQDemo
{
    class Program02
    {
        static void Main(string[] args)
        {
            //Data Source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            //LINQ Query using Mixed Syntax
            var MethodSyntax = (from obj in integerList
                                where obj > 5
                                select obj).Sum();

            //Execution
            Console.Write("Sum Is : " + MethodSyntax);

            Console.ReadKey();
        }
    }
}



namespace LINQDemo00
{
    class Program03
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            IEnumerable<int> QuerySyntax = from obj in integerList
                                           where obj > 5
                                           select obj;

            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}



namespace LINQDemo01
{
    class Program04
    {
        static void Main(string[] args)
        {
            List<Student01> studentList = new List<Student01>()
            {
                new Student01(){ID = 1, Name = "James", Gender = "Male"},
                new Student01(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student01(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student01(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            //Linq Query to Fetch all students with Gender Male
            IEnumerable<Student01> QuerySyntax = from std in studentList
                                                 where std.Gender == "Male"
                                                 select std;
            //Iterate through the collection
            foreach (var student in QuerySyntax)
            {
                Console.WriteLine($"ID : {student.ID}  Name : {student.Name}");
            }

            Console.ReadKey();
        }
    }

    public class Student01
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}



namespace LINQDemo02
{
    class Program05
    {
        static void Main(string[] args)
        {
            List<Student02> studentList = new List<Student02>()
            {
                new Student02(){ID = 1, Name = "James", Gender = "Male"},
                new Student02(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student02(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student02(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            //Linq Query to Fetch all students with Gender Male
            IQueryable<Student02> MethodSyntax = studentList.AsQueryable()
                                .Where(std => std.Gender == "Male");

            //Iterate through the collection
            foreach (var student in MethodSyntax)
            {
                Console.WriteLine($"ID : {student.ID}  Name : {student.Name}");
            }

            Console.ReadKey();
        }
    }

    public class Student02
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}


/* 
Sintaxe básica do LINQ: O desenvolvedor deve ser capaz de escrever consultas básicas usando a sintaxe padrão do LINQ, 
incluindo a cláusula "from", a cláusula "where" e outras cláusulas comuns.

Consultas de junção: O desenvolvedor deve ser capaz de unir dados de várias fontes usando junções no LINQ, 
incluindo junções internas, externas e cruzadas.

Consultas aninhadas: O desenvolvedor deve ser capaz de usar consultas aninhadas para recuperar dados de várias tabelas ou 
coleções em uma única consulta.

Operadores de agregação: O desenvolvedor deve ser capaz de usar operadores de agregação, como "Sum", "Count", "Max" e "Min",
para resumir dados em uma consulta.

Consultas parametrizadas: O desenvolvedor deve ser capaz de escrever consultas parametrizadas 
que permitem que os valores dos parâmetros sejam especificados dinamicamente em tempo de execução.

Consultas com expressões lambda: O desenvolvedor deve ser capaz de escrever consultas LINQ usando expressões lambda, 
que são uma forma mais concisa e expressiva de escrever consultas.

Operações de projeção: O desenvolvedor deve ser capaz de projetar dados em diferentes formatos usando operadores de projeção,
como "Select" e "SelectMany".

Consultas assíncronas: O desenvolvedor deve ser capaz de escrever consultas LINQ assíncronas usando o operador "await"
para melhorar o desempenho de aplicativos que acessam dados remotamente.

Uso do LINQ em diferentes fontes de dados: O desenvolvedor deve ser capaz de usar o LINQ em diferentes fontes de dados,
incluindo bancos de dados relacionais, bancos de dados NoSQL e coleções em memória.

Otimização de consultas: O desenvolvedor deve ser capaz de otimizar consultas LINQ para melhorar o desempenho, 
incluindo o uso de índices em bancos de dados e a aplicação de cláusulas "where" de forma seletiva.
*/

// Sintaxe de consulta:
var consulta = from variavel in colecao
               where condicao
               orderby ordenacao
               select resultado;


// Sintaxe de método:

var resultado = colecao.Where(variavel => condicao)
                       .OrderBy(ordenacao)
                       .Select(resultado);


// Exemplo básico (sintaxe de consulta):

int[] numeros = { 1, 2, 3, 4, 5 };

var consulta = from n in numeros
               where n % 2 == 0
               select n;

foreach (var numero in consulta)
{
    Console.WriteLine(numero);
}

// Exemplo intermediário (sintaxe de método):


var livros = new List<Livro>()
{
    new Livro() { Titulo = "Dom Casmurro", Autor = "Machado de Assis", AnoPublicacao = 1899 },
    new Livro() { Titulo = "Memórias Póstumas de Brás Cubas", Autor = "Machado de Assis", AnoPublicacao = 1881 },
    new Livro() { Titulo = "O Cortiço", Autor = "Aluísio Azevedo", AnoPublicacao = 1890 },
    new Livro() { Titulo = "Vidas Secas", Autor = "Graciliano Ramos", AnoPublicacao = 1938 }
};

var consulta = livros.Where(l => l.Autor == "Machado de Assis")
                     .OrderBy(l => l.AnoPublicacao)
                     .Select(l => l.Titulo);

foreach (var livro in consulta)
{
    Console.WriteLine(livro);
}


/*
Suponha que você tenha duas listas de objetos: uma lista de Clientes e uma lista de Pedidos. 
Cada cliente possui um ID único e cada pedido está associado a um cliente pelo ID do cliente. 
Você deseja obter uma lista de todos os clientes juntamente com a quantidade de pedidos que cada cliente fez. 
Você pode fazer isso usando uma junção (join) e agrupamento (group by) em LINQ, conforme o exemplo a seguir:
*/

List<Cliente> clientes = new List<Cliente>
{
    new Cliente { Id = 1, Nome = "João" },
    new Cliente { Id = 2, Nome = "Maria" },
    new Cliente { Id = 3, Nome = "Pedro" }
};

List<Pedido> pedidos = new List<Pedido>
{
    new Pedido { Id = 1, ClienteId = 1, Valor = 100 },
    new Pedido { Id = 2, ClienteId = 2, Valor = 200 },
    new Pedido { Id = 3, ClienteId = 1, Valor = 50 },
    new Pedido { Id = 4, ClienteId = 3, Valor = 300 },
    new Pedido { Id = 5, ClienteId = 2, Valor = 150 }
};

var pedidosPorCliente = from c in clientes
                        join p in pedidos on c.Id equals p.ClienteId into gj
                        select new { Cliente = c.Nome, NumPedidos = gj.Count() };

foreach (var item in pedidosPorCliente)
{
    Console.WriteLine($"Cliente: {item.Cliente}, Número de Pedidos: {item.NumPedidos}");
}

