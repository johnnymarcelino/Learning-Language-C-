using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Interface2.Model.Entities
{
    internal class Circle : Shape
    {
        public double Radious { get; set; }

        public override double Area()
        {
            return Math.PI * Radious * Radious;
        }

        public override string ToString()
        {
            return "Circle = "
                + Color
                + ", radius = "
                + Radious.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
