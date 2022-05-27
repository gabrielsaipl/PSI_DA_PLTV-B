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

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (tbNova.Text != "")
            {
                string nome = tbNova.Text;
                Categoria novaCategoria = new Categoria(nome); // CRIAR NOVA CATEGORIA
                restGest.Categoria.Add(novaCategoria);
                restGest.SaveChanges();
                listarCategorias();
                tbNova.Text = "";
            }
        }
        /// <summary>
        /// Lista as categorias na Listbox das categorias
        /// </summary>
        private void listarCategorias()
        {
            lbCategorias.DataSource = restGest.Categoria.ToList<Categoria>();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text != "")
            {
                Categoria categoriaSelecionada = lbCategorias.SelectedItem as Categoria;
                categoriaSelecionada.Nome = tbNome.Text;
                categoriaSelecionada.Ativo = cbEstado.Text;
                restGest.SaveChanges();
                listarCategorias();
            }
            else MessageBox.Show("Insira o nome...");
        }

        private void lbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategorias.SelectedIndex >= 0)
            {
                Categoria categoriaSelecionada = lbCategorias.SelectedItem as Categoria;
                tbNome.Text = categoriaSelecionada.Nome;
                cbEstado.Text = categoriaSelecionada.Ativo;
            }
        }
    }
}
