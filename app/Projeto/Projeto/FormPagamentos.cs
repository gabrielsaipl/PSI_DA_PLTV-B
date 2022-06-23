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
    public partial class FormPagamentos : Form
    {
        RestGestModelContainer restGest;
        Pedido pedido;
        public FormPagamentos()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            obterPedido();
            preencherLabels();
            listarMetodos();
            listarPagamentos();
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
        /// Listar os métodos de pagamento
        /// </summary>
        private void listarMetodos()
        {
            try
            {
                cbMetodos.DataSource = null;
                var metodosPagamento = restGest.MetodoPagamento.ToList<MetodoPagamento>();
                var metodosPagamentoAtivos = metodosPagamento.Where(metodo => metodo.Ativo == "Ativo").ToList();
                cbMetodos.DataSource = metodosPagamentoAtivos.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os métodos de pagamento.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de métodos de pagamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMetodos_Click(object sender, EventArgs e)
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
        /// Botão que atualiza os métodos de pagamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarMetodos();
            listarPagamentos();
        }

        /// <summary>
        /// Lista os pagamentos do pedido
        /// </summary>
        private void listarPagamentos()
        {
            try
            {
                lbPagamentos.DataSource = null;
                lbPagamentos.DataSource = pedido.Pagamento.ToList<Pagamento>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os pagamentos.");
            }
            
        }

        /// <summary>
        /// Obtém o pedido que está selecionado no outro form;
        /// </summary>
        private void obterPedido()
        {
            try
            {
                int idPedido = FormPedidos.idPedido;
                var pedidos = restGest.Pedido.ToList();
                var pedidoSelecionado = pedidos.Where(pedido => pedido.IdPedido == idPedido).ToList();
                pedido = pedidoSelecionado[0] as Pedido;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao obter o pedido.");
            }  
        }

        /// <summary>
        /// Adiciona o pagamento à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovo_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbValor.Text == "" || cbMetodos.Text == "") return;
                double valor = Convert.ToDouble(tbValor.Text);
                if (valor < 0) return;
                Pagamento novoPagamento = new Pagamento(valor);
                MetodoPagamento metodoSelecionado = cbMetodos.SelectedItem as MetodoPagamento;
                novoPagamento.MetodoPagamento = metodoSelecionado;
                pedido.Pagamento.Add(novoPagamento);
                restGest.SaveChanges();
                preencherLabels();
                listarPagamentos();
                tbValor.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar o pagamento.");
            }
            
        }

        /// <summary>
        /// Preenche labels de Valor pago e Valor a pagar
        /// </summary>
        private void preencherLabels()
        {
            try
            {
                labelValorAPagar.Text = pedido.ValorTotal.ToString() + "€";
                double valorPago = 0;
                foreach (Pagamento pagamento in pedido.Pagamento)
                {
                    valorPago += pagamento.Valor;
                }
                labelValorPago.Text = Math.Round(valorPago,2).ToString() + "€";
                double troco = valorPago - pedido.ValorTotal;
                if (troco > 0) labelTroco.Text = Math.Round(troco,2).ToString() + "€";
                else labelTroco.Text = "0€";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o valor pago e o valor a pagar.");
            }
        }
    }
}
