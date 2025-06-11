namespace Prime_Gadgets.modulos.moduloFinanceiro
{
    partial class MainFinanceiro
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
            menuGlobal = new Menu();
            dtMainFinanceiroGastos = new DataGridView();
            lbMainFinaceiroTitulo = new Label();
            btMainFinanceiroSalvar = new Button();
            lbMainFinaceiroAno = new Label();
            lbMainFinaceiroMes = new Label();
            ddmainFinaceiroMesSelect = new ComboBox();
            ddmainFinaceiroAnoSelect = new ComboBox();
            btMainFinaceiroNext = new Button();
            btMainFinaceiroBack = new Button();
            btMainFinanceiroReset = new Button();
            btMainFinanceiroGraficos = new Button();
            ((System.ComponentModel.ISupportInitialize)dtMainFinanceiroGastos).BeginInit();
            SuspendLayout();
            // 
            // menuGlobal
            // 
            menuGlobal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menuGlobal.BackColor = Color.FromArgb(230, 34, 34);
            menuGlobal.Location = new Point(-3, 0);
            menuGlobal.Name = "menuGlobal";
            menuGlobal.Size = new Size(212, 1000);
            menuGlobal.TabIndex = 0;
            // 
            // dtMainFinanceiroGastos
            // 
            dtMainFinanceiroGastos.AllowUserToOrderColumns = true;
            dtMainFinanceiroGastos.Anchor = AnchorStyles.Top;
            dtMainFinanceiroGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMainFinanceiroGastos.Location = new Point(495, 248);
            dtMainFinanceiroGastos.Name = "dtMainFinanceiroGastos";
            dtMainFinanceiroGastos.Size = new Size(664, 540);
            dtMainFinanceiroGastos.TabIndex = 1;
            // 
            // lbMainFinaceiroTitulo
            // 
            lbMainFinaceiroTitulo.Anchor = AnchorStyles.Top;
            lbMainFinaceiroTitulo.BackColor = Color.Blue;
            lbMainFinaceiroTitulo.Font = new Font("Segoe UI", 25F);
            lbMainFinaceiroTitulo.Location = new Point(545, 63);
            lbMainFinaceiroTitulo.Name = "lbMainFinaceiroTitulo";
            lbMainFinaceiroTitulo.Size = new Size(509, 59);
            lbMainFinaceiroTitulo.TabIndex = 2;
            lbMainFinaceiroTitulo.Text = "Planejador Financeiro";
            lbMainFinaceiroTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btMainFinanceiroSalvar
            // 
            btMainFinanceiroSalvar.Location = new Point(333, 304);
            btMainFinanceiroSalvar.Name = "btMainFinanceiroSalvar";
            btMainFinanceiroSalvar.Size = new Size(75, 23);
            btMainFinanceiroSalvar.TabIndex = 3;
            btMainFinanceiroSalvar.Text = "Salvar";
            btMainFinanceiroSalvar.UseVisualStyleBackColor = true;
            btMainFinanceiroSalvar.Click += btMainFinanceiroSalvar_Click;
            // 
            // lbMainFinaceiroAno
            // 
            lbMainFinaceiroAno.Anchor = AnchorStyles.Top;
            lbMainFinaceiroAno.BackColor = Color.FromArgb(192, 192, 255);
            lbMainFinaceiroAno.FlatStyle = FlatStyle.Flat;
            lbMainFinaceiroAno.Font = new Font("Segoe UI", 25F);
            lbMainFinaceiroAno.Location = new Point(1094, 169);
            lbMainFinaceiroAno.Name = "lbMainFinaceiroAno";
            lbMainFinaceiroAno.Size = new Size(119, 54);
            lbMainFinaceiroAno.TabIndex = 56;
            lbMainFinaceiroAno.Text = "2025";
            lbMainFinaceiroAno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMainFinaceiroMes
            // 
            lbMainFinaceiroMes.Anchor = AnchorStyles.Top;
            lbMainFinaceiroMes.BackColor = Color.FromArgb(192, 255, 192);
            lbMainFinaceiroMes.FlatStyle = FlatStyle.Flat;
            lbMainFinaceiroMes.Font = new Font("Segoe UI", 20F);
            lbMainFinaceiroMes.Location = new Point(887, 169);
            lbMainFinaceiroMes.Name = "lbMainFinaceiroMes";
            lbMainFinaceiroMes.Size = new Size(184, 54);
            lbMainFinaceiroMes.TabIndex = 55;
            lbMainFinaceiroMes.Text = "Julho";
            lbMainFinaceiroMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ddmainFinaceiroMesSelect
            // 
            ddmainFinaceiroMesSelect.AllowDrop = true;
            ddmainFinaceiroMesSelect.Anchor = AnchorStyles.Top;
            ddmainFinaceiroMesSelect.BackColor = Color.Violet;
            ddmainFinaceiroMesSelect.FormattingEnabled = true;
            ddmainFinaceiroMesSelect.Items.AddRange(new object[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" });
            ddmainFinaceiroMesSelect.Location = new Point(412, 193);
            ddmainFinaceiroMesSelect.Name = "ddmainFinaceiroMesSelect";
            ddmainFinaceiroMesSelect.Size = new Size(197, 23);
            ddmainFinaceiroMesSelect.TabIndex = 53;
            ddmainFinaceiroMesSelect.Text = "----Selecionar o Mês----";
            // 
            // ddmainFinaceiroAnoSelect
            // 
            ddmainFinaceiroAnoSelect.AllowDrop = true;
            ddmainFinaceiroAnoSelect.Anchor = AnchorStyles.Top;
            ddmainFinaceiroAnoSelect.BackColor = Color.Violet;
            ddmainFinaceiroAnoSelect.FormattingEnabled = true;
            ddmainFinaceiroAnoSelect.Items.AddRange(new object[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" });
            ddmainFinaceiroAnoSelect.Location = new Point(635, 193);
            ddmainFinaceiroAnoSelect.Name = "ddmainFinaceiroAnoSelect";
            ddmainFinaceiroAnoSelect.Size = new Size(91, 23);
            ddmainFinaceiroAnoSelect.TabIndex = 58;
            ddmainFinaceiroAnoSelect.Text = "---- Ano----";
            // 
            // btMainFinaceiroNext
            // 
            btMainFinaceiroNext.Anchor = AnchorStyles.Top;
            btMainFinaceiroNext.Location = new Point(911, 800);
            btMainFinaceiroNext.Name = "btMainFinaceiroNext";
            btMainFinaceiroNext.Size = new Size(128, 31);
            btMainFinaceiroNext.TabIndex = 60;
            btMainFinaceiroNext.Text = "next";
            btMainFinaceiroNext.UseVisualStyleBackColor = true;
            // 
            // btMainFinaceiroBack
            // 
            btMainFinaceiroBack.Anchor = AnchorStyles.Top;
            btMainFinaceiroBack.Location = new Point(607, 800);
            btMainFinaceiroBack.Name = "btMainFinaceiroBack";
            btMainFinaceiroBack.Size = new Size(128, 31);
            btMainFinaceiroBack.TabIndex = 59;
            btMainFinaceiroBack.Text = "back";
            btMainFinaceiroBack.UseVisualStyleBackColor = true;
            // 
            // btMainFinanceiroReset
            // 
            btMainFinanceiroReset.Location = new Point(333, 348);
            btMainFinanceiroReset.Name = "btMainFinanceiroReset";
            btMainFinanceiroReset.Size = new Size(75, 23);
            btMainFinanceiroReset.TabIndex = 61;
            btMainFinanceiroReset.Text = "Reverter";
            btMainFinanceiroReset.UseVisualStyleBackColor = true;
            btMainFinanceiroReset.Click += btMainFinanceiroReset_Click;
            // 
            // btMainFinanceiroGraficos
            // 
            btMainFinanceiroGraficos.Location = new Point(333, 688);
            btMainFinanceiroGraficos.Name = "btMainFinanceiroGraficos";
            btMainFinanceiroGraficos.Size = new Size(121, 64);
            btMainFinanceiroGraficos.TabIndex = 62;
            btMainFinanceiroGraficos.Text = "Gráficos";
            btMainFinanceiroGraficos.UseVisualStyleBackColor = true;
            // 
            // MainFinanceiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1234, 839);
            Controls.Add(btMainFinanceiroGraficos);
            Controls.Add(btMainFinanceiroReset);
            Controls.Add(btMainFinaceiroNext);
            Controls.Add(btMainFinaceiroBack);
            Controls.Add(ddmainFinaceiroAnoSelect);
            Controls.Add(lbMainFinaceiroAno);
            Controls.Add(lbMainFinaceiroMes);
            Controls.Add(ddmainFinaceiroMesSelect);
            Controls.Add(btMainFinanceiroSalvar);
            Controls.Add(lbMainFinaceiroTitulo);
            Controls.Add(dtMainFinanceiroGastos);
            Controls.Add(menuGlobal);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(689, 643);
            Name = "MainFinanceiro";
            Text = "MainFinanceiro";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dtMainFinanceiroGastos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Menu menuGlobal;
        private DataGridView dtMainFinanceiroGastos;
        private Label lbMainFinaceiroTitulo;
        private Button btMainFinanceiroSalvar;
        private Label lbMainFinaceiroAno;
        private Label lbMainFinaceiroMes;
        private ComboBox ddmainFinaceiroMesSelect;
        private ComboBox ddmainFinaceiroAnoSelect;
        private Button btMainFinaceiroNext;
        private Button btMainFinaceiroBack;
        private Button btMainFinanceiroReset;
        private Button btMainFinanceiroGraficos;
    }
}