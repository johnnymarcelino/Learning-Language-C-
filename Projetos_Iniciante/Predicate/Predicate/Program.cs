using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using Predicate.Entities;

namespace Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0);  // há duas maneiras de se fazer atraves de referencia e expressão lambda
            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            /*
            User user = new User()
            {
                Name = "johnny",
                Email = "invalid email"
            };

            var context = new ValidationContext(user, null, null);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(user, context, results, true);

            if (!isValid)
            {
                // validation failed, display errors
                foreach (var result in results)
                {
                    Console.WriteLine(result.ErrorMessage);
                }
            }
            else
            {
                // validation passed, display approved
                foreach (var result in results)
                {
                    Console.WriteLine("passed");
                }
            }

            */
        }

        public static bool ProductTest(Product product)
        {
            return product.Price >= 100.00;
        }
    }
}
