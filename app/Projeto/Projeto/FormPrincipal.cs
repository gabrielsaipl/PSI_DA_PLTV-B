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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        /// <summary>
        /// Botão que volta ao menu anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Botão que abre o formulário de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClientes_Click(object sender, EventArgs e)
        {
            try
            {
                FormClientes FClientes = new FormClientes();
                FClientes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRestaurantes_Click(object sender, EventArgs e)
        {
            try
            {
                FormRestaurantes FRestaurantes = new FormRestaurantes();
                FRestaurantes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Métodos de Pagamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMetodosPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                FormMetodosPagamento FMetodosPagamento = new FormMetodosPagamento();
                FMetodosPagamento.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Categorias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCategoriasItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCategorias FCategorias = new FormCategorias();
                FCategorias.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Menus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMenus_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenuRestaurante FMenuRestaurante = new FormMenuRestaurante();
                FMenuRestaurante.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                FormPedidos FPedidos = new FormPedidos();
                FPedidos.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormClientes FClientes = new FormClientes();
                FClientes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de categorias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCategorias FCategorias = new FormCategorias();
                FCategorias.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Estados do pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void estadosDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstados formEstados = new FormEstados();
                formEstados.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Métodos de pagamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void métodosDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormMetodosPagamento FMetodosPagamento = new FormMetodosPagamento();
                FMetodosPagamento.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Restaurantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormRestaurantes FRestaurantes = new FormRestaurantes();
                FRestaurantes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de itens da cadeia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itensDaCadeiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormItensCadeia FItensCadeia = new FormItensCadeia();
                FItensCadeia.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de gestão do restaurante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGestaoRestaurante FGestaoRestaurante = new FormGestaoRestaurante();
                FGestaoRestaurante.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormPedidos Fpedidos = new FormPedidos();
                Fpedidos.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Menus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenuRestaurante FormMenuRestaurante = new FormMenuRestaurante();
                FormMenuRestaurante.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }

        /// <summary>
        /// Botão que abre o formulário de Estatisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstatisticas formEstatisticas = new FormEstatisticas();
                formEstatisticas.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }
        
        /// <summary>
        /// Botão que abre o formulário de Estatísticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstatisticas formEstatisticas = new FormEstatisticas();
                formEstatisticas.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário.");
            }
        }
    }
}
