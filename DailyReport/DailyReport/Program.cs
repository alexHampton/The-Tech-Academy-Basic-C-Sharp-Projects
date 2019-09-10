using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpNeeded = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveEXP = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            //Console.WriteLine("Your current course is: " + currentCourse);
            //Console.WriteLine("Your current page is: " + currentPage);
            //Console.WriteLine("Help needed is: " + helpNeeded);
            //Console.WriteLine("Positive experience: " + positiveEXP);
            //Console.WriteLine("Feedback: " + feedback);
            //Console.WriteLine("Hours studied: " + hoursStudied);

            Console.WriteLine("");
            Console.WriteLine("Thank you for your answers. An Insructor will respond to this shortly. Have a great day!");
            Console.Read();

        }
    }
}
