using System;

namespace Strings
{
    class Program {
        static void Main(string[] args) {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            // caixa alta
            string s1 = original.ToUpper();

            // caixa baixa
            string s2 = original.ToLower();

            // corta ultimos e primeiros espaços
            string s3 = original.Trim();

            // primeira ocorrencia
            int n1 = original.IndexOf("ABC abd");

            // última ocorrencia
            int n2 = original.LastIndexOf("bc");

            // traz e limita itens nas posiçoes predeterminadas
            string s4 = original.Substring(1, 5);
            string s5 = original.Substring(0, 5);
            string s6 = original.Substring(0, 3);
            string s7 = original.Substring(1, 7);

            // traz itens na posição predeterminada
            string s8 = original.Substring(8);

            // substitui determinado item pelo desejado
            string s9 = original.Replace('a', 'x');
            string s10 = original.Replace("abc", "xy");

            // se exite valor vazio dentro da string
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(1, 5): " + s4);
            Console.WriteLine("Substring(0, 5): " + s5);
            Console.WriteLine("Substring(0, 3): " + s6);
            Console.WriteLine("Substring(1, 7): " + s7);
            Console.WriteLine("Substring(8): " + s8);
            Console.WriteLine("Replace('a', 'x'): " + s10);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}
