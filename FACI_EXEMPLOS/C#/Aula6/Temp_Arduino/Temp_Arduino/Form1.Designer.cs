namespace Temp_Arduino
{
    partial class Termometro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Termometro));
            this.btIniciar = new System.Windows.Forms.Button();
            this.lbPorta = new System.Windows.Forms.Label();
            this.txPorta = new System.Windows.Forms.TextBox();
            this.thermControl1 = new ThermometerControl.ThermControl();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.ForeColor = System.Drawing.Color.Chartreuse;
            this.btIniciar.Location = new System.Drawing.Point(27, 522);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(125, 63);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Text = "INICIAR";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // lbPorta
            // 
            this.lbPorta.AutoSize = true;
            this.lbPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorta.Location = new System.Drawing.Point(41, 466);
            this.lbPorta.Name = "lbPorta";
            this.lbPorta.Size = new System.Drawing.Size(111, 24);
            this.lbPorta.TabIndex = 2;
            this.lbPorta.Text = "Porta COM";
            // 
            // txPorta
            // 
            this.txPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPorta.Location = new System.Drawing.Point(158, 466);
            this.txPorta.Name = "txPorta";
            this.txPorta.Size = new System.Drawing.Size(100, 29);
            this.txPorta.TabIndex = 3;
            this.txPorta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // thermControl1
            // 
            this.thermControl1.Location = new System.Drawing.Point(91, 12);
            this.thermControl1.MinimumSize = new System.Drawing.Size(180, 315);
            this.thermControl1.Name = "thermControl1";
            this.thermControl1.Size = new System.Drawing.Size(180, 420);
            this.thermControl1.TabIndex = 5;
            this.thermControl1.Value = 0;
            this.thermControl1.Load += new System.EventHandler(this.thermControl1_Load);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.Chocolate;
            this.btFinalizar.Location = new System.Drawing.Point(186, 522);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(125, 63);
            this.btFinalizar.TabIndex = 2;
            this.btFinalizar.Text = "FINALIZAR";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Termometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(338, 597);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.thermControl1);
            this.Controls.Add(this.txPorta);
            this.Controls.Add(this.lbPorta);
            this.Controls.Add(this.btIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Termometro";
            this.Text = "Termômetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Label lbPorta;
        private System.Windows.Forms.TextBox txPorta;
        private ThermometerControl.ThermControl thermControl1;
        private System.Windows.Forms.Button btFinalizar;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

