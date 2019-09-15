using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numOne = new Number() { Amount = 2.345m};
            Console.WriteLine(numOne.Amount);

            Console.Read();
        }
    }
}
