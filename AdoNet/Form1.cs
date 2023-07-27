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
    public partial class Form1 : Form
    {
        Repo repo = new Repo();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            binddate();
        }
        void Saveskill()
        {
            
            string skillName = txtskillname.Text;
            string createdby = txtcreatedby.Text;
            repo.AddSkill(skillName,createdby);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Saveskill();
            binddate();
        }

        void binddate()
        {
            dataGridView1.DataSource = repo.Get_1();
        }
    }
}
