using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Person
    {
        // Create Person class with properties FirstName and LastName.
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        // Create void method that takes no parameters and writes persons full name.
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, Lastname);
        }
    }
}
