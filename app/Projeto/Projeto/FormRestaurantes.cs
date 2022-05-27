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
    public partial class FormRestaurantes : Form
    {
        RestGestModelContainer restGest;
        public FormRestaurantes()
        {
            InitializeComponent();
            this.ControlBox = false;
            restGest = new RestGestModelContainer();
            listarRestaurantes();
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
            FormAddRestaurante formAddRestaurante = new FormAddRestaurante();
            formAddRestaurante.ShowDialog();
        }

        private void btGerir_Click(object sender, EventArgs e)
        {
            FormGestaoRestaurante formGestaoRestaurante = new FormGestaoRestaurante();
            formGestaoRestaurante.ShowDialog();
        }

        /// <summary>
        /// Atualizar listbox dos restaurantes
        /// </summary>
        public void listarRestaurantes()
        {
            if (restGest.Restaurante.Count() > 0)
            {
                lbRestaurantes.DataSource = null;
                lbRestaurantes.DataSource = restGest.Restaurante.ToList<Restaurante>();
            }
            else MessageBox.Show("Ainda não existem restaurantes");
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            listarRestaurantes();
        }

        private void lbRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRestaurantes.SelectedIndex >= 0)  // VERIFICA SE EXISTE UM ITEM SELECIONADO
            {
                Restaurante restauranteSelecionado = (Restaurante)lbRestaurantes.SelectedItem;
                tbNome.Text = restauranteSelecionado.Nome;
                tbPais.Text = restauranteSelecionado.Morada.Pais;
                tbCidade.Text = restauranteSelecionado.Morada.Cidade;
                tbRua.Text = restauranteSelecionado.Morada.Rua;
                tbCodPostal.Text = restauranteSelecionado.Morada.CodPostal;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (lbRestaurantes.SelectedIndex >= 0) // VERIFICA SE EXISTE UM ITEM SELECIONADO
            {
                string nomeRestaurante = tbNome.Text;
                string pais = tbPais.Text;
                string cidade = tbCidade.Text;
                string rua = tbRua.Text;
                string codPostal = tbCodPostal.Text;
                // VERIFICA SE ALGUMA TEXTBOX ESTÁ VAZIA
                if (nomeRestaurante != "" && pais != "" && cidade != "" && rua != "" && codPostal != "")    
                {
                    Restaurante restauranteSelecionado = (Restaurante)lbRestaurantes.SelectedItem;
                    restauranteSelecionado.Nome = nomeRestaurante;
                    restauranteSelecionado.Morada.Pais = pais;
                    restauranteSelecionado.Morada.Cidade = cidade;
                    restauranteSelecionado.Morada.Rua = rua;
                    restauranteSelecionado.Morada.CodPostal = codPostal;
                }
            }
        }
    }
}
