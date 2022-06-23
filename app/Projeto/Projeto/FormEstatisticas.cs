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
    public partial class FormEstatisticas : Form
    {
        RestGestModelContainer restGest;
        public FormEstatisticas()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        /// <summary>
        /// Quando o form é carregado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            try
            {
                restGest = new RestGestModelContainer();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar verificar as estatisticas");
            }
            valorMedioCliente();
            numeroClientes();
            ganhosTotaisCadeia();
            graficoGanhosRestaurante();
            graficoTrabalhadoresRestaurante();
            clienteComMaisGastos();
            mediaTrabalhadoresRestaurante();
            totalTrabalhadores();
            quantidadePedidos();
            pratoMaisPedido();
            MetodoPagamentoMaisUsado();
            MaiorCidade();
        }

        /// <summary>
        /// Calcula o valor médio gasto por cliente
        /// </summary>
        private void valorMedioCliente()
        {
            try
            {
                double total = 0;
                var clientes = restGest.Pessoa.OfType<Cliente>().ToList();
                foreach (Cliente cliente in clientes)
                {
                    total += cliente.TotalGasto;
                }
                double media = total / clientes.Count();
                lbMediaCliente.Text = Math.Round(media,2).ToString()+" €";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar obter a média do valor gasto dos clientes.");
            }
        }

        /// <summary>
        /// Calcula o número total de clientes
        /// </summary>
        private void numeroClientes()
        {
            try
            {
                var clientes = restGest.Pessoa.OfType<Cliente>().ToList();
                lbClientes.Text = clientes.Count().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar obter o número de clientes.");
            }
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
        /// Calcula o total ganho na cadeia
        /// </summary>
        private void ganhosTotaisCadeia()
        {
            try
            {
                double total=0;
                foreach (Cliente cliente in restGest.Pessoa.OfType<Cliente>().ToList())
                {
                    total += cliente.TotalGasto;
                }
                lbGanhosTotais.Text = total.ToString()+"€";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar calcular os ganhos totais da cadeia..");
            }
        }

        /// <summary>
        /// Cria o gráfico de ganhos do restaurante
        /// </summary>
        private void graficoGanhosRestaurante()
        {
            try
            {
                chartGanhosRestaurante.Titles.Add("Ganhos por restaurante");
                foreach (Restaurante restaurante in restGest.Restaurante.ToList())
                {
                    double total = 0;
                    foreach (Pedido pedido in restaurante.Pedido.ToList())
                    {
                        total += pedido.ValorTotal;
                    }
                    chartGanhosRestaurante.Series["Ganhos"].Points.AddXY(restaurante.Nome, Convert.ToInt32(total).ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar fazer o gráfico dos ganhos por restaurante.");
            }

        }

        /// <summary>
        /// Cria o gráfico de quantidade de trabalhadores
        /// </summary>
        private void graficoTrabalhadoresRestaurante()
        {
            try
            {
                chartTrabalhadores.Titles.Add("Trabalhadores por restaurante");
                foreach (Restaurante restaurante in restGest.Restaurante.ToList())
                {
                    chartTrabalhadores.Series["Trabalhadores"].Points.AddXY(restaurante.Nome, restaurante.Trabalhador.Count().ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar fazer os gráficos da quantidade de trabalhadores por restaurantes");
            }
            
        }

        /// <summary>
        /// Calcula qual o cliente que tem mais gastos na cadeia e o valor
        /// </summary>
        private void clienteComMaisGastos()
        {
            try
            {
                string nomeCliente = "";
                double maior = 0;
                foreach (Cliente cliente in restGest.Pessoa.OfType<Cliente>().ToList())
                {
                    if (maior < cliente.TotalGasto)
                    {
                        maior = cliente.TotalGasto;
                        nomeCliente = cliente.Nome;
                    }
                }
                lbValorCliente.Text = nomeCliente + " " + maior.ToString() + "€";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar obter o cliente que tem mais gastos.");
            }
        }

        /// <summary>
        /// Calcula a média de trabalhadores por restaurante da cadeia
        /// </summary>
        private void mediaTrabalhadoresRestaurante()
        {
            try
            {
                double trabalhadores = restGest.Pessoa.OfType<Trabalhador>().Count();
                double restaurantes = restGest.Restaurante.Count();
                double media = trabalhadores / restaurantes;
                lbMediaTrabalhadores.Text = Math.Round(media, 2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar calcular a média de trabalhadores.");
            }
        }

        /// <summary>
        /// Calcula a quantidade de trabalhadores
        /// </summary>
        private void totalTrabalhadores()
        {
            try
            {
                int total = restGest.Pessoa.OfType<Trabalhador>().Count();
                lbTrabalhadores.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar obter a quantidade de trabalhadores.");
            }
            
        }

        /// <summary>
        /// Quantidade de pedidos da cadeia
        /// </summary>
        private void quantidadePedidos()
        {
            try
            {
                int quantidade = restGest.Pedido.Count();
                lbPedidosCadeia.Text = quantidade.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar obter a quantidade de pedidos da cadeia.");
            }
            
        }

        /// <summary>
        /// Prato mais requisitado do restaurante
        /// </summary>
        private void pratoMaisPedido()
        {
            try
            {
                Dictionary<string, int> ItemQuantidade = new Dictionary<string, int>();
                bool existe;
                foreach (Pedido pedido in restGest.Pedido.ToList())
                {
                    foreach (ItemMenu item in pedido.ItemMenu)
                    {

                        existe = false;
                        foreach (var itemDicionario in ItemQuantidade)
                        {
                            if (itemDicionario.Key == item.Nome) existe = true;
                        }
                        if (existe) ItemQuantidade[item.Nome]++;
                        else ItemQuantidade.Add(item.Nome, 1);
                    }
                }
                int maior = 0;
                string nome = "";
                foreach (var item in ItemQuantidade)
                {
                    if (item.Value > maior)
                    {
                        maior = item.Value;
                        nome = item.Key;
                    }
                }
                lbPratoMaisPedido.Text = nome + " " + maior + " vezes";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar encontrar o prato mais pedido.");
            }
        }

        /// <summary>
        /// Metodo de pagamento mais usado na cadeira
        /// </summary>
        private void MetodoPagamentoMaisUsado()
        {
            try
            {
                Dictionary<string, int> metodoQuantidade = new Dictionary<string, int>();
                bool existe;
                foreach (Pedido pedido in restGest.Pedido.ToList<Pedido>())
                {
                    foreach (Pagamento pagamento in pedido.Pagamento.ToList<Pagamento>())
                    {
                        existe = false;
                        foreach (var itemDicionario in metodoQuantidade)
                        {
                            if (itemDicionario.Key == pagamento.MetodoPagamento.MetodoPagament)
                            {
                                existe = true;
                            }
                        }
                        if (existe) metodoQuantidade[pagamento.MetodoPagamento.MetodoPagament]++;
                        else metodoQuantidade.Add(pagamento.MetodoPagamento.MetodoPagament, 1);
                    }
                }
                int maior = 0;
                string nome = "";
                foreach (var item in metodoQuantidade)
                {
                    if (item.Value > maior)
                    {
                        maior = item.Value;
                        nome = item.Key;
                    }
                }
                lbMetodoPagamento.Text = nome + " " + maior + " vezes";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar encontrar o prato mais pedido.");
            }
        }

        /// <summary>
        /// Calcula a localidade(dos clientes) onde houve mais gastos
        /// </summary>
        private void MaiorCidade()
        {
            try
            {
                Dictionary<string, int> cidadeQuantidade = new Dictionary<string, int>();
                bool existe;
                foreach (Pedido pedido in restGest.Pedido.ToList<Pedido>())
                {
                    existe = false;
                    foreach (var itemDicionario in cidadeQuantidade)
                    {
                        if (itemDicionario.Key == pedido.Cliente.Morada.Cidade)
                        {
                            existe = true;
                        }
                    }
                    if (existe) cidadeQuantidade[pedido.Cliente.Morada.Cidade]++;
                    else cidadeQuantidade.Add(pedido.Cliente.Morada.Cidade, 1);
                }
                int maior = 0;
                string nome = "";
                foreach (var item in cidadeQuantidade)
                {
                    if (item.Value > maior)
                    {
                        maior = item.Value;
                        nome = item.Key;
                    }
                }
                lbCidadeMaisGastos.Text = nome;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar encontrar o prato mais pedido.");
            }
        }
    }
}
