using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class Alterar : Form
    {
        public Alterar()
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

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlterarCliente alterarCliente = new AlterarCliente();
            alterarCliente.FormClosed += (s, args) => this.Close();
            alterarCliente.Show();
        }
    }
}
