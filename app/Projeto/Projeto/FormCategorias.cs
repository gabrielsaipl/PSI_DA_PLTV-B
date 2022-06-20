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
    public partial class FormCategorias : Form
    {
        RestGestModelContainer restGest;
        public FormCategorias()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            listarCategorias();
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
        /// Adiciona categoria à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovo_Click(object sender, EventArgs e)
        {
            if (tbNova.Text != "")
            {
                try
                {
                    string nome = tbNova.Text;
                    Categoria novaCategoria = new Categoria(nome); // CRIAR NOVA CATEGORIA
                    restGest.Categoria.Add(novaCategoria);
                    restGest.SaveChanges();
                    listarCategorias();
                    tbNova.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar adicionar a categoria, por favor volte a tentar.");
                }
            }
            else MessageBox.Show("Preencha a caixa de texto.");
        }

        /// <summary>
        /// Lista as categorias na Listbox das categorias
        /// </summary>
        private void listarCategorias()
        {
            try
            {
                lbCategorias.DataSource = null;
                lbCategorias.DataSource = restGest.Categoria.ToList<Categoria>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar as categorias");
            }
            
        }

        /// <summary>
        /// Botão que grava na base de dados os novos dados editados da categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGravar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text != "")
            {
                try
                {
                    Categoria categoriaSelecionada = lbCategorias.SelectedItem as Categoria;
                    categoriaSelecionada.Nome = tbNome.Text;
                    categoriaSelecionada.Ativo = cbEstado.Text;
                    restGest.SaveChanges();
                    listarCategorias();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar gravar a categoria, por favor volte a tentar.");
                }
            }
            else MessageBox.Show("Insira o nome...");
        }

        /// <summary>
        /// Quando o utilizador seleciona outra categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbCategorias.SelectedIndex >= 0)
                {
                    Categoria categoriaSelecionada = lbCategorias.SelectedItem as Categoria;
                    tbNome.Text = categoriaSelecionada.Nome;
                    cbEstado.Text = categoriaSelecionada.Ativo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar a categoria.");
            }
        }
    }
}
