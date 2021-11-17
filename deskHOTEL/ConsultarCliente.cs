using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar consultar = new Consultar();
            consultar.FormClosed += (s, args) => this.Close();
            consultar.Show();
        }

        private void btnProximoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarSubcliente consultarSubcliente = new ConsultarSubcliente();
            consultarSubcliente.FormClosed += (s, args) => this.Close();
            consultarSubcliente.Show();
        }

        private void dtpDataNascCliente_ValueChanged(object sender, EventArgs e)
        {
            dtpDataNascCliente.Format = DateTimePickerFormat.Short;
        }
    }
}
