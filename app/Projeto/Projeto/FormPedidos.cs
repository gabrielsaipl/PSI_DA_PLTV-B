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
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            FormPagamentos formPagamentos = new FormPagamentos();
            formPagamentos.ShowDialog();
        }
    }
}
