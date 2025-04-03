using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;

namespace Temp_Arduino
{
    public partial class Termometro : Form
    {
        public Termometro()
        {
            InitializeComponent(); // INICIALIZA COMPONENTES DO FORMULARIO (FORM)
        }

        private void lerTemp(object sender, EventArgs e)
        {
            byte[] dados = new byte[2]; // BUFFER PARA DADOS (NÃO UTILIZADOS)
            string valor; //VARIÁVEL PARA ARMAZENAMENTO DE LEITURA

            valor = serialPort1.ReadExisting(); //LÊ TODOS OS DADOS QUE SERÃO DISPONIBILIZADOS PELA PORTA SERIAL

            if (valor != "") // SE RECEBEU DADOS
            {
                thermControl1.UpdateControl(Convert.ToInt32(valor)); //ATUALIZA CONTROLE DE TEMPERATURA

                // LIMPA BUFFER DA PORTA SERIAL
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerTemp)); 
        }

        private void thermControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (txPorta.Text != "")
                serialPort1.PortName = txPorta.Text;
            if (!serialPort1.IsOpen)
                serialPort1.Open();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                serialPort1.Close();

            Application.Exit();
        }
    }
}
