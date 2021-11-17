using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deskHOTEL
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.FormClosed += (s, args) => this.Close();
            cadastrarCliente.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alterar alterar = new Alterar();
            alterar.FormClosed += (s, args) => this.Close();
            alterar.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar consultar = new Consultar();
            consultar.FormClosed += (s, args) => this.Close();
            consultar.Show();
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Excluir excluir = new Excluir();
            excluir.FormClosed += (s, args) => this.Close();
            excluir.Show();
        }
    }
}
