﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Principal;
using System.Text;

namespace Linq.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
        }
    }
}
