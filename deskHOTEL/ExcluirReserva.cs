using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class ExcluirReserva : Form
    {
        public ExcluirReserva()
        {
            InitializeComponent();
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckin.Format = DateTimePickerFormat.Short;
            dtpCheckoutPrevisto.Format = DateTimePickerFormat.Short;
        }

        private void btnVoltarReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirSubcliente excluirSubcliente = new ExcluirSubcliente();
            excluirSubcliente.FormClosed += (s, args) => this.Close();
            excluirSubcliente.Show();
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Cliente cliente = new Cliente();
                cliente.FormClosed += (s, args) => this.Close();
                cliente.Show();
            }
        }
    }
}
