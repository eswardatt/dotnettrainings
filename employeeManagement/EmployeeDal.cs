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

        

    }
}
