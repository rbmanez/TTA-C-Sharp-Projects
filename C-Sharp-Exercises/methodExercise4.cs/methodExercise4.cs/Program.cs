//PURPOSE:    More method exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.
            MathOperation mathOp = new MathOperation();

            //Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
            Console.WriteLine("Please enter two numbers, one at a time. The second number is optional.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            string num2 = Console.ReadLine();

            //Call the method in the class, passing in the one or two numbers entered.
            //Try various combinations of numbers on the code, including having no second number.
            int number2;
            if (!String.IsNullOrEmpty(num2))
            {
                number2 = Convert.ToInt32(num2);
                Console.WriteLine(mathOp.Add(number1, number2));
            }
            else
            {
                Console.WriteLine(mathOp.Add(number1));
            }
            
            Console.ReadLine();
        }
    }
}
