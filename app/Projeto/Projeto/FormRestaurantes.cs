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
    public partial class FormRestaurantes : Form
    {
        RestGestModelContainer restGest;
        public static int restauranteSelecionado;   // VARIAVEL PARA PASSAR O INDICE DO FORMULÁRIO SELECIONADO PARA O OUTRO FORMULÁRIO
        public FormRestaurantes()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            listarRestaurantes();
        }

        /// <summary>
        /// Botão que volta ao menu anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abre o formulário para criar o novo restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddRestaurante formAddRestaurante = new FormAddRestaurante();
                formAddRestaurante.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Abre o formulário de gestão do restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGerir_Click(object sender, EventArgs e)
        {
            try
            {
                restauranteSelecionado = dgvRestaurantes.SelectedRows[0].Index;
                FormGestaoRestaurante formGestaoRestaurante = new FormGestaoRestaurante();
                formGestaoRestaurante.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Atualizar listbox dos restaurantes
        /// </summary>
        private void listarRestaurantes()
        {
            try
            {
                if (restGest.Restaurante.Count() > 0)
                {
                    bsRestaurantes.DataSource = null;
                    bsRestaurantes.DataSource = restGest.Restaurante.ToList<Restaurante>();
                }
                else MessageBox.Show("Ainda não existem restaurantes");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os restaurantes.");
            }
            
        }

        /// <summary>
        /// Botão  que atualiza a lista de trabalhadores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarRestaurantes();
        }

        /// <summary>
        /// Guarda os dados editados do trabalhador na base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRestaurantes.SelectedRows.Count > 0) // VERIFICA SE EXISTE UM ITEM SELECIONADO
                {
                    string nomeRestaurante = tbNome.Text;
                    string pais = tbPais.Text;
                    string cidade = tbCidade.Text;
                    string rua = tbRua.Text;
                    string codPostal = tbCodPostal.Text;
                    // VERIFICA SE ALGUMA TEXTBOX ESTÁ VAZIA
                    if (nomeRestaurante != "" && pais != "" && cidade != "" && rua != "" && codPostal != "")
                    {
                        Restaurante restauranteSelecionado = (Restaurante)dgvRestaurantes.SelectedRows[0].DataBoundItem;
                        restauranteSelecionado.Nome = nomeRestaurante;
                        restauranteSelecionado.Morada.Pais = pais;
                        restauranteSelecionado.Morada.Cidade = cidade;
                        restauranteSelecionado.Morada.Rua = rua;
                        restauranteSelecionado.Morada.CodPostal = codPostal;
                        restGest.SaveChanges();
                        listarRestaurantes();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar gravar os dados do trabalhador.");
            }
        }

        /// <summary>
        /// Quando o seleciona outro trabalhador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTrabalhadores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRestaurantes.SelectedRows.Count > 0)  // VERIFICA SE EXISTE UM ITEM SELECIONADO
                {
                    Restaurante restauranteSelecionado = (Restaurante)dgvRestaurantes.SelectedRows[0].DataBoundItem;
                    tbNome.Text = restauranteSelecionado.Nome;
                    tbPais.Text = restauranteSelecionado.Morada.Pais;
                    tbCidade.Text = restauranteSelecionado.Morada.Cidade;
                    tbRua.Text = restauranteSelecionado.Morada.Rua;
                    tbCodPostal.Text = restauranteSelecionado.Morada.CodPostal;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar o trabalhador");
            }
        }

        /// <summary>
        /// Abre o formulário de métodos de pagamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMetodosPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                FormMetodosPagamento formMetodosPagamento = new FormMetodosPagamento();
                formMetodosPagamento.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Abre o formulário de métodos de categorias
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
    }
}
