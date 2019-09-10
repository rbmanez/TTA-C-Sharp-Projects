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
            //Applicants must be over 15 years old.
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            bool age_over15 = Convert.ToInt32(age) > 15;

            //Applicants must not have any DUI’s.
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool zero_dui = Convert.ToBoolean(dui) == false;

            //Applicants must not have more than 3 speeding tickets.
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            bool few_tickets = Convert.ToInt32(tickets) <= 3;

            //Print the result
            Console.WriteLine("Qualified?");
            Console.WriteLine(age_over15 && zero_dui && few_tickets);
            Console.ReadLine();
        }
    }
}
