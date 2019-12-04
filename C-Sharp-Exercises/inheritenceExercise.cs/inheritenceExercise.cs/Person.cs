using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritenceExercise.cs
{
    //Create a class called Person and give it two properties, each of data type string.
    //One called FirstName, the other LastName.
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Give this class a void method called SayName() that takes no parameters and
        //simply writes the person's full name to the console in the format of: "Name: [full name]".
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
