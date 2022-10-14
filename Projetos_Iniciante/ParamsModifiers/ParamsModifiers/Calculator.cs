using System;

namespace ParamsModifiers {
    class Calculator {

        // Estes são exemplos de sobrecargas
        /*
        public static int Sum(int n1, int n2) {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3) {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4) {
            return n1 + n2 + n3 + n4;
        }
        */

        // Estes são exemplos mais sofisticados com uma funçao de vetores / listas

        // Esta forma deixa um pouco redundante a função
        /*
        public static int Sum(int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
        */


        // Estes são exemplos mais sofisticados com uma funçao de vetores / listas e parametro params
        // já esta deixa o código mais sucinto com o modificador de parametros params

        /*
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
        */

        // Modificador ref
        /*
        public static void Triple(int x) { // sem a utilização da palavra ref não podemos ter referencia
            x = x * 3;
            System.Console.WriteLine(x);
        }
        */

        // com a palavra ref em uso guardamos tambem na variavel do program
        /*
        public static void Triple(ref int x) {
            x = x * 3;
            System.Console.WriteLine(x);
        }
        */


        // modificador out
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
