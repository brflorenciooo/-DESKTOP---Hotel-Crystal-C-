
namespace deskHOTEL
{
    partial class Alterar
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.dgvAlterarCliente = new System.Windows.Forms.DataGridView();
            this.mskCpfBusca = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfBusca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 408);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(666, 408);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(109, 23);
            this.btnAlterarCliente.TabIndex = 8;
            this.btnAlterarCliente.Text = "Alterar Cliente";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // dgvAlterarCliente
            // 
            this.dgvAlterarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlterarCliente.Location = new System.Drawing.Point(13, 59);
            this.dgvAlterarCliente.Name = "dgvAlterarCliente";
            this.dgvAlterarCliente.RowTemplate.Height = 25;
            this.dgvAlterarCliente.Size = new System.Drawing.Size(775, 341);
            this.dgvAlterarCliente.TabIndex = 7;
            // 
            // mskCpfBusca
            // 
            this.mskCpfBusca.Location = new System.Drawing.Point(204, 20);
            this.mskCpfBusca.Mask = "000.000.000-00";
            this.mskCpfBusca.Name = "mskCpfBusca";
            this.mskCpfBusca.Size = new System.Drawing.Size(100, 23);
            this.mskCpfBusca.TabIndex = 6;
            // 
            // lblCpfBusca
            // 
            this.lblCpfBusca.AutoSize = true;
            this.lblCpfBusca.Location = new System.Drawing.Point(67, 29);
            this.lblCpfBusca.Name = "lblCpfBusca";
            this.lblCpfBusca.Size = new System.Drawing.Size(130, 15);
            this.lblCpfBusca.TabIndex = 5;
            this.lblCpfBusca.Text = "Digite o CPF do cliente:";
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.dgvAlterarCliente);
            this.Controls.Add(this.mskCpfBusca);
            this.Controls.Add(this.lblCpfBusca);
            this.Name = "Alterar";
            this.Text = "Alterar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.DataGridView dgvAlterarCliente;
        private System.Windows.Forms.MaskedTextBox mskCpfBusca;
        private System.Windows.Forms.Label lblCpfBusca;
    }
}