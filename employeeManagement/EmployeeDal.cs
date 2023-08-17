using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeManagement
{
    // Single ton
    class EmployeeDal
    {
         string constr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        SqlConnection sqlConnection;
        
        public DataTable Get(string qry)
        {
            DataTable dataTable = new DataTable();
            sqlConnection = new SqlConnection(constr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, sqlConnection);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void SaveSqlBulk(List<Employee> employees)
        {
            try
            {
                DataTable dt = new DataTable();
                //Adding columns
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("EmployeeName", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("Address", typeof(string));
                int empcount = employees.Count;
                if (empcount > 0)
                {
                    for (int i = 0; i < empcount; i++)
                    {
                        dt.Rows.Add(i+1,employees[i].Name, employees[i].Email, employees[i].Phone, employees[i].Address);
                    }
                    sqlConnection = new SqlConnection(constr);
                    sqlConnection.Open();
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlConnection);
                    bulkCopy.DestinationTableName = "EmployeeData";
                    bulkCopy.WriteToServer(dt);
                }

                Console.WriteLine("Data Added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error : {ex.Message.ToString()}");

            }
           
        }
    }
}
