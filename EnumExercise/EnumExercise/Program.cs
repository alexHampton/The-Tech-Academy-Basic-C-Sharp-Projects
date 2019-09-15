using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string userString = Console.ReadLine().ToLower();
                Console.WriteLine();
                Enum.Parse(typeof(DaysOfTheWeek), userString); //Check to see if user input is found in Enum.
                

                DaysOfTheWeek userInputEnum; //Declare enum.
                for (int i = 0; i < 7; i++) //use For Loop to find which enum value the user input matches.
                {
                    if (userString == GetDayName(i))
                    {
                        userInputEnum = (DaysOfTheWeek)i;
                        Console.WriteLine("The day you entered, as an Enum data type, is: ");
                        Console.WriteLine(userInputEnum);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.Read();
        }

        public static string GetDayName(int DayIndex) // Convert enum values to strings.
        {
            DaysOfTheWeek DayName = (DaysOfTheWeek)DayIndex;
            return DayName.ToString();
        }

        public enum DaysOfTheWeek
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
    }
}
