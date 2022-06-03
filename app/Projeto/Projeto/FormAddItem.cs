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
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.CheckFileExists)
                    {
                        string pathImagem = System.IO.Path.GetFullPath(dlg.FileName);
                        pbImagem.Image = new Bitmap(dlg.FileName);
                        pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                        string nomeFicheiro = System.IO.Path.GetFileName(dlg.FileName);
                        string pathProjeto = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        System.IO.File.Copy(dlg.FileName, pathProjeto + "\\Resources\\ImagensItens\\" + nomeFicheiro);
                        nomeImagem = dlg.SafeFileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar a imagem pretendida.");
            }
        }
    }
}
