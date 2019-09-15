//PURPOSE:    Method exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user what number they want to do the math operations on
            Console.WriteLine("Input a number to perform math operations on.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
            Console.WriteLine(userInput + " plus 10 equals " + MathOperation.Add10(userInput));
            Console.WriteLine(userInput + " times 10 equals " + MathOperation.Multiply10(userInput));
            Console.WriteLine(userInput + " squared equals " +  MathOperation.Square(userInput));
            Console.ReadLine();
        }
    }
}
