﻿namespace Projeto
{
    partial class FormRestaurantes
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
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRestaurante = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCodPostal = new System.Windows.Forms.MaskedTextBox();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btGerir = new System.Windows.Forms.Button();
            this.btCategorias = new System.Windows.Forms.Button();
            this.btMetodosPagamento = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // lbRestaurante
            // 
            this.lbRestaurante.FormattingEnabled = true;
            this.lbRestaurante.ItemHeight = 16;
            this.lbRestaurante.Location = new System.Drawing.Point(422, 112);
            this.lbRestaurante.Name = "lbRestaurante";
            this.lbRestaurante.Size = new System.Drawing.Size(526, 340);
            this.lbRestaurante.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.tbMorada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Pais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cidade);
            this.groupBox1.Location = new System.Drawing.Point(13, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 152);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Morada";
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(140, 108);
            this.tbCodPostal.Mask = "0000-000";
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(78, 22);
            this.tbCodPostal.TabIndex = 11;
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(140, 80);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(258, 22);
            this.tbMorada.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(55, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Morada :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(78, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "País :";
            // 
            // Pais
            // 
            this.Pais.Location = new System.Drawing.Point(140, 24);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(258, 22);
            this.Pais.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código Postal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(59, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cidade :";
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(140, 52);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(258, 22);
            this.Cidade.TabIndex = 6;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Window;
            this.btSave.Location = new System.Drawing.Point(13, 112);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(403, 41);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Guardar Alterações";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Restaurantes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(80, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome :";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(153, 171);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(258, 22);
            this.tbNome.TabIndex = 4;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.Red;
            this.btEliminar.Location = new System.Drawing.Point(8, 357);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(403, 41);
            this.btEliminar.TabIndex = 16;
            this.btEliminar.Text = "Eliminar restaurante selecionado";
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(8, 404);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(403, 41);
            this.btNovo.TabIndex = 17;
            this.btNovo.Text = "Novo Restaurante";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btGerir
            // 
            this.btGerir.BackColor = System.Drawing.SystemColors.Window;
            this.btGerir.Location = new System.Drawing.Point(954, 112);
            this.btGerir.Name = "btGerir";
            this.btGerir.Size = new System.Drawing.Size(100, 68);
            this.btGerir.TabIndex = 18;
            this.btGerir.Text = "Gerir Restaurante";
            this.btGerir.UseVisualStyleBackColor = false;
            // 
            // btCategorias
            // 
            this.btCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.btCategorias.Location = new System.Drawing.Point(954, 310);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(100, 68);
            this.btCategorias.TabIndex = 19;
            this.btCategorias.Text = "Categorias";
            this.btCategorias.UseVisualStyleBackColor = false;
            // 
            // btMetodosPagamento
            // 
            this.btMetodosPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.btMetodosPagamento.Location = new System.Drawing.Point(954, 384);
            this.btMetodosPagamento.Name = "btMetodosPagamento";
            this.btMetodosPagamento.Size = new System.Drawing.Size(100, 68);
            this.btMetodosPagamento.TabIndex = 20;
            this.btMetodosPagamento.Text = "Métodos de Pagamento";
            this.btMetodosPagamento.UseVisualStyleBackColor = false;
            // 
            // FormRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1082, 483);
            this.Controls.Add(this.btMetodosPagamento);
            this.Controls.Add(this.btCategorias);
            this.Controls.Add(this.btGerir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRestaurante);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1100, 530);
            this.MinimumSize = new System.Drawing.Size(1100, 530);
            this.Name = "FormRestaurantes";
            this.Text = "Rest Gest - Restaurantes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ListBox lbRestaurante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btGerir;
        private System.Windows.Forms.Button btCategorias;
        private System.Windows.Forms.Button btMetodosPagamento;
    }
}