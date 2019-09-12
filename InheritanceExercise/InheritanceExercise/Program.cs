using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee object.
            Employee employee1 = new Employee() { FirstName = "Sample", Lastname = "Student" };

             // Call the superclass method.
            employee1.SayName();
            Console.Read();
        }
    }
}
