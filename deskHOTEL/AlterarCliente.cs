using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class AlterarCliente : Form
    {
        public AlterarCliente()
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
            Alterar alterar = new Alterar();
            alterar.FormClosed += (s, args) => this.Close();
            alterar.Show();
        }

        private void btnProximoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlterarSubcliente alterarSubcliente = new AlterarSubcliente();
            alterarSubcliente.FormClosed += (s, args) => this.Close();
            alterarSubcliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Enabled = true;
            txtEmailCliente.Enabled = true;
            txtTelefoneCliente.Enabled = true;
            dtpDataNascCliente.Enabled = true;
            mskCpf.Enabled = true;
            txtRgCliente.Enabled = true;
        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
