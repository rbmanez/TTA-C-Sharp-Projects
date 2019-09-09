using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type_ex.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string course_num = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page_num = Console.ReadLine();
            Console.WriteLine("Do you need help? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positive_exp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string study_hours = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
