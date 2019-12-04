//PURPOSE:    More method exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.
            MathOperation mathOp = new MathOperation();
            //Call the method in the class, passing in two numbers.
            mathOp.Add20(10, 30);
            //Call the method in the class, specifying the parameters by name.
            mathOp.Add20(num1: 10, num2: 30);
            Console.ReadLine();
        }
    }
}
