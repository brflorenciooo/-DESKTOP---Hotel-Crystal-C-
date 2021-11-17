using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class Consultar : Form
    {
        public Consultar()
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

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.FormClosed += (s, args) => this.Close();
            consultarCliente.Show();
        }
    }
}
