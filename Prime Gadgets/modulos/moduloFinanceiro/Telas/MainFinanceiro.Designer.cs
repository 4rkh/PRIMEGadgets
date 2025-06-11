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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFinanceiro));
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
            menuGlobal.BackColor = Color.FromArgb(230, 34, 34);
            menuGlobal.Dock = DockStyle.Left;
            menuGlobal.Location = new Point(0, 0);
            menuGlobal.Name = "menuGlobal";
            menuGlobal.Size = new Size(212, 650);
            menuGlobal.TabIndex = 0;
            // 
            // dtMainFinanceiroGastos
            // 
            dtMainFinanceiroGastos.AllowUserToOrderColumns = true;
            dtMainFinanceiroGastos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtMainFinanceiroGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtMainFinanceiroGastos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtMainFinanceiroGastos.BackgroundColor = Color.FromArgb(140, 132, 127);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle4.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtMainFinanceiroGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtMainFinanceiroGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle5.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtMainFinanceiroGastos.DefaultCellStyle = dataGridViewCellStyle5;
            dtMainFinanceiroGastos.GridColor = Color.FromArgb(140, 132, 127);
            dtMainFinanceiroGastos.Location = new Point(257, 210);
            dtMainFinanceiroGastos.Name = "dtMainFinanceiroGastos";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle6.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtMainFinanceiroGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtMainFinanceiroGastos.Size = new Size(687, 337);
            dtMainFinanceiroGastos.TabIndex = 1;
            // 
            // lbMainFinaceiroTitulo
            // 
            lbMainFinaceiroTitulo.Anchor = AnchorStyles.Top;
            lbMainFinaceiroTitulo.BackColor = Color.Transparent;
            lbMainFinaceiroTitulo.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbMainFinaceiroTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainFinaceiroTitulo.Location = new Point(441, 25);
            lbMainFinaceiroTitulo.Name = "lbMainFinaceiroTitulo";
            lbMainFinaceiroTitulo.Size = new Size(374, 53);
            lbMainFinaceiroTitulo.TabIndex = 2;
            lbMainFinaceiroTitulo.Text = "Planejador Financeiro";
            lbMainFinaceiroTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btMainFinanceiroSalvar
            // 
            btMainFinanceiroSalvar.BackColor = Color.FromArgb(230, 34, 34);
            btMainFinanceiroSalvar.FlatAppearance.BorderSize = 0;
            btMainFinanceiroSalvar.FlatStyle = FlatStyle.Flat;
            btMainFinanceiroSalvar.Font = new Font("Arial", 12.75F);
            btMainFinanceiroSalvar.ForeColor = Color.FromArgb(255, 252, 237);
            btMainFinanceiroSalvar.Location = new Point(257, 157);
            btMainFinanceiroSalvar.Name = "btMainFinanceiroSalvar";
            btMainFinanceiroSalvar.Size = new Size(191, 37);
            btMainFinanceiroSalvar.TabIndex = 3;
            btMainFinanceiroSalvar.Text = "Salvar";
            btMainFinanceiroSalvar.UseVisualStyleBackColor = false;
            btMainFinanceiroSalvar.Click += btMainFinanceiroSalvar_Click;
            // 
            // lbMainFinaceiroAno
            // 
            lbMainFinaceiroAno.Anchor = AnchorStyles.Top;
            lbMainFinaceiroAno.BackColor = Color.Transparent;
            lbMainFinaceiroAno.FlatStyle = FlatStyle.Flat;
            lbMainFinaceiroAno.Font = new Font("Arial", 21.75F);
            lbMainFinaceiroAno.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainFinaceiroAno.Location = new Point(857, 91);
            lbMainFinaceiroAno.Name = "lbMainFinaceiroAno";
            lbMainFinaceiroAno.Size = new Size(87, 42);
            lbMainFinaceiroAno.TabIndex = 56;
            lbMainFinaceiroAno.Text = "2025";
            lbMainFinaceiroAno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMainFinaceiroMes
            // 
            lbMainFinaceiroMes.Anchor = AnchorStyles.Top;
            lbMainFinaceiroMes.BackColor = Color.Transparent;
            lbMainFinaceiroMes.FlatStyle = FlatStyle.Flat;
            lbMainFinaceiroMes.Font = new Font("Arial", 21.75F);
            lbMainFinaceiroMes.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainFinaceiroMes.Location = new Point(694, 91);
            lbMainFinaceiroMes.Name = "lbMainFinaceiroMes";
            lbMainFinaceiroMes.Size = new Size(157, 42);
            lbMainFinaceiroMes.TabIndex = 55;
            lbMainFinaceiroMes.Text = "Julho";
            lbMainFinaceiroMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ddmainFinaceiroMesSelect
            // 
            ddmainFinaceiroMesSelect.AllowDrop = true;
            ddmainFinaceiroMesSelect.Anchor = AnchorStyles.Top;
            ddmainFinaceiroMesSelect.BackColor = Color.FromArgb(255, 252, 237);
            ddmainFinaceiroMesSelect.Font = new Font("Arial", 15.75F);
            ddmainFinaceiroMesSelect.ForeColor = Color.FromArgb(230, 34, 34);
            ddmainFinaceiroMesSelect.FormattingEnabled = true;
            ddmainFinaceiroMesSelect.Items.AddRange(new object[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" });
            ddmainFinaceiroMesSelect.Location = new Point(257, 101);
            ddmainFinaceiroMesSelect.Name = "ddmainFinaceiroMesSelect";
            ddmainFinaceiroMesSelect.Size = new Size(237, 32);
            ddmainFinaceiroMesSelect.TabIndex = 53;
            ddmainFinaceiroMesSelect.Text = "-- Selecionar o Mês --";
            // 
            // ddmainFinaceiroAnoSelect
            // 
            ddmainFinaceiroAnoSelect.AllowDrop = true;
            ddmainFinaceiroAnoSelect.Anchor = AnchorStyles.Top;
            ddmainFinaceiroAnoSelect.BackColor = Color.FromArgb(255, 252, 237);
            ddmainFinaceiroAnoSelect.Font = new Font("Arial", 15.75F);
            ddmainFinaceiroAnoSelect.ForeColor = Color.FromArgb(230, 34, 34);
            ddmainFinaceiroAnoSelect.FormattingEnabled = true;
            ddmainFinaceiroAnoSelect.Location = new Point(517, 101);
            ddmainFinaceiroAnoSelect.Name = "ddmainFinaceiroAnoSelect";
            ddmainFinaceiroAnoSelect.Size = new Size(119, 32);
            ddmainFinaceiroAnoSelect.TabIndex = 58;
            ddmainFinaceiroAnoSelect.Text = "-- Ano --";
            // 
            // btMainFinaceiroNext
            // 
            btMainFinaceiroNext.Anchor = AnchorStyles.Bottom;
            btMainFinaceiroNext.BackColor = Color.FromArgb(230, 34, 34);
            btMainFinaceiroNext.FlatAppearance.BorderSize = 0;
            btMainFinaceiroNext.FlatStyle = FlatStyle.Flat;
            btMainFinaceiroNext.Image = Properties.Resources.avancar;
            btMainFinaceiroNext.Location = new Point(649, 564);
            btMainFinaceiroNext.Name = "btMainFinaceiroNext";
            btMainFinaceiroNext.Size = new Size(60, 60);
            btMainFinaceiroNext.TabIndex = 60;
            btMainFinaceiroNext.UseVisualStyleBackColor = false;
            // 
            // btMainFinaceiroBack
            // 
            btMainFinaceiroBack.Anchor = AnchorStyles.Bottom;
            btMainFinaceiroBack.BackColor = Color.FromArgb(230, 34, 34);
            btMainFinaceiroBack.FlatAppearance.BorderSize = 0;
            btMainFinaceiroBack.FlatStyle = FlatStyle.Flat;
            btMainFinaceiroBack.Image = Properties.Resources.voltar;
            btMainFinaceiroBack.Location = new Point(491, 564);
            btMainFinaceiroBack.Name = "btMainFinaceiroBack";
            btMainFinaceiroBack.Size = new Size(60, 60);
            btMainFinaceiroBack.TabIndex = 59;
            btMainFinaceiroBack.UseVisualStyleBackColor = false;
            // 
            // btMainFinanceiroReset
            // 
            btMainFinanceiroReset.BackColor = Color.FromArgb(230, 34, 34);
            btMainFinanceiroReset.FlatAppearance.BorderSize = 0;
            btMainFinanceiroReset.FlatStyle = FlatStyle.Flat;
            btMainFinanceiroReset.Font = new Font("Arial", 12.75F);
            btMainFinanceiroReset.ForeColor = Color.FromArgb(255, 252, 237);
            btMainFinanceiroReset.Location = new Point(474, 157);
            btMainFinanceiroReset.Name = "btMainFinanceiroReset";
            btMainFinanceiroReset.Size = new Size(191, 37);
            btMainFinanceiroReset.TabIndex = 61;
            btMainFinanceiroReset.Text = "Reverter";
            btMainFinanceiroReset.UseVisualStyleBackColor = false;
            btMainFinanceiroReset.Click += btMainFinanceiroReset_Click;
            // 
            // btMainFinanceiroGraficos
            // 
            btMainFinanceiroGraficos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btMainFinanceiroGraficos.BackColor = Color.FromArgb(230, 34, 34);
            btMainFinanceiroGraficos.FlatAppearance.BorderSize = 0;
            btMainFinanceiroGraficos.FlatStyle = FlatStyle.Flat;
            btMainFinanceiroGraficos.Font = new Font("Arial", 12.75F);
            btMainFinanceiroGraficos.ForeColor = Color.FromArgb(255, 252, 237);
            btMainFinanceiroGraficos.Location = new Point(753, 157);
            btMainFinanceiroGraficos.Name = "btMainFinanceiroGraficos";
            btMainFinanceiroGraficos.Size = new Size(191, 37);
            btMainFinanceiroGraficos.TabIndex = 62;
            btMainFinanceiroGraficos.Text = "Resumo Mensal";
            btMainFinanceiroGraficos.UseVisualStyleBackColor = false;
            btMainFinanceiroGraficos.Click += btMainFinanceiroGraficos_Click;
            // 
            // MainFinanceiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1000, 650);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 650);
            Name = "MainFinanceiro";
            Text = "MainFinanceiro";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dtMainFinanceiroGastos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Menu menuGlobal;
        private System.Windows.Forms.DataGridView dtMainFinanceiroGastos;
        private System.Windows.Forms.Label lbMainFinaceiroTitulo;
        private System.Windows.Forms.Button btMainFinanceiroSalvar;
        private System.Windows.Forms.Label lbMainFinaceiroAno;
        private System.Windows.Forms.Label lbMainFinaceiroMes;
        private System.Windows.Forms.ComboBox ddmainFinaceiroMesSelect;
        private System.Windows.Forms.ComboBox ddmainFinaceiroAnoSelect;
        private System.Windows.Forms.Button btMainFinaceiroNext;
        private System.Windows.Forms.Button btMainFinaceiroBack;
        private System.Windows.Forms.Button btMainFinanceiroReset;
        private System.Windows.Forms.Button btMainFinanceiroGraficos;
    }
}