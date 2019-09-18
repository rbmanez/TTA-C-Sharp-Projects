//PURPOSE:    Inheritence exercise, operator overloading exercise, generic type exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritenceExercise.cs
{
    class Program
    {
        //Inside of the Main method, instantiate and initialize an Employee object
        //with a first name of "Sample" and a last name of "Student".
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Call the superclass method SayName() on the Employee object.
            employee.SayName();
            Console.ReadLine();

            //Instantiate an Employee object with type "string" as its generic parameter.
            //Assign a list of strings as the property value of Things.
            Employee<string> stringList = new Employee<string>();
            stringList.Things = new List<string> { "hi", "hey", "hello" };

            //Instantiate an Employee object with type "int" as its generic parameter.
            //Assign a list of integers as the property value of Things.
            Employee<int> intList = new Employee<int>();
            intList.Things = new List<int> { 2, 4, 8, 16 };

            //Create a loop that prints all of the Things to the Console.
            Console.WriteLine("String List:");
            foreach (string word in stringList.Things)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Integer List:");
            foreach (int integer in intList.Things)
            {
                Console.WriteLine(integer);
            }
            Console.ReadLine();
        }
    }
}
