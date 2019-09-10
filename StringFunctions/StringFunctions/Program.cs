using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Concatenate three strings
            string myString = "Hello, ";
            string myOtherString = "my name is ";
            string myLastString = "enter name here.";
            myLastString = myLastString.ToUpper(); //convert a string to uppercase

            string sentence = myString + myOtherString + myLastString;
            Console.WriteLine(sentence);
            Console.ReadLine();

            // Using StringBuilder, build a paragraph of text.
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("It was cold.");
            paragraph.Append(" I had just gotten out of bed.");
            paragraph.Append(" I was forced to. It was late.");
            paragraph.Append(" In an instant, I went from the warmth of the blankets and the fire, to the feel of ice and asphalt.");
            paragraph.Append(" In that moment, just like the night before, I wondered 'Why did I choose this path?'");


            Console.WriteLine(paragraph);
            Console.ReadLine();

            //string name = "Alex";
            //string quote = "The man said, \\\"Hello!\" \n Hello on a new line \n\t Hello on a tab";
            //string fileName = "C:\\Users\\alext\\documents";
            //string fileName2 = @"C:\Users\alext\documents";


            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("x");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);
            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(fileName2);
            //Console.Read();




            ////Strings are immutable
            //string name = "Alex";
            //name = "Bill";  // when you reassign a string, you're actually making a new string in memory.

            //// Can use C#'s string builder class to 'add on' to the same string.
            //StringBuilder sb = new StringBuilder();

            //sb.Append("This is the beginning of the string.");

            //Console.WriteLine(sb);
            //Console.ReadLine();
        }
    }
}
