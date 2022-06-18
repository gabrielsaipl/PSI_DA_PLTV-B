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
    public partial class FormPedidos : Form
    {
        RestGestModelContainer restGest;
        public static int idPedido;         // VARIÁVEL QUE VAI GUARDAR O ID DO PEDIDO PARA O FORM DOS PAGAMENTOS
        public FormPedidos()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            preencherComboBoxRestaurantes();
            estadosPredefinidos();
            listarPedidos();
            listarItensMenu();
            listarClientes();
            listarTrabalhadores();
            listarItensPedido();
            listarEstados();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
            if (pedidoSelecionado == null) return;
            idPedido = pedidoSelecionado.IdPedido;
            FormPagamentos formPagamentos = new FormPagamentos();
            formPagamentos.ShowDialog();
        }

        /// <summary>
        /// Preencher ComboBox dos Restaurantes
        /// </summary>
        private void preencherComboBoxRestaurantes()
        {
            cbRestaurante.DataSource = restGest.Restaurante.ToList<Restaurante>();
        }

        private void cbRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarTrabalhadores();
            listarItensMenu();
            listarClientes();
            listarPedidos();
            listarItensMenu();
            listarItensPedido();
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
            lbMenu.DataSource = restauranteSelecionado.ItemMenu.ToList();
        }

        /// <summary>
        /// Lista todos os clientes da cadeia
        /// </summary>
        private void listarClientes()
        {
            cbClientes.DataSource = null;
            // VERIFICA SE EXISTE PESSOAS (TRABALHADORES OU CLIENTES)
            if (restGest.Pessoa.Count() > 0)
            {
                // SELECIONA OS OBJETOS DO TIPO CLIENTE DE TODAS AS PESSOAS
                var clientes = restGest.Pessoa.OfType<Cliente>().ToList();
                // VERIFICA SE EXISTEM CLIENTES
                if (clientes.Count() > 0) cbClientes.DataSource = clientes;
            }
        }

        /// <summary>
        /// Lista todos os trabalhadores
        /// </summary>
        private void listarTrabalhadores()
        {
            cbTrabalhadores.DataSource = null;
            // VERIFICA SE EXISTE PESSOAS (TRABALHADORES OU CLIENTES)
            if (restGest.Pessoa.Count() > 0)
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                // SELECIONA TODOS OS TRABALHADORES DENTRO DAS PESSOAS
                var trabalhadores = restGest.Pessoa.OfType<Trabalhador>().ToList();
                if (trabalhadores.Count() > 0)
                {
                    // PROCURA OS TRABALHADORES DO RESTAURANTE SELECIONADO
                    var trabalhadoresRestaurante = trabalhadores.Where(trabalhador => trabalhador.RestauranteIdRestaurante == restauranteSelecionado.IdRestaurante).ToList();
                    if (trabalhadoresRestaurante.Count() > 0)
                    {
                        //PROCURA OS TRABALHADORES ATIVOS
                        var trabalhadoresAtivos = trabalhadoresRestaurante.Where(trabalhador => trabalhador.Ativo == true).ToList();
                        if (trabalhadoresAtivos.Count() > 0)
                        {
                            cbTrabalhadores.DataSource = trabalhadoresRestaurante;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Lista todos os estados
        /// </summary>
        private void listarEstados()
        {
            if (restGest.Estado.Count() == 0) return;
            cbEstado.DataSource = restGest.Estado.ToList<Estado>();
        }

        /// <summary>
        /// Lista todos os itens do pedido
        /// </summary>
        private  void listarItensPedido()
        {
            lbitensPedido.DataSource = null;
            Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
            if (pedidoSelecionado == null) return;
            if (pedidoSelecionado.ItemMenu.Count() == 0) return;
            lbitensPedido.DataSource = pedidoSelecionado.ItemMenu.ToList<ItemMenu>();
        }

        /// <summary>
        /// Lista todos os Pedidos
        /// </summary>
        private void listarPedidos()
        {
            Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
            lbPedidos.DataSource = restauranteSelecionado.Pedido.ToList<Pedido>();
        }

        /// <summary>
        /// Filtrar Itens do Menu
        /// </summary>
        private void tbFiltrarMenu_TextChanged(object sender, EventArgs e)
        {
            if (restGest.ItemMenu.Count() > 0)
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                if (restauranteSelecionado == null) return;
                if (tbFiltrarMenu.Text != "")
                {
                    var itens = restauranteSelecionado.ItemMenu.ToList();
                    var itensFiltrados = itens.Where(item => item.Nome.Contains(tbFiltrarMenu.Text)).ToList();
                    lbMenu.DataSource = null;
                    lbMenu.DataSource = itensFiltrados;
                }
                else
                {
                    lbMenu.DataSource = null;
                    lbMenu.DataSource = restauranteSelecionado.ItemMenu.ToList();
                }
            }
        }

        /// <summary>
        /// Filtrar trabalhadores
        /// </summary>
        private void tbFiltrarTrabalhador_TextChanged(object sender, EventArgs e)
        {
            cbTrabalhadores.DataSource = null;
            if (restGest.Pessoa.Count() > 0)
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                // SELECIONA TODOS OS TRABALHADORES DENTRO DAS PESSOAS
                var trabalhadores = restGest.Pessoa.OfType<Trabalhador>().ToList();
                if (trabalhadores.Count() > 0)
                {
                    // PROCURA OS TRABALHADORES DO RESTAURANTE SELECIONADO
                    var trabalhadoresRestaurante = trabalhadores.Where(trabalhador => trabalhador.RestauranteIdRestaurante == restauranteSelecionado.IdRestaurante).ToList();
                    if (trabalhadoresRestaurante.Count() > 0)
                    {
                        if (tbFiltrarTrabalhador.Text != "")
                        {
                            var trabalhadoresFiltrados = trabalhadoresRestaurante.Where(trabalhador => trabalhador.Nome.Contains(tbFiltrarTrabalhador.Text)).ToList();
                            // VERIFICAR SE EXISTEM TRABALHADORES COM O FILTRO APLICADO
                            if (trabalhadoresFiltrados.Count() > 0) cbTrabalhadores.DataSource = trabalhadoresFiltrados;
                            else cbTrabalhadores.DataSource = null;
                        }
                        else cbTrabalhadores.DataSource = trabalhadoresRestaurante;
                    }
                }
            }
        }

        /// <summary>
        /// Filtrar todos os clientes
        /// </summary>
        private void tbFiltrarCliente_TextChanged(object sender, EventArgs e)
        {
            cbClientes.DataSource = null;
            if (restGest.Pessoa.Count() > 0)
            {
                // SELECIONA OS OBJETOS DO TIPO CLIENTE DE TODAS AS PESSOAS
                var clientes = restGest.Pessoa.OfType<Cliente>().ToList();
                if (clientes.Count() > 0)
                {
                    if (tbFiltrarCliente.Text != "")
                    {
                        var clientesFiltrados = clientes.Where(cliente => cliente.Nome.Contains(tbFiltrarCliente.Text)).ToList();
                        // VERIFICAR SE EXISTEM TRABALHADORES COM O FILTRO APLICADO
                        if (clientesFiltrados.Count() > 0) cbClientes.DataSource = clientesFiltrados;
                        else cbClientes.DataSource = null;
                    }
                    else cbClientes.DataSource = clientes;
                }
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
            if (restauranteSelecionado == null) return;
            //ADICIONAR PEDIDO E OBTER IDS ESTRANGEIROS DO PEDIDO
            Pedido novoPedido = new Pedido();
            Cliente clienteSelecionado = cbClientes.SelectedItem as Cliente;
            Trabalhador trabalhadorSelecionado = cbTrabalhadores.SelectedItem as Trabalhador;
            Estado estadoSelecionado = cbEstado.SelectedItem as Estado;
            if(estadoSelecionado == null || trabalhadorSelecionado == null || clienteSelecionado == null) return;
            novoPedido.Estado = estadoSelecionado;
            novoPedido.Cliente = clienteSelecionado;
            novoPedido.Trabalhador = trabalhadorSelecionado;
            restauranteSelecionado.Pedido.Add(novoPedido);
            restGest.SaveChanges();
            listarPedidos();
        }

        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
            if (pedidoSelecionado == null) return;
            ItemMenu itemSelecionado = lbMenu.SelectedItem as ItemMenu;
            if (itemSelecionado == null) return;
            pedidoSelecionado.ItemMenu.Add(itemSelecionado);
            pedidoSelecionado.ValorTotal += itemSelecionado.Preco;
            restGest.SaveChanges();
            listarItensPedido();
            listarPedidos();
            lbPedidos.SelectedItem = pedidoSelecionado;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarEstados();
        }

        private void btEstados_Click(object sender, EventArgs e)
        {
            FormEstados formEstados = new FormEstados();
            formEstados.ShowDialog();
        }

        private void btRemoverItem_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
            if (pedidoSelecionado == null) return;
            ItemMenu itemSelecionado = lbMenu.SelectedItem as ItemMenu;
            if (itemSelecionado == null) return;
            pedidoSelecionado.ItemMenu.Remove(itemSelecionado);
            pedidoSelecionado.ValorTotal -= itemSelecionado.Preco;
            restGest.SaveChanges();
            listarItensPedido();
            listarPedidos();
            lbPedidos.SelectedItem = pedidoSelecionado;
        }

        private void lbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarItensPedido();
            Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
            if(pedidoSelecionado == null) return;
            cbClientes.SelectedItem = pedidoSelecionado.Cliente;
            cbTrabalhadores.SelectedItem = pedidoSelecionado.Trabalhador;
            cbEstado.SelectedItem = pedidoSelecionado.Estado;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
            if (pedidoSelecionado == null) return;
            Estado estadoSelecionado = cbEstado.SelectedItem as Estado;
            if (estadoSelecionado == null) return;
            pedidoSelecionado.Estado = estadoSelecionado;
            restGest.SaveChanges();
            listarPedidos();
            lbPedidos.SelectedItem = pedidoSelecionado;
        }

        /// <summary>
        /// Vai colocar na base de dados se ainda não existirem os quatro estados obrigatórios
        /// </summary>
        private void estadosPredefinidos()
        {
            if (restGest.Estado.Count() > 4) return;
            Estado estado1 = new Estado("Recebido");
            Estado estado2 = new Estado("Em processamento");
            Estado estado3 = new Estado("Cancelado");
            Estado estado4 = new Estado("Concluído");
            restGest.Estado.Add(estado1);
            restGest.Estado.Add(estado2);
            restGest.Estado.Add(estado3);
            restGest.Estado.Add(estado4);
            restGest.SaveChanges();
        }
    }
}