﻿using System;

namespace CLASS {
    internal class Triangle {

        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // double raiz = ....
            // return raiz; // Two metod to return de value
        }
    }
}
