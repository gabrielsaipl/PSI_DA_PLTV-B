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
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.ShowDialog();
        }

        private void btItensCadeia_Click(object sender, EventArgs e)
        {
            FormItensCadeia formItensCadeia = new FormItensCadeia();
            formItensCadeia.ShowDialog();
        }

        /// <summary>
        /// Lista todos os itens na ListView
        /// </summary>
        private void listarItensCadeia()
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
            cbRestaurante.DataSource = restGest.Restaurante.ToList<Restaurante>();
            /*List<Restaurante> lista = new List<Restaurante>();
            lista = restGest.Restaurante.ToList<Restaurante>();
            foreach (Restaurante restaurante in lista)
            {
                cbRestaurante.Items.Add(restaurante.Nome);
            }
            cbRestaurante.SelectedIndex = 0;
            MessageBox.Show(cbRestaurante.SelectedItem.ToString());*/
        }

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
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

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
            if (restauranteSelecionado == null) return;
            ItemMenu itemSelecionado = lvItensCadeia.SelectedItems[0].Tag as ItemMenu;
            restauranteSelecionado.ItemMenu.Add(itemSelecionado);
            restGest.SaveChanges();
            listarItensMenu();
            
        }

        /// <summary>
        /// Lista todos os ites do menu do restaurante
        /// </summary>
        private void listarItensMenu()
        {
            Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
            if (restauranteSelecionado == null) return;
            lbMenu.DataSource = null;
            if (restauranteSelecionado.ItemMenu.Count() == 0) return;
            lbMenu.DataSource=restauranteSelecionado.ItemMenu.ToList();
        }

        private void cbRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarItensMenu();
        }

        private void btRemoverItem_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
            if (restauranteSelecionado == null) return;
            if (restauranteSelecionado.ItemMenu.Count() == 0) return;
            ItemMenu itemSelecionado = lbMenu.SelectedItem as ItemMenu;
            restauranteSelecionado.ItemMenu.Remove(itemSelecionado);
            restGest.SaveChanges();
            listarItensMenu();
        }
    }
}
