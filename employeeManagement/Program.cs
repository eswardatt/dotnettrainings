using System;
using System.Collections.Generic;

namespace employeeManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            EmployeeBAL employeeBAL = new EmployeeBAL();
            //Employee employee = new Employee();

            //Console.WriteLine("Enter employee name : ");
            //employee.Name = Console.ReadLine().ToString();
            //Console.WriteLine("Enter employee email : ");
            //employee.Email = Console.ReadLine().ToString();

            //Console.WriteLine("Enter employee Phone : ");
            //employee.Phone = Console.ReadLine().ToString();
            //Console.WriteLine("Enter employee Address : ");
            //employee.Address = Console.ReadLine().ToString();

            //Employee employeedata = employeeBAL.AddEmployee(employee);

            //Console.WriteLine("Data saved succfully");
            //Console.WriteLine($"Id : {employeedata.Id} \nName : {employeedata.Name}\nEmail : {employeedata.Email}");

            Console.WriteLine("Enter no.of employees to insert");
            int num = Convert.ToInt32(Console.ReadLine());
            List<Employee> employees1 = new List<Employee>();

            for (int i = 0; i < num; i++)
            {
                Employee employee = new Employee();

                Console.WriteLine("Enter employee name : ");
                employee.Name = Console.ReadLine().ToString();
                Console.WriteLine("Enter employee email : ");
                employee.Email = Console.ReadLine().ToString();

                Console.WriteLine("Enter employee Phone : ");
                employee.Phone = Console.ReadLine().ToString();
                Console.WriteLine("Enter employee Address : ");
                employee.Address = Console.ReadLine().ToString();

                employees1.Add(employee);
            }
            Console.WriteLine($"Employes count : {employees1.Count}");
            //string st = employeeBAL.AddEmployees(employees1);
            //Console.WriteLine(st);
            EmployeeDal employeeDal = new EmployeeDal();
            employeeDal.SaveSqlBulk(employees1);

            //List<Employee> employees = employeeBAL.GetEmployees();
            //if (employees.Count > 0)
            //{
            //    foreach (var item in employees)
            //    {
            //        Console.WriteLine($"Id : {item.Id} \nName : {item.Name}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Data Found!");
            //}

            // count 
        }
    }
}
