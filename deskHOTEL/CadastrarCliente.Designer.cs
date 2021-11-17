
namespace deskHOTEL
{
    partial class CadastrarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.lblDataNascCliente = new System.Windows.Forms.Label();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblRgCliente = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascCliente = new System.Windows.Forms.DateTimePicker();
            this.btnProximoCliente = new System.Windows.Forms.Button();
            this.btnLimparCliente = new System.Windows.Forms.Button();
            this.btnVoltarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de clientes";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(69, 121);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(43, 15);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(69, 153);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(39, 15);
            this.lblEmailCliente.TabIndex = 2;
            this.lblEmailCliente.Text = "Email:";
            this.lblEmailCliente.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(69, 188);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(96, 15);
            this.lblTelefoneCliente.TabIndex = 3;
            this.lblTelefoneCliente.Text = "Telefone/Celular:";
            // 
            // lblDataNascCliente
            // 
            this.lblDataNascCliente.AutoSize = true;
            this.lblDataNascCliente.Location = new System.Drawing.Point(69, 223);
            this.lblDataNascCliente.Name = "lblDataNascCliente";
            this.lblDataNascCliente.Size = new System.Drawing.Size(115, 15);
            this.lblDataNascCliente.TabIndex = 4;
            this.lblDataNascCliente.Text = "Data de nascimento:";
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(69, 267);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(31, 15);
            this.lblCpfCliente.TabIndex = 5;
            this.lblCpfCliente.Text = "CPF:";
            this.lblCpfCliente.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 23);
            this.textBox2.TabIndex = 7;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(171, 185);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(168, 23);
            this.txtTelefoneCliente.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 307);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 23);
            this.textBox4.TabIndex = 9;
            // 
            // lblRgCliente
            // 
            this.lblRgCliente.AutoSize = true;
            this.lblRgCliente.Location = new System.Drawing.Point(69, 310);
            this.lblRgCliente.Name = "lblRgCliente";
            this.lblRgCliente.Size = new System.Drawing.Size(25, 15);
            this.lblRgCliente.TabIndex = 10;
            this.lblRgCliente.Text = "RG:";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(114, 267);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 23);
            this.mskCpf.TabIndex = 11;
            // 
            // dtpDataNascCliente
            // 
            this.dtpDataNascCliente.Location = new System.Drawing.Point(190, 217);
            this.dtpDataNascCliente.Name = "dtpDataNascCliente";
            this.dtpDataNascCliente.Size = new System.Drawing.Size(149, 23);
            this.dtpDataNascCliente.TabIndex = 12;
            this.dtpDataNascCliente.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnProximoCliente
            // 
            this.btnProximoCliente.Location = new System.Drawing.Point(688, 410);
            this.btnProximoCliente.Name = "btnProximoCliente";
            this.btnProximoCliente.Size = new System.Drawing.Size(100, 28);
            this.btnProximoCliente.TabIndex = 13;
            this.btnProximoCliente.Text = "Próximo";
            this.btnProximoCliente.UseVisualStyleBackColor = true;
            this.btnProximoCliente.Click += new System.EventHandler(this.btnProximoCliente_Click);
            // 
            // btnLimparCliente
            // 
            this.btnLimparCliente.Location = new System.Drawing.Point(354, 410);
            this.btnLimparCliente.Name = "btnLimparCliente";
            this.btnLimparCliente.Size = new System.Drawing.Size(100, 28);
            this.btnLimparCliente.TabIndex = 14;
            this.btnLimparCliente.Text = "Limpar";
            this.btnLimparCliente.UseVisualStyleBackColor = true;
            // 
            // btnVoltarCliente
            // 
            this.btnVoltarCliente.Location = new System.Drawing.Point(12, 410);
            this.btnVoltarCliente.Name = "btnVoltarCliente";
            this.btnVoltarCliente.Size = new System.Drawing.Size(100, 28);
            this.btnVoltarCliente.TabIndex = 15;
            this.btnVoltarCliente.Text = "Voltar";
            this.btnVoltarCliente.UseVisualStyleBackColor = true;
            this.btnVoltarCliente.Click += new System.EventHandler(this.btnVoltarCliente_Click);
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarCliente);
            this.Controls.Add(this.btnLimparCliente);
            this.Controls.Add(this.btnProximoCliente);
            this.Controls.Add(this.dtpDataNascCliente);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblRgCliente);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCpfCliente);
            this.Controls.Add(this.lblDataNascCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarCliente";
            this.Text = "a";
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.Label lblDataNascCliente;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblRgCliente;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.DateTimePicker dtpDataNascCliente;
        private System.Windows.Forms.Button btnProximoCliente;
        private System.Windows.Forms.Button btnLimparCliente;
        private System.Windows.Forms.Button btnVoltarCliente;
    }
}