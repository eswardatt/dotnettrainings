using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace interviewstatus
{
    public class Repo
    {
        private static readonly object obj = new object();
        private static Repo instance = null;
        public static Repo GetInstance()
        {
            // double checked lock 
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Repo();
                    }
                }
            }


            return instance;
        }

        public DataTable save(Employee obj)
        {
            string qry = $"insert into EmployeeStatus(empName,empStatus,JDE) values ('{obj.Name}','{obj.JobStatus}','{obj.JobDescription}')" +
                "select id,empName,empStatus,JDE from EmployeeStatus where id = IDENT_CURRENT('EmployeeStatus');";
            return Get(qry);
        }

        public List<Employee> GetEmployees(int id)
        {
            string qry = $"select id,empName,empStatus,JDE,empStatus,createddate from EmployeeStatus where isactive=1 ;";
            DataTable dt = new DataTable(); dt = Get(qry);
            List<Employee> _list = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                Employee employee = new Employee()
                {
                    Id = Convert.ToInt32(row["id"]),
                    Name = row["empName"].ToString(),
                    JobDate = Convert.ToDateTime(row["createddate"]),
                    JobStatus = row["empStatus"].ToString(),
                };
                _list.Add(employee);
            }
            return _list;
        }

        public List<Employee> GetEmployees()
        {
            string qry = $"select id,empName from EmployeeStatus where isactive=1 ;";
            DataTable dt = Get(qry);
            List<Employee> _list = new List<Employee>();
            Employee employee = new Employee();
            foreach (DataRow row in dt.Rows)
            {
                employee.Id = Convert.ToInt32(row["id"]);
                employee.Name = row["empName"].ToString();
                _list.Add(employee);
            }
            return _list;
        }

        private DataTable Get(string qry)
        {
            string conStr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;

        }
    }
}