//PURPOSE:    Enum exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumExercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wrap in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            try
            {
                //Prompt the user to enter the current day of the week.
                Console.WriteLine("Please enter the current day of the week.");
                //Assign the value to a variable of that enum data type you just created.
                DaysOfTheWeek day;
                Enum.TryParse(Console.ReadLine(), out day);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }

        //Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thurday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
