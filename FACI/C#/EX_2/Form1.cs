using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Botão Executar 4318
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult bc;
            MessageBoxButtons bot = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxDefaultButton bd = MessageBoxDefaultButton.Button1;
            bc = MessageBox.Show("Message\nBox","Informação",bot, icon, bd);

            switch(bc)
            {
                case DialogResult.OK:
                    textBox1.Text = "OK";
                    break;
                    case DialogResult.Cancel:
                    textBox1.Text = "Cancelar";
                    break;
            }


            
        }
        //Botão Sair
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
