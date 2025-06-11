namespace Prime_Gadgets.modulos.moduloSenhas
{
    partial class GeradorSenhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeradorSenhas));
            btGeradorSenhasCancelar = new Button();
            btGeradorSenhasSalvar = new Button();
            cbGeradorSenhasLetrasMa = new CheckBox();
            lbGeradorSenhasComprimento = new Label();
            tbGeradorSenhasComprimento = new TrackBar();
            cbGeradorSenhasCaracterEs = new CheckBox();
            lbGeradorSenhasTitulo = new Label();
            cbGeradorSenhasLetrasMi = new CheckBox();
            lbGeradorSenhasComprimentoNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)tbGeradorSenhasComprimento).BeginInit();
            SuspendLayout();
            // 
            // btGeradorSenhasCancelar
            // 
            btGeradorSenhasCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btGeradorSenhasCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btGeradorSenhasCancelar.FlatAppearance.BorderSize = 0;
            btGeradorSenhasCancelar.FlatStyle = FlatStyle.Flat;
            btGeradorSenhasCancelar.Font = new Font("Arial", 12.75F);
            btGeradorSenhasCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btGeradorSenhasCancelar.Location = new Point(240, 248);
            btGeradorSenhasCancelar.Name = "btGeradorSenhasCancelar";
            btGeradorSenhasCancelar.Size = new Size(118, 37);
            btGeradorSenhasCancelar.TabIndex = 24;
            btGeradorSenhasCancelar.Text = "Cancelar";
            btGeradorSenhasCancelar.UseVisualStyleBackColor = false;
            btGeradorSenhasCancelar.Click += btGeradorSenhasCancelar_Click;
            // 
            // btGeradorSenhasSalvar
            // 
            btGeradorSenhasSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btGeradorSenhasSalvar.BackColor = Color.FromArgb(230, 34, 34);
            btGeradorSenhasSalvar.FlatAppearance.BorderSize = 0;
            btGeradorSenhasSalvar.FlatStyle = FlatStyle.Flat;
            btGeradorSenhasSalvar.Font = new Font("Arial", 12.75F);
            btGeradorSenhasSalvar.ForeColor = Color.FromArgb(255, 252, 237);
            btGeradorSenhasSalvar.Location = new Point(71, 248);
            btGeradorSenhasSalvar.Name = "btGeradorSenhasSalvar";
            btGeradorSenhasSalvar.Size = new Size(118, 37);
            btGeradorSenhasSalvar.TabIndex = 25;
            btGeradorSenhasSalvar.Text = "Salvar";
            btGeradorSenhasSalvar.UseVisualStyleBackColor = false;
            btGeradorSenhasSalvar.Click += btGeradorSenhasSalvar_Click;
            // 
            // cbGeradorSenhasLetrasMa
            // 
            cbGeradorSenhasLetrasMa.Anchor = AnchorStyles.Left;
            cbGeradorSenhasLetrasMa.Checked = true;
            cbGeradorSenhasLetrasMa.CheckState = CheckState.Checked;
            cbGeradorSenhasLetrasMa.Font = new Font("Arial", 12.75F);
            cbGeradorSenhasLetrasMa.ForeColor = Color.FromArgb(52, 60, 76);
            cbGeradorSenhasLetrasMa.Location = new Point(127, 132);
            cbGeradorSenhasLetrasMa.Name = "cbGeradorSenhasLetrasMa";
            cbGeradorSenhasLetrasMa.Size = new Size(165, 30);
            cbGeradorSenhasLetrasMa.TabIndex = 26;
            cbGeradorSenhasLetrasMa.Text = "Letras maiúsculas";
            cbGeradorSenhasLetrasMa.TextAlign = ContentAlignment.MiddleCenter;
            cbGeradorSenhasLetrasMa.UseVisualStyleBackColor = true;
            // 
            // lbGeradorSenhasComprimento
            // 
            lbGeradorSenhasComprimento.Font = new Font("Arial", 12.75F);
            lbGeradorSenhasComprimento.ForeColor = Color.FromArgb(52, 60, 76);
            lbGeradorSenhasComprimento.Location = new Point(105, 72);
            lbGeradorSenhasComprimento.Name = "lbGeradorSenhasComprimento";
            lbGeradorSenhasComprimento.Size = new Size(187, 19);
            lbGeradorSenhasComprimento.TabIndex = 27;
            lbGeradorSenhasComprimento.Text = "Comprimento da senha:";
            lbGeradorSenhasComprimento.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbGeradorSenhasComprimento
            // 
            tbGeradorSenhasComprimento.AutoSize = false;
            tbGeradorSenhasComprimento.Location = new Point(71, 94);
            tbGeradorSenhasComprimento.Maximum = 50;
            tbGeradorSenhasComprimento.Minimum = 8;
            tbGeradorSenhasComprimento.Name = "tbGeradorSenhasComprimento";
            tbGeradorSenhasComprimento.Size = new Size(287, 32);
            tbGeradorSenhasComprimento.TabIndex = 30;
            tbGeradorSenhasComprimento.Value = 8;
            tbGeradorSenhasComprimento.Scroll += tbGerarSenhasComprimento_Scroll;
            // 
            // cbGeradorSenhasCaracterEs
            // 
            cbGeradorSenhasCaracterEs.Anchor = AnchorStyles.Left;
            cbGeradorSenhasCaracterEs.Checked = true;
            cbGeradorSenhasCaracterEs.CheckState = CheckState.Checked;
            cbGeradorSenhasCaracterEs.Font = new Font("Arial", 12.75F);
            cbGeradorSenhasCaracterEs.ForeColor = Color.FromArgb(52, 60, 76);
            cbGeradorSenhasCaracterEs.Location = new Point(127, 200);
            cbGeradorSenhasCaracterEs.Name = "cbGeradorSenhasCaracterEs";
            cbGeradorSenhasCaracterEs.Size = new Size(190, 30);
            cbGeradorSenhasCaracterEs.TabIndex = 31;
            cbGeradorSenhasCaracterEs.Text = "Caracteres especiais";
            cbGeradorSenhasCaracterEs.TextAlign = ContentAlignment.MiddleCenter;
            cbGeradorSenhasCaracterEs.UseVisualStyleBackColor = true;
            // 
            // lbGeradorSenhasTitulo
            // 
            lbGeradorSenhasTitulo.Font = new Font("Arial", 24F);
            lbGeradorSenhasTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbGeradorSenhasTitulo.Location = new Point(24, 13);
            lbGeradorSenhasTitulo.Name = "lbGeradorSenhasTitulo";
            lbGeradorSenhasTitulo.Size = new Size(374, 45);
            lbGeradorSenhasTitulo.TabIndex = 32;
            lbGeradorSenhasTitulo.Text = "Configuração da geração";
            lbGeradorSenhasTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbGeradorSenhasLetrasMi
            // 
            cbGeradorSenhasLetrasMi.Anchor = AnchorStyles.Left;
            cbGeradorSenhasLetrasMi.Checked = true;
            cbGeradorSenhasLetrasMi.CheckState = CheckState.Checked;
            cbGeradorSenhasLetrasMi.Font = new Font("Arial", 12.75F);
            cbGeradorSenhasLetrasMi.ForeColor = Color.FromArgb(52, 60, 76);
            cbGeradorSenhasLetrasMi.Location = new Point(127, 168);
            cbGeradorSenhasLetrasMi.Name = "cbGeradorSenhasLetrasMi";
            cbGeradorSenhasLetrasMi.Size = new Size(165, 30);
            cbGeradorSenhasLetrasMi.TabIndex = 33;
            cbGeradorSenhasLetrasMi.Text = "Letras minúsculas";
            cbGeradorSenhasLetrasMi.TextAlign = ContentAlignment.MiddleCenter;
            cbGeradorSenhasLetrasMi.UseVisualStyleBackColor = true;
            // 
            // lbGeradorSenhasComprimentoNumber
            // 
            lbGeradorSenhasComprimentoNumber.Font = new Font("Arial", 12.75F);
            lbGeradorSenhasComprimentoNumber.Location = new Point(290, 72);
            lbGeradorSenhasComprimentoNumber.Name = "lbGeradorSenhasComprimentoNumber";
            lbGeradorSenhasComprimentoNumber.Size = new Size(27, 19);
            lbGeradorSenhasComprimentoNumber.TabIndex = 34;
            lbGeradorSenhasComprimentoNumber.Text = "8";
            lbGeradorSenhasComprimentoNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // GeradorSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(423, 297);
            Controls.Add(lbGeradorSenhasComprimentoNumber);
            Controls.Add(cbGeradorSenhasLetrasMi);
            Controls.Add(lbGeradorSenhasTitulo);
            Controls.Add(cbGeradorSenhasCaracterEs);
            Controls.Add(tbGeradorSenhasComprimento);
            Controls.Add(lbGeradorSenhasComprimento);
            Controls.Add(cbGeradorSenhasLetrasMa);
            Controls.Add(btGeradorSenhasSalvar);
            Controls.Add(btGeradorSenhasCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GeradorSenhas";
            Text = "Configurações de Geração";
            Load += GeradorSenhas_Load;
            ((System.ComponentModel.ISupportInitialize)tbGeradorSenhasComprimento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btGeradorSenhasCancelar;
        private Button btGeradorSenhasSalvar;
        private CheckBox cbGeradorSenhasLetrasMa;
        private Label lbGeradorSenhasComprimento;
        private TrackBar tbGeradorSenhasComprimento;
        private CheckBox cbGeradorSenhasCaracterEs;
        private Label lbGeradorSenhasTitulo;
        private CheckBox cbGeradorSenhasLetrasMi;
        private Label lbGeradorSenhasComprimentoNumber;
    }
}