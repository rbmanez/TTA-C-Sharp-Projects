using System;

namespace math_exercise.cs
{
    class Program
    {
        //Drill:
        //  - Create a console application that takes user input number, performs some math operations, and prints results to the console

        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("Input a number:");
            int user_input = Convert.ToInt32(Console.ReadLine());

            //performs some math operations to user's input and displays it
            int times = 50 * user_input;
            Console.WriteLine("Your number times 50 is " + times);
            int plus = 25 + user_input;
            Console.WriteLine("Your number plus 25 is " + plus);
            double divide = (double)user_input / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + divide);
            bool tOrF = user_input > 50;
            Console.WriteLine("Your number being greater than 50 is " + tOrF);
            double remainder = (double)user_input % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of " + remainder);
            Console.ReadLine();
        }
    }
}
