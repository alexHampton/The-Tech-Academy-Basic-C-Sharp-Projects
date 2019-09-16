using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number: ");
            string userInput = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\alext\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Logs\log2.txt", true))
            {
                file.WriteLine(userInput);
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\alext\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Logs\log2.txt"));
            Console.Read();
        }
    }
}
