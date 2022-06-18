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

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Listar os métodos de pagamento
        /// </summary>
        private void listarMetodos()
        {
            cbMetodos.DataSource = null;
            var metodosPagamento = restGest.MetodoPagamento.ToList<MetodoPagamento>();
            var metodosPagamentoAtivos = metodosPagamento.Where(metodo => metodo.Ativo == "Ativo").ToList();
            cbMetodos.DataSource = metodosPagamentoAtivos.ToList();
        }

        private void btMetodos_Click(object sender, EventArgs e)
        {
            FormMetodosPagamento formMetodosPagamento = new FormMetodosPagamento();
            formMetodosPagamento.ShowDialog();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            cbMetodos.DataSource = null;
            listarMetodos();
            listarPagamentos();
        }

        /// <summary>
        /// Lista os pagamentos do pedido
        /// </summary>
        private void listarPagamentos()
        {
            lbPagamentos.DataSource = null;
            lbPagamentos.DataSource = pedido.Pagamento.ToList<Pagamento>();
        }

        /// <summary>
        /// Obtém o pedido que está selecionado no outro form;
        /// </summary>
        private void obterPedido()
        {
            int idPedido = FormPedidos.idPedido;
            var pedidos = restGest.Pedido.ToList();
            var pedidoSelecionado = pedidos.Where(pedido => pedido.IdPedido == idPedido).ToList();
            pedido = pedidoSelecionado[0] as Pedido;
        }

        private void btNovo_Click(object sender, EventArgs e)
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
        }

        /// <summary>
        /// Preenche labels de Valor pago e Valor a pagar
        /// </summary>
        private void preencherLabels()
        {
            labelValorAPagar.Text = pedido.ValorTotal.ToString()+"€";
            double valorPago = 0;
            foreach (Pagamento pagamento in pedido.Pagamento)
            {
                valorPago += pagamento.Valor;
            }
            labelValorPago.Text = valorPago.ToString()+"€";
            double troco = valorPago - pedido.ValorTotal;
            if (troco > 0) labelTroco.Text = troco.ToString() + "€";
            else labelTroco.Text = "0€";
        }
    }
}
