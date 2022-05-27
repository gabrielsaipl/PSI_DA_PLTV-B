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

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbClientes.SelectedIndex >= 0) // SE FOR MAIOR QUE 0
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
            if (restGest.Pessoa.Count() > 0)    // VERIFICA SE EXISTE PESSOAS (TRABALHADORES OU CLIENTES)
            {
                lbClientes.DataSource = null;
                var clientes = restGest.Pessoa.OfType<Cliente>().ToList();  // SELECIONA OS OBJETOS DO TIPO CLIENTE DE TODAS AS PESSOAS
                if (clientes.Count() > 0) lbClientes.DataSource = clientes; // VERIFICA SE EXISTEM CLIENTES
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
    }
}
