using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class.
            MathOps objOne = new MathOps();

            int squaredNum; // Declare a variable to be used for output parameter 1.
            int numTimesTwo; // Declare a variable to be used for output parameter 2.
            

            // Have the user enter a number.
            Console.Write("Please enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            // Call the method on that number.
            objOne.divideByTwo(userNum, out squaredNum, out numTimesTwo); // For the outputs, assign where you want them to go.
            // Display the output to the screen.
            Console.WriteLine("Your number divided by two is: {0}.", objOne.dividedNum);
            Console.WriteLine("Your number squared is: {0}", squaredNum);
            Console.WriteLine("Your number multiplied by two is: {0}", numTimesTwo);


            decimal userNumAgain = Convert.ToDecimal(userNum);
            objOne.divideByTwo(userNumAgain);
            Console.WriteLine("Your number more accurately divided by two is: {0}", objOne.dividedDecimal);



            // This is used just to check how to use a static class. A good example 
            // of a static class is the System.Math class. You can use this class 
            // to perform various math operations, but you don't declare an object
            // in order to use it. 
            Console.WriteLine("Check to see if the static class works.");
            Console.Write("Enter a number: ");
            int userStaticNum = Convert.ToInt32(Console.ReadLine());

            int plusFive = NewStaticClass.numPlusFive(userStaticNum);
            Console.WriteLine("The number to typed is: {0}", NewStaticClass.input);
            Console.WriteLine("Your number plus five is: {0}", plusFive);

            Console.ReadLine();

        }
    }
}
