using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = textName.Text;
            string pwd = textBox1.Text;
            if (username.Equals("Admin") && pwd.Equals("123"))
            {
                label1.Text = "Success";
            }
            else
            {
                label1.Text = "invalid!";
            }
        }
    }
}
