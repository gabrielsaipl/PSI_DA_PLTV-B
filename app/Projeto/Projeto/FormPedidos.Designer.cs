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
            this.tbFiltrarCliente = new System.Windows.Forms.TextBox();
            this.tbFiltrarTrabalhador = new System.Windows.Forms.TextBox();
            this.tbFiltrarMenu = new System.Windows.Forms.TextBox();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.btAdicionarItem = new System.Windows.Forms.Button();
            this.btRemoverItem = new System.Windows.Forms.Button();
            this.lbitensPedido = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btEstados = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
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
            this.cbRestaurante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestaurante.FormattingEnabled = true;
            this.cbRestaurante.Location = new System.Drawing.Point(12, 106);
            this.cbRestaurante.Name = "cbRestaurante";
            this.cbRestaurante.Size = new System.Drawing.Size(399, 24);
            this.cbRestaurante.TabIndex = 45;
            this.cbRestaurante.SelectedIndexChanged += new System.EventHandler(this.cbRestaurante_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 46;
            this.label1.Text = "Pedidos";
            // 
            // lbPedidos
            // 
            this.lbPedidos.FormattingEnabled = true;
            this.lbPedidos.ItemHeight = 16;
            this.lbPedidos.Location = new System.Drawing.Point(12, 172);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(399, 420);
            this.lbPedidos.TabIndex = 47;
            this.lbPedidos.SelectedIndexChanged += new System.EventHandler(this.lbPedidos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(163, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            ""});
            this.cbEstado.Location = new System.Drawing.Point(235, 604);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(138, 24);
            this.cbEstado.TabIndex = 48;
            // 
            // btPagamento
            // 
            this.btPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.btPagamento.Location = new System.Drawing.Point(12, 139);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(191, 27);
            this.btPagamento.TabIndex = 50;
            this.btPagamento.Text = "Pagamento";
            this.btPagamento.UseVisualStyleBackColor = false;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(209, 139);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(202, 27);
            this.btNovo.TabIndex = 51;
            this.btNovo.Text = "Adicionar Pedido";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // lbTrabalhadores
            // 
            this.lbTrabalhadores.FormattingEnabled = true;
            this.lbTrabalhadores.ItemHeight = 16;
            this.lbTrabalhadores.Location = new System.Drawing.Point(438, 172);
            this.lbTrabalhadores.Name = "lbTrabalhadores";
            this.lbTrabalhadores.Size = new System.Drawing.Size(351, 180);
            this.lbTrabalhadores.TabIndex = 52;
            // 
            // lbCliente
            // 
            this.lbCliente.FormattingEnabled = true;
            this.lbCliente.ItemHeight = 16;
            this.lbCliente.Location = new System.Drawing.Point(438, 396);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(351, 196);
            this.lbCliente.TabIndex = 53;
            // 
            // tbFiltrarCliente
            // 
            this.tbFiltrarCliente.Location = new System.Drawing.Point(564, 599);
            this.tbFiltrarCliente.Name = "tbFiltrarCliente";
            this.tbFiltrarCliente.Size = new System.Drawing.Size(225, 22);
            this.tbFiltrarCliente.TabIndex = 54;
            this.tbFiltrarCliente.TextChanged += new System.EventHandler(this.tbFiltrarCliente_TextChanged);
            // 
            // tbFiltrarTrabalhador
            // 
            this.tbFiltrarTrabalhador.Location = new System.Drawing.Point(633, 358);
            this.tbFiltrarTrabalhador.Name = "tbFiltrarTrabalhador";
            this.tbFiltrarTrabalhador.Size = new System.Drawing.Size(156, 22);
            this.tbFiltrarTrabalhador.TabIndex = 56;
            this.tbFiltrarTrabalhador.TextChanged += new System.EventHandler(this.tbFiltrarTrabalhador_TextChanged);
            // 
            // tbFiltrarMenu
            // 
            this.tbFiltrarMenu.Location = new System.Drawing.Point(955, 358);
            this.tbFiltrarMenu.Name = "tbFiltrarMenu";
            this.tbFiltrarMenu.Size = new System.Drawing.Size(156, 22);
            this.tbFiltrarMenu.TabIndex = 59;
            this.tbFiltrarMenu.TextChanged += new System.EventHandler(this.tbFiltrarMenu_TextChanged);
            // 
            // lbMenu
            // 
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 16;
            this.lbMenu.Location = new System.Drawing.Point(807, 172);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(304, 180);
            this.lbMenu.TabIndex = 58;
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.BackColor = System.Drawing.SystemColors.Window;
            this.btAdicionarItem.Location = new System.Drawing.Point(807, 386);
            this.btAdicionarItem.Name = "btAdicionarItem";
            this.btAdicionarItem.Size = new System.Drawing.Size(304, 29);
            this.btAdicionarItem.TabIndex = 61;
            this.btAdicionarItem.Text = "Adicionar Item ao Pedido";
            this.btAdicionarItem.UseVisualStyleBackColor = false;
            this.btAdicionarItem.Click += new System.EventHandler(this.btAdicionarItem_Click);
            // 
            // btRemoverItem
            // 
            this.btRemoverItem.BackColor = System.Drawing.SystemColors.Window;
            this.btRemoverItem.Location = new System.Drawing.Point(807, 599);
            this.btRemoverItem.Name = "btRemoverItem";
            this.btRemoverItem.Size = new System.Drawing.Size(304, 29);
            this.btRemoverItem.TabIndex = 63;
            this.btRemoverItem.Text = "Remover Item do Pedido";
            this.btRemoverItem.UseVisualStyleBackColor = false;
            this.btRemoverItem.Click += new System.EventHandler(this.btRemoverItem_Click);
            // 
            // lbitensPedido
            // 
            this.lbitensPedido.FormattingEnabled = true;
            this.lbitensPedido.ItemHeight = 16;
            this.lbitensPedido.Location = new System.Drawing.Point(807, 421);
            this.lbitensPedido.Name = "lbitensPedido";
            this.lbitensPedido.Size = new System.Drawing.Size(304, 164);
            this.lbitensPedido.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(891, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Filtrar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(569, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Filtrar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(500, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Filtrar:";
            // 
            // btEstados
            // 
            this.btEstados.BackColor = System.Drawing.SystemColors.Window;
            this.btEstados.Location = new System.Drawing.Point(1002, 90);
            this.btEstados.Name = "btEstados";
            this.btEstados.Size = new System.Drawing.Size(109, 54);
            this.btEstados.TabIndex = 68;
            this.btEstados.Text = "Estados";
            this.btEstados.UseVisualStyleBackColor = false;
            this.btEstados.Click += new System.EventHandler(this.btEstados_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::Projeto.Properties.Resources.update;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btUpdate.Location = new System.Drawing.Point(379, 595);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(52, 41);
            this.btUpdate.TabIndex = 69;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(434, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Clientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(434, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Trabalhadores";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Window;
            this.btSave.Location = new System.Drawing.Point(12, 598);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(145, 34);
            this.btSave.TabIndex = 72;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1130, 642);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btEstados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbitensPedido);
            this.Controls.Add(this.btRemoverItem);
            this.Controls.Add(this.btAdicionarItem);
            this.Controls.Add(this.tbFiltrarMenu);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.tbFiltrarTrabalhador);
            this.Controls.Add(this.tbFiltrarCliente);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.lbTrabalhadores);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lbPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRestaurante);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox tbFiltrarCliente;
        private System.Windows.Forms.TextBox tbFiltrarTrabalhador;
        private System.Windows.Forms.TextBox tbFiltrarMenu;
        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.Button btAdicionarItem;
        private System.Windows.Forms.Button btRemoverItem;
        private System.Windows.Forms.ListBox lbitensPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEstados;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSave;
    }
}