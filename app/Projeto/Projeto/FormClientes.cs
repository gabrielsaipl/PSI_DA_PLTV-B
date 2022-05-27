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

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            FormAddCliente addcliente = new FormAddCliente();
            addcliente.ShowDialog();
        }
        // FALTA TRATAR DO TOTAL








        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SE HOUVER CLIENTE SELECIONADO
            if (lbClientes.SelectedIndex >= 0) 
            {
                Cliente cliente = lbClientes.SelectedItem as Cliente;
                tbNome.Text = cliente.Nome;
                tbTelemovel.Text = cliente.Telemovel;
                tbNif.Text = cliente.NumContribuinte;
                tbPais.Text = cliente.Morada.Pais;
                tbRua.Text = cliente.Morada.Rua;
                tbCidade.Text = cliente.Morada.Cidade;
                tbCodPostal.Text = cliente.Morada.CodPostal;
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarClientes();
        }

        /// <summary>
        /// Atualiza ListBox Clientes
        /// </summary>
        private void listarClientes()
        {
            lbClientes.DataSource = null;
            // VERIFICA SE EXISTE PESSOAS (TRABALHADORES OU CLIENTES)
            if (restGest.Pessoa.Count() > 0)    
            {
                // SELECIONA OS OBJETOS DO TIPO CLIENTE DE TODAS AS PESSOAS
                var clientes = restGest.Pessoa.OfType<Cliente>().ToList();
                // VERIFICA SE EXISTEM CLIENTES
                if (clientes.Count() > 0) lbClientes.DataSource = clientes; 
                else MessageBox.Show("Ainda não existem clientes");
            }
            else MessageBox.Show("Ainda não existem Clientes");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex >= 0)
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
                    Cliente cliente = lbClientes.SelectedItem as Cliente;
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

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            lbClientes.DataSource = null;
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
                        if (clientesFiltrados.Count() > 0) lbClientes.DataSource = clientesFiltrados;
                        else lbClientes.DataSource = null;
                    }
                    else lbClientes.DataSource = clientes;
                }
            }
        }
    }
}
