﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExercise.cs
{
    //Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person, IQuittable
    {
        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            throw new NotImplementedException();
        }

        //Have your Employee class inherit that interface and implement the Quit() method in any way you choose.
        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
