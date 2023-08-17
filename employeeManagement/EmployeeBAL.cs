﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace employeeManagement
{
    class EmployeeBAL
    {
        EmployeeDal employeeDal = new EmployeeDal();


        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string qry = $"select Id,EmployeeName,Email,Phone,Address from [EmployeeData]";

            DataTable dt = employeeDal.Get(qry);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Employee employee = new Employee()
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["EmployeeName"].ToString(),
                        Phone = row["Phone"].ToString(),
                        Address = row["Address"].ToString()
                    };
                    employees.Add(employee);
                }
            }

            return employees;
        }

        public Employee GetEmployees(int id)
        {
            Employee employees = new Employee();
            return employees;
        }

        public Employee AddEmployee(Employee obj)
        {

            string qry = $"exec sp_insertEmployee '{obj.Name}','{obj.Email}','{obj.Phone}','{obj.Address}'";
            DataTable dt = employeeDal.Get(qry);
            Employee employee = new Employee();
            foreach (DataRow row in dt.Rows) 
            { 
                employee.Id = Convert.ToInt32(row["Id"]);
                employee.Name = row["EmployeeName"].ToString();
                employee.Phone = row["Phone"].ToString();
                employee.Address = row["Address"].ToString();
                employee.Email = row["Email"].ToString();
            }
            return employee;
        }

        public string AddEmployees(List<Employee> employees)
        {
            DataTable dt = new DataTable();
            string msg = "";
            int empCount = employees.Count;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("insert into [EmployeeData] ([EmployeeName],[Email],[Phone],[Address]) values");
                
                for (int i = 0; i < empCount; i++)
                {
                    sb.Append($"('{employees[i].Name}','{employees[i].Email}','{employees[i].Phone}','{employees[i].Address}'),");
                }
                string qry = sb.ToString().TrimEnd(',');
                qry += $"\n select top {empCount} Id,EmployeeName,Email,Phone,Address from [EmployeeData] order by Id desc ; ";

               
                dt = employeeDal.Get(qry);
                if (dt.Rows.Count == empCount)
                {
                    msg = $"Records : {empCount} saved successfully";
                }
            }
            catch (Exception ex)
            {

                msg = ex.Message.ToString();
            }

            return msg;
           

        }

        public Employee UpdateEmployee(Employee obj)
        {
            Employee employees = new Employee();
            return employees;
        }

        public Employee DeleteEmployees(int id)
        {
            Employee employees = new Employee();
            return employees;
        }

    }
}
