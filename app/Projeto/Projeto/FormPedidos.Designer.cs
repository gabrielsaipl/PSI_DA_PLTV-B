namespace Projeto
{
    partial class FormPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbRestaurante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPedidos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btPagamento = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.lbTrabalhadores = new System.Windows.Forms.ListBox();
            this.lbCliente = new System.Windows.Forms.ListBox();
            this.btFiltrarCliente = new System.Windows.Forms.Button();
            this.tbFiltrarCliente = new System.Windows.Forms.TextBox();
            this.btFiltrarTrabalhador = new System.Windows.Forms.Button();
            this.tbFiltrarTrabalhador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbMenuRestaurante = new System.Windows.Forms.ListBox();
            this.btAdicionarItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbRemoverItem = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.gravarPedidoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // gravarPedidoToolStripMenuItem
            // 
            this.gravarPedidoToolStripMenuItem.Name = "gravarPedidoToolStripMenuItem";
            this.gravarPedidoToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.gravarPedidoToolStripMenuItem.Text = "Gravar Pedido";
            // 
            // cbRestaurante
            // 
            this.cbRestaurante.FormattingEnabled = true;
            this.cbRestaurante.Location = new System.Drawing.Point(12, 106);
            this.cbRestaurante.Name = "cbRestaurante";
            this.cbRestaurante.Size = new System.Drawing.Size(336, 24);
            this.cbRestaurante.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 46;
            this.label1.Text = "Pedidos";
            // 
            // lbPedidos
            // 
            this.lbPedidos.FormattingEnabled = true;
            this.lbPedidos.ItemHeight = 16;
            this.lbPedidos.Location = new System.Drawing.Point(12, 136);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(336, 420);
            this.lbPedidos.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbEstado.Location = new System.Drawing.Point(87, 564);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(113, 24);
            this.cbEstado.TabIndex = 48;
            // 
            // btPagamento
            // 
            this.btPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.btPagamento.Location = new System.Drawing.Point(206, 564);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(142, 27);
            this.btPagamento.TabIndex = 50;
            this.btPagamento.Text = "Pagamento";
            this.btPagamento.UseVisualStyleBackColor = false;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(865, 89);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(246, 41);
            this.btNovo.TabIndex = 51;
            this.btNovo.Text = "Adicionar Pedido";
            this.btNovo.UseVisualStyleBackColor = false;
            // 
            // lbTrabalhadores
            // 
            this.lbTrabalhadores.FormattingEnabled = true;
            this.lbTrabalhadores.ItemHeight = 16;
            this.lbTrabalhadores.Location = new System.Drawing.Point(388, 136);
            this.lbTrabalhadores.Name = "lbTrabalhadores";
            this.lbTrabalhadores.Size = new System.Drawing.Size(351, 180);
            this.lbTrabalhadores.TabIndex = 52;
            // 
            // lbCliente
            // 
            this.lbCliente.FormattingEnabled = true;
            this.lbCliente.ItemHeight = 16;
            this.lbCliente.Location = new System.Drawing.Point(388, 360);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(351, 196);
            this.lbCliente.TabIndex = 53;
            // 
            // btFiltrarCliente
            // 
            this.btFiltrarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btFiltrarCliente.Location = new System.Drawing.Point(619, 564);
            this.btFiltrarCliente.Name = "btFiltrarCliente";
            this.btFiltrarCliente.Size = new System.Drawing.Size(120, 27);
            this.btFiltrarCliente.TabIndex = 55;
            this.btFiltrarCliente.Text = "Filtrar";
            this.btFiltrarCliente.UseVisualStyleBackColor = false;
            // 
            // tbFiltrarCliente
            // 
            this.tbFiltrarCliente.Location = new System.Drawing.Point(388, 564);
            this.tbFiltrarCliente.Name = "tbFiltrarCliente";
            this.tbFiltrarCliente.Size = new System.Drawing.Size(225, 22);
            this.tbFiltrarCliente.TabIndex = 54;
            // 
            // btFiltrarTrabalhador
            // 
            this.btFiltrarTrabalhador.BackColor = System.Drawing.SystemColors.Window;
            this.btFiltrarTrabalhador.Location = new System.Drawing.Point(619, 322);
            this.btFiltrarTrabalhador.Name = "btFiltrarTrabalhador";
            this.btFiltrarTrabalhador.Size = new System.Drawing.Size(120, 27);
            this.btFiltrarTrabalhador.TabIndex = 57;
            this.btFiltrarTrabalhador.Text = "Filtrar";
            this.btFiltrarTrabalhador.UseVisualStyleBackColor = false;
            // 
            // tbFiltrarTrabalhador
            // 
            this.tbFiltrarTrabalhador.Location = new System.Drawing.Point(388, 322);
            this.tbFiltrarTrabalhador.Name = "tbFiltrarTrabalhador";
            this.tbFiltrarTrabalhador.Size = new System.Drawing.Size(225, 22);
            this.tbFiltrarTrabalhador.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(991, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 60;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(760, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 59;
            // 
            // lbMenuRestaurante
            // 
            this.lbMenuRestaurante.FormattingEnabled = true;
            this.lbMenuRestaurante.ItemHeight = 16;
            this.lbMenuRestaurante.Location = new System.Drawing.Point(760, 136);
            this.lbMenuRestaurante.Name = "lbMenuRestaurante";
            this.lbMenuRestaurante.Size = new System.Drawing.Size(351, 180);
            this.lbMenuRestaurante.TabIndex = 58;
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.BackColor = System.Drawing.SystemColors.Window;
            this.btAdicionarItem.Location = new System.Drawing.Point(760, 350);
            this.btAdicionarItem.Name = "btAdicionarItem";
            this.btAdicionarItem.Size = new System.Drawing.Size(351, 29);
            this.btAdicionarItem.TabIndex = 61;
            this.btAdicionarItem.Text = "Adicionar Item ao Pedido";
            this.btAdicionarItem.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(760, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(351, 29);
            this.button2.TabIndex = 63;
            this.button2.Text = "Remover Item do Pedido";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbRemoverItem
            // 
            this.lbRemoverItem.FormattingEnabled = true;
            this.lbRemoverItem.ItemHeight = 16;
            this.lbRemoverItem.Location = new System.Drawing.Point(760, 385);
            this.lbRemoverItem.Name = "lbRemoverItem";
            this.lbRemoverItem.Size = new System.Drawing.Size(351, 164);
            this.lbRemoverItem.TabIndex = 64;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1130, 617);
            this.Controls.Add(this.lbRemoverItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btAdicionarItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbMenuRestaurante);
            this.Controls.Add(this.btFiltrarTrabalhador);
            this.Controls.Add(this.tbFiltrarTrabalhador);
            this.Controls.Add(this.btFiltrarCliente);
            this.Controls.Add(this.tbFiltrarCliente);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.lbTrabalhadores);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lbPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRestaurante);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1148, 664);
            this.MinimumSize = new System.Drawing.Size(1148, 664);
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Pedidos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarPedidoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbRestaurante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btPagamento;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.ListBox lbTrabalhadores;
        private System.Windows.Forms.ListBox lbCliente;
        private System.Windows.Forms.Button btFiltrarCliente;
        private System.Windows.Forms.TextBox tbFiltrarCliente;
        private System.Windows.Forms.Button btFiltrarTrabalhador;
        private System.Windows.Forms.TextBox tbFiltrarTrabalhador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbMenuRestaurante;
        private System.Windows.Forms.Button btAdicionarItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbRemoverItem;
    }
}