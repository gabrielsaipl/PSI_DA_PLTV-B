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
    public partial class FormAddItem : Form
    {
        RestGestModelContainer restGest;
        private string nomeImagem;
        public FormAddItem()
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

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            double preco = Convert.ToDouble(tbPreco.Text);
            string ingredientes = tbIngredientes.Text;
            string estado = "Ativo";
            Categoria categoria = cbCategoria.SelectedItem as Categoria;
            if (nome !=  "" && preco > 0 && ingredientes != "" && estado != "" && categoria != null)
            {
                ItemMenu novoItem = new ItemMenu(nome, preco, ingredientes, estado, nomeImagem);
                novoItem.CategoriaIdCategoria = categoria.IdCategoria;
                restGest.ItemMenu.Add(novoItem);
                restGest.SaveChanges();
            }
            this.Close();
        }

        /// <summary>
        /// Lista as categorias que estão ativas na comboBox
        /// </summary>
        private void listarCategorias()
        {
            var categoriasAtivas = restGest.Categoria.ToList().Where(categoria => categoria.Ativo == "Ativo").ToList();
            cbCategoria.DataSource = categoriasAtivas;
        }

        private void btAlterarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Selecione a imagem";
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                nomeImagem = dlg.SafeFileName;
            }
        }
        
        private void btInfoImagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para que a imagem seja guardada é necessário que a mesma esteja na pasta 'Resources' da aplicação.");
        }
    }
}
