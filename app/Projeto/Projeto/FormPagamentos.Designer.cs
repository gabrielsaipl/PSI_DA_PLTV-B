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
            this.btMetodos = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValorAPagar = new System.Windows.Forms.Label();
            this.labelValorPago = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTroco = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(109, 166);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(93, 22);
            this.tbValor.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(45, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(34, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Método:";
            // 
            // cbMetodos
            // 
            this.cbMetodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodos.FormattingEnabled = true;
            this.cbMetodos.Location = new System.Drawing.Point(109, 136);
            this.cbMetodos.Name = "cbMetodos";
            this.cbMetodos.Size = new System.Drawing.Size(209, 24);
            this.cbMetodos.TabIndex = 32;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(38, 206);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(280, 41);
            this.btNovo.TabIndex = 43;
            this.btNovo.Text = "Adicionar";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // lbPagamentos
            // 
            this.lbPagamentos.FormattingEnabled = true;
            this.lbPagamentos.ItemHeight = 16;
            this.lbPagamentos.Location = new System.Drawing.Point(336, 88);
            this.lbPagamentos.Name = "lbPagamentos";
            this.lbPagamentos.Size = new System.Drawing.Size(365, 196);
            this.lbPagamentos.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 45;
            this.label1.Text = "Pagamentos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
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
            // btMetodos
            // 
            this.btMetodos.BackColor = System.Drawing.SystemColors.Window;
            this.btMetodos.Location = new System.Drawing.Point(38, 253);
            this.btMetodos.Name = "btMetodos";
            this.btMetodos.Size = new System.Drawing.Size(280, 31);
            this.btMetodos.TabIndex = 47;
            this.btMetodos.Text = "Métodos";
            this.btMetodos.UseVisualStyleBackColor = false;
            this.btMetodos.Click += new System.EventHandler(this.btMetodos_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::Projeto.Properties.Resources.update;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btUpdate.Location = new System.Drawing.Point(293, 103);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(37, 27);
            this.btUpdate.TabIndex = 49;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Valor a pagar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Valor pago:";
            // 
            // labelValorAPagar
            // 
            this.labelValorAPagar.AutoSize = true;
            this.labelValorAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelValorAPagar.Location = new System.Drawing.Point(154, 47);
            this.labelValorAPagar.Name = "labelValorAPagar";
            this.labelValorAPagar.Size = new System.Drawing.Size(0, 20);
            this.labelValorAPagar.TabIndex = 52;
            // 
            // labelValorPago
            // 
            this.labelValorPago.AutoSize = true;
            this.labelValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelValorPago.Location = new System.Drawing.Point(134, 78);
            this.labelValorPago.Name = "labelValorPago";
            this.labelValorPago.Size = new System.Drawing.Size(0, 20);
            this.labelValorPago.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(34, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Troco a devolver:";
            // 
            // labelTroco
            // 
            this.labelTroco.AutoSize = true;
            this.labelTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTroco.Location = new System.Drawing.Point(185, 103);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(0, 20);
            this.labelTroco.TabIndex = 55;
            // 
            // FormPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(721, 307);
            this.Controls.Add(this.labelTroco);
            this.Controls.Add(this.labelValorPago);
            this.Controls.Add(this.labelValorAPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btMetodos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPagamentos);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.cbMetodos);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Button btMetodos;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValorAPagar;
        private System.Windows.Forms.Label labelValorPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTroco;
    }
}