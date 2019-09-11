using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOps mathOpsOne = new MathOps();
            // Call the method in the class, passing in two numbers.
            mathOpsOne.takeInNums(5, 20);
            //Call the method in the class, specifying thre parameters by name.
            mathOpsOne.takeInNums(numOne: 5, numTwo: 35);


            Console.ReadLine();
            
        }
    }
}
