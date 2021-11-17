
namespace deskHOTEL
{
    partial class CadastrarReserva
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
            this.btnVoltarReserva = new System.Windows.Forms.Button();
            this.btnFinalizarCadastro = new System.Windows.Forms.Button();
            this.dtpCheckoutPrevisto = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNumQuarto = new System.Windows.Forms.TextBox();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.lblCheckoutPrevisto = new System.Windows.Forms.Label();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.lblNumQuarto = new System.Windows.Forms.Label();
            this.lblTipoQuarto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoQuarto = new System.Windows.Forms.ComboBox();
            this.lblAndarQuarto = new System.Windows.Forms.Label();
            this.txtAndarQuarto = new System.Windows.Forms.TextBox();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.cboFormaPag = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rdbDesocupado = new System.Windows.Forms.RadioButton();
            this.rdbOcupado = new System.Windows.Forms.RadioButton();
            this.lblCheckoutConfirmado = new System.Windows.Forms.Label();
            this.chkCheckouConfirmado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvlTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltarReserva
            // 
            this.btnVoltarReserva.Location = new System.Drawing.Point(12, 397);
            this.btnVoltarReserva.Name = "btnVoltarReserva";
            this.btnVoltarReserva.Size = new System.Drawing.Size(100, 28);
            this.btnVoltarReserva.TabIndex = 47;
            this.btnVoltarReserva.Text = "Voltar";
            this.btnVoltarReserva.UseVisualStyleBackColor = true;
            this.btnVoltarReserva.Click += new System.EventHandler(this.btnVoltarReserva_Click);
            // 
            // btnFinalizarCadastro
            // 
            this.btnFinalizarCadastro.Location = new System.Drawing.Point(688, 397);
            this.btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            this.btnFinalizarCadastro.Size = new System.Drawing.Size(100, 28);
            this.btnFinalizarCadastro.TabIndex = 45;
            this.btnFinalizarCadastro.Text = "Finalizar";
            this.btnFinalizarCadastro.UseVisualStyleBackColor = true;
            this.btnFinalizarCadastro.Click += new System.EventHandler(this.btnFinalizarCadastro_Click);
            // 
            // dtpCheckoutPrevisto
            // 
            this.dtpCheckoutPrevisto.Location = new System.Drawing.Point(190, 204);
            this.dtpCheckoutPrevisto.Name = "dtpCheckoutPrevisto";
            this.dtpCheckoutPrevisto.Size = new System.Drawing.Size(149, 23);
            this.dtpCheckoutPrevisto.TabIndex = 44;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(69, 282);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Status:";
            // 
            // txtNumQuarto
            // 
            this.txtNumQuarto.Location = new System.Drawing.Point(154, 137);
            this.txtNumQuarto.Name = "txtNumQuarto";
            this.txtNumQuarto.Size = new System.Drawing.Size(71, 23);
            this.txtNumQuarto.TabIndex = 39;
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Location = new System.Drawing.Point(69, 247);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(124, 15);
            this.lblFormaPag.TabIndex = 37;
            this.lblFormaPag.Text = "Forma de pagamento:";
            // 
            // lblCheckoutPrevisto
            // 
            this.lblCheckoutPrevisto.AutoSize = true;
            this.lblCheckoutPrevisto.Location = new System.Drawing.Point(69, 210);
            this.lblCheckoutPrevisto.Name = "lblCheckoutPrevisto";
            this.lblCheckoutPrevisto.Size = new System.Drawing.Size(111, 15);
            this.lblCheckoutPrevisto.TabIndex = 36;
            this.lblCheckoutPrevisto.Text = "Check-out previsto:";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Location = new System.Drawing.Point(69, 175);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(58, 15);
            this.lblCheckin.TabIndex = 35;
            this.lblCheckin.Text = "Check-in:";
            // 
            // lblNumQuarto
            // 
            this.lblNumQuarto.AutoSize = true;
            this.lblNumQuarto.Location = new System.Drawing.Point(69, 140);
            this.lblNumQuarto.Name = "lblNumQuarto";
            this.lblNumQuarto.Size = new System.Drawing.Size(79, 15);
            this.lblNumQuarto.TabIndex = 34;
            this.lblNumQuarto.Text = "N° do quarto:";
            // 
            // lblTipoQuarto
            // 
            this.lblTipoQuarto.AutoSize = true;
            this.lblTipoQuarto.Location = new System.Drawing.Point(69, 108);
            this.lblTipoQuarto.Name = "lblTipoQuarto";
            this.lblTipoQuarto.Size = new System.Drawing.Size(88, 15);
            this.lblTipoQuarto.TabIndex = 33;
            this.lblTipoQuarto.Text = "Tipo do quarto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cadastro de reserva";
            // 
            // cboTipoQuarto
            // 
            this.cboTipoQuarto.FormattingEnabled = true;
            this.cboTipoQuarto.Items.AddRange(new object[] {
            "Standard",
            "Master",
            "Deluxe"});
            this.cboTipoQuarto.Location = new System.Drawing.Point(163, 108);
            this.cboTipoQuarto.Name = "cboTipoQuarto";
            this.cboTipoQuarto.Size = new System.Drawing.Size(176, 23);
            this.cboTipoQuarto.TabIndex = 48;
            // 
            // lblAndarQuarto
            // 
            this.lblAndarQuarto.AutoSize = true;
            this.lblAndarQuarto.Location = new System.Drawing.Point(231, 140);
            this.lblAndarQuarto.Name = "lblAndarQuarto";
            this.lblAndarQuarto.Size = new System.Drawing.Size(42, 15);
            this.lblAndarQuarto.TabIndex = 49;
            this.lblAndarQuarto.Text = "Andar:";
            // 
            // txtAndarQuarto
            // 
            this.txtAndarQuarto.Location = new System.Drawing.Point(279, 137);
            this.txtAndarQuarto.Name = "txtAndarQuarto";
            this.txtAndarQuarto.Size = new System.Drawing.Size(59, 23);
            this.txtAndarQuarto.TabIndex = 50;
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Location = new System.Drawing.Point(133, 169);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(149, 23);
            this.dtpCheckin.TabIndex = 51;
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);
            // 
            // cboFormaPag
            // 
            this.cboFormaPag.FormattingEnabled = true;
            this.cboFormaPag.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de crédito",
            "Cartão de débito",
            "Cheque",
            "PIX"});
            this.cboFormaPag.Location = new System.Drawing.Point(200, 238);
            this.cboFormaPag.Name = "cboFormaPag";
            this.cboFormaPag.Size = new System.Drawing.Size(139, 23);
            this.cboFormaPag.TabIndex = 52;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rdbDesocupado);
            this.gbStatus.Controls.Add(this.rdbOcupado);
            this.gbStatus.Location = new System.Drawing.Point(118, 270);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(203, 29);
            this.gbStatus.TabIndex = 53;
            this.gbStatus.TabStop = false;
            this.gbStatus.Enter += new System.EventHandler(this.gbStatus_Enter);
            // 
            // rdbDesocupado
            // 
            this.rdbDesocupado.AutoSize = true;
            this.rdbDesocupado.Location = new System.Drawing.Point(81, 10);
            this.rdbDesocupado.Name = "rdbDesocupado";
            this.rdbDesocupado.Size = new System.Drawing.Size(91, 19);
            this.rdbDesocupado.TabIndex = 1;
            this.rdbDesocupado.TabStop = true;
            this.rdbDesocupado.Text = "Desocupado";
            this.rdbDesocupado.UseVisualStyleBackColor = true;
            // 
            // rdbOcupado
            // 
            this.rdbOcupado.AutoSize = true;
            this.rdbOcupado.Location = new System.Drawing.Point(7, 10);
            this.rdbOcupado.Name = "rdbOcupado";
            this.rdbOcupado.Size = new System.Drawing.Size(74, 19);
            this.rdbOcupado.TabIndex = 0;
            this.rdbOcupado.TabStop = true;
            this.rdbOcupado.Text = "Ocupado";
            this.rdbOcupado.UseVisualStyleBackColor = true;
            // 
            // lblCheckoutConfirmado
            // 
            this.lblCheckoutConfirmado.AutoSize = true;
            this.lblCheckoutConfirmado.Location = new System.Drawing.Point(69, 311);
            this.lblCheckoutConfirmado.Name = "lblCheckoutConfirmado";
            this.lblCheckoutConfirmado.Size = new System.Drawing.Size(131, 15);
            this.lblCheckoutConfirmado.TabIndex = 54;
            this.lblCheckoutConfirmado.Text = "Check-out confirmado:";
            this.lblCheckoutConfirmado.Click += new System.EventHandler(this.lblCheckoutConfirmado_Click);
            // 
            // chkCheckouConfirmado
            // 
            this.chkCheckouConfirmado.AutoSize = true;
            this.chkCheckouConfirmado.Location = new System.Drawing.Point(207, 311);
            this.chkCheckouConfirmado.Name = "chkCheckouConfirmado";
            this.chkCheckouConfirmado.Size = new System.Drawing.Size(15, 14);
            this.chkCheckouConfirmado.TabIndex = 55;
            this.chkCheckouConfirmado.UseVisualStyleBackColor = true;
            this.chkCheckouConfirmado.CheckedChanged += new System.EventHandler(this.chkCheckouConfirmado_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(561, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "Valor total:";
            // 
            // lvlTotal
            // 
            this.lvlTotal.AutoSize = true;
            this.lvlTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlTotal.Location = new System.Drawing.Point(650, 311);
            this.lvlTotal.Name = "lvlTotal";
            this.lvlTotal.Size = new System.Drawing.Size(111, 41);
            this.lvlTotal.TabIndex = 57;
            this.lvlTotal.Text = "24,000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(615, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "R$";
            // 
            // CadastrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvlTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkCheckouConfirmado);
            this.Controls.Add(this.lblCheckoutConfirmado);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.cboFormaPag);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.txtAndarQuarto);
            this.Controls.Add(this.lblAndarQuarto);
            this.Controls.Add(this.cboTipoQuarto);
            this.Controls.Add(this.btnVoltarReserva);
            this.Controls.Add(this.btnFinalizarCadastro);
            this.Controls.Add(this.dtpCheckoutPrevisto);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtNumQuarto);
            this.Controls.Add(this.lblFormaPag);
            this.Controls.Add(this.lblCheckoutPrevisto);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.lblNumQuarto);
            this.Controls.Add(this.lblTipoQuarto);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarReserva";
            this.Text = "CadastrarReserva";
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarReserva;
        private System.Windows.Forms.Button btnFinalizarCadastro;
        private System.Windows.Forms.DateTimePicker dtpCheckoutPrevisto;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNumQuarto;
        private System.Windows.Forms.Label lblFormaPag;
        private System.Windows.Forms.Label lblCheckoutPrevisto;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Label lblNumQuarto;
        private System.Windows.Forms.Label lblTipoQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoQuarto;
        private System.Windows.Forms.Label lblAndarQuarto;
        private System.Windows.Forms.TextBox txtAndarQuarto;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.ComboBox cboFormaPag;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rdbDesocupado;
        private System.Windows.Forms.RadioButton rdbOcupado;
        private System.Windows.Forms.Label lblCheckoutConfirmado;
        private System.Windows.Forms.CheckBox chkCheckouConfirmado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lvlTotal;
        private System.Windows.Forms.Label label3;
    }
}