using System;

namespace math_exercise.cs
{
    class Program
    {
        //A console application that takes user input and performs some math operations.

        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("Input a number:");
            string user_input = Console.ReadLine();
            int new_input = Convert.ToInt32(user_input);

            //performs some math operations to user's input and displays it
            int times = 50 * new_input;
            Console.WriteLine("Your number times 50 is " + times);
            int plus = 25 + new_input;
            Console.WriteLine("Your number plus 25 is " + plus);
            double divide = (double)new_input / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + divide);
            bool tOrF = new_input > 50;
            Console.WriteLine("Your number being greater than 50 is " + tOrF);
            double remainder = (double)new_input % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of " + remainder);
            Console.ReadLine();
        }
    }
}
