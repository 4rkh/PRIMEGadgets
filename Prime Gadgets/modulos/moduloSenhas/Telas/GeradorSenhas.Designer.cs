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
            cbGerarSenhasLetrasM = new CheckBox();
            lbGerarSenhasComprimento = new Label();
            tbGerarSenhasComprimento = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)tbGerarSenhasComprimento).BeginInit();
            SuspendLayout();
            // 
            // btGeradorSenhasCancelar
            // 
            btGeradorSenhasCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btGeradorSenhasCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btGeradorSenhasCancelar.FlatAppearance.BorderSize = 0;
            btGeradorSenhasCancelar.FlatStyle = FlatStyle.Flat;
            btGeradorSenhasCancelar.Font = new Font("Arial", 12.75F);
            btGeradorSenhasCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btGeradorSenhasCancelar.Location = new Point(398, 375);
            btGeradorSenhasCancelar.Name = "btGeradorSenhasCancelar";
            btGeradorSenhasCancelar.Size = new Size(118, 37);
            btGeradorSenhasCancelar.TabIndex = 24;
            btGeradorSenhasCancelar.Text = "Cancelar";
            btGeradorSenhasCancelar.UseVisualStyleBackColor = false;
            // 
            // btGeradorSenhasSalvar
            // 
            btGeradorSenhasSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btGeradorSenhasSalvar.BackColor = Color.FromArgb(230, 34, 34);
            btGeradorSenhasSalvar.FlatAppearance.BorderSize = 0;
            btGeradorSenhasSalvar.FlatStyle = FlatStyle.Flat;
            btGeradorSenhasSalvar.Font = new Font("Arial", 12.75F);
            btGeradorSenhasSalvar.ForeColor = Color.FromArgb(255, 252, 237);
            btGeradorSenhasSalvar.Location = new Point(260, 375);
            btGeradorSenhasSalvar.Name = "btGeradorSenhasSalvar";
            btGeradorSenhasSalvar.Size = new Size(118, 37);
            btGeradorSenhasSalvar.TabIndex = 25;
            btGeradorSenhasSalvar.Text = "Salvar";
            btGeradorSenhasSalvar.UseVisualStyleBackColor = false;
            // 
            // cbGerarSenhasLetrasM
            // 
            cbGerarSenhasLetrasM.Checked = true;
            cbGerarSenhasLetrasM.CheckState = CheckState.Checked;
            cbGerarSenhasLetrasM.Location = new Point(260, 251);
            cbGerarSenhasLetrasM.Name = "cbGerarSenhasLetrasM";
            cbGerarSenhasLetrasM.Size = new Size(256, 30);
            cbGerarSenhasLetrasM.TabIndex = 26;
            cbGerarSenhasLetrasM.Text = "Letras maiúsculas";
            cbGerarSenhasLetrasM.TextAlign = ContentAlignment.MiddleCenter;
            cbGerarSenhasLetrasM.UseVisualStyleBackColor = true;
            // 
            // lbGerarSenhasComprimento
            // 
            lbGerarSenhasComprimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbGerarSenhasComprimento.AutoSize = true;
            lbGerarSenhasComprimento.Font = new Font("Arial", 12.75F);
            lbGerarSenhasComprimento.Location = new Point(298, 180);
            lbGerarSenhasComprimento.Name = "lbGerarSenhasComprimento";
            lbGerarSenhasComprimento.Size = new Size(178, 19);
            lbGerarSenhasComprimento.TabIndex = 27;
            lbGerarSenhasComprimento.Text = "Comprimento da senha";
            // 
            // tbGerarSenhasComprimento
            // 
            tbGerarSenhasComprimento.Location = new Point(260, 202);
            tbGerarSenhasComprimento.Maximum = 50;
            tbGerarSenhasComprimento.Minimum = 8;
            tbGerarSenhasComprimento.Name = "tbGerarSenhasComprimento";
            tbGerarSenhasComprimento.Size = new Size(256, 45);
            tbGerarSenhasComprimento.TabIndex = 30;
            tbGerarSenhasComprimento.Value = 8;
            // 
            // GeradorSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(tbGerarSenhasComprimento);
            Controls.Add(lbGerarSenhasComprimento);
            Controls.Add(cbGerarSenhasLetrasM);
            Controls.Add(btGeradorSenhasSalvar);
            Controls.Add(btGeradorSenhasCancelar);
            Name = "GeradorSenhas";
            Text = "GeradorSenhas";
            ((System.ComponentModel.ISupportInitialize)tbGerarSenhasComprimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btGeradorSenhasCancelar;
        private Button btGeradorSenhasSalvar;
        private CheckBox cbGerarSenhasLetrasM;
        private Label lbGerarSenhasComprimento;
        private TrackBar tbGerarSenhasComprimento;
    }
}