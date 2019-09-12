using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee1.SayName();
            employee1.Quit();

            IQuittable employee2 = new Employee() { FirstName = "Example", LastName = "Employee" };
            employee2.Quit();

            Console.ReadLine();
        }
    }
}
