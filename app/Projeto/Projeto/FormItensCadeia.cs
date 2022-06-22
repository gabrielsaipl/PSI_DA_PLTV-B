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
        public FormItensCadeia()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            criarImageList();
            preencherComboBoxCategorias();
            listarItensCadeia();
            cbTipo.SelectedIndex = 0;
        }

        /// <summary>
        /// Botão para voltrar ao menu anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Botão que abre o formulário para criar itens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddItem formAddItem = new FormAddItem();
                formAddItem.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Lista todos os itens na ListView
        /// </summary>
        private void listarItensCadeia()
        {
            try
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

                    ListViewItem lvi = new ListViewItem(linha, i);
                    lvi.Tag = item;
                    i++;
                    lvItens.Items.Add(lvi);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os itens da cadeia.");
            }
            
        }

        /// <summary>
        /// Coloca todas as imagens de todos os itens na ImageList
        /// </summary>
        private void criarImageList()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar encontrar as Imagens");
            }
            
        }

        /// <summary>
        /// Quando o utilizador seleciona outro item da cadeia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvItens != null)
                {
                    if (lvItens.SelectedItems.Count == 0) return;
                    ItemMenu itemSelecionado = lvItens.SelectedItems[0].Tag as ItemMenu;
                    tbNome.Text = itemSelecionado.Nome;
                    tbPreco.Text = itemSelecionado.Preco.ToString();
                    tbIngredientes.Text = itemSelecionado.Ingredientes;
                    cbEstado.Text = itemSelecionado.Ativo;
                    cbCategoria.Text = itemSelecionado.Categoria.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar o item");
            }
            
        }

        /// <summary>
        /// Preenche a comboBox com todas as categorias ativas
        /// </summary>
        private void preencherComboBoxCategorias()
        {
            try
            {
                var categorias = restGest.Categoria.ToList();
                var categoriasAtivas = categorias.Where(categoria => categoria.Ativo == "Ativo").ToList();
                cbCategoria.DataSource = categoriasAtivas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar preencher as Categorias.");
            }
            
        }

        /// <summary>
        /// Botão que vai guardar os novos dados do item  da cadeia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvItens != null)
                {
                    ItemMenu itemSelecionado = lvItens.SelectedItems[0].Tag as ItemMenu;
                    Categoria categoriaSelecionada = cbCategoria.SelectedItem as Categoria;
                    string nome = tbNome.Text;
                    double preco = Convert.ToDouble(tbPreco.Text);
                    string ingredientes = tbIngredientes.Text;
                    string estado = cbEstado.Text;
                    if (categoriaSelecionada != null && nome != "" && preco >= 0 && ingredientes != "" && estado != "")
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar gravar os novos dados do item da cadeia.");
            }
        }

        /// <summary>
        /// Atualiza a listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            criarImageList();
            listarItensCadeia();
        }

        /// <summary>
        /// Filtração de itens da cadeia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar filtrar os itens da cadeia.");
            }
        }

        /// <summary>
        /// Troca a forma de como os itens são listados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoListView = cbTipo.Text;
            switch(tipoListView)
            {
                case "Detalhes":
                    lvItens.View = View.Details;
                    break;
                case "Icones Grandes":
                    lvItens.View = View.LargeIcon;
                    break;
                case "Icones Pequenos":
                    lvItens.View = View.SmallIcon;
                    break;
                case "Lista":
                    lvItens.View = View.List;
                    break;
                case "Tile":
                    lvItens.View = View.Tile;
                    break;
            }
        }
    }
}
