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
            this.gravarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbRestaurante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPedidos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btPagamento = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
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
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.cbTrabalhadores = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.gravarPedidoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1425, 28);
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
            // gravarPedidoToolStripMenuItem
            // 
            this.gravarPedidoToolStripMenuItem.Name = "gravarPedidoToolStripMenuItem";
            this.gravarPedidoToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.gravarPedidoToolStripMenuItem.Text = "Exportar Pedido(TXT)";
            this.gravarPedidoToolStripMenuItem.Click += new System.EventHandler(this.gravarPedidoToolStripMenuItem_Click);
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
            this.label1.Location = new System.Drawing.Point(717, 56);
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
            this.lbPedidos.Size = new System.Drawing.Size(399, 452);
            this.lbPedidos.TabIndex = 47;
            this.lbPedidos.SelectedIndexChanged += new System.EventHandler(this.lbPedidos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(442, 444);
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
            this.cbEstado.Location = new System.Drawing.Point(514, 444);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(138, 24);
            this.cbEstado.TabIndex = 48;
            // 
            // btPagamento
            // 
            this.btPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.btPagamento.Location = new System.Drawing.Point(589, 491);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(123, 84);
            this.btPagamento.TabIndex = 50;
            this.btPagamento.Text = "Pagamento";
            this.btPagamento.UseVisualStyleBackColor = false;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(446, 172);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(302, 47);
            this.btNovo.TabIndex = 51;
            this.btNovo.Text = "Adicionar Pedido";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // tbFiltrarCliente
            // 
            this.tbFiltrarCliente.Location = new System.Drawing.Point(512, 398);
            this.tbFiltrarCliente.Name = "tbFiltrarCliente";
            this.tbFiltrarCliente.Size = new System.Drawing.Size(156, 22);
            this.tbFiltrarCliente.TabIndex = 54;
            this.tbFiltrarCliente.TextChanged += new System.EventHandler(this.tbFiltrarCliente_TextChanged);
            // 
            // tbFiltrarTrabalhador
            // 
            this.tbFiltrarTrabalhador.Location = new System.Drawing.Point(512, 287);
            this.tbFiltrarTrabalhador.Name = "tbFiltrarTrabalhador";
            this.tbFiltrarTrabalhador.Size = new System.Drawing.Size(156, 22);
            this.tbFiltrarTrabalhador.TabIndex = 56;
            this.tbFiltrarTrabalhador.TextChanged += new System.EventHandler(this.tbFiltrarTrabalhador_TextChanged);
            // 
            // tbFiltrarMenu
            // 
            this.tbFiltrarMenu.Location = new System.Drawing.Point(1245, 526);
            this.tbFiltrarMenu.Name = "tbFiltrarMenu";
            this.tbFiltrarMenu.Size = new System.Drawing.Size(156, 22);
            this.tbFiltrarMenu.TabIndex = 59;
            this.tbFiltrarMenu.TextChanged += new System.EventHandler(this.tbFiltrarMenu_TextChanged);
            // 
            // lbMenu
            // 
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 16;
            this.lbMenu.Location = new System.Drawing.Point(772, 172);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(304, 420);
            this.lbMenu.TabIndex = 58;
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.BackColor = System.Drawing.SystemColors.Window;
            this.btAdicionarItem.Location = new System.Drawing.Point(1097, 554);
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
            this.btRemoverItem.Location = new System.Drawing.Point(1097, 589);
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
            this.lbitensPedido.Location = new System.Drawing.Point(1097, 172);
            this.lbitensPedido.Name = "lbitensPedido";
            this.lbitensPedido.Size = new System.Drawing.Size(304, 340);
            this.lbitensPedido.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(1181, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Filtrar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(448, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Filtrar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(448, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Filtrar:";
            // 
            // btEstados
            // 
            this.btEstados.BackColor = System.Drawing.SystemColors.Window;
            this.btEstados.Location = new System.Drawing.Point(1249, 112);
            this.btEstados.Name = "btEstados";
            this.btEstados.Size = new System.Drawing.Size(152, 54);
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
            this.btUpdate.Location = new System.Drawing.Point(672, 435);
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
            this.label6.Location = new System.Drawing.Point(448, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Clientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(442, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Trabalhadores";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Window;
            this.btSave.Location = new System.Drawing.Point(453, 491);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(130, 84);
            this.btSave.TabIndex = 72;
            this.btSave.Text = "Atualizar pedido";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbClientes
            // 
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(446, 359);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(302, 24);
            this.cbClientes.TabIndex = 73;
            // 
            // cbTrabalhadores
            // 
            this.cbTrabalhadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrabalhadores.FormattingEnabled = true;
            this.cbTrabalhadores.Location = new System.Drawing.Point(446, 257);
            this.cbTrabalhadores.Name = "cbTrabalhadores";
            this.cbTrabalhadores.Size = new System.Drawing.Size(302, 24);
            this.cbTrabalhadores.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(768, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Menu";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1425, 642);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTrabalhadores);
            this.Controls.Add(this.cbClientes);
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
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lbPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRestaurante);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(1443, 689);
            this.MinimumSize = new System.Drawing.Size(1443, 689);
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
        private System.Windows.Forms.ToolStripMenuItem gravarPedidoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbRestaurante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btPagamento;
        private System.Windows.Forms.Button btNovo;
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
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ComboBox cbTrabalhadores;
        private System.Windows.Forms.Label label8;
    }
}