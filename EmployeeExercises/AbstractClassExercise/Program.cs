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
            // Used for lambda expression practice.
            Employee<string> employee11 = new Employee<string>() { FirstName = "Jane", LastName = "Meyer", Id = 11 };
            Employee<string> employee12 = new Employee<string>() { FirstName = "Frank", LastName = "Hernandez", Id = 12 };
            Employee<string> employee13 = new Employee<string>() { FirstName = "Jill", LastName = "Vulcano", Id = 13 };
            Employee<string> employee14 = new Employee<string>() { FirstName = "Joe", LastName = "Camden", Id = 14 };
            Employee<string> employee15 = new Employee<string>() { FirstName = "Brenda", LastName = "Picasso", Id = 15 };
            Employee<string> employee16 = new Employee<string>() { FirstName = "Holly", LastName = "Guillen", Id = 16 };
            Employee<string> employee17 = new Employee<string>() { FirstName = "Joe", LastName = "Acosta", Id = 17 };
            Employee<string> employee18 = new Employee<string>() { FirstName = "Roman", LastName = "Hampton", Id = 18 };
            Employee<string> employee19 = new Employee<string>() { FirstName = "Joe", LastName = "Smith", Id = 19 };
            Employee<string> employee20 = new Employee<string>() { FirstName = "Gabe", LastName = "Hamilton", Id = 20 };

            List<Employee<string>> employees = new List<Employee<string>>()
                {   employee11, employee12, employee13, employee14, employee15,
                    employee16, employee17, employee18, employee19, employee20 };



            // Using a foreach loop, make a list of all employees whose first name is Joe.
            List<Employee<string>> newList1 = new List<Employee<string>>(); //This takes 8 lines of code.
            foreach(Employee<string> employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList1.Add(employee);
                }
            }

            Console.WriteLine("Here is a list of employees with a first name of Joe: ");
            foreach (Employee<string> employee in newList1)
            {
                Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
            }

            Console.WriteLine();

            //Using a lambda expression, make a list of all employees whose first name is Joe.
            List<Employee<string>> newList2 = employees.Where(x => x.FirstName == "Joe").ToList(); //This takes 1 line of code.
            Console.WriteLine("Here is a list of employees with a first name of Joe, by using only one line of code thanks to lambda expressions!");
            foreach (Employee<string> employee in newList2)
            {
                Console.WriteLine("{0} {1}",employee.FirstName, employee.LastName);
            }

            Console.WriteLine();

            // Use a lambda expression to generate a list of employees whose ID is grater than 5.
            List<Employee<string>> IdGreaterThanFive = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("Here is a list of employees whose ID is greater than 5: ");
            foreach (Employee<string> employee in IdGreaterThanFive)
            {
                Console.WriteLine("{0} {1}, Employee ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            }








            //Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            //employee1.SayName();
            //employee1.Quit();

            //IQuittable employee2 = new Employee() { FirstName = "Example", LastName = "Employee", Id = 2 };
            //Employee<string> employee3 = new Employee<string>() { FirstName = "Emilio", LastName = "Estevez", Id = 1 };
            //employee2.Quit();
            //Console.WriteLine();

            //Console.WriteLine("employee1 Id is: {0}, employee3 Id is: {1}. Are they the same person?", employee1.Id, employee3.Id);

            //Console.WriteLine(employee1 == employee3);



            /* USE OF GENERICS WHEN MAKING A CLASS */


            //Employee<string> employee4 = new Employee<string>() { FirstName = "Another", LastName = "Employee", Id = 4,
            //    Things = new List<string>() { "pen", "notepad", "glasses" } };
            //Employee<int> employee5 = new Employee<int>() { FirstName = "Bender", LastName = "Rodriguez", Id = 5,
            //    Things = new List<int>() { 0, 1 } };

            //Console.WriteLine("employee4's things: ");
            //employee4.PrintThings();
            //Console.WriteLine();
            //Console.WriteLine("employee5's things: ");
            //employee5.PrintThings();


            Console.ReadLine();
        }
    }
}
