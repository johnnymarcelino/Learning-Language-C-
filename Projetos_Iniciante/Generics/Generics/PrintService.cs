﻿using System;

namespace Generics
{
    internal class PrintService
    {
        private int[] _values = new int[10];  // armazenar 10 numeros inteiros

        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Value printservice is full already");
            }
            _values[_count] = value;
            _count ++;
        }

        public int First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Value printservice is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.Write("]");
        }

    }
}
