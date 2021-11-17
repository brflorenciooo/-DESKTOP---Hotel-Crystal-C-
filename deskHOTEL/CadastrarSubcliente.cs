using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class CadastrarSubcliente : Form
    {
        public CadastrarSubcliente()
        {
            InitializeComponent();
        }

        private void btnVoltarSubcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.FormClosed += (s, args) => this.Close();
            cadastrarCliente.Show();
        }

        private void btnProximoSubcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarReserva cadastrarReserva = new CadastrarReserva();
            cadastrarReserva.FormClosed += (s, args) => this.Close();
            cadastrarReserva.Show();
        }

        private void dtpDataNascSubcliente_ValueChanged(object sender, EventArgs e)
        {
            dtpDataNascSubcliente.Format = DateTimePickerFormat.Short;
        }
    }
}
