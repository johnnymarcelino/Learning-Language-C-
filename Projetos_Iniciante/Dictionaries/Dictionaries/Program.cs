using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@email.com";
            cookies["phone"] = "58746821";
            cookies["phone"] = "54621682";  // a chave sobrescreve a chave anterior repetida

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["user"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no key 'email' for this user!");
            }

            Console.WriteLine($"Size is: " + cookies.Count);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"All cookies more difficult:");  // dictionary is a collections so it implement the INumerable
            foreach (string key in cookies.Keys)
            {
                foreach (string value in cookies.Values)
                {
                    Console.Write(key + ": " + value);
                    Console.WriteLine();
                    //Console.WriteLine(value);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"All cookies more easy:");
            //foreach (KeyValuePair<string, string> item in cookies)
            foreach (var item in cookies)  // podemos utilizar o metodo var como tipo da variavel generica
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
