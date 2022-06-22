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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRestaurante = new System.Windows.Forms.ComboBox();
            this.btCategorias = new System.Windows.Forms.Button();
            this.btItensCadeia = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.btRemoverItem = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.lvItensCadeia = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ingredientes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 28);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Menu do Restaurante";
            // 
            // cbRestaurante
            // 
            this.cbRestaurante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestaurante.FormattingEnabled = true;
            this.cbRestaurante.Location = new System.Drawing.Point(12, 96);
            this.cbRestaurante.Name = "cbRestaurante";
            this.cbRestaurante.Size = new System.Drawing.Size(388, 24);
            this.cbRestaurante.TabIndex = 26;
            this.cbRestaurante.SelectedIndexChanged += new System.EventHandler(this.cbRestaurante_SelectedIndexChanged);
            // 
            // btCategorias
            // 
            this.btCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.btCategorias.Location = new System.Drawing.Point(680, 510);
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
            this.btItensCadeia.Location = new System.Drawing.Point(475, 510);
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
            this.btRemoverItem.Click += new System.EventHandler(this.btRemoverItem_Click);
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
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // lvItensCadeia
            // 
            this.lvItensCadeia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Preco,
            this.Ingredientes,
            this.Estado,
            this.Categoria});
            this.lvItensCadeia.HideSelection = false;
            this.lvItensCadeia.LargeImageList = this.imageList1;
            this.lvItensCadeia.Location = new System.Drawing.Point(355, 164);
            this.lvItensCadeia.Name = "lvItensCadeia";
            this.lvItensCadeia.Size = new System.Drawing.Size(917, 340);
            this.lvItensCadeia.SmallImageList = this.imageList1;
            this.lvItensCadeia.TabIndex = 32;
            this.lvItensCadeia.UseCompatibleStateImageBehavior = false;
            this.lvItensCadeia.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 100;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 75;
            // 
            // Ingredientes
            // 
            this.Ingredientes.Text = "Ingredientes";
            this.Ingredientes.Width = 300;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 75;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 125;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            // tbFiltrar
            // 
            this.tbFiltrar.Location = new System.Drawing.Point(1011, 510);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(261, 22);
            this.tbFiltrar.TabIndex = 35;
            this.tbFiltrar.TextChanged += new System.EventHandler(this.tbFiltrar_TextChanged);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::Projeto.Properties.Resources.update;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btUpdate.Location = new System.Drawing.Point(1220, 99);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(52, 41);
            this.btUpdate.TabIndex = 47;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(937, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Filtrar:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Detalhes",
            "Icones Grandes",
            "Icones Pequenos",
            "Lista",
            "Tile"});
            this.cbTipo.Location = new System.Drawing.Point(1034, 132);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(150, 24);
            this.cbTipo.TabIndex = 51;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // FormMenuRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1284, 562);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btUpdate);
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
            this.MinimumSize = new System.Drawing.Size(1225, 609);
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
        private System.Windows.Forms.TextBox tbFiltrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader Ingredientes;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}