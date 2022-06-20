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

        /// <summary>
        /// Botão para voltar ao menu anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adiciona o Cliente à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string pais = tbPais.Text;
                string cidade = tbCidade.Text;
                string codPostal = tbCodPostal.Text;
                string rua = tbRua.Text;
                string nome = tbNome.Text;
                string telemovel = tbTelemovel.Text;
                string nif = tbNif.Text;
                if (pais == "" || cidade == "" || codPostal == "" || rua == "" || nome== "" || telemovel == "" || nif == "")
                {
                    MessageBox.Show("Insira todos os campos.");
                    return;
                }
                Morada novaMorada = new Morada(pais, cidade, codPostal, rua);  // CRIAR A MORADA DO CLIENTE
                Cliente novoCliente = new Cliente(nome, telemovel, nif);    // CRIAR O CLIENTE
                novoCliente.Morada = novaMorada;

                restGest.Pessoa.Add(novoCliente);

                restGest.SaveChanges();         // GRAVAR ATUALIZAÇÕES
                MessageBox.Show("Clique no botão de atualizar que está acima da lista para que a lista seja atualizada!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar o cliente, por favor volte a tentar.");
            }
            
        }
    }
}
