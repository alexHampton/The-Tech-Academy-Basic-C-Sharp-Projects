using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleAppDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXERCISE 1: Takes an input, multiplies by 50, prints the result.

            Console.WriteLine("Please input a number:");
            string yourNum1 = Console.ReadLine();
            long yourLongNum1 = Convert.ToInt64(yourNum1);
            long solutionOne = yourLongNum1 * 50;

            Console.WriteLine("Your number times 50 is " + solutionOne);
            Console.WriteLine();


            //EXERCISE 2: Takes an input, adds 25, prints the result.

            Console.WriteLine("Please input a number:");
            string yourNum2 = Console.ReadLine();
            double yourDoubleNum2 = Convert.ToDouble(yourNum2);
            double solutionTwo = yourDoubleNum2 + 25;

            Console.WriteLine(yourDoubleNum2 + " plus 25 = " + solutionTwo);
            Console.WriteLine();


            //EXERCISE 3: Takes an input, divides by 12.5, prints the result.

            Console.WriteLine("Please input a number: ");
            string yourNum3 = Console.ReadLine();
            double yourDubNum3 = Convert.ToDouble(yourNum3);
            double solutionThree = yourDubNum3 / 12.5;

            Console.WriteLine(yourNum3 + " divided by 12.5 equals " + solutionThree);
            Console.WriteLine();


            //EXERCISE 4: Takes an input, checks if it is grater than 50, prints true/false result.

            Console.WriteLine("Please input a number: ");
            string yourNum4 = Console.ReadLine();
            int yourIntNum4 = Convert.ToInt32(yourNum4);
            bool solutionFour = yourIntNum4 > 50;

            Console.WriteLine("Is " + yourNum4 + " greater than 50?");
            Console.WriteLine(solutionFour);
            Console.WriteLine();

            //EXERCISE 5: Takes an input, prints the remainder of input divided by 7.

            Console.WriteLine("Please input a number: ");
            string yourNum5 = Console.ReadLine();
            double yourDubNum5 = Convert.ToDouble(yourNum5);
            double solutionFive = yourDubNum5 % 7;

            Console.WriteLine(yourNum5 + " divided by 7 yields a remainder of " + solutionFive);
            Console.Read();
        }
    }
}
