using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class ConsultarReserva : Form
    {
        public ConsultarReserva()
        {
            InitializeComponent();
        }

        private void btnVoltarReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarSubcliente consultarSubcliente = new ConsultarSubcliente();
            consultarSubcliente.FormClosed += (s, args) => this.Close();
            consultarSubcliente.Show();
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
                this.Hide();
                Cliente cliente = new Cliente();
                cliente.FormClosed += (s, args) => this.Close();
                cliente.Show();
            
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckin.Format = DateTimePickerFormat.Short;
            dtpCheckoutPrevisto.Format = DateTimePickerFormat.Short;
        }
    }
}
