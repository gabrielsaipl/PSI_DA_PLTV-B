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

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
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
                this.Close();
            }
            else MessageBox.Show("Insira todos os dados.");
        }
    }
}
