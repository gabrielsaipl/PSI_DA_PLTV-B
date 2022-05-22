namespace Projeto
{
    partial class FormMenuRestaurante
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbRestaurante = new System.Windows.Forms.ComboBox();
            this.btCategorias = new System.Windows.Forms.Button();
            this.btItensCadeia = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.btRemoverItem = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.lvItensCadeia = new System.Windows.Forms.ListView();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 28);
            this.menuStrip1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Menu do Restaurante";
            // 
            // cbRestaurante
            // 
            this.cbRestaurante.FormattingEnabled = true;
            this.cbRestaurante.Location = new System.Drawing.Point(12, 96);
            this.cbRestaurante.Name = "cbRestaurante";
            this.cbRestaurante.Size = new System.Drawing.Size(324, 24);
            this.cbRestaurante.TabIndex = 26;
            // 
            // btCategorias
            // 
            this.btCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.btCategorias.Location = new System.Drawing.Point(790, 96);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(199, 43);
            this.btCategorias.TabIndex = 28;
            this.btCategorias.Text = "Categorias";
            this.btCategorias.UseVisualStyleBackColor = false;
            this.btCategorias.Click += new System.EventHandler(this.btCategorias_Click);
            // 
            // btItensCadeia
            // 
            this.btItensCadeia.BackColor = System.Drawing.SystemColors.Window;
            this.btItensCadeia.Location = new System.Drawing.Point(585, 96);
            this.btItensCadeia.Name = "btItensCadeia";
            this.btItensCadeia.Size = new System.Drawing.Size(199, 43);
            this.btItensCadeia.TabIndex = 27;
            this.btItensCadeia.Text = "Alterar Itens da Cadeia";
            this.btItensCadeia.UseVisualStyleBackColor = false;
            this.btItensCadeia.Click += new System.EventHandler(this.btItensCadeia_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 16;
            this.lbMenu.Location = new System.Drawing.Point(12, 164);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(337, 340);
            this.lbMenu.TabIndex = 29;
            // 
            // btRemoverItem
            // 
            this.btRemoverItem.BackColor = System.Drawing.SystemColors.Window;
            this.btRemoverItem.Location = new System.Drawing.Point(12, 510);
            this.btRemoverItem.Name = "btRemoverItem";
            this.btRemoverItem.Size = new System.Drawing.Size(156, 43);
            this.btRemoverItem.TabIndex = 30;
            this.btRemoverItem.Text = "Remover";
            this.btRemoverItem.UseVisualStyleBackColor = false;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btAdicionar.Location = new System.Drawing.Point(193, 510);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(156, 43);
            this.btAdicionar.TabIndex = 31;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            // 
            // lvItensCadeia
            // 
            this.lvItensCadeia.HideSelection = false;
            this.lvItensCadeia.Location = new System.Drawing.Point(355, 164);
            this.lvItensCadeia.Name = "lvItensCadeia";
            this.lvItensCadeia.Size = new System.Drawing.Size(634, 340);
            this.lvItensCadeia.TabIndex = 32;
            this.lvItensCadeia.UseCompatibleStateImageBehavior = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label.Location = new System.Drawing.Point(12, 136);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 20);
            this.label.TabIndex = 33;
            this.label.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(351, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Itens da cadeia";
            // 
            // btFiltrar
            // 
            this.btFiltrar.BackColor = System.Drawing.SystemColors.Window;
            this.btFiltrar.Location = new System.Drawing.Point(846, 510);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(143, 27);
            this.btFiltrar.TabIndex = 36;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = false;
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Location = new System.Drawing.Point(579, 512);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(261, 22);
            this.tbFiltrar.TabIndex = 35;
            // 
            // FormMenuRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1001, 562);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.tbFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lvItensCadeia);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btRemoverItem);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btCategorias);
            this.Controls.Add(this.btItensCadeia);
            this.Controls.Add(this.cbRestaurante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1019, 609);
            this.MinimumSize = new System.Drawing.Size(1019, 609);
            this.Name = "FormMenuRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Menu do Restaurante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRestaurante;
        private System.Windows.Forms.Button btCategorias;
        private System.Windows.Forms.Button btItensCadeia;
        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.Button btRemoverItem;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.ListView lvItensCadeia;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.TextBox tbFiltrar;
    }
}