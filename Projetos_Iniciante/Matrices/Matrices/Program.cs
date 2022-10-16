using System;

namespace Matrices {
    internal class Program {
        static void Main(string[] args) {

            double[,] matrix = new double[4 , 5];

            // tamanho da matriz
            Console.WriteLine(matrix.Length);

            // dimensão da matriz inicial
            Console.WriteLine(matrix.Rank);

            // retorna o valor referente ao tamanho da posição desejada no indice
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
        }
    }
}
