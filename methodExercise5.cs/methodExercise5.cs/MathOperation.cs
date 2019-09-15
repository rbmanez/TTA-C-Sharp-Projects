using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise5.cs
{
    //Create a class. In that class, create a void method that outputs an integer.
    //Have the method divide the data passed to it by 2.
    class MathOperation
    {
        public void DivideBy2(int num)
        {
            int num2 = num / 2;
            Console.WriteLine(num + " divided by 2 equals " + num2);
        }

        //Create a method with output parameters.
        public void Add(out int num)
        {
            num = 10;
        }

        //Overload a method.
        public void Add(int num1, int num2, int num3)
        {
            int answer = num1 + num2 + num3;
            Console.WriteLine(num1 + " plus " + num2 + " plus " + num3 + " equals " + answer);
        }
    }

    //Declare a class to be static.
    static class MathOperation2
    {
        public static int Multiply(int num)
        {
            num = num * 2;
            return num;
        }
    }
}
