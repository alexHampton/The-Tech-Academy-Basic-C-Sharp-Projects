using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number would you like to do math operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            MathOps firstOne = new MathOps(userInput);


            Console.WriteLine(firstOne.addTen);
            Console.WriteLine(firstOne.square);
            Console.WriteLine(firstOne.minusfour);


            Console.WriteLine("Ok, now input another number, so we can create another object.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            MathOps secondOne = new MathOps(userInput1);

            Console.WriteLine(secondOne.addTen);
            Console.WriteLine(secondOne.square);
            Console.WriteLine(secondOne.minusfour);

            Console.Read();


        }
        
    }
}
