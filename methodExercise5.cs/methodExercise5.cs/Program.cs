//PURPOSE:    More method exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise5.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, instantiate that class.
            MathOperation math = new MathOperation();

            //Have the user enter a number. Call the method on that number.
            //Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            math.DivideBy2(num);

            //Using method with out parameters.
            Console.WriteLine("Out parameter example using method Add:");
            int num2;
            math.Add(out num2);
            Console.WriteLine(num2);

            //Using method overload
            Console.WriteLine("Method overload example using method Add:");
            math.Add(5, 10, 15);

            //Using static class
            Console.WriteLine("Static class example:");
            Console.WriteLine(MathOperation2.Multiply(5));

            Console.ReadLine();
        }
    }
}
