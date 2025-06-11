namespace Prime_Gadgets.modulos.moduloFinanceiro 
{ 
    partial class Resumo
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
            lbResumoTitulo = new Label();
            lbResumoGraficoColuna = new Label();
            pnResumoGastosMes = new Panel();
            tbResumoGastosMes = new DataGridView();
            lbResumoGastoTotal = new Label();
            lbResumoGastosMes = new Label();
            btResumoVoltar = new Button();
            btResumoAvancarMes = new Button();
            btResumoAnteriorMes = new Button();
            lbResumoMesAno = new Label();
            ctResumoMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnResumoGastosMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbResumoGastosMes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctResumoMes).BeginInit();
            SuspendLayout();
            // 
            // lbResumoTitulo
            // 
            lbResumoTitulo.AutoSize = true;
            lbResumoTitulo.Location = new Point(487, 29);
            lbResumoTitulo.Name = "lbResumoTitulo";
            lbResumoTitulo.Size = new Size(91, 15);
            lbResumoTitulo.TabIndex = 1;
            lbResumoTitulo.Text = "Resumo mensal";
            // 
            // lbResumoGraficoColuna
            // 
            lbResumoGraficoColuna.AutoSize = true;
            lbResumoGraficoColuna.Location = new Point(767, 106);
            lbResumoGraficoColuna.Name = "lbResumoGraficoColuna";
            lbResumoGraficoColuna.Size = new Size(100, 15);
            lbResumoGraficoColuna.TabIndex = 2;
            lbResumoGraficoColuna.Text = "Gráfico de coluna";
            // 
            // pnResumoGastosMes
            // 
            pnResumoGastosMes.BackColor = Color.White;
            pnResumoGastosMes.Controls.Add(tbResumoGastosMes);
            pnResumoGastosMes.Controls.Add(lbResumoGastoTotal);
            pnResumoGastosMes.Location = new Point(12, 124);
            pnResumoGastosMes.Name = "pnResumoGastosMes";
            pnResumoGastosMes.Size = new Size(519, 343);
            pnResumoGastosMes.TabIndex = 3;
            // 
            // tbResumoGastosMes
            // 
            tbResumoGastosMes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbResumoGastosMes.Location = new Point(3, 3);
            tbResumoGastosMes.Name = "tbResumoGastosMes";
            tbResumoGastosMes.Size = new Size(513, 312);
            tbResumoGastosMes.TabIndex = 2;
            // 
            // lbResumoGastoTotal
            // 
            lbResumoGastoTotal.AutoSize = true;
            lbResumoGastoTotal.Location = new Point(3, 321);
            lbResumoGastoTotal.Name = "lbResumoGastoTotal";
            lbResumoGastoTotal.Size = new Size(110, 15);
            lbResumoGastoTotal.TabIndex = 1;
            lbResumoGastoTotal.Text = "Total gasto no mês:";
            // 
            // lbResumoGastosMes
            // 
            lbResumoGastosMes.AutoSize = true;
            lbResumoGastosMes.Location = new Point(224, 106);
            lbResumoGastosMes.Name = "lbResumoGastosMes";
            lbResumoGastosMes.Size = new Size(84, 15);
            lbResumoGastosMes.TabIndex = 4;
            lbResumoGastosMes.Text = "Gastos no mês";
            // 
            // btResumoVoltar
            // 
            btResumoVoltar.Location = new Point(487, 510);
            btResumoVoltar.Name = "btResumoVoltar";
            btResumoVoltar.Size = new Size(75, 23);
            btResumoVoltar.TabIndex = 5;
            btResumoVoltar.Text = "Voltar";
            btResumoVoltar.UseVisualStyleBackColor = true;
            btResumoVoltar.Click += btResumoVoltar_Click;
            // 
            // btResumoAvancarMes
            // 
            btResumoAvancarMes.Location = new Point(651, 60);
            btResumoAvancarMes.Name = "btResumoAvancarMes";
            btResumoAvancarMes.Size = new Size(75, 23);
            btResumoAvancarMes.TabIndex = 6;
            btResumoAvancarMes.Text = "Avançar";
            btResumoAvancarMes.UseVisualStyleBackColor = true;
            btResumoAvancarMes.Click += btResumoAvancarMes_Click;
            // 
            // btResumoAnteriorMes
            // 
            btResumoAnteriorMes.Location = new Point(351, 60);
            btResumoAnteriorMes.Name = "btResumoAnteriorMes";
            btResumoAnteriorMes.Size = new Size(75, 23);
            btResumoAnteriorMes.TabIndex = 7;
            btResumoAnteriorMes.Text = "Anterior";
            btResumoAnteriorMes.UseVisualStyleBackColor = true;
            btResumoAnteriorMes.Click += btResumoAnteriorMes_Click;
            // 
            // lbResumoMesAno
            // 
            lbResumoMesAno.AutoSize = true;
            lbResumoMesAno.Location = new Point(506, 64);
            lbResumoMesAno.Name = "lbResumoMesAno";
            lbResumoMesAno.Size = new Size(56, 15);
            lbResumoMesAno.TabIndex = 8;
            lbResumoMesAno.Text = "Mês/Ano";
            // 
            // ctResumoMes
            // 
            ctResumoMes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ctResumoMes.Location = new Point(537, 124);
            ctResumoMes.Name = "ctResumoMes";
            ctResumoMes.Size = new Size(558, 343);
            ctResumoMes.TabIndex = 9;
            // 
            // Resumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1107, 545);
            Controls.Add(lbResumoMesAno);
            Controls.Add(btResumoAnteriorMes);
            Controls.Add(btResumoAvancarMes);
            Controls.Add(btResumoVoltar);
            Controls.Add(lbResumoGastosMes);
            Controls.Add(pnResumoGastosMes);
            Controls.Add(lbResumoGraficoColuna);
            Controls.Add(lbResumoTitulo);
            Controls.Add(ctResumoMes);
            Name = "Resumo";
            Text = "Resumo";
            pnResumoGastosMes.ResumeLayout(false);
            pnResumoGastosMes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbResumoGastosMes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctResumoMes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ctResumoMes;
        private Label lbResumoTitulo;
        private Label lbResumoGraficoColuna;
        private Panel pnResumoGastosMes;
        private Label lbResumoGastosMes;
        private Label lbResumoGastoTotal;
        private Button btResumoVoltar;
        private Button btResumoAvancarMes;
        private Button btResumoAnteriorMes;
        private Label lbResumoMesAno;
        private DataGridView tbResumoGastosMes;
    }
}