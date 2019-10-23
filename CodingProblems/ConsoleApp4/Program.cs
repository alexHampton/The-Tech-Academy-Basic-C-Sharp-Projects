using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given an array of integers, write a method to total the odd numbers.
            Console.WriteLine("Given an array of integers, write a method to total " +
                "the odd numbers.");
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("The integers in the array are:");
            foreach (int i in myArray)
            {
                Console.Write("{0} ", i.ToString());
            }
            Console.WriteLine();
            Console.Write("The sum of all odd numbers is: ");
            int oddSum = OddSum(myArray);
            Console.WriteLine(oddSum);
            Console.WriteLine();

            // Given an array of integers, write a method to sum the elements in 
            // the array, knowing that some of the elements may be very large
            // integers.
            Console.WriteLine("Given an array of integers, write a method to sum " +
                "the elemnts in the array, knowing that some of the elements may " +
                "be very large integers.");
            Console.WriteLine("The integers in the array are: ");

            int[] myOtherArray = new int[] { 600000000, 300000000, 2000000000,  };
            foreach (int i in myOtherArray)
            {
                Console.WriteLine("{0} ", i.ToString());
            }
            Console.WriteLine();

            long totalSum = TotalSum(myOtherArray);
            Console.Write("The sum of all of these large numbers is: ");
            Console.WriteLine(totalSum);
            Console.WriteLine();


            // Given a string, reverse it.
            string myString = "Hello";
            Console.WriteLine("The original string is '{0}'.", myString);
            Console.WriteLine("That string reversed is: ");
            Console.WriteLine(Reversed(myString));
            Console.WriteLine();

            // Given a string, remove any repeated letters.
            var myOtherString = "mississippi";
            Console.WriteLine("The original string is '{0}'.", myOtherString);
            Console.WriteLine("The same string, but with repeated letters removed is: ");
            Console.WriteLine(Removed(myOtherString));
            Console.WriteLine();

            Console.WriteLine("Fizzbuzz:");
            Console.WriteLine("Write a function that counts from 1 to 100. ");
            Console.WriteLine("When the number is divisible by 3, say 'Fizz'.");
            Console.WriteLine("When the number is divisible by 5, say 'Buzz'.");
            Console.WriteLine("If the number is divisible by both 3 and 5, say 'FizzBuzz'.");
            Console.WriteLine("Press enter when ready.");
            Console.ReadLine();
            var myList = FizzBuzz();
            myList.ForEach(Console.WriteLine);
            Console.Read();
        }

        static int OddSum(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    total += numbers[i];
                }
            }
            return total;
        }

        static long TotalSum(int[] numbers)
        {
            long total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += Convert.ToInt64(numbers[i]);
            }
            return total;
        }

        static string Reversed(string original)
        {
            string revStr = "";
            for (int i = 0; i < original.Length; i++)
            {
                revStr = original[i] + revStr;
            }
            return revStr;
        }

        static string Removed(string original)
        {
            string newStr = "";
            for (int i = 0; i < original.Length; i++)
            {
                if (!newStr.Contains(original[i]))
                {
                    newStr += original[i];
                }
            }
            return newStr;
        }

        static List<string> FizzBuzz()
        {
            var myFizz = new List<string>();
            for ( int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    myFizz.Add("FizzBuzz (" + i + ")");
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    myFizz.Add("Fizz (" + i + ")");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    myFizz.Add("Buzz (" + i + ")");
                }
                else
                {
                    myFizz.Add(i.ToString());
                }
                
            }
            return myFizz;
        }
    }
}
