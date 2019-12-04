//PURPOSE:    Struct Exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structExercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create an object of data type Number and assign an amount to it.
            Number numberObject = new Number();
            numberObject.Amount = 20.5m;

            //Print this amount to the console.
            Console.WriteLine(numberObject.Amount);
            Console.ReadLine();
        }
    }
}
