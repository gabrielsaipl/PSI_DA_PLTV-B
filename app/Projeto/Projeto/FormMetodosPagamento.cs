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
    public partial class FormMetodosPagamento : Form
    {
        RestGestModelContainer restGest;
        public FormMetodosPagamento()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            listarMetodoPagamento();
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
        /// Botão que lista os métodos de pagamento existentes
        /// </summary>
        private void listarMetodoPagamento()
        {
            try
            {
                lbMetodosPagamento.DataSource = null;
                lbMetodosPagamento.DataSource = restGest.MetodoPagamento.ToList<MetodoPagamento>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os métodos de pagamento.");
            }
        }

        /// <summary>
        /// Adiciona um método de pagamento à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovo_Click(object sender, EventArgs e) 
        {
            try
            {
                if (tbNovo.Text != "")
                {
                    string metodopagamento = tbNovo.Text;
                    MetodoPagamento novoMetodoPagamento = new MetodoPagamento(metodopagamento);
                    restGest.MetodoPagamento.Add(novoMetodoPagamento);
                    restGest.SaveChanges();
                    listarMetodoPagamento();
                    tbNovo.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar o método de pagamento.");
            } 
        }
        
        /// <summary>
        /// Quando o método de pagamento selecionado é alterado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbMetodosPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbMetodosPagamento.SelectedIndex >= 0)
                {
                    MetodoPagamento categoriaSelecionada = lbMetodosPagamento.SelectedItem as MetodoPagamento;
                    tbNome.Text = categoriaSelecionada.MetodoPagament;
                    cbEstado.Text = categoriaSelecionada.Ativo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar um método de pagamento.");
            }
        }

        /// <summary>
        /// Guarda os novos dados editados do método de pagamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNome.Text != "")
                {
                    MetodoPagamento metodopagamentoSelecionado = lbMetodosPagamento.SelectedItem as MetodoPagamento;
                    metodopagamentoSelecionado.MetodoPagament = tbNome.Text;
                    metodopagamentoSelecionado.Ativo = cbEstado.Text;
                    restGest.SaveChanges();
                    listarMetodoPagamento();
                }
                else MessageBox.Show("Insira o Método...");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar gravar o método de pagamento.");
            }
        }
    }
}
