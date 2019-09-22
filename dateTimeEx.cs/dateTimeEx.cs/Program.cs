//PURPOSE:    DateTime exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeEx.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console.
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);

            //Asks the user for a number.
            Console.WriteLine("Enter a number.");
            string number = Console.ReadLine();

            //Print to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            DateTime futureDateTime = currentDateTime.AddHours(Convert.ToInt32(number));
            Console.WriteLine(number + " hours from now it will be " + futureDateTime);

            Console.ReadLine();
        }
    }
}
