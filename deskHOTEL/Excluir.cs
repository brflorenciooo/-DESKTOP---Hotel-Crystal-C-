using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cliente = new Cliente();
            cliente.FormClosed += (s, args) => this.Close();
            cliente.Show();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirCliente cxcluirCliente = new ExcluirCliente();
            cxcluirCliente.FormClosed += (s, args) => this.Close();
            cxcluirCliente.Show();
        }
    }
}
