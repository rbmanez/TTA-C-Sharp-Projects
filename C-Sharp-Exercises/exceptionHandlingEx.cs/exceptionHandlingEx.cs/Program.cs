//PURPOSE:    Exception handling exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlingEx.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //put the loop in a try/catch block
            try
            {
                //Create a list of integers.
                List<int> numberList = new List<int>() { 10, 20, 30, 40 };
                //Ask the user for a number to divide each number in the list by.
                Console.WriteLine("Please enter a number to divide by.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                //Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                foreach (int number in numberList)
                {
                    int answer = number / userInput;
                    Console.WriteLine(number + " divided by " + userInput + " is equal to " + answer);
                }
                
            }
            //In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string.
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            //Below and outside of the try/catch block, make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.
            Console.WriteLine("Just exited the try/catch block. Continuing with program execution.");
            Console.ReadLine();
        }
    }
}
