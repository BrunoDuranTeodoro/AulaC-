using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace objetivo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            DialogResult bc;
            MessageBoxButtons bot = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxDefaultButton bd = MessageBoxDefaultButton.Button1;
            bc = MessageBox.Show("Certeza que\ndeseja sair?", "Informação", bot, icon, bd);

            switch (bc)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    textBox1.Text = "Aguardando";
                    pictureBox1.Image = Image.FromFile("c:\\imagens\\Amarelo.bmp");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Vermelho.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox1.Text = "LIGADO";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox1.Text = "DESLIGADO";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Aguardando";
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Amarelo.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
