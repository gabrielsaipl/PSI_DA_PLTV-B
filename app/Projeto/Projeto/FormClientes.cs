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
    public partial class FormClientes : Form
    {
        RestGestModelContainer restGest;
        public FormClientes()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            listarClientes();
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
        /// Botão que abre o formulário de adicionar novo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            FormAddCliente addcliente = new FormAddCliente();
            addcliente.ShowDialog();
        }

        /// <summary>
        /// Botão que atualiza a lista de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarClientes();
        }

        /// <summary>
        /// Atualiza ListBox Clientes
        /// </summary>
        private void listarClientes()
        {
            bsClientes.DataSource = null;
            // VERIFICA SE EXISTE PESSOAS (TRABALHADORES OU CLIENTES)
            if (restGest.Pessoa.Count() > 0)    
            {
                try
                {
                    // SELECIONA OS CLIENTES DE TODAS AS PESSOAS
                    var clientes = restGest.Pessoa.OfType<Cliente>().ToList();
                    // VERIFICA SE EXISTEM CLIENTES
                    if (clientes.Count() > 0) bsClientes.DataSource = clientes;
                    else MessageBox.Show("Ainda não existem clientes");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar listar os Clientes");
                }
            }
            else MessageBox.Show("Ainda não existem Clientes");
        }

        /// <summary>
        /// Botão que grava na base de dados os novos dados editados da cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    string pais = tbPais.Text;
                    string cidade = tbCidade.Text;
                    string codPostal = tbCodPostal.Text;
                    string rua = tbRua.Text;
                    string nome = tbNome.Text;
                    string telemovel = tbTelemovel.Text;
                    string nif = tbNif.Text;
                    if (pais != "" && cidade != "" && codPostal != "" && rua != "" && nome != "" && telemovel != "" && nif != "")
                    {
                        Cliente cliente = dgvClientes.SelectedRows[0].DataBoundItem as Cliente;
                        cliente.Telemovel = telemovel;
                        cliente.Nome = nome;
                        cliente.NumContribuinte = nif;
                        cliente.Morada.Pais = pais;
                        cliente.Morada.Cidade = cidade;
                        cliente.Morada.Rua = rua;
                        cliente.Morada.CodPostal = codPostal;
                        restGest.SaveChanges();
                        listarClientes();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar atualizar os dados do cliente.");
            }
        }

        /// <summary>
        /// Filtração de Clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsClientes.DataSource = null;
                // VERIFICA SE EXISTE PESSOAS (TRABALHADORES OU CLIENTES)
                if (restGest.Pessoa.Count() > 0)
                {
                    // SELECIONA OS OBJETOS DO TIPO CLIENTE DE TODAS AS PESSOAS
                    var clientes = restGest.Pessoa.OfType<Cliente>().ToList();
                    // VERIFICA SE EXISTEM CLIENTES
                    if (clientes.Count() > 0)
                    {
                        if (tbFiltrar.Text != "")
                        {
                            var clientesFiltrados = clientes.Where(cliente => cliente.Nome.Contains(tbFiltrar.Text)).ToList();
                            // VERIFICAR SE EXISTEM TRABALHADORES COM O FILTRO APLICADO
                            if (clientesFiltrados.Count() > 0) bsClientes.DataSource = clientesFiltrados;
                            else bsClientes.DataSource = null;
                        }
                        else bsClientes.DataSource = clientes;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar filtrar os clientes.");
            }
        }

        /// <summary>
        /// Quando o utilizador seleciona outro cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    Cliente cliente = dgvClientes.SelectedRows[0].DataBoundItem as Cliente;
                    tbNome.Text = cliente.Nome;
                    tbTelemovel.Text = cliente.Telemovel;
                    lbtotal.Text = cliente.TotalGasto.ToString()+"€";
                    tbNif.Text = cliente.NumContribuinte;
                    tbPais.Text = cliente.Morada.Pais;
                    tbRua.Text = cliente.Morada.Rua;
                    tbCidade.Text = cliente.Morada.Cidade;
                    tbCodPostal.Text = cliente.Morada.CodPostal;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar selecionar o cliente.");
            }
        }

        /// <summary>
        /// Eliminar cliente da base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btApagar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count <= 0) return;
            DialogResult Confirmacao = MessageBox.Show("Tem a certeza que pretende eliminar o cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
            if (Confirmacao == DialogResult.Yes)
            {
                try
                {
                    Cliente cliente = dgvClientes.SelectedRows[0].DataBoundItem as Cliente;
                    Morada moradaCliente = cliente.Morada;
                    // para cada pedido do Cliente Selecionado
                    foreach (Pedido pedido in cliente.Pedido.ToList())
                    {
                        //para cada pagamento do pedido 
                        foreach (Pagamento pagamento in pedido.Pagamento.ToList())
                        {
                            //Eliminar pagamento do pedido
                            restGest.Pagamento.Remove(pagamento);
                        }
                        //para cada itemMenu de cada pedido
                        foreach (ItemMenu itemPedido in pedido.ItemMenu.ToList())
                        {
                            //Eliminar Item do pedido
                            pedido.ItemMenu.Remove(itemPedido);
                        }
                        //Elimina o Pedido do Cliente
                        restGest.Pedido.Remove(pedido);
                    }
                    restGest.Pessoa.Remove(cliente);
                    restGest.Morada.Remove(moradaCliente);
                    restGest.SaveChanges();
                    listarClientes();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar eliminar o cliente selecionado.");
                }
            }           
        }
    }
}
