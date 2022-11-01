using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHanding.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string messege) : base(messege)
        {
        }
    }
}
