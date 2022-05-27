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
            Morada novaMorada = new Morada(pais, cidade, codPostal, rua);  // CRIAR A MORADA DO RESTAURANTE
           // restGest.Morada.Add(novaMorada);                               // ENVIA MORADA PARA A BASE DE DADOS
           // restGest.SaveChanges();

            string nomeRestaurante = tbNome.Text;
            Restaurante novoRestaurante = new Restaurante(nomeRestaurante); //CRIAR O RESTAURANTE
            novoRestaurante.Morada = novaMorada;
            
            restGest.Restaurante.Add(novoRestaurante);


            //novaMorada.Restaurante = novoRestaurante;

            restGest.SaveChanges();

        }
    }
}
