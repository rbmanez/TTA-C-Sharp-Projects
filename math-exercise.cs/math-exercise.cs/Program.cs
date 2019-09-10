using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_exercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            string user_input = Console.ReadLine();
            int new_input = Convert.ToInt32(user_input);
            int times = 50 * new_input;
            int plus = 25 + new_input;
            double divide = (double)new_input / 12.5;
            bool tOrF = new_input > 50;
            int modulo = new_input % 7;
            Console.WriteLine("Your number times 50 is " + times);
            Console.WriteLine("Your number plus 25 is " + plus);
            Console.WriteLine("Your number divided by 12.5 is " + divide);
            Console.WriteLine("Your number being greater than 50 is " + tOrF);
            Console.WriteLine("Your number divided by 7 has a remainder of " + modulo);
            Console.ReadLine();
        }
    }
}
