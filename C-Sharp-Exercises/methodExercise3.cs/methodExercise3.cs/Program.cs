//PURPOSE:    More method exercises
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class and call the one method,
            //passing in an integer, such as 12. Then display the result to the screen.
            MathOperation mathOp = new MathOperation();
            Console.WriteLine(mathOp.Add(12));

            //In the Main() method of the console app, instantiate the class and call the second method,
            //passing in a decimal. Display the result to the screen.
            Console.WriteLine(mathOp.Add(5.20m));

            //In the Main() method of the console app, instantiate the class and call the third method,
            //passing in a string that equates to an integer. Display the result to the screen.
            Console.WriteLine(mathOp.Add("2"));

            Console.ReadLine();
        }
    }
}
