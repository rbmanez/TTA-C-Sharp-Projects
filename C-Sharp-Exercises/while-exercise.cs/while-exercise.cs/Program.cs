using System;

namespace while_exercise.cs
{
    //Drill:
    //  - Do a boolean comparison using a while statement.
    //  - Do a boolean comparison using a do while statement.
    class Program
    {
        static void Main(string[] args)
        {
            //a boolean comparison using a while statement
            Console.WriteLine("Guess a number between 1 and 10.");
            int user_num = Convert.ToInt32(Console.ReadLine());
            int secret_num = 3;
            bool correct_guess = false;
            while (!correct_guess)
            {
                if (user_num != secret_num)
                {
                    Console.WriteLine("Guess again.");
                    user_num = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ding! Ding! Ding! You guessed the secret number!");
                    correct_guess = true;
                    Console.ReadLine();
                }
            }

            //a boolean comparison using a do while statement
            Console.WriteLine("Now, I will count 1 to 10:");
            int starting_num = 1;
            do
            {
                Console.WriteLine(starting_num);
                starting_num++;
            } while (starting_num < 11);
            Console.ReadLine();
        }
    }
}
