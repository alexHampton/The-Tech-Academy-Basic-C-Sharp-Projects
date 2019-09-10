using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQualifications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string sAge = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            string sDUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string sTickets = Console.ReadLine();

            //data type conversions
            int age = Convert.ToInt32(sAge);
            bool DUI = Convert.ToBoolean(sDUI);
            int tickets = Convert.ToInt32(sTickets);

            bool qualified = (age > 15 && !DUI && tickets <= 3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);

            Console.Read();

        }
    }
}
