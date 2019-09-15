using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise.cs
{
    //Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
    //The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.
    public class MathOperation
    {
        public static int Add10(int num)
        {
            num = num + 10;
            return num;
        }
        public static int Multiply10(int num)
        {
            num = num * 10;
            return num;
        }
        public static int Square(int num)
        {
            num = num * num;
            return num;
        }
    }
}
