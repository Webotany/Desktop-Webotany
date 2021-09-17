using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWebotany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.FromArgb(4, 178, 78);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        { 
            Form2 filho2 = new Form2();
            filho2.MdiParent = this;
            filho2.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 filho3 = new Form3();
            filho3.MdiParent = this;
            filho3.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
