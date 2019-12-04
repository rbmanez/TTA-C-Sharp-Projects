using System;

namespace branching_exercise.cs
{
    //Drill:
    //  - Your job is to create a console-based application for getting a shipping quote for a package.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            //get package weight
            Console.WriteLine("What is the package weight?");
            double weight = Convert.ToDouble(Console.ReadLine());

            //If the weight is greater than 50, display the error message
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                //get package dimensions
                Console.WriteLine("What is the package width?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                double length = Convert.ToDouble(Console.ReadLine());
                double dimension = width + height + length;

                //If the sum of the dimensions is greater than 50, display the error message
                if (dimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    //The sum total of dimensions are then multiplied by the weight and divided by 100. The result is the quote.
                    decimal quote = Convert.ToDecimal(dimension) * Convert.ToDecimal(weight) / 100;

                    //Display the quote to the user as a dollar amount
                    Console.WriteLine("Your estimated total for shipping this package is:");
                    Console.WriteLine("$" + quote);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
            }
        }
    }
}
