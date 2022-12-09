using System;
using System.Globalization;

namespace Comparison.Entities
{
    internal class Product // : IComparable<Product>  // retirando a interface ICompareble e metodo CompareTo, ela deixa de ser ICompareble
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        //public int CompareTo(Product other)
        //{
        //    return Price.CompareTo(other.Price);
        //}
    }
}
