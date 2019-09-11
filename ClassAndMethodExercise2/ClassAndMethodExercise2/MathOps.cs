using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise2
{
    class MathOps
    {
        public MathOps() // MathOps object constructor
        {

        }
        // Create a class. In that class, create a void method that takes two 
        // integers as parameters. Have the method do a math operation on the 
        // first integer and display the second integer to the screen.
        public void takeInNums(int numOne, int numTwo)
        {
            firstInteger = numOne + 10;
            secondInteger = numTwo;
            Console.WriteLine(secondInteger);
        }

        // Declaration of state of this mathOps class.
        int firstInteger;
        int secondInteger;
    }
}
