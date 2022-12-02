using System;

namespace Generics
{
    //  declarando um tipo como objeto para tudo, podemos não ter perfomance e nem o typesafety => exem: object[] _values = new object[10];
    internal class PrintService<T>  // parametrizado com um tipo T - define o tipo do objeto para resolver problemas de typesafety e perfomance
        // toda a classe printservice é de um tipo Generico do tipo T
    {
        private T[] _values = new T[10];  // armazenar 10 numeros inteiros

        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Value printservice is full already");
            }
            _values[_count] = value;
            _count ++;
        }

        public T First()
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
