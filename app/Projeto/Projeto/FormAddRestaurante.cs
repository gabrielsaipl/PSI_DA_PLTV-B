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
    public partial class FormAddRestaurante : Form
    {
        private RestGestModelContainer restGest;
        public FormAddRestaurante()
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
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adiciona o Restaurante à base de dados
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
                string nomeRestaurante = tbNome.Text;

                if (pais != "" && cidade != "" && codPostal != "" && rua != "" && nomeRestaurante != "")
                {
                    Morada novaMorada = new Morada(pais, cidade, codPostal, rua);  // CRIAR A MORADA DO RESTAURANTE 
                    Restaurante novoRestaurante = new Restaurante(nomeRestaurante); //CRIAR O RESTAURANTE
                    novoRestaurante.Morada = novaMorada;            // ATRIBUIÇÃO DA MORADA AO RESTAURANTE
                    restGest.Restaurante.Add(novoRestaurante);

                    restGest.SaveChanges();     //      GUARDAR NA BASE DE DADOS
                    MessageBox.Show("Clique no botão de atualizar que está acima da lista para que a lista seja atualizada!");
                    this.Close();
                }
                else MessageBox.Show("Insira todos os dados.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar o Restaurante, por favor volte a tentar.");
            }
           
        }
    }
}
