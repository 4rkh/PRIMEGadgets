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
            btGeradorSenhasCancelar.Anchor = AnchorStyles.Left;
            btGeradorSenhasCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btGeradorSenhasCancelar.FlatAppearance.BorderSize = 0;
            btGeradorSenhasCancelar.FlatStyle = FlatStyle.Flat;
            btGeradorSenhasCancelar.Font = new Font("Arial", 12.75F);
            btGeradorSenhasCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btGeradorSenhasCancelar.Location = new Point(157, 232);
            btGeradorSenhasCancelar.Name = "btGeradorSenhasCancelar";
            btGeradorSenhasCancelar.Size = new Size(118, 37);
            btGeradorSenhasCancelar.TabIndex = 24;
            btGeradorSenhasCancelar.Text = "Cancelar";
            btGeradorSenhasCancelar.UseVisualStyleBackColor = false;
            btGeradorSenhasCancelar.Click += btGeradorSenhasCancelar_Click;
            // 
            // btGeradorSenhasSalvar
            // 
            btGeradorSenhasSalvar.Anchor = AnchorStyles.Left;
            btGeradorSenhasSalvar.BackColor = Color.FromArgb(230, 34, 34);
            btGeradorSenhasSalvar.FlatAppearance.BorderSize = 0;
            btGeradorSenhasSalvar.FlatStyle = FlatStyle.Flat;
            btGeradorSenhasSalvar.Font = new Font("Arial", 12.75F);
            btGeradorSenhasSalvar.ForeColor = Color.FromArgb(255, 252, 237);
            btGeradorSenhasSalvar.Location = new Point(19, 232);
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
            cbGeradorSenhasLetrasMa.Checked = SenhaConfig.letraMa;
            cbGeradorSenhasLetrasMa.Location = new Point(19, 114);
            cbGeradorSenhasLetrasMa.Name = "cbGeradorSenhasLetrasMa";
            cbGeradorSenhasLetrasMa.Size = new Size(256, 30);
            cbGeradorSenhasLetrasMa.TabIndex = 26;
            cbGeradorSenhasLetrasMa.Text = "Letras maiúsculas";
            cbGeradorSenhasLetrasMa.TextAlign = ContentAlignment.MiddleCenter;
            cbGeradorSenhasLetrasMa.UseVisualStyleBackColor = SenhaConfig.letraMa;
            // 
            // lbGeradorSenhasComprimento
            // 
            lbGeradorSenhasComprimento.Anchor = AnchorStyles.Left;
            lbGeradorSenhasComprimento.Font = new Font("Arial", 12.75F);
            lbGeradorSenhasComprimento.Location = new Point(19, 53);
            lbGeradorSenhasComprimento.Name = "lbGeradorSenhasComprimento";
            lbGeradorSenhasComprimento.Size = new Size(256, 19);
            lbGeradorSenhasComprimento.TabIndex = 27;
            lbGeradorSenhasComprimento.Text = "Comprimento da senha:";
            lbGeradorSenhasComprimento.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbGerarSenhasComprimento
            // 
            tbGeradorSenhasComprimento.Anchor = AnchorStyles.Left;
            tbGeradorSenhasComprimento.Location = new Point(19, 75);
            tbGeradorSenhasComprimento.Maximum = 50;
            tbGeradorSenhasComprimento.Minimum = 8;
            tbGeradorSenhasComprimento.Name = "tbGerarSenhasComprimento";
            tbGeradorSenhasComprimento.Size = new Size(256, 45);
            tbGeradorSenhasComprimento.TabIndex = 30;
            tbGeradorSenhasComprimento.Value = SenhaConfig.comprimento;
            tbGeradorSenhasComprimento.Scroll += tbGerarSenhasComprimento_Scroll;
            // 
            // cbGeradorSenhasCaracterEs
            // 
            cbGeradorSenhasCaracterEs.Anchor = AnchorStyles.Left;
            cbGeradorSenhasCaracterEs.Checked = SenhaConfig.CaracterEs;
            cbGeradorSenhasCaracterEs.Location = new Point(19, 182);
            cbGeradorSenhasCaracterEs.Name = "cbGeradorSenhasCaracterEs";
            cbGeradorSenhasCaracterEs.Size = new Size(256, 30);
            cbGeradorSenhasCaracterEs.TabIndex = 31;
            cbGeradorSenhasCaracterEs.Text = "Caracteres especiais";
            cbGeradorSenhasCaracterEs.TextAlign = ContentAlignment.MiddleCenter;
            cbGeradorSenhasCaracterEs.UseVisualStyleBackColor = SenhaConfig.CaracterEs;
            // 
            // lbGeradorSenhasTitulo
            // 
            lbGeradorSenhasTitulo.Anchor = AnchorStyles.Left;
            lbGeradorSenhasTitulo.Font = new Font("Arial", 15F);
            lbGeradorSenhasTitulo.Location = new Point(19, 9);
            lbGeradorSenhasTitulo.Name = "lbGeradorSenhasTitulo";
            lbGeradorSenhasTitulo.Size = new Size(256, 34);
            lbGeradorSenhasTitulo.TabIndex = 32;
            lbGeradorSenhasTitulo.Text = "Configuração da geração";
            lbGeradorSenhasTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbGeradorSenhasLetrasMi
            // 
            cbGeradorSenhasLetrasMi.Anchor = AnchorStyles.Left;
            cbGeradorSenhasLetrasMi.Checked = SenhaConfig.letraMi;
            cbGeradorSenhasLetrasMi.Location = new Point(19, 146);
            cbGeradorSenhasLetrasMi.Name = "cbGeradorSenhasLetrasMi";
            cbGeradorSenhasLetrasMi.Size = new Size(256, 30);
            cbGeradorSenhasLetrasMi.TabIndex = 33;
            cbGeradorSenhasLetrasMi.Text = "Letras minúsculas";
            cbGeradorSenhasLetrasMi.TextAlign = ContentAlignment.MiddleCenter;
            cbGeradorSenhasLetrasMi.UseVisualStyleBackColor = SenhaConfig.letraMi;
            // 
            // lbGeradorSenhasComprimentoNumber
            // 
            lbGeradorSenhasComprimentoNumber.Anchor = AnchorStyles.Left;
            lbGeradorSenhasComprimentoNumber.Font = new Font("Arial", 12.75F);
            lbGeradorSenhasComprimentoNumber.Location = new Point(236, 53);
            lbGeradorSenhasComprimentoNumber.Name = "lbGeradorSenhasComprimentoNumber";
            lbGeradorSenhasComprimentoNumber.Size = new Size(39, 19);
            lbGeradorSenhasComprimentoNumber.TabIndex = 34;
            lbGeradorSenhasComprimentoNumber.Text = SenhaConfig.comprimento.ToString();
            lbGeradorSenhasComprimentoNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // GeradorSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(291, 287);
            Controls.Add(lbGeradorSenhasComprimentoNumber);
            Controls.Add(cbGeradorSenhasLetrasMi);
            Controls.Add(lbGeradorSenhasTitulo);
            Controls.Add(cbGeradorSenhasCaracterEs);
            Controls.Add(tbGeradorSenhasComprimento);
            Controls.Add(lbGeradorSenhasComprimento);
            Controls.Add(cbGeradorSenhasLetrasMa);
            Controls.Add(btGeradorSenhasSalvar);
            Controls.Add(btGeradorSenhasCancelar);
            Name = "GeradorSenhas";
            Text = "GeradorSenhas";
            ((System.ComponentModel.ISupportInitialize)tbGeradorSenhasComprimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
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