namespace Prime_Gadgets.modulos.moduloSenhas
{
    partial class UpdateSenhas
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
            btUpdateSenhasCancelar = new Button();
            btUpdateSenhasAtualizar = new Button();
            campUpdateSenhasOrigem = new TextBox();
            campUpdateSenhasSenha = new TextBox();
            campUpdateSenhasEmail = new TextBox();
            campUpdateSenhasNome = new TextBox();
            lbUpdateSenhasEmailInvalido = new Label();
            lbUpdateSenhasOrigem = new Label();
            lbUpdateSenhasSenha = new Label();
            lbUpdateSenhasEmail = new Label();
            lbUpdateSenhasNome = new Label();
            lbUpdateSenhasTitulo = new Label();
            campUpdateSenhasId = new TextBox();
            lbUpdateSenhasId = new Label();
            lbUpdateSenhasSenhaInvalida = new Label();
            btUpdateSenhasMostrar = new Button();
            btUpdateSenhasGerar = new Button();
            SuspendLayout();
            // 
            // btUpdateSenhasCancelar
            // 
            btUpdateSenhasCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btUpdateSenhasCancelar.Location = new Point(216, 374);
            btUpdateSenhasCancelar.Name = "btUpdateSenhasCancelar";
            btUpdateSenhasCancelar.Size = new Size(118, 37);
            btUpdateSenhasCancelar.TabIndex = 23;
            btUpdateSenhasCancelar.Text = "Cancelar";
            btUpdateSenhasCancelar.UseVisualStyleBackColor = true;
            btUpdateSenhasCancelar.Click += btUpdateSenhasCancelar_Click;
            // 
            // btUpdateSenhasAtualizar
            // 
            btUpdateSenhasAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btUpdateSenhasAtualizar.Location = new Point(62, 374);
            btUpdateSenhasAtualizar.Name = "btUpdateSenhasAtualizar";
            btUpdateSenhasAtualizar.Size = new Size(118, 37);
            btUpdateSenhasAtualizar.TabIndex = 22;
            btUpdateSenhasAtualizar.Text = "Atualizar";
            btUpdateSenhasAtualizar.UseVisualStyleBackColor = true;
            btUpdateSenhasAtualizar.Click += btUpdateSenhasAtualizar_Click;
            // 
            // campUpdateSenhasOrigem
            // 
            campUpdateSenhasOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasOrigem.Location = new Point(156, 234);
            campUpdateSenhasOrigem.Name = "campUpdateSenhasOrigem";
            campUpdateSenhasOrigem.Size = new Size(100, 23);
            campUpdateSenhasOrigem.TabIndex = 21;
            // 
            // campUpdateSenhasSenha
            // 
            campUpdateSenhasSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasSenha.Location = new Point(156, 196);
            campUpdateSenhasSenha.Name = "campUpdateSenhasSenha";
            campUpdateSenhasSenha.Size = new Size(100, 23);
            campUpdateSenhasSenha.TabIndex = 20;
            campUpdateSenhasSenha.UseSystemPasswordChar = true;
            campUpdateSenhasSenha.TextChanged += Campos_TextChanged;
            campUpdateSenhasSenha.Validating += PasswordValidator;
            // 
            // campUpdateSenhasEmail
            // 
            campUpdateSenhasEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasEmail.Location = new Point(156, 153);
            campUpdateSenhasEmail.Name = "campUpdateSenhasEmail";
            campUpdateSenhasEmail.Size = new Size(100, 23);
            campUpdateSenhasEmail.TabIndex = 19;
            campUpdateSenhasEmail.Validating += campUpdateSenhasEmail_Validating;
            // 
            // campUpdateSenhasNome
            // 
            campUpdateSenhasNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasNome.Location = new Point(156, 113);
            campUpdateSenhasNome.Name = "campUpdateSenhasNome";
            campUpdateSenhasNome.Size = new Size(100, 23);
            campUpdateSenhasNome.TabIndex = 18;
            campUpdateSenhasNome.KeyPress += campUpdateSenhasNome_KeyPress;
            // 
            // lbUpdateSenhasEmailInvalido
            // 
            lbUpdateSenhasEmailInvalido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasEmailInvalido.AutoSize = true;
            lbUpdateSenhasEmailInvalido.Location = new Point(156, 178);
            lbUpdateSenhasEmailInvalido.Name = "lbUpdateSenhasEmailInvalido";
            lbUpdateSenhasEmailInvalido.Size = new Size(86, 15);
            lbUpdateSenhasEmailInvalido.TabIndex = 17;
            lbUpdateSenhasEmailInvalido.Text = "E-mail inválido";
            // 
            // lbUpdateSenhasOrigem
            // 
            lbUpdateSenhasOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasOrigem.AutoSize = true;
            lbUpdateSenhasOrigem.Location = new Point(32, 237);
            lbUpdateSenhasOrigem.Name = "lbUpdateSenhasOrigem";
            lbUpdateSenhasOrigem.Size = new Size(47, 15);
            lbUpdateSenhasOrigem.TabIndex = 16;
            lbUpdateSenhasOrigem.Text = "Origem";
            // 
            // lbUpdateSenhasSenha
            // 
            lbUpdateSenhasSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasSenha.AutoSize = true;
            lbUpdateSenhasSenha.Location = new Point(32, 199);
            lbUpdateSenhasSenha.Name = "lbUpdateSenhasSenha";
            lbUpdateSenhasSenha.Size = new Size(39, 15);
            lbUpdateSenhasSenha.TabIndex = 15;
            lbUpdateSenhasSenha.Text = "Senha";
            // 
            // lbUpdateSenhasEmail
            // 
            lbUpdateSenhasEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasEmail.AutoSize = true;
            lbUpdateSenhasEmail.Location = new Point(32, 156);
            lbUpdateSenhasEmail.Name = "lbUpdateSenhasEmail";
            lbUpdateSenhasEmail.Size = new Size(41, 15);
            lbUpdateSenhasEmail.TabIndex = 14;
            lbUpdateSenhasEmail.Text = "E-mail";
            // 
            // lbUpdateSenhasNome
            // 
            lbUpdateSenhasNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasNome.AutoSize = true;
            lbUpdateSenhasNome.Location = new Point(32, 116);
            lbUpdateSenhasNome.Name = "lbUpdateSenhasNome";
            lbUpdateSenhasNome.Size = new Size(99, 15);
            lbUpdateSenhasNome.TabIndex = 13;
            lbUpdateSenhasNome.Text = "Nome de Usuário";
            // 
            // lbUpdateSenhasTitulo
            // 
            lbUpdateSenhasTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasTitulo.AutoSize = true;
            lbUpdateSenhasTitulo.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUpdateSenhasTitulo.Location = new Point(101, 40);
            lbUpdateSenhasTitulo.Name = "lbUpdateSenhasTitulo";
            lbUpdateSenhasTitulo.Size = new Size(199, 37);
            lbUpdateSenhasTitulo.TabIndex = 12;
            lbUpdateSenhasTitulo.Text = "Atualizar Conta";
            // 
            // campUpdateSenhasId
            // 
            campUpdateSenhasId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasId.Location = new Point(156, 80);
            campUpdateSenhasId.Name = "campUpdateSenhasId";
            campUpdateSenhasId.Size = new Size(100, 23);
            campUpdateSenhasId.TabIndex = 25;
            campUpdateSenhasId.KeyPress += campUpdateSenhasId_KeyPress;
            // 
            // lbUpdateSenhasId
            // 
            lbUpdateSenhasId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasId.AutoSize = true;
            lbUpdateSenhasId.Location = new Point(32, 83);
            lbUpdateSenhasId.Name = "lbUpdateSenhasId";
            lbUpdateSenhasId.Size = new Size(18, 15);
            lbUpdateSenhasId.TabIndex = 24;
            lbUpdateSenhasId.Text = "ID";
            // 
            // lbUpdateSenhasSenhaInvalida
            // 
            lbUpdateSenhasSenhaInvalida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasSenhaInvalida.AutoSize = true;
            lbUpdateSenhasSenhaInvalida.Location = new Point(153, 217);
            lbUpdateSenhasSenhaInvalida.Name = "lbUpdateSenhasSenhaInvalida";
            lbUpdateSenhasSenhaInvalida.Size = new Size(86, 15);
            lbUpdateSenhasSenhaInvalida.TabIndex = 28;
            lbUpdateSenhasSenhaInvalida.Text = "Senha inválida!";
            // 
            // btUpdateSenhasMostrar
            // 
            btUpdateSenhasMostrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btUpdateSenhasMostrar.Location = new Point(292, 225);
            btUpdateSenhasMostrar.Name = "btUpdateSenhasMostrar";
            btUpdateSenhasMostrar.Size = new Size(72, 37);
            btUpdateSenhasMostrar.TabIndex = 27;
            btUpdateSenhasMostrar.Text = "Mostrar";
            btUpdateSenhasMostrar.UseVisualStyleBackColor = true;
            btUpdateSenhasMostrar.Click += btUpdateSenhasMostrar_Click;
            // 
            // btUpdateSenhasGerar
            // 
            btUpdateSenhasGerar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btUpdateSenhasGerar.Location = new Point(281, 182);
            btUpdateSenhasGerar.Name = "btUpdateSenhasGerar";
            btUpdateSenhasGerar.Size = new Size(83, 37);
            btUpdateSenhasGerar.TabIndex = 26;
            btUpdateSenhasGerar.Text = "Gerar senha";
            btUpdateSenhasGerar.UseVisualStyleBackColor = true;
            btUpdateSenhasGerar.Click += btUpdateSenhasGerar_Click;
            // 
            // UpdateSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(367, 450);
            Controls.Add(lbUpdateSenhasSenhaInvalida);
            Controls.Add(btUpdateSenhasMostrar);
            Controls.Add(btUpdateSenhasGerar);
            Controls.Add(campUpdateSenhasId);
            Controls.Add(lbUpdateSenhasId);
            Controls.Add(btUpdateSenhasCancelar);
            Controls.Add(btUpdateSenhasAtualizar);
            Controls.Add(campUpdateSenhasOrigem);
            Controls.Add(campUpdateSenhasSenha);
            Controls.Add(campUpdateSenhasEmail);
            Controls.Add(campUpdateSenhasNome);
            Controls.Add(lbUpdateSenhasEmailInvalido);
            Controls.Add(lbUpdateSenhasOrigem);
            Controls.Add(lbUpdateSenhasSenha);
            Controls.Add(lbUpdateSenhasEmail);
            Controls.Add(lbUpdateSenhasNome);
            Controls.Add(lbUpdateSenhasTitulo);
            Name = "UpdateSenhas";
            Text = "UpdateSenhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btUpdateSenhasCancelar;
        private Button btUpdateSenhasAtualizar;
        private TextBox campUpdateSenhasOrigem;
        private TextBox campUpdateSenhasSenha;
        private TextBox campUpdateSenhasEmail;
        private TextBox campUpdateSenhasNome;
        private Label lbUpdateSenhasEmailInvalido;
        private Label lbUpdateSenhasOrigem;
        private Label lbUpdateSenhasSenha;
        private Label lbUpdateSenhasEmail;
        private Label lbUpdateSenhasNome;
        private Label lbUpdateSenhasTitulo;
        private TextBox campUpdateSenhasId;
        private Label lbUpdateSenhasId;
        private Label lbUpdateSenhasSenhaInvalida;
        private Button btUpdateSenhasMostrar;
        private Button btUpdateSenhasGerar;
    }
}