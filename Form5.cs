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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Form4 filho4 = new Form4();
            filho4.Show();
        }
    }
}
