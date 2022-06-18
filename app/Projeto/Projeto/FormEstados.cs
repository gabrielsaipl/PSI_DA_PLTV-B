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
            estadosPredefinidos();
            listarEstados();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
