namespace Projeto
{
    partial class FormEstatisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbClientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMediaCliente = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGanhosTotais = new System.Windows.Forms.Label();
            this.lbTrabalhadores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartTrabalhadores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.lbValorCliente = new System.Windows.Forms.Label();
            this.lbMediaTrabalhadores = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPedidosCadeia = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPratoMaisPedido = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbMetodoPagamento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCidadeMaisGastos = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chartGanhosRestaurante = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrabalhadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanhosRestaurante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "Estatísticas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(617, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nº de Clientes da cadeia:  ";
            // 
            // lbClientes
            // 
            this.lbClientes.AutoSize = true;
            this.lbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbClientes.Location = new System.Drawing.Point(831, 132);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(18, 20);
            this.lbClientes.TabIndex = 28;
            this.lbClientes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(617, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor médio gasto por cliente:";
            // 
            // lbMediaCliente
            // 
            this.lbMediaCliente.AutoSize = true;
            this.lbMediaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMediaCliente.Location = new System.Drawing.Point(882, 162);
            this.lbMediaCliente.Name = "lbMediaCliente";
            this.lbMediaCliente.Size = new System.Drawing.Size(18, 20);
            this.lbMediaCliente.TabIndex = 30;
            this.lbMediaCliente.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 28);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(617, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ganhos totais da Cadeia:";
            // 
            // lbGanhosTotais
            // 
            this.lbGanhosTotais.AutoSize = true;
            this.lbGanhosTotais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGanhosTotais.Location = new System.Drawing.Point(832, 248);
            this.lbGanhosTotais.Name = "lbGanhosTotais";
            this.lbGanhosTotais.Size = new System.Drawing.Size(18, 20);
            this.lbGanhosTotais.TabIndex = 49;
            this.lbGanhosTotais.Text = "0";
            // 
            // lbTrabalhadores
            // 
            this.lbTrabalhadores.AutoSize = true;
            this.lbTrabalhadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTrabalhadores.Location = new System.Drawing.Point(268, 220);
            this.lbTrabalhadores.Name = "lbTrabalhadores";
            this.lbTrabalhadores.Size = new System.Drawing.Size(18, 20);
            this.lbTrabalhadores.TabIndex = 52;
            this.lbTrabalhadores.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(41, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Trabalhadores da Cadeia:";
            // 
            // chartTrabalhadores
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTrabalhadores.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTrabalhadores.Legends.Add(legend3);
            this.chartTrabalhadores.Location = new System.Drawing.Point(45, 282);
            this.chartTrabalhadores.Name = "chartTrabalhadores";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Trabalhadores";
            this.chartTrabalhadores.Series.Add(series3);
            this.chartTrabalhadores.Size = new System.Drawing.Size(547, 389);
            this.chartTrabalhadores.TabIndex = 53;
            this.chartTrabalhadores.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(617, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cliente com mais gastos:  ";
            // 
            // lbValorCliente
            // 
            this.lbValorCliente.AutoSize = true;
            this.lbValorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbValorCliente.Location = new System.Drawing.Point(832, 191);
            this.lbValorCliente.Name = "lbValorCliente";
            this.lbValorCliente.Size = new System.Drawing.Size(18, 20);
            this.lbValorCliente.TabIndex = 56;
            this.lbValorCliente.Text = "0";
            // 
            // lbMediaTrabalhadores
            // 
            this.lbMediaTrabalhadores.AutoSize = true;
            this.lbMediaTrabalhadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMediaTrabalhadores.Location = new System.Drawing.Point(393, 248);
            this.lbMediaTrabalhadores.Name = "lbMediaTrabalhadores";
            this.lbMediaTrabalhadores.Size = new System.Drawing.Size(18, 20);
            this.lbMediaTrabalhadores.TabIndex = 58;
            this.lbMediaTrabalhadores.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(43, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Média de trabalhadores por restaurante:";
            // 
            // lbPedidosCadeia
            // 
            this.lbPedidosCadeia.AutoSize = true;
            this.lbPedidosCadeia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPedidosCadeia.Location = new System.Drawing.Point(347, 191);
            this.lbPedidosCadeia.Name = "lbPedidosCadeia";
            this.lbPedidosCadeia.Size = new System.Drawing.Size(18, 20);
            this.lbPedidosCadeia.TabIndex = 60;
            this.lbPedidosCadeia.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(43, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Quantidade de pedidos da Cadeia:";
            // 
            // lbPratoMaisPedido
            // 
            this.lbPratoMaisPedido.AutoSize = true;
            this.lbPratoMaisPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPratoMaisPedido.Location = new System.Drawing.Point(204, 162);
            this.lbPratoMaisPedido.Name = "lbPratoMaisPedido";
            this.lbPratoMaisPedido.Size = new System.Drawing.Size(18, 20);
            this.lbPratoMaisPedido.TabIndex = 62;
            this.lbPratoMaisPedido.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(44, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Prato mais pedido: ";
            // 
            // lbMetodoPagamento
            // 
            this.lbMetodoPagamento.AutoSize = true;
            this.lbMetodoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMetodoPagamento.Location = new System.Drawing.Point(347, 132);
            this.lbMetodoPagamento.Name = "lbMetodoPagamento";
            this.lbMetodoPagamento.Size = new System.Drawing.Size(18, 20);
            this.lbMetodoPagamento.TabIndex = 64;
            this.lbMetodoPagamento.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(41, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Método de Pagamento mais usado:";
            // 
            // lbCidadeMaisGastos
            // 
            this.lbCidadeMaisGastos.AutoSize = true;
            this.lbCidadeMaisGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCidadeMaisGastos.Location = new System.Drawing.Point(1023, 220);
            this.lbCidadeMaisGastos.Name = "lbCidadeMaisGastos";
            this.lbCidadeMaisGastos.Size = new System.Drawing.Size(18, 20);
            this.lbCidadeMaisGastos.TabIndex = 66;
            this.lbCidadeMaisGastos.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(617, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(362, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = "Cidade com mais pedidos efetuados na cadeia:";
            // 
            // chartGanhosRestaurante
            // 
            chartArea4.Name = "ChartArea1";
            this.chartGanhosRestaurante.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGanhosRestaurante.Legends.Add(legend4);
            this.chartGanhosRestaurante.Location = new System.Drawing.Point(621, 282);
            this.chartGanhosRestaurante.Name = "chartGanhosRestaurante";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Ganhos";
            this.chartGanhosRestaurante.Series.Add(series4);
            this.chartGanhosRestaurante.Size = new System.Drawing.Size(547, 389);
            this.chartGanhosRestaurante.TabIndex = 67;
            this.chartGanhosRestaurante.Text = "chart1";
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1243, 709);
            this.Controls.Add(this.chartGanhosRestaurante);
            this.Controls.Add(this.lbCidadeMaisGastos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbMetodoPagamento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbPratoMaisPedido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbPedidosCadeia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbMediaTrabalhadores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbValorCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartTrabalhadores);
            this.Controls.Add(this.lbTrabalhadores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbGanhosTotais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbMediaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1261, 756);
            this.MinimumSize = new System.Drawing.Size(1261, 756);
            this.Name = "FormEstatisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest Gest - Estatísticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrabalhadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanhosRestaurante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMediaCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGanhosTotais;
        private System.Windows.Forms.Label lbTrabalhadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrabalhadores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbValorCliente;
        private System.Windows.Forms.Label lbMediaTrabalhadores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPedidosCadeia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPratoMaisPedido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMetodoPagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCidadeMaisGastos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanhosRestaurante;
    }
}