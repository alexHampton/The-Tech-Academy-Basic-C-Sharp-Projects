using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodexercise3
{
    class MathOps
    {
        // Object constructor
        public MathOps()
        {

        }

        // Create a method that will take an integer, do a math operation to it
        // and then return theanswer as an integer.
        public int numberMath(int num)
        {
            return num * num;
        }

        // Add a second method to the class, with the same name, that will take
        // in a decimal, do a different math operation to it and then return 
        // the answer as an integer.
        public int numberMath(decimal numOne)
        {
            return Convert.ToInt32(numOne) + 5;
        }

        // Add a third method to the class, with the same name, that will take
        // in a string, convert it to an integer if possible, do a different 
        // math operation to it and then return the answer as an integer.
        public int numberMath(string num)
        {
            int numInt = Convert.ToInt32(num);
            return numInt - 5;
        }

    }
}
