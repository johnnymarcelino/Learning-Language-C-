using System;
using System.Globalization;

namespace Interface4.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = decimal.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))  // proteção lógica
            {
                throw new ArgumentException("Comparing error: argument is not an employee");
            }

            Employee other = obj as Employee;  // downcasting
            return Salary.CompareTo(other.Salary);
            //return Name.CompareTo(other.Name);
        }
    }
}
