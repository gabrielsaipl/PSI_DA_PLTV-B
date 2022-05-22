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
    public partial class FormGestaoRestaurante : Form
    {
        public FormGestaoRestaurante()
        {
            InitializeComponent();
            this.ControlBox = false;
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
            FormAddTrabalhador formAddTrabalhador = new FormAddTrabalhador();
            formAddTrabalhador.ShowDialog();
        }

        private void btMenus_Click(object sender, EventArgs e)
        {
            FormMenuRestaurante formMenuRestaurante = new FormMenuRestaurante();
            formMenuRestaurante.ShowDialog();
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.ShowDialog();
        }
    }
}
