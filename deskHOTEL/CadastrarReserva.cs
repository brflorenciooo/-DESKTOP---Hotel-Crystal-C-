using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class CadastrarReserva : Form
    {
        public CadastrarReserva()
        {
            InitializeComponent();
        }

        private void gbStatus_Enter(object sender, EventArgs e)
        {

        }

        private void chkCheckouConfirmado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCheckoutConfirmado_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarSubcliente cadastrarSubcliente = new CadastrarSubcliente();
            cadastrarSubcliente.FormClosed += (s, args) => this.Close();
            cadastrarSubcliente.Show();
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Cliente cliente = new Cliente();
                cliente.FormClosed += (s, args) => this.Close();
                cliente.Show();
            }
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckin.Format = DateTimePickerFormat.Short;
            dtpCheckoutPrevisto.Format = DateTimePickerFormat.Short;
        }
    }
}
