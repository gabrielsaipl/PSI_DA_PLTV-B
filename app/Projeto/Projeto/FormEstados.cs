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
        /// Botão que adiciona um novo estado à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNovo_Click(object sender, EventArgs e)
        {
            if (tbNova.Text == "") return;
            try
            {   
                string estado = tbNova.Text;
                Estado novoEstado = new Estado(estado);
                restGest.Estado.Add(novoEstado);
                restGest.SaveChanges();
                tbNova.Text = "";
                listarEstados();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar um novo estado.");
            }
            
        }

        /// <summary>
        /// Quando o utilizador seleciona outro estado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbEstados.SelectedIndex >= 0)
                {
                    Estado estadoSelecionado = lbEstados.SelectedItem as Estado;
                    tbNome.Text = estadoSelecionado.Estadoo;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar o estado.");
            }
        }

        /// <summary>
        /// Botão que adiciona um estado à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGravar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text != "")
            {
                try
                {
                    Estado estadoSelecionado = lbEstados.SelectedItem as Estado;
                    estadoSelecionado.Estadoo = tbNome.Text;
                    restGest.SaveChanges();
                    listarEstados();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar gravar o estado selecionado.");
                }
            }
            else MessageBox.Show("Insira o nome...");
        }

        /// <summary>
        /// Lista os estados na Listbox 
        /// </summary>
        private void listarEstados()
        {
            try
            {
                lbEstados.DataSource = null;
                lbEstados.DataSource = restGest.Estado.ToList<Estado>();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar os estados.");
            }
            
        }

        /// <summary>
        /// Coloca na base de dados se ainda não existirem os quatro estados obrigatórios
        /// </summary>
        private void estadosPredefinidos()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao adicionar os estados obrigatórios.");
            }
            
        }
    }
}
