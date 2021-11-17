using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpDataNascCliente.Format = DateTimePickerFormat.Short;
        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cliente = new Cliente();
            cliente.FormClosed += (s, args) => this.Close();
            cliente.Show();
        }

        private void btnProximoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarSubcliente cadastrarSubcliente = new CadastrarSubcliente();
            cadastrarSubcliente.FormClosed += (s, args) => this.Close();
            cadastrarSubcliente.Show();
        }
    }
}
