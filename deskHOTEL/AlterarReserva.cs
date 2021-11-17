using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class AlterarReserva : Form
    {
        public AlterarReserva()
        {
            InitializeComponent();
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckoutPrevisto.Format = DateTimePickerFormat.Short;
            dtpCheckin.Format = DateTimePickerFormat.Short;
        }

        private void btnVoltarReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlterarSubcliente alterarSubcliente = new AlterarSubcliente();
            alterarSubcliente.FormClosed += (s, args) => this.Close();
            alterarSubcliente.Show();
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Cliente cliente = new Cliente();
                cliente.FormClosed += (s, args) => this.Close();
                cliente.Show();
            }
        }

        private void txtAndarQuarto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cboTipoQuarto.Enabled = true;
            txtNumQuarto.Enabled = true;
            txtAndarQuarto.Enabled = true;
            dtpCheckin.Enabled = true;
            dtpCheckoutPrevisto.Enabled = true;
            cboFormaPag.Enabled = true;
            gbStatus.Enabled = true;
            chkCheckouConfirmado.Enabled = true;

        }
    }
}
