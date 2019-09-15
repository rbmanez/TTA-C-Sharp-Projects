using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise3.cs
{
    //Create a class. In that class, create a method that will take in an integer,
    //do a math operation to it and then return the answer as an integer.
    class MathOperation
    {
        public int Add(int num)
        {
            num = num + 30;
            return num;
        }

        //Add a second method to the class, with the same name, that will take in a decimal,
        //do a different math operation to it and then return the answer as an integer.
        public decimal Add(decimal num)
        {
            num = num + 25;
            num = Convert.ToInt32(num);
            return num;
        }

        //Add a third method to the class, with the same name, that will take in a string,
        //convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.
        public int Add(string num)
        {
            int num2 = Convert.ToInt32(num);
            num2 = num2 + 5;
            return num2;
        }
    }
}
