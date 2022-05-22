namespace Projeto
{
    partial class FormAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddItem));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btAlterarImagem = new System.Windows.Forms.Button();
            this.tbIngredientes = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btAdicionar = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(505, 28);
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
            this.label1.Location = new System.Drawing.Point(205, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Novo Item";
            // 
            // btAlterarImagem
            // 
            this.btAlterarImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAlterarImagem.BackgroundImage")));
            this.btAlterarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAlterarImagem.Location = new System.Drawing.Point(427, 109);
            this.btAlterarImagem.Name = "btAlterarImagem";
            this.btAlterarImagem.Size = new System.Drawing.Size(64, 50);
            this.btAlterarImagem.TabIndex = 36;
            this.btAlterarImagem.UseVisualStyleBackColor = true;
            // 
            // tbIngredientes
            // 
            this.tbIngredientes.Location = new System.Drawing.Point(118, 165);
            this.tbIngredientes.Name = "tbIngredientes";
            this.tbIngredientes.Size = new System.Drawing.Size(373, 22);
            this.tbIngredientes.TabIndex = 35;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(118, 137);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(93, 22);
            this.tbPreco.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(49, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Preço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(2, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ingredientes:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(118, 109);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(206, 22);
            this.tbNome.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(44, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(21, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbCategoria.Location = new System.Drawing.Point(118, 193);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(165, 24);
            this.cbCategoria.TabIndex = 41;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btAdicionar.Location = new System.Drawing.Point(75, 241);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(334, 41);
            this.btAdicionar.TabIndex = 43;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(505, 308);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btAlterarImagem);
            this.Controls.Add(this.tbIngredientes);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(523, 355);
            this.MinimumSize = new System.Drawing.Size(523, 355);
            this.Name = "FormAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Adicionar Item";
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
        private System.Windows.Forms.Button btAlterarImagem;
        private System.Windows.Forms.TextBox tbIngredientes;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btAdicionar;
    }
}