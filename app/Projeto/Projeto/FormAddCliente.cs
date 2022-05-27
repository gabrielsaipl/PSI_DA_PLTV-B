using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormAddCliente : Form
    {
        private RestGestModelContainer restGest;
        public FormAddCliente()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string pais = tbPais.Text;
            string cidade = tbCidade.Text;
            string codPostal = tbCodPostal.Text;
            string rua = tbRua.Text;
            Morada novaMorada = new Morada(pais,cidade,codPostal,rua);  // CRIAR A MORADA DO CLIENTE

            string nome = tbNome.Text;
            string telemovel = tbTelemovel.Text;
            string nif = tbNif.Text;
            Cliente novoCliente = new Cliente(nome, telemovel, nif);    // CRIAR O CLIENTE
            novoCliente.Morada = novaMorada;

            restGest.Pessoa.Add(novoCliente);

            restGest.SaveChanges();         // GRAVAR ATUALIZAÇÕES
        }
    }
}
