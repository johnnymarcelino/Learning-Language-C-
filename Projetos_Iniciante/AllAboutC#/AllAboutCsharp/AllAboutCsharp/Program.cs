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
