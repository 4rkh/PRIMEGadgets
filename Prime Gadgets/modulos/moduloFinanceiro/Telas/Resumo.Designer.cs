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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resumo));
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
            lbResumoTitulo.Font = new Font("Arial", 24F);
            lbResumoTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbResumoTitulo.Location = new Point(411, 9);
            lbResumoTitulo.Name = "lbResumoTitulo";
            lbResumoTitulo.Size = new Size(244, 36);
            lbResumoTitulo.TabIndex = 1;
            lbResumoTitulo.Text = "Resumo Mensal";
            // 
            // lbResumoGraficoColuna
            // 
            lbResumoGraficoColuna.AutoSize = true;
            lbResumoGraficoColuna.Font = new Font("Arial", 20F);
            lbResumoGraficoColuna.ForeColor = Color.FromArgb(52, 60, 76);
            lbResumoGraficoColuna.Location = new Point(745, 92);
            lbResumoGraficoColuna.Name = "lbResumoGraficoColuna";
            lbResumoGraficoColuna.Size = new Size(227, 32);
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
            tbResumoGastosMes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbResumoGastosMes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbResumoGastosMes.BackgroundColor = Color.FromArgb(140, 132, 127);
            tbResumoGastosMes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbResumoGastosMes.Location = new Point(3, 3);
            tbResumoGastosMes.Name = "tbResumoGastosMes";
            tbResumoGastosMes.Size = new Size(513, 312);
            tbResumoGastosMes.TabIndex = 2;
            // 
            // lbResumoGastoTotal
            // 
            lbResumoGastoTotal.AutoSize = true;
            lbResumoGastoTotal.Font = new Font("Arial", 12.75F);
            lbResumoGastoTotal.ForeColor = Color.FromArgb(230, 34, 34);
            lbResumoGastoTotal.Location = new Point(3, 318);
            lbResumoGastoTotal.Name = "lbResumoGastoTotal";
            lbResumoGastoTotal.Size = new Size(148, 19);
            lbResumoGastoTotal.TabIndex = 1;
            lbResumoGastoTotal.Text = "Total gasto no mês:";
            // 
            // lbResumoGastosMes
            // 
            lbResumoGastosMes.AutoSize = true;
            lbResumoGastosMes.Font = new Font("Arial", 20F);
            lbResumoGastosMes.ForeColor = Color.FromArgb(52, 60, 76);
            lbResumoGastosMes.Location = new Point(159, 92);
            lbResumoGastosMes.Name = "lbResumoGastosMes";
            lbResumoGastosMes.Size = new Size(198, 32);
            lbResumoGastosMes.TabIndex = 4;
            lbResumoGastosMes.Text = "Gastos no mês";
            // 
            // btResumoVoltar
            // 
            btResumoVoltar.BackColor = Color.FromArgb(230, 34, 34);
            btResumoVoltar.FlatAppearance.BorderSize = 0;
            btResumoVoltar.FlatStyle = FlatStyle.Flat;
            btResumoVoltar.Image = Properties.Resources.primeira;
            btResumoVoltar.Location = new Point(15, 21);
            btResumoVoltar.Name = "btResumoVoltar";
            btResumoVoltar.Size = new Size(60, 60);
            btResumoVoltar.TabIndex = 5;
            btResumoVoltar.UseVisualStyleBackColor = false;
            btResumoVoltar.Click += btResumoVoltar_Click;
            // 
            // btResumoAvancarMes
            // 
            btResumoAvancarMes.BackColor = Color.FromArgb(230, 34, 34);
            btResumoAvancarMes.FlatAppearance.BorderSize = 0;
            btResumoAvancarMes.FlatStyle = FlatStyle.Flat;
            btResumoAvancarMes.Image = Properties.Resources.avancar;
            btResumoAvancarMes.Location = new Point(631, 58);
            btResumoAvancarMes.Name = "btResumoAvancarMes";
            btResumoAvancarMes.Size = new Size(60, 60);
            btResumoAvancarMes.TabIndex = 6;
            btResumoAvancarMes.UseVisualStyleBackColor = false;
            btResumoAvancarMes.Click += btResumoAvancarMes_Click;
            // 
            // btResumoAnteriorMes
            // 
            btResumoAnteriorMes.BackColor = Color.FromArgb(230, 34, 34);
            btResumoAnteriorMes.FlatAppearance.BorderSize = 0;
            btResumoAnteriorMes.FlatStyle = FlatStyle.Flat;
            btResumoAnteriorMes.Image = Properties.Resources.voltar;
            btResumoAnteriorMes.Location = new Point(381, 58);
            btResumoAnteriorMes.Name = "btResumoAnteriorMes";
            btResumoAnteriorMes.Size = new Size(60, 60);
            btResumoAnteriorMes.TabIndex = 7;
            btResumoAnteriorMes.UseVisualStyleBackColor = false;
            btResumoAnteriorMes.Click += btResumoAnteriorMes_Click;
            // 
            // lbResumoMesAno
            // 
            lbResumoMesAno.AutoSize = true;
            lbResumoMesAno.Font = new Font("Arial", 12.75F);
            lbResumoMesAno.ForeColor = Color.FromArgb(52, 60, 76);
            lbResumoMesAno.Location = new Point(479, 78);
            lbResumoMesAno.Name = "lbResumoMesAno";
            lbResumoMesAno.Size = new Size(73, 19);
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
            ClientSize = new Size(1092, 545);
            Controls.Add(lbResumoMesAno);
            Controls.Add(btResumoAnteriorMes);
            Controls.Add(btResumoAvancarMes);
            Controls.Add(btResumoVoltar);
            Controls.Add(lbResumoGastosMes);
            Controls.Add(pnResumoGastosMes);
            Controls.Add(lbResumoGraficoColuna);
            Controls.Add(lbResumoTitulo);
            Controls.Add(ctResumoMes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1108, 584);
            Name = "Resumo";
            Text = "Resumo Mensal";
            pnResumoGastosMes.ResumeLayout(false);
            pnResumoGastosMes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbResumoGastosMes).EndInit();
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