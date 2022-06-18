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
    public partial class FormAddTrabalhador : Form
    {
        RestGestModelContainer restGest;
        public FormAddTrabalhador()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            preencherComboBox();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            // CRIAR A MORADA DO CLIENTE
            string pais = tbPais.Text;
            string cidade = tbCidade.Text;
            string codPostal = tbCodPostal.Text;
            string rua = tbRua.Text;
            Morada novaMorada = new Morada(pais, cidade, codPostal, rua);
            // CRIAR O CLIENTE
            string nome = tbNome.Text;
            string telemovel = tbTelemovel.Text;
            double salario = Convert.ToDouble(tbSalario.Text);
            string posicao = tbPosicao.Text;
            Trabalhador novoTrabalhador = new Trabalhador(nome, telemovel, salario, posicao);
            // OBTEM RESTAURANTE SELECIONADO
            Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante; 
            // ATRIBUI ID DO RESTAURANTE E MORADA AO TRABALHADOR
            novoTrabalhador.Morada = novaMorada;
            novoTrabalhador.RestauranteIdRestaurante = restauranteSelecionado.IdRestaurante;
            
            restGest.Pessoa.Add(novoTrabalhador);

            restGest.SaveChanges();         // GRAVAR ATUALIZAÇÕES
            MessageBox.Show("Clique no botão de atualizar que está acima da lista para que a lista seja atualizada!");
            this.Close();
        }

        /// <summary>
        /// Preenche a comboBox com todos os restaurantes da cadeia
        /// </summary>
        private void preencherComboBox()
        {
            cbRestaurante.DataSource = restGest.Restaurante.ToList<Restaurante>();
            cbRestaurante.SelectedIndex = FormGestaoRestaurante.restauranteSelecionado;
        }
    }
}
