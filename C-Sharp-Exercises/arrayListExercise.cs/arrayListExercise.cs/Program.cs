//Purpose:    Array and list exercise
//Author:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayListExercise.cs
{
    class Program
    {
        //Drill: Array and list exercises
        static void Main(string[] args)
        {
            //Create an array of strings.
            //Ask the user to select an index of the Array and then display the string at that index on the screen.
            //Add in a message that displays when the user selects an index that doesn’t exist.
            string[] stringArray = new string[] { "red", "blue", "green" };
            bool stringArrayBool = false;
            while (!stringArrayBool)
            {
                Console.WriteLine("Select an index between 0 and 2 to see the color it contains.");
                int stringArrayPick = Convert.ToInt32(Console.ReadLine());
                if (stringArrayPick > 2)
                {
                    Console.WriteLine("Sorry, that index doesn't exist.");
                }
                else
                {
                    Console.WriteLine("The item on index " + stringArrayPick + " is the color " + stringArray[stringArrayPick] + ".");
                    stringArrayBool = true;
                    Console.ReadLine();
                }
            }

            //Create an array of integers.
            //Ask the user to select an index of the Array and then display the integer at that index on the screen.
            //Add in a message that displays when the user selects an index that doesn’t exist.
            int[] numArray = new int[] { 1, 2, 4, 8 };
            bool numArrayBool = false;
            while (!numArrayBool)
            {
                Console.WriteLine("Select an index between 0 and 3 to see the number it contains.");
                int numArrayPick = Convert.ToInt32(Console.ReadLine());
                if (numArrayPick > 3)
                {
                    Console.WriteLine("Sorry, that index doesn't exist.");
                }
                else
                {
                    Console.WriteLine("The item on index " + numArrayPick + " is the number " + numArray[numArrayPick] + ".");
                    numArrayBool = true;
                    Console.ReadLine();
                }
            }

            //Create a List of strings.
            //Ask the user to select an index of the List and then display the content at that index on the screen.
            //Add in a message that displays when the user selects an index that doesn’t exist.
            List<string> stringList = new List<string>() { "banana", "apple", "orange", "mango" };
            bool stringListBool = false;
            while (!stringListBool)
            {
                Console.WriteLine("Select an index between 0 and 3 to see the fruit it contains.");
                int stringListPick = Convert.ToInt32(Console.ReadLine());
                if (stringListPick > 3)
                {
                    Console.WriteLine("Sorry, that index doesn't exist.");
                }
                else
                {
                    Console.WriteLine("The item on index " + stringListPick + " is the fruit " + stringList[stringListPick] + ".");
                    stringListBool = true;
                    Console.ReadLine();
                }
            }
        }
    }
}
