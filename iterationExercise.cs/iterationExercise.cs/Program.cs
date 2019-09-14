//Purpose:    Iteration exercise
//Author:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterationExercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one-dimensional Array of strings. Ask the user to input some text.
            string[] userStringArray = new string[4];
            Console.WriteLine("Please input four words one at a time, pressing \"enter\" after each word.");
            //Create a loop that goes through each string in the Array, adding the user’s text to the string.
            for (int i = 0; i < userStringArray.Length; i++)
            {
                userStringArray[i] = Console.ReadLine();
            }
            //Then create a loop that prints off each string in the Array on a separate line.
            Console.WriteLine("Your four words are:");
            foreach (string userString in userStringArray)
            {
                Console.WriteLine(userString);
            }
            Console.ReadLine();


            //Create an infinite loop.
            bool infiniteIsTrue = true;
            while (infiniteIsTrue)
            {
                Console.WriteLine("This is an infinite loop!");
                //Fix the infinite loop so it will execute.
                infiniteIsTrue = false;
                Console.WriteLine("This is no longer an infinite loop!");
            }
            Console.ReadLine();


            //Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            List<int> intList = new List<int>() { 2, 4, 8, 16 };
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
            Console.ReadLine();


            //Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            int count = 1;
            while (count <= 4)
            {
                Console.WriteLine(count);
                count++;
            }
            Console.ReadLine();


            //Create a List of strings where each item in the list is unique.
            List<string> officeList = new List<string>() { "pen", "paper", "stapler", "computer" };
            Console.WriteLine("I have a list of four common office supplies:");
            foreach (string item in officeList)
            {
                Console.WriteLine("- " + item);
            }
            //Ask the user to select text to search for in the List.
            bool officeListBool = false;
            while (!officeListBool)
            {
                Console.WriteLine("Enter an item from the list of office supplies to see their index.");
                string userInput = Console.ReadLine();
                //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
                for (int i = 0; i < officeList.Count; i++)
                {
                    if (userInput == officeList[i])
                    {
                        Console.WriteLine("The index of " + officeList[i] + " is " + i + ".");
                        Console.ReadLine();
                        //stops loop from executing once a match has been found
                        officeListBool = true;
                    }
                }
                //tell a user if they put in text that isn’t in the List
                if (!officeList.Contains(userInput))
                {
                    Console.WriteLine("Sorry, there is no match for " + userInput + " from the list.");
                }
            }


            //Create a List of strings that has at least two identical strings in the List.
            List<string> fruitList = new List<string>() { "mango", "peach", "grape", "mango" };
            Console.WriteLine("I have a list of fruits:");
            foreach (string fruit in fruitList)
            {
                Console.WriteLine("- " + fruit);
            }
            bool fruitListBool = false;
            while (!fruitListBool)
            {
                //Ask the user to select text to search for in the List.
                Console.WriteLine("Enter a fruit from the list to see their index.");
                string fruitChoice = Console.ReadLine();
                //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
                for (int i = 0; i < fruitList.Count; i++)
                {
                    if (fruitChoice == fruitList[i])
                    {
                        Console.WriteLine(fruitList[i] + " has an index of " + i + ".");
                        fruitListBool = true;
                    }
                }
                //tell a user if they put in text that isn’t in the List
                if (!fruitList.Contains(fruitChoice))
                {
                    Console.WriteLine("Sorry, there is no match for " + fruitChoice + ".");
                }
            }
            Console.ReadLine();


            //create a list of strings that has at least two identical strings in the list.
            List<string> langList = new List<string>() { "c#", "python", "javascript", "c#", "python", "c#", "java" };
            //create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> landList2 = new List<string>();
            foreach (string lang in langList)
            {
                if (!landList2.Contains(lang))
                {
                    landList2.Add(lang);
                    Console.WriteLine("The language " + lang + " has made its first appearance.");
                }
                else
                {
                    Console.WriteLine("The language " + lang + " has already appeared in the list.");
                }
            }
            Console.ReadLine();
        }
    }
}
