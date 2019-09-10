using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop
            
            //Console.WriteLine("Guess the month I was born:");
            //string myBirthMonth = Console.ReadLine();

            //while (myBirthMonth != "May" && myBirthMonth != "may")
            //{
            //    Console.WriteLine("That is incorrect. Guess again:");
            //    myBirthMonth = Console.ReadLine();
            //}
            //Console.WriteLine("That is correct!");
            //Console.Read();



            // Do While loop
            
            string myBirthMonth = "may";

            do
            {
                Console.WriteLine("Guess the month I was born:");
                myBirthMonth = Console.ReadLine();
            }
            while (myBirthMonth != "May" && myBirthMonth != "may");
            
            Console.WriteLine("That is correct!");
            Console.Read();
        }
    }
}
