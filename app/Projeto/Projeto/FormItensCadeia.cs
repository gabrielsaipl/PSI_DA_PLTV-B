using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormItensCadeia : Form
    {
        RestGestModelContainer restGest;
        ImageList il;
        public FormItensCadeia()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            il = new ImageList();
            criarImageList();
            preencherComboBoxCategorias();
            listarItensCadeia();
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
            FormAddItem formAddItem = new FormAddItem();
            formAddItem.ShowDialog();
        }

        /// <summary>
        /// Lista todos os itens na ListView
        /// </summary>
        private void listarItensCadeia()
        {
            lvItens.Items.Clear();
            int i = 0;
            foreach (ItemMenu item in restGest.ItemMenu.ToList())
            {
                var linha = new string[]
                {
                    item.Nome,
                    item.Preco.ToString(),
                    item.Ingredientes,
                    item.Ativo,
                    item.Categoria.Nome
                };

                ListViewItem lvi = new ListViewItem(linha,i);
                lvi.Tag = item;
                i++;
                lvItens.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Coloca todas as imagens de todos os itens na ImageList
        /// </summary>
        private void criarImageList()
        {
            imageList1.Images.Clear();
            string pastaImagens = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\resources\ImagensItens\";
            imageList1.ImageSize = new Size(32, 32);
            foreach (ItemMenu item in restGest.ItemMenu.ToList())
            {
                if (item.Fotografia != null)
                {
                    string caminhoImagem = pastaImagens + item.Fotografia;
                    imageList1.Images.Add(Image.FromFile(caminhoImagem));
                }
            }
        }

        private void lvItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItens != null)
            {
                if (lvItens.SelectedItems.Count == 0) return;
                ItemMenu itemSelecionado = lvItens.SelectedItems[0].Tag as ItemMenu;
                tbNome.Text = itemSelecionado.Nome;
                tbPreco.Text = itemSelecionado.Preco.ToString();
                tbIngredientes.Text = itemSelecionado.Ingredientes;
                cbEstado.Text = itemSelecionado.Ativo;
                cbCategoria.Text= itemSelecionado.Categoria.ToString();
            }
        }

        /// <summary>
        /// Preenche a comboBox com todas as categorias ativas
        /// </summary>
        private void preencherComboBoxCategorias()
        {
            var categorias = restGest.Categoria.ToList();
            var categoriasAtivas = categorias.Where(categoria => categoria.Ativo == "Ativo").ToList();
            cbCategoria.DataSource = categoriasAtivas;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (lvItens != null)
            {
                ItemMenu itemSelecionado = lvItens.SelectedItems[0].Tag as ItemMenu;
                Categoria categoriaSelecionada = cbCategoria.SelectedItem as Categoria;
                string nome = tbNome.Text;
                double preco = Convert.ToDouble(tbPreco.Text);
                string ingredientes = tbIngredientes.Text;
                string estado = cbEstado.Text;
                if (categoriaSelecionada != null && nome != ""  && preco >= 0 && ingredientes != "" && estado != "")
                {
                    itemSelecionado.Nome = nome;
                    itemSelecionado.Preco = preco;
                    itemSelecionado.Ingredientes = ingredientes;
                    itemSelecionado.Ativo = estado;
                    itemSelecionado.Categoria = categoriaSelecionada;
                    restGest.SaveChanges();
                    criarImageList();
                    listarItensCadeia();
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            criarImageList();
            listarItensCadeia();
        }

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (restGest.ItemMenu.Count() > 0 && tbFiltrar.Text != "")
            {
                var itens = restGest.ItemMenu.ToList();
                var itensFiltrados = itens.Where(item => item.Nome.Contains(tbFiltrar.Text)).ToList();


                //CRIAR IMAGELIST BASEADO NO FILTRO
                imageList1.Images.Clear();
                string pastaImagens = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\resources\ImagensItens\";
                imageList1.ImageSize = new Size(32, 32);
                foreach (ItemMenu item in itensFiltrados)
                {
                    if (item.Fotografia != null)
                    {
                        string caminhoImagem = pastaImagens + item.Fotografia;
                        imageList1.Images.Add(Image.FromFile(caminhoImagem));
                    }
                }

                //LISTAR LISTVIEW BASEADO NO FILTRO
                lvItens.Items.Clear();
                int i = 0;
                foreach (ItemMenu item in itensFiltrados)
                {
                    var linha = new string[]
                    {
                    item.Nome,
                    item.Preco.ToString(),
                    item.Ingredientes,
                    item.Ativo,
                    item.Categoria.Nome
                    };

                    ListViewItem lvi = new ListViewItem(linha, i);
                    lvi.Tag = item;
                    i++;
                    lvItens.Items.Add(lvi);
                }
            }
            else
            {
                criarImageList();
                listarItensCadeia();
            }
        }


    }
}
