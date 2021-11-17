
namespace deskHOTEL
{
    partial class ConsultarCliente
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
            this.btnVoltarCliente = new System.Windows.Forms.Button();
            this.btnProximoCliente = new System.Windows.Forms.Button();
            this.dtpDataNascCliente = new System.Windows.Forms.DateTimePicker();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblRgCliente = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.lblDataNascCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltarCliente
            // 
            this.btnVoltarCliente.Location = new System.Drawing.Point(12, 397);
            this.btnVoltarCliente.Name = "btnVoltarCliente";
            this.btnVoltarCliente.Size = new System.Drawing.Size(100, 28);
            this.btnVoltarCliente.TabIndex = 31;
            this.btnVoltarCliente.Text = "Voltar";
            this.btnVoltarCliente.UseVisualStyleBackColor = true;
            this.btnVoltarCliente.Click += new System.EventHandler(this.btnVoltarCliente_Click);
            // 
            // btnProximoCliente
            // 
            this.btnProximoCliente.Location = new System.Drawing.Point(688, 397);
            this.btnProximoCliente.Name = "btnProximoCliente";
            this.btnProximoCliente.Size = new System.Drawing.Size(100, 28);
            this.btnProximoCliente.TabIndex = 29;
            this.btnProximoCliente.Text = "Próximo";
            this.btnProximoCliente.UseVisualStyleBackColor = true;
            this.btnProximoCliente.Click += new System.EventHandler(this.btnProximoCliente_Click);
            // 
            // dtpDataNascCliente
            // 
            this.dtpDataNascCliente.Enabled = false;
            this.dtpDataNascCliente.Location = new System.Drawing.Point(190, 204);
            this.dtpDataNascCliente.Name = "dtpDataNascCliente";
            this.dtpDataNascCliente.Size = new System.Drawing.Size(149, 23);
            this.dtpDataNascCliente.TabIndex = 28;
            this.dtpDataNascCliente.ValueChanged += new System.EventHandler(this.dtpDataNascCliente_ValueChanged);
            // 
            // mskCpf
            // 
            this.mskCpf.Enabled = false;
            this.mskCpf.Location = new System.Drawing.Point(114, 254);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 23);
            this.mskCpf.TabIndex = 27;
            // 
            // lblRgCliente
            // 
            this.lblRgCliente.AutoSize = true;
            this.lblRgCliente.Location = new System.Drawing.Point(69, 297);
            this.lblRgCliente.Name = "lblRgCliente";
            this.lblRgCliente.Size = new System.Drawing.Size(25, 15);
            this.lblRgCliente.TabIndex = 26;
            this.lblRgCliente.Text = "RG:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(113, 294);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 23);
            this.textBox4.TabIndex = 25;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Enabled = false;
            this.txtTelefoneCliente.Location = new System.Drawing.Point(171, 172);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(168, 23);
            this.txtTelefoneCliente.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(113, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 23);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(113, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 23);
            this.textBox1.TabIndex = 22;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(69, 254);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(31, 15);
            this.lblCpfCliente.TabIndex = 21;
            this.lblCpfCliente.Text = "CPF:";
            // 
            // lblDataNascCliente
            // 
            this.lblDataNascCliente.AutoSize = true;
            this.lblDataNascCliente.Location = new System.Drawing.Point(69, 210);
            this.lblDataNascCliente.Name = "lblDataNascCliente";
            this.lblDataNascCliente.Size = new System.Drawing.Size(115, 15);
            this.lblDataNascCliente.TabIndex = 20;
            this.lblDataNascCliente.Text = "Data de nascimento:";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(69, 175);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(96, 15);
            this.lblTelefoneCliente.TabIndex = 19;
            this.lblTelefoneCliente.Text = "Telefone/Celular:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(69, 140);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(39, 15);
            this.lblEmailCliente.TabIndex = 18;
            this.lblEmailCliente.Text = "Email:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(69, 108);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(43, 15);
            this.lblNomeCliente.TabIndex = 17;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Consulta de clientes";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarCliente);
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
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarCliente;
        private System.Windows.Forms.Button btnProximoCliente;
        private System.Windows.Forms.DateTimePicker dtpDataNascCliente;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblRgCliente;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Label lblDataNascCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label1;
    }
}