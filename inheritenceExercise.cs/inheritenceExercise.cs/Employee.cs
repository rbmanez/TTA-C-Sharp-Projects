using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritenceExercise.cs
{
    //Create another class called Employee and have it inherit from the Person class.
    //Give the Employee class a property called Id and have it be of data type int.
    //Make the Employee class take a generic type parameter.
    class Employee<T> : Person
    {
        public int Id { get; set; }

        //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee<T> a, Employee<T> b)
        {
            if (a.Id == b.Id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Employee<T> a, Employee<T> b)
        {
            if (a.Id != b.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Add a property to the Employee class called "things" and
        //have its data type be a generic list matching the generic type of the class.
        public List<T> Things { get; set; }
    }

}
