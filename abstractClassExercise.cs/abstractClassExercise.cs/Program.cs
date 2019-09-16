//PURPOSE:    Abstract class exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside the Main() method, instantiate an Employee object with firstName "Sample" and
            //lastName "Student". Call the SayName() method on the object.
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            IQuittable iquit = new Employee();
            iquit.Quit();

        }
    }
}
