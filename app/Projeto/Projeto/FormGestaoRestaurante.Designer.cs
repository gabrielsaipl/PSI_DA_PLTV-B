namespace Projeto
{
    partial class FormGestaoRestaurante
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
            this.cbRestaurante = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAtivo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPosicao = new System.Windows.Forms.TextBox();
            this.tbTelemovel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.btNovo = new System.Windows.Forms.Button();
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.btPedidos = new System.Windows.Forms.Button();
            this.btMenus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bsTrabalhadores = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTrabalhadores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSalario = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1471, 28);
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
            // cbRestaurante
            // 
            this.cbRestaurante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestaurante.FormattingEnabled = true;
            this.cbRestaurante.Location = new System.Drawing.Point(12, 58);
            this.cbRestaurante.Name = "cbRestaurante";
            this.cbRestaurante.Size = new System.Drawing.Size(381, 24);
            this.cbRestaurante.TabIndex = 2;
            this.cbRestaurante.SelectedIndexChanged += new System.EventHandler(this.cbRestaurante_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSalario);
            this.groupBox2.Controls.Add(this.cbAtivo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbPosicao);
            this.groupBox2.Controls.Add(this.tbTelemovel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbNome);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 147);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trabalhador";
            // 
            // cbAtivo
            // 
            this.cbAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtivo.FormattingEnabled = true;
            this.cbAtivo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbAtivo.Location = new System.Drawing.Point(105, 119);
            this.cbAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(113, 24);
            this.cbAtivo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(-4, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Em serviço:";
            // 
            // tbPosicao
            // 
            this.tbPosicao.Location = new System.Drawing.Point(105, 90);
            this.tbPosicao.Name = "tbPosicao";
            this.tbPosicao.Size = new System.Drawing.Size(261, 22);
            this.tbPosicao.TabIndex = 14;
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.Location = new System.Drawing.Point(105, 60);
            this.tbTelemovel.Mask = "000000000";
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(90, 22);
            this.tbTelemovel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(20, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Posição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(31, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome :";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(105, 32);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(261, 22);
            this.tbNome.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(201, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(0, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Telemóvel :";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 141);
            this.groupBox1.TabIndex = 13;
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
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(95, 80);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(258, 22);
            this.tbRua.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(36, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rua :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(33, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "País :";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(95, 24);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(258, 22);
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
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cidade :";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(95, 52);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(258, 22);
            this.tbCidade.TabIndex = 6;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Window;
            this.btSave.Location = new System.Drawing.Point(12, 97);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(372, 41);
            this.btSave.TabIndex = 15;
            this.btSave.Text = "Guardar Alterações";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.Window;
            this.btNovo.Location = new System.Drawing.Point(12, 500);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(372, 52);
            this.btNovo.TabIndex = 16;
            this.btNovo.Text = "Criar novo trabalhador";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Location = new System.Drawing.Point(1112, 463);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(346, 22);
            this.tbFiltrar.TabIndex = 15;
            this.tbFiltrar.TextChanged += new System.EventHandler(this.tbFiltrar_TextChanged);
            // 
            // btPedidos
            // 
            this.btPedidos.BackColor = System.Drawing.SystemColors.Window;
            this.btPedidos.Location = new System.Drawing.Point(390, 500);
            this.btPedidos.Name = "btPedidos";
            this.btPedidos.Size = new System.Drawing.Size(298, 58);
            this.btPedidos.TabIndex = 19;
            this.btPedidos.Text = "Pedidos";
            this.btPedidos.UseVisualStyleBackColor = false;
            this.btPedidos.Click += new System.EventHandler(this.btPedidos_Click);
            // 
            // btMenus
            // 
            this.btMenus.BackColor = System.Drawing.SystemColors.Window;
            this.btMenus.Location = new System.Drawing.Point(694, 500);
            this.btMenus.Name = "btMenus";
            this.btMenus.Size = new System.Drawing.Size(298, 58);
            this.btMenus.TabIndex = 20;
            this.btMenus.Text = "Menus";
            this.btMenus.UseVisualStyleBackColor = false;
            this.btMenus.Click += new System.EventHandler(this.btMenus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "Gerir Restaurante";
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::Projeto.Properties.Resources.update;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btUpdate.Location = new System.Drawing.Point(1406, 49);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(52, 41);
            this.btUpdate.TabIndex = 48;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(1053, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Filtrar";
            // 
            // dgvTrabalhadores
            // 
            this.dgvTrabalhadores.AllowUserToAddRows = false;
            this.dgvTrabalhadores.AllowUserToDeleteRows = false;
            this.dgvTrabalhadores.AutoGenerateColumns = false;
            this.dgvTrabalhadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabalhadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTrabalhadores.DataSource = this.bsTrabalhadores;
            this.dgvTrabalhadores.Location = new System.Drawing.Point(390, 97);
            this.dgvTrabalhadores.Name = "dgvTrabalhadores";
            this.dgvTrabalhadores.ReadOnly = true;
            this.dgvTrabalhadores.RowHeadersWidth = 51;
            this.dgvTrabalhadores.RowTemplate.Height = 24;
            this.dgvTrabalhadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrabalhadores.Size = new System.Drawing.Size(1068, 360);
            this.dgvTrabalhadores.TabIndex = 50;
            this.dgvTrabalhadores.SelectionChanged += new System.EventHandler(this.dgvTrabalhadores_SelectionChanged);
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
            this.Column2.DataPropertyName = "Telemovel";
            this.Column2.HeaderText = "Telemovel";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Salario";
            this.Column3.HeaderText = "Salário";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Posicao";
            this.Column4.HeaderText = "Posição";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Morada";
            this.Column5.HeaderText = "Morada";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 247;
            // 
            // tbSalario
            // 
            this.tbSalario.DecimalPlaces = 2;
            this.tbSalario.Location = new System.Drawing.Point(273, 60);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(93, 22);
            this.tbSalario.TabIndex = 50;
            // 
            // FormGestaoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1471, 570);
            this.Controls.Add(this.dgvTrabalhadores);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMenus);
            this.Controls.Add(this.btPedidos);
            this.Controls.Add(this.tbFiltrar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbRestaurante);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1489, 617);
            this.MinimumSize = new System.Drawing.Size(1489, 617);
            this.Name = "FormGestaoRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Gestão Restaurante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrabalhadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbRestaurante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.MaskedTextBox tbTelemovel;
        private System.Windows.Forms.TextBox tbPosicao;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox tbFiltrar;
        private System.Windows.Forms.Button btPedidos;
        private System.Windows.Forms.Button btMenus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAtivo;
        private System.Windows.Forms.BindingSource bsTrabalhadores;
        private System.Windows.Forms.DataGridView dgvTrabalhadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown tbSalario;
    }
}