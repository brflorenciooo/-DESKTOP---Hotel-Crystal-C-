using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class AlterarSubcliente : Form
    {
        public AlterarSubcliente()
        {
            InitializeComponent();
        }

        private void dtpDataNascSubcliente_ValueChanged(object sender, EventArgs e)
        {
            dtpDataNascSubcliente.Format = DateTimePickerFormat.Short;
        }

        private void btnVoltarSubcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlterarCliente alterarCliente = new AlterarCliente();
            alterarCliente.FormClosed += (s, args) => this.Close();
            alterarCliente.Show();
        }

        private void btnProximoSubcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlterarReserva alterarReserva = new AlterarReserva();
            alterarReserva.FormClosed += (s, args) => this.Close();
            alterarReserva.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNomeSubcliente.Enabled = true;
            txtEmailSubcliente.Enabled = true;
            txtTelefoneSubcliente.Enabled = true;
            dtpDataNascSubcliente.Enabled = true;
            mskCpfSubcliente.Enabled = true;
            txtRgSubcliente.Enabled = true;
        }
    }
}
