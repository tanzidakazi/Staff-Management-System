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
    public partial class Form5 : Form
    {
        private MyRepo repo;
        private int id;
        public Form5(int id)
        {
            repo = new MyRepo();
            InitializeComponent();
            this.id = id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
        }

        private void LeavingB_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
        }

        private void ReportingB_Click(object sender, EventArgs e)
        {
            textBox7.Visible = true;
        }

        private void EmailB_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void Back4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 b4 = new Form2();
            b4.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string error;
            if (textBox1.Visible)      repo.ModifyAddress(id, textBox1.Text, out error);
            else if (textBox2.Visible) repo.ModifyContactNo(id, textBox2.Text, out error);
            else if (textBox3.Visible) repo.ModifyEmail(id, textBox3.Text, out error);
            else if (textBox4.Visible) repo.ModifyPost(id, textBox4.Text, out error);
            else if (textBox5.Visible) repo.ModifyWorkingDays(id, textBox5.Text, out error);
            else if (textBox6.Visible) repo.ModifyWorkingHours(id, textBox6.Text, out error);
            else if (textBox7.Visible) repo.ModifyReportingTime(id, textBox7.Text, out error);
            else if (textBox8.Visible) repo.ModifyLeavingTime(id, textBox8.Text, out error);

            this.Visible = false;
            Form7 b2 = new Form7();
            b2.Visible = true;
           
        }

        private void AddressB_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void ContactB_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DaysB_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
        }

        private void HoursB_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
