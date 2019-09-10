using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.Read();

            //float quotient = 100.0f / 17.0f;
            //Console.WriteLine(quotient);
            //Console.Read();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 71;

            //bool isWarm = currentTemp >= roomTemp;
            bool isWarm = currentTemp != roomTemp;
            Console.WriteLine(isWarm);
            Console.Read();
        }
    }
}
