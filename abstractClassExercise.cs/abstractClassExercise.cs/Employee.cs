using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExercise.cs
{
    //Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person
    {
        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            throw new NotImplementedException();
        }
    }
}
