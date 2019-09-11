using System;
using System.Collections.Generic;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myNums = new List<int>() { 1000, 500, 250, 125, 100, 50, 25 };
                Console.WriteLine("Please provide a number to be used as a divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int num in myNums)
                {
                    int quotient = num / divisor;
                    Console.WriteLine(num + " divided by " + divisor + " equals " + quotient);
                }
            }

            catch (DivideByZeroException) // Display an error message in case dividend is 0.
            {
                Console.WriteLine("ERROR: Don't divide by zero.");
            }
            catch (System.FormatException) // Display an error message in case anything other than an integer is provided.
            {
                Console.WriteLine("ERROR: Please input a whole number.");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //At the end of the Try Catch Block, do this.
            {
                Console.WriteLine();
                Console.WriteLine("Program has exited the Try Catch Block."); 
                Console.Read();
            }               
        }
    }
}
