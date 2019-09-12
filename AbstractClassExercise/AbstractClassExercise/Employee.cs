using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("{0} {1} has left the building.", FirstName, LastName);
        }

        public static bool operator== (Employee e1, Employee e2) //Overloading operator
        {
            return e1.Id == e2.Id;
        }
        public static bool operator!= (Employee e1, Employee e2) // Overloading operator
        {
            return e1.Id != e2.Id;
        }

        public int Id { get; set; }
    }
}
