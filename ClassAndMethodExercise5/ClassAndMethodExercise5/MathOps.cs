using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise5
{
    class MathOps
    {
        public MathOps()
        {

        }

        // Create a void method that outputs an integer. Have the method divide the 
        // data passed to it by 2.
        // Create a method with output parameters.
        public void divideByTwo(int num, out int squaredNum, out int timesTwo)
        {
            dividedNum = num / 2;
            squaredNum = num * num;
            timesTwo = num * 2;
        }


        // Overload a method.
        public void divideByTwo(decimal num)
        {
            dividedDecimal = num / 2;
        }

        public decimal dividedDecimal;
        public int dividedNum;
    }
}
