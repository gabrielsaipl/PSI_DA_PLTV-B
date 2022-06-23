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
        /// Botão que abre o formulário de pagamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
                if (pedidoSelecionado == null) return;
                if (pedidoSelecionado.ValorTotal <= 0)
                {
                    MessageBox.Show("Ainda não existem itens no Pedido");
                    return;
                }
                idPedido = pedidoSelecionado.IdPedido;
                FormPagamentos formPagamentos = new FormPagamentos();
                formPagamentos.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o formulário.");
            }
        }

        /// <summary>
        /// Preencher ComboBox dos Restaurantes
        /// </summary>
        private void preencherComboBoxRestaurantes()
        {
            try
            {
                cbRestaurante.DataSource = null;
                cbRestaurante.DataSource = restGest.Restaurante.ToList<Restaurante>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar preencher a comboBox dos restaurantes.");
            }
            
        }

        /// <summary>
        /// Quando o restaurante selecionado é alterado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            try
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                if (restauranteSelecionado == null) return;
                lbMenu.DataSource = null;
                if (restauranteSelecionado.ItemMenu.Count() == 0) return;
                lbMenu.DataSource = restauranteSelecionado.ItemMenu.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os itens de menu.");
            }
        }

        /// <summary>
        /// Lista todos os clientes da cadeia
        /// </summary>
        private void listarClientes()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os clientes.");
            }
        }

        /// <summary>
        /// Lista todos os trabalhadores
        /// </summary>
        private void listarTrabalhadores()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os trabalhadores.");
            }
        }

        /// <summary>
        /// Lista todos os estados
        /// </summary>
        private void listarEstados()
        {
            try
            {
                if (restGest.Estado.Count() == 0) return;
                cbEstado.DataSource = restGest.Estado.ToList<Estado>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao listar os Estados.");
            }
            
        }

        /// <summary>
        /// Lista todos os itens do pedido
        /// </summary>
        private  void listarItensPedido()
        {
            try
            {
                lbitensPedido.DataSource = null;
                Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
                if (pedidoSelecionado == null) return;
                if (pedidoSelecionado.ItemMenu.Count() == 0) return;
                lbitensPedido.DataSource = pedidoSelecionado.ItemMenu.ToList<ItemMenu>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os itens de pedido.");
            }
        }

        /// <summary>
        /// Lista todos os Pedidos
        /// </summary>
        private void listarPedidos()
        {
            try
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                lbPedidos.DataSource = restauranteSelecionado.Pedido.ToList<Pedido>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os pedidos.");
            }
        }

        /// <summary>
        /// Filtrar Itens do Menu
        /// </summary>
        private void tbFiltrarMenu_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar filtrar itens do cadeia.");
            }
        }

        /// <summary>
        /// Filtrar trabalhadores
        /// </summary>
        private void tbFiltrarTrabalhador_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar filtrar os trabalhadores.");
            }
        }

        /// <summary>
        /// Filtrar todos os clientes
        /// </summary>
        private void tbFiltrarCliente_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar filtrar os trabalhadores.");
            }
        }

        /// <summary>
        /// Guarda um novo pedido na base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovo_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                if (restauranteSelecionado == null) return;
                //ADICIONAR PEDIDO E OBTER IDS ESTRANGEIROS DO PEDIDO
                Pedido novoPedido = new Pedido();
                Cliente clienteSelecionado = cbClientes.SelectedItem as Cliente;
                Trabalhador trabalhadorSelecionado = cbTrabalhadores.SelectedItem as Trabalhador;
                Estado estadoSelecionado = cbEstado.SelectedItem as Estado;
                if (estadoSelecionado == null || trabalhadorSelecionado == null || clienteSelecionado == null) return;
                novoPedido.Estado = estadoSelecionado;
                novoPedido.Cliente = clienteSelecionado;
                novoPedido.Trabalhador = trabalhadorSelecionado;
                restauranteSelecionado.Pedido.Add(novoPedido);
                restGest.SaveChanges();
                listarPedidos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar um pedido à base de dados.");
            }
            
        }

        /// <summary>
        /// Adiciona um item ao pedido selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
                if (pedidoSelecionado == null) 
                {
                    MessageBox.Show("Adicione primeiro um pedido à lista.");
                    return;
                };
                ItemMenu itemSelecionado = lbMenu.SelectedItem as ItemMenu;
                if (itemSelecionado == null) return;
                pedidoSelecionado.ItemMenu.Add(itemSelecionado);
                pedidoSelecionado.ValorTotal += itemSelecionado.Preco;
                pedidoSelecionado.Cliente.TotalGasto += itemSelecionado.Preco;
                restGest.SaveChanges();
                listarItensPedido();
                listarPedidos();
                lbPedidos.SelectedItem = pedidoSelecionado;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar o item.");
            }   
        }

        /// <summary>
        /// Atualiza a lista de estados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarEstados();
        }

        /// <summary>
        /// Abre o formulário de gestão dos estados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEstados_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstados formEstados = new FormEstados();
                formEstados.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o formulário.");
            }
            
        }

        /// <summary>
        /// Remove itens do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRemoverItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
                if (pedidoSelecionado == null) return;
                ItemMenu itemSelecionado = lbitensPedido.SelectedItem as ItemMenu;
                if (itemSelecionado == null) return;
                pedidoSelecionado.ItemMenu.Remove(itemSelecionado);
                pedidoSelecionado.ValorTotal -= itemSelecionado.Preco;
                pedidoSelecionado.Cliente.TotalGasto -= itemSelecionado.Preco;
                restGest.SaveChanges();
                listarItensPedido();
                listarPedidos();
                lbPedidos.SelectedItem = pedidoSelecionado;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar eliminar o item.");
            }
        }

        /// <summary>
        /// Quando o pedido selecionado é alterado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listarItensPedido();
                Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
                if (pedidoSelecionado == null) return;
                cbClientes.SelectedItem = pedidoSelecionado.Cliente;
                cbTrabalhadores.SelectedItem = pedidoSelecionado.Trabalhador;
                cbEstado.SelectedItem = pedidoSelecionado.Estado;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar o pedido.");
            }
        }

        /// <summary>
        /// Botão que guarda os novos dados editados do pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar gravar o pedido.");
            }
        }

        /// <summary>
        /// Vai colocar na base de dados se ainda não existirem os quatro estados obrigatórios
        /// </summary>
        private void estadosPredefinidos()
        {
            try
            {
                if (restGest.Estado.Count() >= 4) return;
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao colocar adicionar estados predifinidos.");
            }
        }

        /// <summary>
        /// Grava o pedido num ficheiro txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gravarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restauranteSelecionado = cbRestaurante.SelectedItem as Restaurante;
                Pedido pedidoSelecionado = lbPedidos.SelectedItem as Pedido;
                SaveFileDialog sdlg = new SaveFileDialog();
                sdlg.Title = "Guarde o ficheiro de dados";
                sdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sdlg.ShowDialog() == DialogResult.OK)
                {
                    string caminho = sdlg.FileName;
                    FileStream ficheiro = new FileStream(caminho, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(ficheiro);
                    sw.WriteLine(restauranteSelecionado.Nome);
                    sw.WriteLine(restauranteSelecionado.Morada.Pais);
                    sw.WriteLine(restauranteSelecionado.Morada.Cidade + "  " + restauranteSelecionado.Morada.CodPostal);
                    sw.WriteLine(restauranteSelecionado.Morada.Rua);
                    sw.WriteLine("----------------------");
                    sw.WriteLine("Informação do Pedido");
                    sw.WriteLine("Pedido nº " + pedidoSelecionado.IdPedido);
                    sw.WriteLine("Cliente - " + pedidoSelecionado.Cliente.Nome);
                    sw.WriteLine("Trabalhador a tratar do Pedido - " + pedidoSelecionado.Trabalhador.Nome);
                    sw.WriteLine("----------------------");
                    sw.WriteLine("Itens do Pedido:");
                    foreach (ItemMenu itemPedido in pedidoSelecionado.ItemMenu)
                    {
                        sw.WriteLine("   - " + itemPedido.Nome + " -- " + itemPedido.Preco + "€");
                    }
                    sw.WriteLine("----------------------");
                    sw.WriteLine("Pagamentos do Pedido");
                    foreach (Pagamento pagamento in pedidoSelecionado.Pagamento)
                    {
                        sw.WriteLine("   - " + pagamento.Valor + "€ - " + pagamento.MetodoPagamento.MetodoPagament);
                    }
                    sw.WriteLine("----------------------");
                    sw.WriteLine("Estado atual do Pedido: " + pedidoSelecionado.Estado.Estadoo);
                    sw.Close();
                    ficheiro.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar gravar o ficheiro.");
            }
        }
    }
}