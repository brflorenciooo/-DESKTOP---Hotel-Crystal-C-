using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class ExcluirSubcliente : Form
    {
        public ExcluirSubcliente()
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
            ExcluirCliente excluirCliente = new ExcluirCliente();
            excluirCliente.FormClosed += (s, args) => this.Close();
            excluirCliente.Show();
        }

        private void btnProximoSubcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirReserva excluirReserva = new ExcluirReserva();
            excluirReserva.FormClosed += (s, args) => this.Close();
            excluirReserva.Show();
        }
    }
}
