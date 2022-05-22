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
    public partial class FormMenuRestaurante : Form
    {
        public FormMenuRestaurante()
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

        private void btCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.ShowDialog();
        }

        private void btItensCadeia_Click(object sender, EventArgs e)
        {
            FormItensCadeia formItensCadeia = new FormItensCadeia();
            formItensCadeia.ShowDialog();
        }
    }
}
