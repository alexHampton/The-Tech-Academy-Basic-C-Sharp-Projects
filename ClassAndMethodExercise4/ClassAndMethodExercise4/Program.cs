using System;

namespace ClassAndMethodExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class.
            MathOps objOne = new MathOps();

            // Ask the user to input two numbers, one at a time. Let them know
            // they do not need to enter anything for the second number.
            Console.WriteLine("Please enter two numbers.");
            Console.Write("Number One: ");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("(Number 2 is optional. If left blank, 1 will be used.) Number Two: ");
            string var2String = Console.ReadLine(); 



            // DO NOT USE THIS IF ELSE STATEMENT. THE TERNARY OPERATORS BELOW ARE MORE SUCCINCT.
            //int var3; // Declare var3 outside of branches so that it can be used later.
            // If the user does not input a second number (var2String) then the default will be used.
            //if (var2String == "")
            //{
            //    var3 = objOne.SimpleMath(var1); //Default used for second number
            //}
            //else
            //{
            //    int var2 = Convert.ToInt32(var2String);
            //    var3 = objOne.SimpleMath(var1, var2); // var2 used for second number
            //}



            // TERNARY OPERATORS
            // Shorter code than the if else statement above. 
            int var2 = var2String == "" ? 1 : Convert.ToInt32(var2String); // If user leaves number two blank, assign var2 a value of 1 and ignore it.
            int var3 = var2 == 1 ? objOne.SimpleMath(var1) : objOne.SimpleMath(var1, var2); // var3 uses the default value of SimpleMath() if var2 == 1.
            Console.WriteLine("{0} plus {1} equals {2}.",
                objOne.simpleMathNumOne, objOne.simpleMathNumTwo, var3);
            Console.Read();

        }
    }
}
