using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class ExcluirCliente : Form
    {
        public ExcluirCliente()
        {
            InitializeComponent();
        }

        private void dtpDataNascCliente_ValueChanged(object sender, EventArgs e)
        {
            dtpDataNascCliente.Format = DateTimePickerFormat.Short;
        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Excluir excluir = new Excluir();
            excluir.FormClosed += (s, args) => this.Close();
            excluir.Show();
        }

        private void btnProximoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirSubcliente excluirSubcliente = new ExcluirSubcliente();
            excluirSubcliente.FormClosed += (s, args) => this.Close();
            excluirSubcliente.Show();
        }
    }
}
