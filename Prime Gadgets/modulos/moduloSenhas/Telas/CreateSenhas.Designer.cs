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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSenhas));
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
            toolTip1 = new ToolTip(components);
            btCreateSenhasGeradorConfig = new Button();
            toolTip2 = new ToolTip(components);
            SuspendLayout();
            // 
            // lbCreateSenhasTitulo
            // 
            lbCreateSenhasTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasTitulo.AutoSize = true;
            lbCreateSenhasTitulo.Font = new Font("Arial", 24F);
            lbCreateSenhasTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateSenhasTitulo.Location = new Point(105, 9);
            lbCreateSenhasTitulo.Margin = new Padding(4, 0, 4, 0);
            lbCreateSenhasTitulo.Name = "lbCreateSenhasTitulo";
            lbCreateSenhasTitulo.Size = new Size(246, 36);
            lbCreateSenhasTitulo.TabIndex = 0;
            lbCreateSenhasTitulo.Text = "Adicionar Senha";
            // 
            // lbCreateSenhasNome
            // 
            lbCreateSenhasNome.AutoSize = true;
            lbCreateSenhasNome.Font = new Font("Arial", 12.75F);
            lbCreateSenhasNome.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateSenhasNome.Location = new Point(24, 86);
            lbCreateSenhasNome.Margin = new Padding(4, 0, 4, 0);
            lbCreateSenhasNome.Name = "lbCreateSenhasNome";
            lbCreateSenhasNome.Size = new Size(135, 19);
            lbCreateSenhasNome.TabIndex = 1;
            lbCreateSenhasNome.Text = "Nome de Usuário";
            // 
            // lbCreateSenhasEmail
            // 
            lbCreateSenhasEmail.AutoSize = true;
            lbCreateSenhasEmail.Font = new Font("Arial", 12.75F);
            lbCreateSenhasEmail.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateSenhasEmail.Location = new Point(58, 112);
            lbCreateSenhasEmail.Margin = new Padding(4, 0, 4, 0);
            lbCreateSenhasEmail.Name = "lbCreateSenhasEmail";
            lbCreateSenhasEmail.Size = new Size(55, 19);
            lbCreateSenhasEmail.TabIndex = 2;
            lbCreateSenhasEmail.Text = "E-mail";
            // 
            // lbCreateSenhasSenha
            // 
            lbCreateSenhasSenha.AutoSize = true;
            lbCreateSenhasSenha.Font = new Font("Arial", 12.75F);
            lbCreateSenhasSenha.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateSenhasSenha.Location = new Point(56, 164);
            lbCreateSenhasSenha.Margin = new Padding(4, 0, 4, 0);
            lbCreateSenhasSenha.Name = "lbCreateSenhasSenha";
            lbCreateSenhasSenha.Size = new Size(56, 19);
            lbCreateSenhasSenha.TabIndex = 3;
            lbCreateSenhasSenha.Text = "Senha";
            // 
            // lbCreateSenhasOrigem
            // 
            lbCreateSenhasOrigem.AutoSize = true;
            lbCreateSenhasOrigem.Font = new Font("Arial", 12.75F);
            lbCreateSenhasOrigem.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateSenhasOrigem.Location = new Point(54, 138);
            lbCreateSenhasOrigem.Margin = new Padding(4, 0, 4, 0);
            lbCreateSenhasOrigem.Name = "lbCreateSenhasOrigem";
            lbCreateSenhasOrigem.Size = new Size(62, 19);
            lbCreateSenhasOrigem.TabIndex = 4;
            lbCreateSenhasOrigem.Text = "Origem";
            // 
            // lbCreateSenhasEmailInvalido
            // 
            lbCreateSenhasEmailInvalido.AutoSize = true;
            lbCreateSenhasEmailInvalido.Font = new Font("Arial", 9F);
            lbCreateSenhasEmailInvalido.ForeColor = Color.FromArgb(230, 34, 34);
            lbCreateSenhasEmailInvalido.Location = new Point(30, 310);
            lbCreateSenhasEmailInvalido.Margin = new Padding(4, 0, 4, 0);
            lbCreateSenhasEmailInvalido.Name = "lbCreateSenhasEmailInvalido";
            lbCreateSenhasEmailInvalido.Size = new Size(91, 15);
            lbCreateSenhasEmailInvalido.TabIndex = 5;
            lbCreateSenhasEmailInvalido.Text = "E-mail inválido!";
            // 
            // campCreateSenhasNome
            // 
            campCreateSenhasNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campCreateSenhasNome.BackColor = Color.FromArgb(255, 252, 237);
            campCreateSenhasNome.BorderStyle = BorderStyle.None;
            campCreateSenhasNome.Font = new Font("Arial", 12.75F);
            campCreateSenhasNome.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateSenhasNome.Location = new Point(172, 85);
            campCreateSenhasNome.Margin = new Padding(4, 3, 4, 3);
            campCreateSenhasNome.Name = "campCreateSenhasNome";
            campCreateSenhasNome.Size = new Size(226, 20);
            campCreateSenhasNome.TabIndex = 6;
            campCreateSenhasNome.TextChanged += Campos_TextChanged;
            // 
            // campCreateSenhasEmail
            // 
            campCreateSenhasEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campCreateSenhasEmail.BackColor = Color.FromArgb(255, 252, 237);
            campCreateSenhasEmail.BorderStyle = BorderStyle.None;
            campCreateSenhasEmail.Font = new Font("Arial", 12.75F);
            campCreateSenhasEmail.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateSenhasEmail.Location = new Point(172, 111);
            campCreateSenhasEmail.Margin = new Padding(4, 3, 4, 3);
            campCreateSenhasEmail.Name = "campCreateSenhasEmail";
            campCreateSenhasEmail.Size = new Size(226, 20);
            campCreateSenhasEmail.TabIndex = 7;
            campCreateSenhasEmail.TextChanged += Campos_TextChanged;
            campCreateSenhasEmail.Validating += campCreateSenhasEmail_Validating;
            // 
            // campCreateSenhasSenha
            // 
            campCreateSenhasSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campCreateSenhasSenha.BackColor = Color.FromArgb(255, 252, 237);
            campCreateSenhasSenha.BorderStyle = BorderStyle.None;
            campCreateSenhasSenha.Font = new Font("Arial", 12.75F);
            campCreateSenhasSenha.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateSenhasSenha.Location = new Point(172, 163);
            campCreateSenhasSenha.Margin = new Padding(4, 3, 4, 3);
            campCreateSenhasSenha.Name = "campCreateSenhasSenha";
            campCreateSenhasSenha.Size = new Size(226, 20);
            campCreateSenhasSenha.TabIndex = 8;
            campCreateSenhasSenha.UseSystemPasswordChar = true;
            campCreateSenhasSenha.TextChanged += Campos_TextChanged;
            campCreateSenhasSenha.Validating += PasswordValidator;
            // 
            // campCreateSenhasOrigem
            // 
            campCreateSenhasOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campCreateSenhasOrigem.BackColor = Color.FromArgb(255, 252, 237);
            campCreateSenhasOrigem.BorderStyle = BorderStyle.None;
            campCreateSenhasOrigem.Font = new Font("Arial", 12.75F);
            campCreateSenhasOrigem.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateSenhasOrigem.Location = new Point(172, 137);
            campCreateSenhasOrigem.Margin = new Padding(4, 3, 4, 3);
            campCreateSenhasOrigem.Name = "campCreateSenhasOrigem";
            campCreateSenhasOrigem.Size = new Size(226, 20);
            campCreateSenhasOrigem.TabIndex = 9;
            campCreateSenhasOrigem.TextChanged += Campos_TextChanged;
            // 
            // btCreateSenhasCriar
            // 
            btCreateSenhasCriar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateSenhasCriar.FlatAppearance.BorderSize = 0;
            btCreateSenhasCriar.FlatStyle = FlatStyle.Flat;
            btCreateSenhasCriar.Font = new Font("Arial", 12.75F);
            btCreateSenhasCriar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateSenhasCriar.Location = new Point(30, 260);
            btCreateSenhasCriar.Margin = new Padding(4, 3, 4, 3);
            btCreateSenhasCriar.Name = "btCreateSenhasCriar";
            btCreateSenhasCriar.Size = new Size(118, 37);
            btCreateSenhasCriar.TabIndex = 10;
            btCreateSenhasCriar.Text = "Criar";
            btCreateSenhasCriar.UseVisualStyleBackColor = false;
            btCreateSenhasCriar.EnabledChanged += btCreateSenhasCriar_EnabledChanged;
            btCreateSenhasCriar.Click += btCreateSenhasCriar_Click;
            // 
            // btCreateSenhasCancelar
            // 
            btCreateSenhasCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCreateSenhasCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateSenhasCancelar.FlatAppearance.BorderSize = 0;
            btCreateSenhasCancelar.FlatStyle = FlatStyle.Flat;
            btCreateSenhasCancelar.Font = new Font("Arial", 12.75F);
            btCreateSenhasCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateSenhasCancelar.Location = new Point(279, 260);
            btCreateSenhasCancelar.Margin = new Padding(4, 3, 4, 3);
            btCreateSenhasCancelar.Name = "btCreateSenhasCancelar";
            btCreateSenhasCancelar.Size = new Size(118, 37);
            btCreateSenhasCancelar.TabIndex = 11;
            btCreateSenhasCancelar.Text = "Cancelar";
            btCreateSenhasCancelar.UseVisualStyleBackColor = false;
            btCreateSenhasCancelar.Click += btCreateSenhasCancelar_Click;
            // 
            // btCreateSenhasGerar
            // 
            btCreateSenhasGerar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateSenhasGerar.FlatAppearance.BorderSize = 0;
            btCreateSenhasGerar.FlatStyle = FlatStyle.Flat;
            btCreateSenhasGerar.Font = new Font("Arial", 12.75F);
            btCreateSenhasGerar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateSenhasGerar.Image = (Image)resources.GetObject("btCreateSenhasGerar.Image");
            btCreateSenhasGerar.Location = new Point(172, 189);
            btCreateSenhasGerar.Margin = new Padding(4, 3, 4, 3);
            btCreateSenhasGerar.Name = "btCreateSenhasGerar";
            btCreateSenhasGerar.Size = new Size(40, 40);
            btCreateSenhasGerar.TabIndex = 12;
            toolTip1.SetToolTip(btCreateSenhasGerar, "Gerar senha aleatória com os padrões de segurança");
            btCreateSenhasGerar.UseVisualStyleBackColor = false;
            btCreateSenhasGerar.Click += btCreateSenhasGerar_Click;
            // 
            // btCreateSenhasMostrar
            // 
            btCreateSenhasMostrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCreateSenhasMostrar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateSenhasMostrar.FlatAppearance.BorderSize = 0;
            btCreateSenhasMostrar.FlatStyle = FlatStyle.Flat;
            btCreateSenhasMostrar.Font = new Font("Arial", 12.75F);
            btCreateSenhasMostrar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateSenhasMostrar.Image = (Image)resources.GetObject("btCreateSenhasMostrar.Image");
            btCreateSenhasMostrar.Location = new Point(357, 189);
            btCreateSenhasMostrar.Margin = new Padding(4, 3, 4, 3);
            btCreateSenhasMostrar.Name = "btCreateSenhasMostrar";
            btCreateSenhasMostrar.Size = new Size(40, 40);
            btCreateSenhasMostrar.TabIndex = 13;
            toolTip2.SetToolTip(btCreateSenhasMostrar, "Mostrar/Ocultar senha");
            btCreateSenhasMostrar.UseVisualStyleBackColor = false;
            btCreateSenhasMostrar.Click += btCreateSenhasMostrar_Click;
            // 
            // lbCreateSenhasSenhaInvalida
            // 
            lbCreateSenhasSenhaInvalida.AutoSize = true;
            lbCreateSenhasSenhaInvalida.Font = new Font("Arial", 9F);
            lbCreateSenhasSenhaInvalida.ForeColor = Color.FromArgb(230, 34, 34);
            lbCreateSenhasSenhaInvalida.Location = new Point(30, 310);
            lbCreateSenhasSenhaInvalida.Margin = new Padding(4, 0, 4, 0);
            lbCreateSenhasSenhaInvalida.Name = "lbCreateSenhasSenhaInvalida";
            lbCreateSenhasSenhaInvalida.Size = new Size(91, 45);
            lbCreateSenhasSenhaInvalida.TabIndex = 14;
            lbCreateSenhasSenhaInvalida.Text = "Senha inválida!\r\na\r\na";
            // 
            // btCreateSenhasGeradorConfig
            // 
            btCreateSenhasGeradorConfig.Anchor = AnchorStyles.Top;
            btCreateSenhasGeradorConfig.BackColor = Color.FromArgb(230, 34, 34);
            btCreateSenhasGeradorConfig.FlatAppearance.BorderSize = 0;
            btCreateSenhasGeradorConfig.FlatStyle = FlatStyle.Flat;
            btCreateSenhasGeradorConfig.Image = (Image)resources.GetObject("btCreateSenhasGeradorConfig.Image");
            btCreateSenhasGeradorConfig.Location = new Point(265, 189);
            btCreateSenhasGeradorConfig.Margin = new Padding(4, 3, 4, 3);
            btCreateSenhasGeradorConfig.Name = "btCreateSenhasGeradorConfig";
            btCreateSenhasGeradorConfig.Size = new Size(40, 40);
            btCreateSenhasGeradorConfig.TabIndex = 30;
            toolTip1.SetToolTip(btCreateSenhasGeradorConfig, "Configurar geração de senhas com os padrões de segurança");
            btCreateSenhasGeradorConfig.UseVisualStyleBackColor = false;
            btCreateSenhasGeradorConfig.Click += btCreateSenhasGeradorConfig_Click;
            // 
            // CreateSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(438, 364);
            Controls.Add(btCreateSenhasGeradorConfig);
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
            Controls.Add(lbCreateSenhasSenhaInvalida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateSenhas";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Adicionar Senha";
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
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Button btCreateSenhasGeradorConfig;
    }
}