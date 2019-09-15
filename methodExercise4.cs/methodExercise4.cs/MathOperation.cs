using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise4.cs
{
    //Create a class. In that class, create a method that takes two integers as parameters.
    //Make one of them optional. Have the method do a math operation and return an integer result.
    class MathOperation
    {
        public int Add(int num1, int num2 = 5)
        {
            num1 = num1 + num2 + 10;
            return num1;
        }
    }
}
