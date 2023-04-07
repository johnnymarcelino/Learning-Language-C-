using System;


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
    class Program
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
