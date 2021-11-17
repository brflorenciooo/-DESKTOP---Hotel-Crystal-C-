
namespace deskHOTEL
{
    partial class Excluir
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
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.dgvExcluirCliente = new System.Windows.Forms.DataGridView();
            this.mskCpfBusca = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfBusca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluirCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 408);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Location = new System.Drawing.Point(666, 408);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(109, 23);
            this.btnExcluirCliente.TabIndex = 13;
            this.btnExcluirCliente.Text = "Excluir Cliente";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // dgvExcluirCliente
            // 
            this.dgvExcluirCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcluirCliente.Location = new System.Drawing.Point(13, 59);
            this.dgvExcluirCliente.Name = "dgvExcluirCliente";
            this.dgvExcluirCliente.RowTemplate.Height = 25;
            this.dgvExcluirCliente.Size = new System.Drawing.Size(775, 341);
            this.dgvExcluirCliente.TabIndex = 12;
            // 
            // mskCpfBusca
            // 
            this.mskCpfBusca.Location = new System.Drawing.Point(204, 20);
            this.mskCpfBusca.Mask = "000.000.000-00";
            this.mskCpfBusca.Name = "mskCpfBusca";
            this.mskCpfBusca.Size = new System.Drawing.Size(100, 23);
            this.mskCpfBusca.TabIndex = 11;
            // 
            // lblCpfBusca
            // 
            this.lblCpfBusca.AutoSize = true;
            this.lblCpfBusca.Location = new System.Drawing.Point(67, 29);
            this.lblCpfBusca.Name = "lblCpfBusca";
            this.lblCpfBusca.Size = new System.Drawing.Size(130, 15);
            this.lblCpfBusca.TabIndex = 10;
            this.lblCpfBusca.Text = "Digite o CPF do cliente:";
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.dgvExcluirCliente);
            this.Controls.Add(this.mskCpfBusca);
            this.Controls.Add(this.lblCpfBusca);
            this.Name = "Excluir";
            this.Text = "Excluir";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluirCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.DataGridView dgvExcluirCliente;
        private System.Windows.Forms.MaskedTextBox mskCpfBusca;
        private System.Windows.Forms.Label lblCpfBusca;
    }
}