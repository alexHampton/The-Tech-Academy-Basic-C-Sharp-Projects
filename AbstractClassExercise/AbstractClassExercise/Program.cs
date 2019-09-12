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
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            employee1.SayName();
            employee1.Quit();

            IQuittable employee2 = new Employee() { FirstName = "Example", LastName = "Employee", Id = 2};
            Employee employee3 = new Employee() { FirstName = "Emilio", LastName = "Estevez", Id = 1 };
            employee2.Quit();
            Console.WriteLine();

            Console.WriteLine("employee1 Id is: {0}, employee3 Id is: {1}. Are they the same person?", employee1.Id, employee3.Id);

            Console.WriteLine(employee1 == employee3);

            Console.ReadLine();
        }
    }
}
