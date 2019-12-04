using System;

namespace math_comparison_ex.cs
{
    class Program
    {
        //Drill:
        //  - Your job is to create an anonymous income comparison program.

        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //p1's hourly rate and hours worked per week
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            decimal p1_rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal p1_hours = Convert.ToDecimal(Console.ReadLine());

            //p2's hourly rate and hours worked per week
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            decimal p2_rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal p2_hours = Convert.ToDecimal(Console.ReadLine());

            //p1 and p2 salaries
            Console.WriteLine("Weekly salary of Person 1:");
            decimal p1_salary = p1_rate * p1_hours;
            Console.WriteLine(p1_salary);
            Console.WriteLine("Weekly salary of Person 2:");
            decimal p2_salary = p2_rate * p2_hours;
            Console.WriteLine(p2_salary);

            //compare salaries
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1_salary > p2_salary);
            Console.ReadLine();

        }
    }
}
