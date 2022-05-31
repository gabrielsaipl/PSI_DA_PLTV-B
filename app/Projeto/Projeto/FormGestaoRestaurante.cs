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
            preencherComboBox();
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
            restauranteSelecionado = cbRestaurante.SelectedIndex;
            FormAddTrabalhador formAddTrabalhador = new FormAddTrabalhador();
            formAddTrabalhador.ShowDialog();
        }

        private void btMenus_Click(object sender, EventArgs e)
        {
            FormMenuRestaurante formMenuRestaurante = new FormMenuRestaurante();
            formMenuRestaurante.ShowDialog();
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.ShowDialog();
        }
        
        /// <summary>
        /// Preenche a comboBox com todos os restaurantes da cadeia
        /// </summary>
        private void preencherComboBox()
        {
            cbRestaurante.DataSource = restGest.Restaurante.ToList<Restaurante>();
            cbRestaurante.SelectedIndex = FormRestaurantes.restauranteSelecionado;
        }

        /// <summary>
        /// Listar trabalhadores do restaurante selecionado
        /// </summary>
        private void listarTrabalhadores()
        {
            lbTrabalhadores.DataSource = null;
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
                        lbTrabalhadores.DataSource = trabalhadoresRestaurante;
                    }
                }
            }
        }

        private void lbTrabalhadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTrabalhadores.SelectedIndex >= 0)
            {
                Trabalhador trabalhadorSelecionado = lbTrabalhadores.SelectedItem as Trabalhador;
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

        private void cbRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRestaurante.SelectedIndex >= 0) listarTrabalhadores();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarTrabalhadores();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (lbTrabalhadores.SelectedIndex >= 0)
            {
                string nome = tbNome.Text;
                double salario = Convert.ToDouble(tbSalario.Text);
                string posicao = tbPosicao.Text ;
                string telemovel = tbTelemovel.Text;
                string pais = tbPais.Text;
                string cidade = tbCidade.Text;
                string rua = tbRua.Text;
                string codPostal = tbCodPostal.Text;
                bool ativo;
                if (cbAtivo.Text == "Ativo") ativo = true;
                else ativo = false;
                if (nome != "" && salario.ToString() != "" && posicao != "" && telemovel != "" && pais != "" && cidade != "" && rua != "" && codPostal != "")
                {
                    Trabalhador trabalhadorSelecionado = lbTrabalhadores.SelectedItem as Trabalhador;
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

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            lbTrabalhadores.DataSource = null;
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
                            if (trabalhadoresFiltrados.Count() > 0) lbTrabalhadores.DataSource = trabalhadoresFiltrados;
                            else lbTrabalhadores.DataSource = null;
                        }
                        else lbTrabalhadores.DataSource = trabalhadoresRestaurante;
                    }
                }
            }
        }
    }
}
