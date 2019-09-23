//PURPOSE:    More exception handling exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for his age.
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("What is your age?");
            //Display the year user born.
            //Exceptions must be handled using "try .. catch".
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new LessThanOneException();
                }
                int yearBorn = currentYear - age;
                Console.WriteLine("You were born on the year of {0}.", yearBorn);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Display appropriate error messages if user enters zero or negative numbers.
            catch (LessThanOneException)
            {
                Console.WriteLine("Please input a number greater than 0.");
            }
            //Display a general message if exception caused by anything else.
            catch (Exception)
            {
                Console.WriteLine("An error has occured.");
            }
            Console.ReadLine();
        }
    }
}
