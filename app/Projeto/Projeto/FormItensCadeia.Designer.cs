namespace Projeto
{
    partial class FormItensCadeia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItensCadeia));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIngredientes = new System.Windows.Forms.TextBox();
            this.btAlterarImagem = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btNovo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "Itens da Cadeia";
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(417, 101);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(93, 22);
            this.tbPreco.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(353, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Preço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(21, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingredientes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(63, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome :";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(137, 101);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(206, 22);
            this.tbNome.TabIndex = 4;
            // 
            // tbIngredientes
            // 
            this.tbIngredientes.Location = new System.Drawing.Point(137, 127);
            this.tbIngredientes.Name = "tbIngredientes";
            this.tbIngredientes.Size = new System.Drawing.Size(373, 22);
            this.tbIngredientes.TabIndex = 28;
            // 
            // btAlterarImagem
            // 
            this.btAlterarImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAlterarImagem.BackgroundImage")));
            this.btAlterarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAlterarImagem.Location = new System.Drawing.Point(529, 99);
            this.btAlterarImagem.Name = "btAlterarImagem";
            this.btAlterarImagem.Size = new System.Drawing.Size(64, 50);
            this.btAlterarImagem.TabIndex = 29;
            this.btAlterarImagem.UseVisualStyleBackColor = true;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.Window;
            this.btGravar.Location = new System.Drawing.Point(633, 89);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(93, 70);
            this.btGravar.TabIndex = 32;
            this.btGravar.Text = "Gravar Alterações";
            this.btGravar.UseVisualStyleBackColor = false;
            // 
            // btFiltrar
            // 
            this.btFiltrar.BackColor = System.Drawing.SystemColors.Window;
            this.btFiltrar.Location = new System.Drawing.Point(290, 495);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(143, 27);
            this.btFiltrar.TabIndex = 38;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = false;
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Location = new System.Drawing.Point(23, 497);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(261, 22);
            this.tbFiltrar.TabIndex = 37;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbEstado.Location = new System.Drawing.Point(137, 155);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(113, 24);
            this.cbEstado.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(60, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Estado:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 185);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(701, 304);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(457, 497);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(269, 41);
            this.btNovo.TabIndex = 42;
            this.btNovo.Text = "Novo Item";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 28);
            this.menuStrip1.TabIndex = 43;
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
            // FormItensCadeia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(766, 541);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.tbFiltrar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btAlterarImagem);
            this.Controls.Add(this.tbIngredientes);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label7);
            this.MaximumSize = new System.Drawing.Size(784, 588);
            this.MinimumSize = new System.Drawing.Size(784, 588);
            this.Name = "FormItensCadeia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Itens da cadeia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbIngredientes;
        private System.Windows.Forms.Button btAlterarImagem;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.TextBox tbFiltrar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}