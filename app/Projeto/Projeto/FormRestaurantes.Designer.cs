namespace Projeto
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCodPostal = new System.Windows.Forms.MaskedTextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btGerir = new System.Windows.Forms.Button();
            this.btCategorias = new System.Windows.Forms.Button();
            this.btMetodosPagamento = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dgvRestaurantes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRestaurantes = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRestaurantes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1111, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.tbRua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCidade);
            this.groupBox1.Location = new System.Drawing.Point(13, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(404, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Morada";
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(140, 108);
            this.tbCodPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodPostal.Mask = "0000-000";
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(79, 22);
            this.tbCodPostal.TabIndex = 11;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(140, 80);
            this.tbRua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(257, 22);
            this.tbRua.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(77, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rua :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(77, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "País :";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(140, 25);
            this.tbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(257, 22);
            this.tbPais.TabIndex = 4;
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
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(140, 52);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(257, 22);
            this.tbCidade.TabIndex = 6;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Window;
            this.btSave.Location = new System.Drawing.Point(13, 112);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(403, 41);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Guardar Alterações";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            this.label7.Location = new System.Drawing.Point(80, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome :";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(153, 159);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(257, 22);
            this.tbNome.TabIndex = 4;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(8, 404);
            this.btNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btGerir.Location = new System.Drawing.Point(999, 111);
            this.btGerir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGerir.Name = "btGerir";
            this.btGerir.Size = new System.Drawing.Size(100, 68);
            this.btGerir.TabIndex = 18;
            this.btGerir.Text = "Gerir Restaurante";
            this.btGerir.UseVisualStyleBackColor = false;
            this.btGerir.Click += new System.EventHandler(this.btGerir_Click);
            // 
            // btCategorias
            // 
            this.btCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.btCategorias.Location = new System.Drawing.Point(999, 255);
            this.btCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(100, 68);
            this.btCategorias.TabIndex = 19;
            this.btCategorias.Text = "Categorias";
            this.btCategorias.UseVisualStyleBackColor = false;
            this.btCategorias.Click += new System.EventHandler(this.btCategorias_Click);
            // 
            // btMetodosPagamento
            // 
            this.btMetodosPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.btMetodosPagamento.Location = new System.Drawing.Point(999, 183);
            this.btMetodosPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMetodosPagamento.Name = "btMetodosPagamento";
            this.btMetodosPagamento.Size = new System.Drawing.Size(100, 68);
            this.btMetodosPagamento.TabIndex = 20;
            this.btMetodosPagamento.Text = "Métodos de Pagamento";
            this.btMetodosPagamento.UseVisualStyleBackColor = false;
            this.btMetodosPagamento.Click += new System.EventHandler(this.btMetodosPagamento_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::Projeto.Properties.Resources.update;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btUpdate.Location = new System.Drawing.Point(933, 66);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(52, 41);
            this.btUpdate.TabIndex = 21;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dgvRestaurantes
            // 
            this.dgvRestaurantes.AllowUserToAddRows = false;
            this.dgvRestaurantes.AllowUserToDeleteRows = false;
            this.dgvRestaurantes.AutoGenerateColumns = false;
            this.dgvRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvRestaurantes.DataSource = this.bsRestaurantes;
            this.dgvRestaurantes.Location = new System.Drawing.Point(423, 112);
            this.dgvRestaurantes.Name = "dgvRestaurantes";
            this.dgvRestaurantes.ReadOnly = true;
            this.dgvRestaurantes.RowHeadersWidth = 51;
            this.dgvRestaurantes.RowTemplate.Height = 24;
            this.dgvRestaurantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRestaurantes.Size = new System.Drawing.Size(570, 333);
            this.dgvRestaurantes.TabIndex = 51;
            this.dgvRestaurantes.SelectionChanged += new System.EventHandler(this.dgvTrabalhadores_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Morada";
            this.Column2.HeaderText = "Morada";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 247;
            // 
            // FormRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1111, 481);
            this.Controls.Add(this.dgvRestaurantes);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btMetodosPagamento);
            this.Controls.Add(this.btCategorias);
            this.Controls.Add(this.btGerir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1129, 528);
            this.MinimumSize = new System.Drawing.Size(1129, 528);
            this.Name = "FormRestaurantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Restaurantes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRestaurantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btGerir;
        private System.Windows.Forms.Button btCategorias;
        private System.Windows.Forms.Button btMetodosPagamento;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DataGridView dgvRestaurantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.BindingSource bsRestaurantes;
    }
}