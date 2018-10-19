using SM.Entity;
using SM.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM.UI
{
    public partial class Form1 : Form
    {
        private MyRepo repo;
        public Form1()
        {
            repo = new MyRepo();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdPassword_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Username = usernametf.Text;
            admin.Password = passwordtf.Text;
             string err;
            if (repo.CheckAdmin(admin, out err))
            {
                this.Visible = false;
                Form2 a = new Form2();
                a.Visible = true;
            }
            else
            {
                MessageBox.Show("wrong or missing info ");
            }
        }

        private void AdUsernametf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
