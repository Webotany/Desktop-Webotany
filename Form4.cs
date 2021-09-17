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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Form5 filho5 = new Form5();
            filho5.Show();
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            Form6 filho6 = new Form6();
            filho6.Show();
        }
    }
}
