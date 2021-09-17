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
    public partial class Form3 : Form
    {
        Form1 filho1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            filho1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário cadastrado com sucesso.");
            filho1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Floricultura cadastrada com sucesso.");
            filho1.Show();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Form1 filho1 = new Form1();
            filho1.Show();
        }
    }
}
