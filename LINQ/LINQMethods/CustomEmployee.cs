using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtocollections
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class CustomEmployee
    {
        List<Employee> employees_1 = new List<Employee>();

        public CustomEmployee()
        {
            List<Employee> employees = new List<Employee>
                {
                    new Employee { EmployeeId = 1, FirstName = "John", LastName = "Doe", Age = 30 },
                    new Employee { EmployeeId = 2, FirstName = "Jane", LastName = "Smith", Age = 25 },
                    new Employee { EmployeeId = 3, FirstName = "Bob", LastName = "Johnson", Age = 35 },
                    new Employee { EmployeeId = 4, FirstName = "Alice", LastName = "Brown", Age = 28 },
                    new Employee { EmployeeId = 5, FirstName = "Charlie", LastName = "Davis", Age = 32 }
                };
            employees_1 = employees;
        }
        private static List<Employee> GetEmployeesData()
        {
            CustomEmployee customEmployee = new CustomEmployee();
            return customEmployee.employees_1;
        }

        //First is used to retrieve the first element of a sequence that matches a specified condition. If no matching element is found, it will throw an exception.
        //FirstOrDefault is similar to First, but it returns the default value for the type (usually null for reference types) if no matching element is found instead of throwing an exception.

        //In the example, we use First to find the first employee older than 25 and FirstOrDefault to find the first employee older than 40 (which doesn't exist).
        public void FirstandFirstorDeafultExample()
        {
            // Using First
            Employee firstEmployee = employees_1.First(e => e.Age > 25);
            Console.WriteLine($"First Employee over 25: {firstEmployee.FirstName}");

            // Using FirstOrDefault
            Employee firstOrDefaultEmployee = employees_1.FirstOrDefault(e => e.Age > 40);
            if (firstOrDefaultEmployee != null)
            {
                Console.WriteLine($"First Employee over 40: {firstOrDefaultEmployee.FirstName}");
            }
            else
            {
                Console.WriteLine("No employee over 40 found.");
            }

        }

        //Single retrieves the single element in a sequence that matches a specified condition. If there are multiple matching elements or none, it throws an exception.

        //SingleOrDefault is similar to Single, but it returns the default value if no matching element is found and throws an exception if there are multiple matching elements.

        //In the example, we use Single to find an employee with a specific ID (2) and SingleOrDefault to find an employee with a non-existent ID (6).

        public void SingleandSingleorDeafultExample()
        {
            // Using Single
            Employee singleEmployee = employees_1.Single(e => e.EmployeeId == 2);
            Console.WriteLine($"Employee with ID 2: {singleEmployee.FirstName}");

            // Using SingleOrDefault
            Employee singleOrDefaultEmployee = employees_1.SingleOrDefault(e => e.EmployeeId == 6);
            if (singleOrDefaultEmployee != null)
            {
                Console.WriteLine($"Employee with ID 6: {singleOrDefaultEmployee.FirstName}");
            }
            else
            {
                Console.WriteLine("No employee with ID 6 found.");
            }

        }


        //Last retrieves the last element in a sequence that matches a specified condition. If no matching element is found, it throws an exception.

        //LastOrDefault is similar to Last, but it returns the default value if no matching element is found instead of throwing an exception.

        //In the example, we use Last to find the last employee under 35 and LastOrDefault to find the last employee over 40 (which doesn't exist).
        public void LastandLastorDeafultExample()
        {
            // Using Last
            Employee lastEmployee = employees_1.Last(e => e.Age < 35);
            Console.WriteLine($"Last Employee under 35: {lastEmployee.FirstName}");

            // Using LastOrDefault
            Employee lastOrDefaultEmployee = employees_1.LastOrDefault(e => e.Age > 40);
            if (lastOrDefaultEmployee != null)
            {
                Console.WriteLine($"Last Employee over 40: {lastOrDefaultEmployee.FirstName}");
            }
            else
            {
                Console.WriteLine("No employee over 40 found.");
            }

        }

    }
}
