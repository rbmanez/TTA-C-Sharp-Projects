using System;

namespace boolean_exercise.cs
{
    class Program
    {
        //A basic approval program for car insurance. It will ask the applicant some
        //questions and return a “true” or “false” at the end as to whether or not
        //the applicant qualified for car insurance.

        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //Applicants must be over 15 years old, no dui's, 3 or less tickets
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && tickets <= 3);
            Console.ReadLine();
        }
    }
}
