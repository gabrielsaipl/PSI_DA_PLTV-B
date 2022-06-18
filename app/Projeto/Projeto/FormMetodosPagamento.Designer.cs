namespace Projeto
{
    partial class FormMetodosPagamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMetodosPagamento = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNovo = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btGravar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Métodos de Pagamento";
            // 
            // lbMetodosPagamento
            // 
            this.lbMetodosPagamento.FormattingEnabled = true;
            this.lbMetodosPagamento.ItemHeight = 16;
            this.lbMetodosPagamento.Location = new System.Drawing.Point(35, 95);
            this.lbMetodosPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMetodosPagamento.Name = "lbMetodosPagamento";
            this.lbMetodosPagamento.Size = new System.Drawing.Size(340, 180);
            this.lbMetodosPagamento.TabIndex = 14;
            this.lbMetodosPagamento.SelectedIndexChanged += new System.EventHandler(this.lbMetodosPagamento_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(28, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Novo método: ";
            // 
            // tbNovo
            // 
            this.tbNovo.Location = new System.Drawing.Point(159, 354);
            this.tbNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNovo.Name = "tbNovo";
            this.tbNovo.Size = new System.Drawing.Size(221, 22);
            this.tbNovo.TabIndex = 16;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(40, 382);
            this.btNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(340, 41);
            this.btNovo.TabIndex = 18;
            this.btNovo.Text = "Adicionar";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbEstado.Location = new System.Drawing.Point(108, 294);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(113, 24);
            this.cbEstado.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estado:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(443, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.SystemColors.Window;
            this.btGravar.Location = new System.Drawing.Point(228, 294);
            this.btGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(152, 25);
            this.btGravar.TabIndex = 22;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(28, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Método:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(108, 321);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(272, 22);
            this.tbNome.TabIndex = 24;
            // 
            // FormMetodosPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(443, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.tbNovo);
            this.Controls.Add(this.lbMetodosPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(461, 484);
            this.MinimumSize = new System.Drawing.Size(461, 484);
            this.Name = "FormMetodosPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Métodos de Pagamento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMetodosPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNovo;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
    }
}