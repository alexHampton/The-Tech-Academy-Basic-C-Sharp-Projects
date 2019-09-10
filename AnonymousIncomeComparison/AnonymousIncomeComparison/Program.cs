using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string person1Rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string person1Hours = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string person2Rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string person2Hours = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Weekly salary of Person 1: ");
            int p1r = Convert.ToInt32(person1Rate);
            int p1h = Convert.ToInt32(person1Hours);
            int p1Weekly = p1r * p1h;
            Console.WriteLine(p1Weekly);
            Console.WriteLine("Weekly salary of Person 2: ");
            int p2r = Convert.ToInt32(person2Rate);
            int p2h = Convert.ToInt32(person2Hours);
            int p2Weekly = p2r * p2h;
            Console.WriteLine(p2Weekly);
            Console.WriteLine();

            Console.WriteLine("Does Person 1 make more money that Person 2?");
            bool person1Greater = p1Weekly > p2Weekly;
            Console.WriteLine(person1Greater);

            Console.Read();

        }
    }
}
