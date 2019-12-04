//PURPOSE:    File I/O exercise
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileExercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask a user for a number.
            Console.WriteLine("Enter a number.");
            string number = Console.ReadLine();

            //Log that number to a text file.
            File.WriteAllText(@"C:\Users\Robert\Documents\TTA\log.txt", number);

            //Print the text file back to the user.
            string readText = File.ReadAllText(@"C:\Users\Robert\Documents\TTA\log.txt");
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
