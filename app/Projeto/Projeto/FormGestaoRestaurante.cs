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
    public partial class FormGestaoRestaurante : Form
    {
        RestGestModelContainer restGest;
        public static int restauranteSelecionado;   // VARIAVEL PARA PASSAR O INDICE DO FORMULÁRIO SELECIONADO PARA O OUTRO FORM
        public FormGestaoRestaurante()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            tbSalario.Maximum = decimal.MaxValue;
            preencherComboBox();
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
        /// Botão que abre o formulário para criar um novo trabalhador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovo_Click(object sender, EventArgs e)
        {
            try
            {
                restauranteSelecionado = cbRestaurante.SelectedIndex;
                FormAddTrabalhador formAddTrabalhador = new FormAddTrabalhador();
                formAddTrabalhador.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário do menu do restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMenus_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenuRestaurante formMenuRestaurante = new FormMenuRestaurante();
                formMenuRestaurante.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir o formulário.");
            }
            
        }

        /// <summary>
        /// Botão que abre o formulário dos pedidos do restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                FormPedidos formPedidos = new FormPedidos();
                formPedidos.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir o formulário.");
            }
        }
        
        /// <summary>
        /// Preenche a comboBox com todos os restaurantes da cadeia
        /// </summary>
        private void preencherComboBox()
        {
            try
            {
                cbRestaurante.DataSource = restGest.Restaurante.ToList<Restaurante>();
                cbRestaurante.SelectedIndex = FormRestaurantes.restauranteSelecionado;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao listar a ComboBox.");
            }
            
        }

        /// <summary>
        /// Listar trabalhadores do restaurante selecionado
        /// </summary>
        private void listarTrabalhadores()
        {
            try
            {
                bsTrabalhadores.DataSource = null;
                // VERIFICA SE EXISTE PESSOAS (TRABALHADORES OU CLIENTES)
                if (restGest.Pessoa.Count() > 0)
                {
                    Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                    // SELECIONA TODOS OS TRABALHADORES DENTRO DAS PESSOAS
                    var trabalhadores = restGest.Pessoa.OfType<Trabalhador>().ToList();
                    // VERIFICA SE EXISTEM TRABALHADORES
                    if (trabalhadores.Count() > 0)
                    {
                        // PROCURA OS TRABALHADORES DO RESTAURANTE SELECIONADO
                        var trabalhadoresRestaurante = trabalhadores.Where(trabalhador => trabalhador.RestauranteIdRestaurante == restauranteSelecionado.IdRestaurante).ToList();
                        // VERIFICA SE EXISTE TRABALHADORES NO RESTAURANTE
                        if (trabalhadoresRestaurante.Count() > 0)
                        {
                            bsTrabalhadores.DataSource = trabalhadoresRestaurante;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os trabalhadores");
            }
            
        }

        /// <summary>
        /// Quando o utilizador seleciona outro restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbRestaurante.SelectedIndex >= 0) listarTrabalhadores();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar trocar o restaurante selecionado");
            }
        }

        /// <summary>
        /// Botão que atualiza a lista de trabalhadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarTrabalhadores();
        }

        /// <summary>
        /// Botão que guarda os novos dados editados do trabalhador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTrabalhadores.SelectedRows.Count > 0)
                {
                    string nome = tbNome.Text;
                    double salario = Convert.ToDouble(tbSalario.Text);
                    string posicao = tbPosicao.Text;
                    string telemovel = tbTelemovel.Text;
                    string pais = tbPais.Text;
                    string cidade = tbCidade.Text;
                    string rua = tbRua.Text;
                    string codPostal = tbCodPostal.Text;
                    bool ativo;
                    if (cbAtivo.Text == "Ativo") ativo = true;
                    else ativo = false;
                    if (nome != "" && salario > 0 && posicao != "" && telemovel != "" && pais != "" && cidade != "" && rua != "" && codPostal != "")
                    {
                        Trabalhador trabalhadorSelecionado = dgvTrabalhadores.SelectedRows[0].DataBoundItem as Trabalhador;
                        trabalhadorSelecionado.Nome = nome;
                        trabalhadorSelecionado.Salario = salario;
                        trabalhadorSelecionado.Posicao = posicao;
                        trabalhadorSelecionado.Telemovel = telemovel;
                        trabalhadorSelecionado.Morada.CodPostal = codPostal;
                        trabalhadorSelecionado.Morada.Cidade = cidade;
                        trabalhadorSelecionado.Morada.Rua = rua;
                        trabalhadorSelecionado.Morada.Pais = pais;
                        trabalhadorSelecionado.Ativo = ativo;
                        restGest.SaveChanges();
                        listarTrabalhadores();
                        MessageBox.Show("Guardado.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar gravar os novos dados do trabalhador.");
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
                bsTrabalhadores.DataSource = null;
                // VERIFICA SE EXISTE PESSOAS (TRABALHADORES OU CLIENTES)
                if (restGest.Pessoa.Count() > 0)
                {
                    Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                    // SELECIONA TODOS OS TRABALHADORES DENTRO DAS PESSOAS
                    var trabalhadores = restGest.Pessoa.OfType<Trabalhador>().ToList();
                    // VERIFICA SE EXISTEM TRABALHADORES
                    if (trabalhadores.Count() > 0)
                    {
                        // PROCURA OS TRABALHADORES DO RESTAURANTE SELECIONADO
                        var trabalhadoresRestaurante = trabalhadores.Where(trabalhador => trabalhador.RestauranteIdRestaurante == restauranteSelecionado.IdRestaurante).ToList();
                        // VERIFICA SE EXISTE TRABALHADORES NO RESTAURANTE
                        if (trabalhadoresRestaurante.Count() > 0)
                        {
                            if (tbFiltrar.Text != "")
                            {
                                var trabalhadoresFiltrados = trabalhadoresRestaurante.Where(trabalhador => trabalhador.Nome.Contains(tbFiltrar.Text)).ToList();
                                // VERIFICAR SE EXISTEM TRABALHADORES COM O FILTRO APLICADO
                                if (trabalhadoresFiltrados.Count() > 0) bsTrabalhadores.DataSource = trabalhadoresFiltrados;
                                else bsTrabalhadores.DataSource = null;
                            }
                            else bsTrabalhadores.DataSource = trabalhadoresRestaurante;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar filtrar os trabalhadores.");
            }
        }

        /// <summary>
        /// Quando o utilizador seleciona outro trabalhador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTrabalhadores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTrabalhadores.SelectedRows.Count > 0)
                {
                    Trabalhador trabalhadorSelecionado = dgvTrabalhadores.SelectedRows[0].DataBoundItem as Trabalhador;
                    tbNome.Text = trabalhadorSelecionado.Nome;
                    tbSalario.Text = trabalhadorSelecionado.Salario.ToString();
                    tbPosicao.Text = trabalhadorSelecionado.Posicao;
                    tbTelemovel.Text = trabalhadorSelecionado.Telemovel;
                    tbPais.Text = trabalhadorSelecionado.Morada.Pais;
                    tbCidade.Text = trabalhadorSelecionado.Morada.Cidade;
                    tbRua.Text = trabalhadorSelecionado.Morada.Rua;
                    tbCodPostal.Text = trabalhadorSelecionado.Morada.CodPostal;
                    if (trabalhadorSelecionado.Ativo == true) cbAtivo.Text = "Ativo";
                    else cbAtivo.Text = "Inativo";
                }
                else
                {
                    tbNome.Text = "";
                    tbSalario.Text = "";
                    tbPosicao.Text = "";
                    tbTelemovel.Text = "";
                    tbPais.Text = "";
                    tbCidade.Text = "";
                    tbRua.Text = "";
                    tbCodPostal.Text = "";
                    cbAtivo.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar o trabalhador.");
            }
        }
    }
}
