using System;
using System.Collections.Generic;

namespace ArrayAndListExercise
{
    class Program
    {
        static void Main()
        {
            // USE ARRAY OF STRINGS
            string[] strArray = { "Jenny, ", "I", "got", "your", "number!" };
            int userStrRef = 10; // Ensures while loop will run the first time.

            while (userStrRef < 0 || userStrRef > 4) // If number is outside of the array length, then ask again.
            {
                Console.WriteLine("Please select a number between 0 and 4, inclusive.");
                userStrRef = Convert.ToInt32(Console.ReadLine());
                if (userStrRef < 0 || userStrRef > 4)
                {
                    Console.WriteLine("That is not between 0 and 4. Try again.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("The word you selected is: " + strArray[userStrRef]);
            Console.WriteLine();



            // USE ARRAY OF INTEGERS
            int[] intArray = { 8, 6, 7, 5, 3, 0, 9 };
            int userIntRef = 10; // Ensure while loop runs the first time.

            while (userIntRef < 0 || userIntRef > 6) // if number is outside of the array length, then ask again.
            {
                Console.WriteLine("Please select a number between 0 and 6, inclusive.");
                userIntRef = Convert.ToInt32(Console.ReadLine());
                if (userIntRef < 0 || userIntRef > 6)
                {
                    Console.WriteLine("That is not between 0 and 6. Try again.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("The number at the index you selected is: " + intArray[userIntRef]);
            Console.WriteLine();


            // USE LIST OF STRINGS
            List<string> strList = new List<string>() {"You found my secret lair!", "a", "b", "c", "d", "e" };

            Console.WriteLine("Select a number between 1 and 5.");
            int userAlphaNum = Convert.ToInt32(Console.ReadLine());

            while (userAlphaNum > 5 || userAlphaNum < 0) // Asks again if number is outside of List length.
            {
                Console.WriteLine("Sorry, I can't count that high... or low... ?");
                Console.WriteLine("Please try again:");
                userAlphaNum = Convert.ToInt32(Console.ReadLine());
            }

            if (userAlphaNum >= 1 && userAlphaNum <= 5) // Gives the letter at that index place.
            {
                Console.WriteLine("The letter of the alphabet at place " + userAlphaNum + " is " + strList[userAlphaNum] + ".");
            }
            else
            {
                Console.WriteLine(strList[0]); // Find the secret lair.
            }

            Console.Read();
        }
    }
}
