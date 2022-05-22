namespace Projeto
{
    partial class FormPagamentos
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
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMetodos = new System.Windows.Forms.ComboBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.lbPagamentos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(109, 148);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(93, 22);
            this.tbValor.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(45, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(34, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Método:";
            // 
            // cbMetodos
            // 
            this.cbMetodos.FormattingEnabled = true;
            this.cbMetodos.Location = new System.Drawing.Point(109, 118);
            this.cbMetodos.Name = "cbMetodos";
            this.cbMetodos.Size = new System.Drawing.Size(209, 24);
            this.cbMetodos.TabIndex = 32;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(38, 195);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(280, 41);
            this.btNovo.TabIndex = 43;
            this.btNovo.Text = "Adicionar";
            this.btNovo.UseVisualStyleBackColor = false;
            // 
            // lbPagamentos
            // 
            this.lbPagamentos.FormattingEnabled = true;
            this.lbPagamentos.ItemHeight = 16;
            this.lbPagamentos.Location = new System.Drawing.Point(336, 88);
            this.lbPagamentos.Name = "lbPagamentos";
            this.lbPagamentos.Size = new System.Drawing.Size(365, 180);
            this.lbPagamentos.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 45;
            this.label1.Text = "Pagamento";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 28);
            this.menuStrip1.TabIndex = 46;
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
            // FormPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(721, 307);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPagamentos);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.cbMetodos);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.MaximumSize = new System.Drawing.Size(739, 354);
            this.MinimumSize = new System.Drawing.Size(739, 354);
            this.Name = "FormPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Pagamento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMetodos;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.ListBox lbPagamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}