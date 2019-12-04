using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constVarConstructorChainEx.cs
{
    public class User
    {
        //Chain two constructors together.
        public User() : this(31)
        {

        }
        public User(int age)
        {
            age = age;
        }
    }
}
