using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritenceExercise.cs
{
    //Create another class called Employee and have it inherit from the Person class.
    //Give the Employee class a property called Id and have it be of data type int.
    class Employee : Person
    {
        public int Id { get; set; }

        //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee a, Employee b)
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
        public static bool operator !=(Employee a, Employee b)
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
    }

}
