namespace Projeto
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bClientes = new System.Windows.Forms.Button();
            this.bRestaurantes = new System.Windows.Forms.Button();
            this.bCategoriasItem = new System.Windows.Forms.Button();
            this.bMetodosPagamento = new System.Windows.Forms.Button();
            this.bPedidos = new System.Windows.Forms.Button();
            this.bMenus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bClientes
            // 
            this.bClientes.BackColor = System.Drawing.SystemColors.Window;
            this.bClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClientes.Location = new System.Drawing.Point(78, 75);
            this.bClientes.MaximumSize = new System.Drawing.Size(180, 96);
            this.bClientes.MinimumSize = new System.Drawing.Size(180, 96);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(180, 96);
            this.bClientes.TabIndex = 0;
            this.bClientes.Text = "Clientes";
            this.bClientes.UseVisualStyleBackColor = false;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bRestaurantes
            // 
            this.bRestaurantes.BackColor = System.Drawing.SystemColors.Window;
            this.bRestaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRestaurantes.Location = new System.Drawing.Point(321, 75);
            this.bRestaurantes.Name = "bRestaurantes";
            this.bRestaurantes.Size = new System.Drawing.Size(180, 96);
            this.bRestaurantes.TabIndex = 1;
            this.bRestaurantes.Text = "Restaurantes";
            this.bRestaurantes.UseVisualStyleBackColor = false;
            this.bRestaurantes.Click += new System.EventHandler(this.bRestaurantes_Click);
            // 
            // bCategoriasItem
            // 
            this.bCategoriasItem.BackColor = System.Drawing.SystemColors.Window;
            this.bCategoriasItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCategoriasItem.Location = new System.Drawing.Point(321, 187);
            this.bCategoriasItem.Name = "bCategoriasItem";
            this.bCategoriasItem.Size = new System.Drawing.Size(180, 96);
            this.bCategoriasItem.TabIndex = 3;
            this.bCategoriasItem.Text = "Categorias de itens";
            this.bCategoriasItem.UseVisualStyleBackColor = false;
            this.bCategoriasItem.Click += new System.EventHandler(this.bCategoriasItem_Click);
            // 
            // bMetodosPagamento
            // 
            this.bMetodosPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.bMetodosPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMetodosPagamento.Location = new System.Drawing.Point(78, 187);
            this.bMetodosPagamento.Name = "bMetodosPagamento";
            this.bMetodosPagamento.Size = new System.Drawing.Size(180, 96);
            this.bMetodosPagamento.TabIndex = 2;
            this.bMetodosPagamento.Text = "Métodos de pagamento";
            this.bMetodosPagamento.UseVisualStyleBackColor = false;
            this.bMetodosPagamento.Click += new System.EventHandler(this.bMetodosPagamento_Click);
            // 
            // bPedidos
            // 
            this.bPedidos.BackColor = System.Drawing.SystemColors.Window;
            this.bPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPedidos.Location = new System.Drawing.Point(321, 303);
            this.bPedidos.Name = "bPedidos";
            this.bPedidos.Size = new System.Drawing.Size(180, 96);
            this.bPedidos.TabIndex = 5;
            this.bPedidos.Text = "Pedidos";
            this.bPedidos.UseVisualStyleBackColor = false;
            this.bPedidos.Click += new System.EventHandler(this.bPedidos_Click);
            // 
            // bMenus
            // 
            this.bMenus.BackColor = System.Drawing.SystemColors.Window;
            this.bMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMenus.Location = new System.Drawing.Point(78, 303);
            this.bMenus.Name = "bMenus";
            this.bMenus.Size = new System.Drawing.Size(180, 96);
            this.bMenus.TabIndex = 4;
            this.bMenus.Text = "Menus";
            this.bMenus.UseVisualStyleBackColor = false;
            this.bMenus.Click += new System.EventHandler(this.bMenus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(241)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.bPedidos);
            this.Controls.Add(this.bMenus);
            this.Controls.Add(this.bCategoriasItem);
            this.Controls.Add(this.bMetodosPagamento);
            this.Controls.Add(this.bRestaurantes);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(608, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(608, 497);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "REST GEST";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bRestaurantes;
        private System.Windows.Forms.Button bCategoriasItem;
        private System.Windows.Forms.Button bMetodosPagamento;
        private System.Windows.Forms.Button bPedidos;
        private System.Windows.Forms.Button bMenus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

