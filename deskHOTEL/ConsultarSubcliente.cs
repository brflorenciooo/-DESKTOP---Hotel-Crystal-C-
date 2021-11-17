using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class ConsultarSubcliente : Form
    {
        public ConsultarSubcliente()
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
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.FormClosed += (s, args) => this.Close();
            consultarCliente.Show();
        }

        private void btnProximoSubcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarReserva consultarReserva = new ConsultarReserva();
            consultarReserva.FormClosed += (s, args) => this.Close();
            consultarReserva.Show();
        }
    }
}
