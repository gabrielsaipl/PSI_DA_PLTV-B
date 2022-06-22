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
    public partial class FormMenuRestaurante : Form
    {
        RestGestModelContainer restGest;
        public FormMenuRestaurante()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            criarImageList();
            listarItensCadeia();
            preencherComboBoxRestaurantes();
            listarItensMenu();
            cbTipo.SelectedIndex = 0;
        }

        /// <summary>
        /// Butão que volta ao menu anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Butão que abre o form de gestão de categorias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                FormCategorias formCategorias = new FormCategorias();
                formCategorias.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Butão que abre o form dos itens da Cadeia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btItensCadeia_Click(object sender, EventArgs e)
        {
            try
            {
                FormItensCadeia formItensCadeia = new FormItensCadeia();
                formItensCadeia.ShowDialog();
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
                lvItensCadeia.Items.Clear();
                int i = 0;
                var itens = restGest.ItemMenu.ToList();
                var itensCategoriasAtivas = itens.Where(item => item.Categoria.Ativo == "Ativo").ToList();
                var itensAtivos = itensCategoriasAtivas.Where(item => item.Ativo == "Ativo").ToList();
                foreach (ItemMenu item in itensAtivos)
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
                    lvItensCadeia.Items.Add(lvi);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os itens.");
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
                MessageBox.Show("Ocorreu um erro ao tentar receber as Imagens.");
            }
            
        }

        /// <summary>
        /// Botão que atualiza a Lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            criarImageList();
            listarItensCadeia();
        }

        /// <summary>
        /// Preencher ComboBox dos Restaurantes
        /// </summary>
        private void preencherComboBoxRestaurantes()
        {
            try
            {
                cbRestaurante.DataSource = null;
                cbRestaurante.DataSource = restGest.Restaurante.ToList<Restaurante>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os restaurantes na comboBox.");
            }
            
        }

        /// <summary>
        /// Filtração de dados
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
                    var itensCategoriasAtivas = itens.Where(item => item.Categoria.Ativo == "Ativo").ToList();
                    var itensAtivos = itensCategoriasAtivas.Where(item => item.Ativo == "Ativo").ToList();
                    var itensFiltrados = itensAtivos.Where(item => item.Nome.Contains(tbFiltrar.Text)).ToList();


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
                    lvItensCadeia.Items.Clear();
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
                        lvItensCadeia.Items.Add(lvi);
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
                MessageBox.Show("Ocorreu um erro ao tentar filtrar itens.");
            }
            
        }

        /// <summary>
        /// Botão que adiciona itens ao menu do restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                if (restauranteSelecionado == null) return;
                ItemMenu itemSelecionado = lvItensCadeia.SelectedItems[0].Tag as ItemMenu;
                restauranteSelecionado.ItemMenu.Add(itemSelecionado);
                restGest.SaveChanges();
                listarItensMenu();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar o item ao menu.");
            }
        }

        /// <summary>
        /// Lista todos os ites do menu do restaurante
        /// </summary>
        private void listarItensMenu()
        {
            try
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                if (restauranteSelecionado == null) return;
                lbMenu.DataSource = null;
                if (restauranteSelecionado.ItemMenu.Count() == 0) return;
                lbMenu.DataSource = restauranteSelecionado.ItemMenu.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os itens do menu do restaurante.");
            }
            
        }

        /// <summary>
        /// Quando o utilizador altera o restaurante selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarItensMenu();
        }

        /// <summary>
        /// Remove itens do menu do restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRemoverItem_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                if (restauranteSelecionado == null) return;
                if (restauranteSelecionado.ItemMenu.Count() == 0) return;
                ItemMenu itemSelecionado = lbMenu.SelectedItem as ItemMenu;
                restauranteSelecionado.ItemMenu.Remove(itemSelecionado);
                restGest.SaveChanges();
                listarItensMenu();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar remover o item do menu do restaurante.");
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
            switch (tipoListView)
            {
                case "Detalhes":
                    lvItensCadeia.View = View.Details;
                    break;
                case "Icones Grandes":
                    lvItensCadeia.View = View.LargeIcon;
                    break;
                case "Icones Pequenos":
                    lvItensCadeia.View = View.SmallIcon;
                    break;
                case "Lista":
                    lvItensCadeia.View = View.List;
                    break;
                case "Tile":
                    lvItensCadeia.View = View.Tile;
                    break;
            }
        }
    }
}
