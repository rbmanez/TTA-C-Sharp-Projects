//Purpose:    String exercise
//Author:     Robert Manez

using System;
using System.Text;

namespace string_exercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings.
            //Convert a string to uppercase.
            string fname = "Robert";
            string lname = "Manez";
            Console.WriteLine(fname.ToUpper() + " " + lname.ToUpper());

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, friend. ");
            sb.Append("It's a pleasure to meet. ");
            sb.Append("My name is " + fname + ". ");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
