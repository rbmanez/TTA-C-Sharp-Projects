//PURPOSE:    Inheritence exercise, operator overloading exercise
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
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Call the superclass method SayName() on the Employee object.
            employee.SayName();
            Console.ReadLine();
        }
    }
}
