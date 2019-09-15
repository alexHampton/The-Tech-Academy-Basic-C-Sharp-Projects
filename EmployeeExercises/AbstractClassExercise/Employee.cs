using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    class Employee<T> : Person, IQuittable // Make Employee class Generic by adding <T> to it. 
    {
        public Employee()
        {

        }
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("{0} {1} has left the building.", FirstName, LastName);
        }

        public static bool operator== (Employee<T> e1, Employee<T> e2) //Overloading operator
        {
            return e1.Id == e2.Id;
        }
        public static bool operator!= (Employee<T> e1, Employee<T> e2) // Overloading operator
        {
            return e1.Id != e2.Id;
        }

        public override bool Equals(object obj) //Overrides added due to warning messages.
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int Id { get; set; }
        public List<T> Things { get; set; } // Things Generic List.

        public void PrintThings()
        {
            foreach (T thing in Things)
            {
                Console.WriteLine(thing);
            }
        }

    }
}
