using SM.Entity;
using SM.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM.UI
{
    public partial class Form3 : Form
    {

        private MyRepo repo;
        public Form3()
        {
            repo = new MyRepo();
            InitializeComponent();
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            Form2 b2 = new Form2();
            b2.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add2_Click(object sender, EventArgs e)
        {
            Employee info = new Employee();
            info.Name = nametf.Text;
            info.Id = Convert.ToInt32(idtf.Text);
            info.DOB = dobtf.Text;
            info.Gender = gendertf.Text;
            info.Address = addresstf.Text;
            info.Email = emailtf.Text;
            info.ContactNumber = contactnotf.Text;
            info.JoiningDate = joiningdatetf.Text;
            info.Post = posttf.Text;
            info.Salary = salarytf.Text;
            info.WorkingDays = workingdaystf.Text;
            info.WorkingHours = workinghourstf.Text;
            info.ReportingTime = reportingtimetf.Text;
            info.LeavingTime = leavingtimetf.Text;


            string error;
            if (!repo.AddInfo(info, out error))
            {
                /*this.Visible = false;
                Form7 a2 = new Form7();
                a2.Visible = true;*/
            }
           // else { MessageBox.Show("wrong or missing info"); }
            this.Visible = false;
            Form7 a2 = new Form7();
            a2.Visible = true;
        }

        private void NameL_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtf_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gendertf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
