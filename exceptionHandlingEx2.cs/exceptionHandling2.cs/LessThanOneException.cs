using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling2.cs
{
    public class LessThanOneException : Exception
    {
        public LessThanOneException()
            : base() { }
    }
}
