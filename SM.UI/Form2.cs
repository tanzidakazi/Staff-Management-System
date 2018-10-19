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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewLable_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 view = new Form7();
            view.Visible = true;
        }

        private void AddLabel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 addStaff = new Form3();
            addStaff.Visible = true;
        }
  
        private void ModifyLabel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 modify = new Form4();
            modify.Visible = true;
        }

        private void SalaryDetailsLable_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 salaryDetails = new Form4();
            salaryDetails.Visible = true;
        }

        private void BackLabel1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 b1 = new Form1();
            b1.Visible = true;
        }

     
    }
}
