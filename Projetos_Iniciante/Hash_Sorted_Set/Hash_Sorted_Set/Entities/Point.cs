using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_Sorted_Set.Entities
{
    struct Point  // tipo valor e não classe
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
