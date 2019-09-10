using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_comparison_ex.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string p1_rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string p1_hours = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string p2_rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string p2_hours = Console.ReadLine();

            Console.WriteLine("Weekly salary of Person 1:");
            decimal p1_salary = decimal.Parse(p1_rate) * decimal.Parse(p1_hours);
            Console.WriteLine(p1_salary);

            Console.WriteLine("Weekly salary of Person 2:");
            decimal p2_salary = decimal.Parse(p2_rate) * decimal.Parse(p2_hours);
            Console.WriteLine(p2_salary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1_salary > p2_salary);
            Console.ReadLine();

        }
    }
}
