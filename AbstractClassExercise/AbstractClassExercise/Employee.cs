using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
