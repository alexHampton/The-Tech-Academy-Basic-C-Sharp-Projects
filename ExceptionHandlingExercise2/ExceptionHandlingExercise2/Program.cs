using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello.");

                int days = 0;
                Console.WriteLine("How old are you?");
                days = Convert.ToInt32(Console.ReadLine()) * 365;
                if (days <= 0)
                {
                    throw new IntegerFormatException();
                }

                TimeSpan tsdays = new TimeSpan();
                tsdays = TimeSpan.FromDays(days);
                DateTime birthyear = new DateTime();
                birthyear = DateTime.Now - tsdays;
                Console.WriteLine("You were born in {0}", birthyear.Year);

                Console.ReadLine();
            }
            catch (IntegerFormatException ex)
            {
                Console.WriteLine("Sorry, you must currently be alive to use this program.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
