using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    class Repo
    {
        string conStr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        public void AddSkill(string skillname,string createdby)
        {
            string qry = $"insert into MySkills (Id,SkillName,createdby,updatedby) values (NEWID(),'{skillname}','{createdby}','{createdby}')";
            SqlConnection connection = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(qry,connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable Get()
        {
            DataTable dt = new DataTable();
            string qry = "SELECT SkillName,[created] from [MySkills] order by SkillName";
            SqlConnection sqlConnection = new SqlConnection(conStr);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(qry,sqlConnection);
            sqlDataAdapter.Fill(dt);
            return dt;
        }
    }
}
