using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise4
{
    class MathOps
    {
        public MathOps()
        {

        }

        // Create a method that takes two integers as parameters. Make one of
        // them optional. Have the method do a math operation and return an 
        // integer result.
        public int SimpleMath(int numOne, int numTwo = 1)
        {
            simpleMathNumOne = numOne;
            simpleMathNumTwo = numTwo;
            return numOne + numTwo;
        }
        // Instead of only returning the value for SimpleMath, these are declared
        // in order to show the user the numbers which were used for the math
        // operation.
        public int simpleMathNumOne; 
        public int simpleMathNumTwo;
    }
}
