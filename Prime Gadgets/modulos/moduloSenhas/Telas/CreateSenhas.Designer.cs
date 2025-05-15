namespace Prime_Gadgets.modulos.moduloSenhas
{
    partial class CreateSenhas
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
            lbCreateSenhasTitulo = new Label();
            lbCreateSenhasNome = new Label();
            lbCreateSenhasEmail = new Label();
            lbCreateSenhasSenha = new Label();
            lbCreateSenhasOrigem = new Label();
            lbCreateSenhasEmailInvalido = new Label();
            campCreateSenhasNome = new TextBox();
            campCreateSenhasEmail = new TextBox();
            campCreateSenhasSenha = new TextBox();
            campCreateSenhasOrigem = new TextBox();
            btCreateSenhasCriar = new Button();
            btCreateSenhasCancelar = new Button();
            btCreateSenhasGerar = new Button();
            btCreateSenhasMostrar = new Button();
            lbCreateSenhasSenhaInvalida = new Label();
            SuspendLayout();
            // 
            // lbCreateSenhasTitulo
            // 
            lbCreateSenhasTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasTitulo.AutoSize = true;
            lbCreateSenhasTitulo.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCreateSenhasTitulo.Location = new Point(81, 33);
            lbCreateSenhasTitulo.Name = "lbCreateSenhasTitulo";
            lbCreateSenhasTitulo.Size = new Size(207, 37);
            lbCreateSenhasTitulo.TabIndex = 0;
            lbCreateSenhasTitulo.Text = "Adicionar Conta";
            // 
            // lbCreateSenhasNome
            // 
            lbCreateSenhasNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasNome.AutoSize = true;
            lbCreateSenhasNome.Location = new Point(12, 109);
            lbCreateSenhasNome.Name = "lbCreateSenhasNome";
            lbCreateSenhasNome.Size = new Size(99, 15);
            lbCreateSenhasNome.TabIndex = 1;
            lbCreateSenhasNome.Text = "Nome de Usuário";
            // 
            // lbCreateSenhasEmail
            // 
            lbCreateSenhasEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasEmail.AutoSize = true;
            lbCreateSenhasEmail.Location = new Point(12, 149);
            lbCreateSenhasEmail.Name = "lbCreateSenhasEmail";
            lbCreateSenhasEmail.Size = new Size(41, 15);
            lbCreateSenhasEmail.TabIndex = 2;
            lbCreateSenhasEmail.Text = "E-mail";
            // 
            // lbCreateSenhasSenha
            // 
            lbCreateSenhasSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasSenha.AutoSize = true;
            lbCreateSenhasSenha.Location = new Point(12, 198);
            lbCreateSenhasSenha.Name = "lbCreateSenhasSenha";
            lbCreateSenhasSenha.Size = new Size(39, 15);
            lbCreateSenhasSenha.TabIndex = 3;
            lbCreateSenhasSenha.Text = "Senha";
            // 
            // lbCreateSenhasOrigem
            // 
            lbCreateSenhasOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasOrigem.AutoSize = true;
            lbCreateSenhasOrigem.Location = new Point(12, 247);
            lbCreateSenhasOrigem.Name = "lbCreateSenhasOrigem";
            lbCreateSenhasOrigem.Size = new Size(47, 15);
            lbCreateSenhasOrigem.TabIndex = 4;
            lbCreateSenhasOrigem.Text = "Origem";
            // 
            // lbCreateSenhasEmailInvalido
            // 
            lbCreateSenhasEmailInvalido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasEmailInvalido.AutoSize = true;
            lbCreateSenhasEmailInvalido.Location = new Point(136, 171);
            lbCreateSenhasEmailInvalido.Name = "lbCreateSenhasEmailInvalido";
            lbCreateSenhasEmailInvalido.Size = new Size(86, 15);
            lbCreateSenhasEmailInvalido.TabIndex = 5;
            lbCreateSenhasEmailInvalido.Text = "E-mail inválido!";
            // 
            // lbCreateSenhasSenhaInvalida
            // 
            lbCreateSenhasSenhaInvalida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasSenhaInvalida.AutoSize = true;
            lbCreateSenhasSenhaInvalida.Location = new Point(136, 221);
            lbCreateSenhasSenhaInvalida.Name = "lbCreateSenhasSenhaInvalida";
            lbCreateSenhasSenhaInvalida.Size = new Size(83, 15);
            lbCreateSenhasSenhaInvalida.TabIndex = 14;
            lbCreateSenhasSenhaInvalida.Text = "Senha inválida!";
            // 
            // campCreateSenhasNome
            // 
            campCreateSenhasNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campCreateSenhasNome.Location = new Point(136, 106);
            campCreateSenhasNome.Name = "campCreateSenhasNome";
            campCreateSenhasNome.Size = new Size(100, 23);
            campCreateSenhasNome.TabIndex = 6;
            campCreateSenhasNome.TextChanged += Campos_TextChanged;
            // 
            // campCreateSenhasEmail
            // 
            campCreateSenhasEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campCreateSenhasEmail.Location = new Point(136, 146);
            campCreateSenhasEmail.Name = "campCreateSenhasEmail";
            campCreateSenhasEmail.Size = new Size(100, 23);
            campCreateSenhasEmail.TabIndex = 7;
            campCreateSenhasEmail.TextChanged += Campos_TextChanged;
            campCreateSenhasEmail.Validating += campCreateSenhasEmail_Validating;
            // 
            // campCreateSenhasSenha
            // 
            campCreateSenhasSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campCreateSenhasSenha.Location = new Point(136, 195);
            campCreateSenhasSenha.Name = "campCreateSenhasSenha";
            campCreateSenhasSenha.Size = new Size(100, 23);
            campCreateSenhasSenha.TabIndex = 8;
            campCreateSenhasSenha.UseSystemPasswordChar = true;
            campCreateSenhasSenha.TextChanged += Campos_TextChanged;
            campCreateSenhasSenha.Validating += PasswordValidator;
            // 
            // campCreateSenhasOrigem
            // 
            campCreateSenhasOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campCreateSenhasOrigem.Location = new Point(136, 244);
            campCreateSenhasOrigem.Name = "campCreateSenhasOrigem";
            campCreateSenhasOrigem.Size = new Size(100, 23);
            campCreateSenhasOrigem.TabIndex = 9;
            campCreateSenhasOrigem.TextChanged += Campos_TextChanged;
            // 
            // btCreateSenhasCriar
            // 
            btCreateSenhasCriar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btCreateSenhasCriar.Location = new Point(42, 367);
            btCreateSenhasCriar.Name = "btCreateSenhasCriar";
            btCreateSenhasCriar.Size = new Size(118, 37);
            btCreateSenhasCriar.TabIndex = 10;
            btCreateSenhasCriar.Text = "Criar";
            btCreateSenhasCriar.UseVisualStyleBackColor = true;
            btCreateSenhasCriar.EnabledChanged += btCreateSenhasCriar_EnabledChanged;
            btCreateSenhasCriar.Click += btCreateSenhasCriar_Click;
            // 
            // btCreateSenhasCancelar
            // 
            btCreateSenhasCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btCreateSenhasCancelar.Location = new Point(196, 367);
            btCreateSenhasCancelar.Name = "btCreateSenhasCancelar";
            btCreateSenhasCancelar.Size = new Size(118, 37);
            btCreateSenhasCancelar.TabIndex = 11;
            btCreateSenhasCancelar.Text = "Cancelar";
            btCreateSenhasCancelar.UseVisualStyleBackColor = true;
            btCreateSenhasCancelar.Click += btCreateSenhasCancelar_Click;
            // 
            // btCreateSenhasGerar
            // 
            btCreateSenhasGerar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btCreateSenhasGerar.Location = new Point(283, 187);
            btCreateSenhasGerar.Name = "btCreateSenhasGerar";
            btCreateSenhasGerar.Size = new Size(83, 37);
            btCreateSenhasGerar.TabIndex = 12;
            btCreateSenhasGerar.Text = "Gerar senha";
            btCreateSenhasGerar.UseVisualStyleBackColor = true;
            btCreateSenhasGerar.Click += btCreateSenhasGerar_Click;
            // 
            // btCreateSenhasMostrar
            // 
            btCreateSenhasMostrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btCreateSenhasMostrar.Location = new Point(294, 230);
            btCreateSenhasMostrar.Name = "btCreateSenhasMostrar";
            btCreateSenhasMostrar.Size = new Size(72, 37);
            btCreateSenhasMostrar.TabIndex = 13;
            btCreateSenhasMostrar.Text = "Mostrar";
            btCreateSenhasMostrar.UseVisualStyleBackColor = true;
            btCreateSenhasMostrar.Click += btCreateSenhasMostrar_Click;
            // 
            // CreateSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(367, 450);
            Controls.Add(lbCreateSenhasSenhaInvalida);
            Controls.Add(btCreateSenhasMostrar);
            Controls.Add(btCreateSenhasGerar);
            Controls.Add(btCreateSenhasCancelar);
            Controls.Add(btCreateSenhasCriar);
            Controls.Add(campCreateSenhasOrigem);
            Controls.Add(campCreateSenhasSenha);
            Controls.Add(campCreateSenhasEmail);
            Controls.Add(campCreateSenhasNome);
            Controls.Add(lbCreateSenhasEmailInvalido);
            Controls.Add(lbCreateSenhasOrigem);
            Controls.Add(lbCreateSenhasSenha);
            Controls.Add(lbCreateSenhasEmail);
            Controls.Add(lbCreateSenhasNome);
            Controls.Add(lbCreateSenhasTitulo);
            Name = "CreateSenhas";
            Text = "CreateSenhas";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            SizeGripStyle = SizeGripStyle.Hide;
            ControlBox = false;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreateSenhasTitulo;
        private Label lbCreateSenhasNome;
        private Label lbCreateSenhasEmail;
        private Label lbCreateSenhasSenha;
        private Label lbCreateSenhasOrigem;
        private Label lbCreateSenhasEmailInvalido;
        private TextBox campCreateSenhasNome;
        private TextBox campCreateSenhasEmail;
        private TextBox campCreateSenhasSenha;
        private TextBox campCreateSenhasOrigem;
        private Button btCreateSenhasCriar;
        private Button btCreateSenhasCancelar;
        private Button btCreateSenhasGerar;
        private Button btCreateSenhasMostrar;
        private Label lbCreateSenhasSenhaInvalida;
    }
}