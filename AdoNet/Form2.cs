using AdoNet.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string email = txtemail.Text;
            Employee employee = new Employee
            {
                MyProperty = name,
                Email = email

            };
            AppContext appContext = new AppContext();
            appContext.Employees.Add(employee);
            appContext.SaveChanges();


        }
        void GetEmployees()
        {
            AppContext appContext = new AppContext();
            List<Employee> employees = appContext.Employees.ToList().Where(x=>x.Email=="").ToList();
        }
    }
}
