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
    public partial class FormEstados : Form
    {
        RestGestModelContainer restGest;
        public FormEstados()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            listarEstados();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (tbNova.Text == "") return;
            string estado = tbNova.Text;
            Estado novoEstado = new Estado(estado);
            restGest.Estado.Add(novoEstado);
            restGest.SaveChanges();
            tbNova.Text = "";
            listarEstados();
        }

        private void lbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEstados.SelectedIndex >= 0)
            {
                Estado estadoSelecionado = lbEstados.SelectedItem as Estado;
                tbNome.Text = estadoSelecionado.Estadoo;
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text != "")
            {
                Estado estadoSelecionado = lbEstados.SelectedItem as Estado;
                estadoSelecionado.Estadoo = tbNome.Text;
                restGest.SaveChanges();
                listarEstados();
            }
            else MessageBox.Show("Insira o nome...");
        }

        /// <summary>
        /// Lista os pedidos na Listbox 
        /// </summary>
        private void listarEstados()
        {
            lbEstados.DataSource = restGest.Estado.ToList<Estado>();
        }
    }
}
