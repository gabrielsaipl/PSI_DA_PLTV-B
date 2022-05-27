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
    public partial class FormMetodosPagamento : Form
    {
        RestGestModelContainer restGest;
        public FormMetodosPagamento()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            listarMetodoPagamento();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void listarMetodoPagamento()
        {
            if (lbMetodosPagamento.SelectedIndex >= 0)
            {
                lbMetodosPagamento.DataSource = restGest.MetodoPagamento.ToList<MetodoPagamento>();
            }
        }

        private void btNovo_Click(object sender, EventArgs e) 
            {
                if (tbNovo.Text != "")
                {
                    string metodopagamento = tbNovo.Text;
                    MetodoPagamento novoMetodoPagamento = new MetodoPagamento(metodopagamento); // CRIAR NOVA CATEGORIA
                    restGest.MetodoPagamento.Add(novoMetodoPagamento);
                    restGest.SaveChanges();
                    listarMetodoPagamento();
                    tbNovo.Text = "";
                }
            }
        
        private void lbMetodosPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMetodosPagamento.SelectedIndex >= 0)
            {
                MetodoPagamento categoriaSelecionada = lbMetodosPagamento.SelectedItem as MetodoPagamento;
                tbNome.Text = categoriaSelecionada.MetodoPagament;
                cbEstado.Text = categoriaSelecionada.Ativo;
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        
        {
            if (tbNovo.Text != "")
            {
                MetodoPagamento metodopagamentoSelecionado = lbMetodosPagamento.SelectedItem as MetodoPagamento;
                metodopagamentoSelecionado.MetodoPagament = tbNome.Text;
                metodopagamentoSelecionado.Ativo = cbEstado.Text;
                restGest.SaveChanges();
                listarMetodoPagamento();
            }
            else MessageBox.Show("Insira o Método...");

        }
    }
}
