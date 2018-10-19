using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM.LogicLayer;

namespace SM.UI
{
    public partial class Form4 : Form
    {
        private MyRepo repo;
        public Form4()
        {
            repo = new MyRepo();
            InitializeComponent();
            //dataGridView1.DataSource = repo.GetInfoId();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 s = new Form6();
            s.Visible = true;
        }

        private void Back3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 b3 = new Form2();
            b3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Idtf.Text);
            if (repo.GetInfoId(id) != null)
            {
                this.Visible = false;
                Form5 m = new Form5(id);
                m.Visible = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
