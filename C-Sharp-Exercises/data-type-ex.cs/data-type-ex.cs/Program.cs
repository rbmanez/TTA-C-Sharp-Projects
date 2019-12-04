using System;

namespace data_type_ex.cs
{
    class Program
    {
        //A daily report for students of The Tech Academy.

        static void Main(string[] args)
        {
            //Ask and save to a well-named variable and proper data type answers to the following questions

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string course_num = Console.ReadLine();

            Console.WriteLine("What page number?");
            int page_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help? Please answer \"true\" or \"false\"");
            bool help = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positive_exp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            float study_hours = float.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
