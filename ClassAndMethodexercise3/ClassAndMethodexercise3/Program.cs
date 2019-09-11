using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodexercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOps objOne = new MathOps();
            //Call the method, passing in an integer.
            // Display the result to the screen.
            Console.WriteLine("Using Method 1, we get: ");
            Console.WriteLine(objOne.numberMath(456));


            // Instantiate the class and call the second method, passing in 
            // a decimal. 
            // Display the result to the screen.
            Console.WriteLine("Using Method 2, we get: ");
            Console.WriteLine(objOne.numberMath(12.45m));


            //Instantiate the class and call the third method, passing in a 
            // string that equates to an integer.
            Console.WriteLine("Using Method 3, we get: ");
            Console.WriteLine(objOne.numberMath("40"));

            Console.Read();


        }
    }
}
