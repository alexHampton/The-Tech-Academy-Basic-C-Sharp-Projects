using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine();
            Console.WriteLine("What is the weight of the package?");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            // Program will stop if package is too heavy.
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("What is the width of the package?");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the package?");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of the package?");
            int pkgLength = Convert.ToInt32(Console.ReadLine());
            int dimSum = pkgWidth + pkgHeight + pkgLength;


            // Package will stop if package is too big.
            if (dimSum > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            double quote = (dimSum * pkgWeight / 100.0);
            string formattedQuote = String.Format("{0:C}", quote); // Used to ensure correct dollar formatting.

            Console.WriteLine("The estimated total for shipping is " + formattedQuote);
            Console.Read();
        }
    }
}
