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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            FormClientes FClientes = new FormClientes();
            FClientes.ShowDialog();
        }

        private void bRestaurantes_Click(object sender, EventArgs e)
        {
            FormRestaurantes FRestaurantes = new FormRestaurantes();
            FRestaurantes.ShowDialog();
        }

        private void bMetodosPagamento_Click(object sender, EventArgs e)
        {

        }

        private void bCategoriasItem_Click(object sender, EventArgs e)
        {

        }

        private void bMenus_Click(object sender, EventArgs e)
        {

        }

        private void bPedidos_Click(object sender, EventArgs e)
        {

        }
    }
}
