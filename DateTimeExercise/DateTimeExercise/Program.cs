using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            TimeSpan tshours = new TimeSpan(hours, 0, 0);
            DateTime future = new DateTime();
            future = DateTime.Now + tshours;
            Console.WriteLine("The time in {0} hours will be {1}", hours, future);

            Console.Read();
        }
    }
}
