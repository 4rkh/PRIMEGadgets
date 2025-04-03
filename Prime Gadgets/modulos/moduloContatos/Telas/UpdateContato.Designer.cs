namespace Prime_Gadgets.modulos.moduloContatos.Telas
{
    partial class UpdateContato
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
            lbUpdateContatosTitulo = new Label();
            btUpdateContatosCriar = new Button();
            btUpdateContatosCancelar = new Button();
            campUpdateContatosNome = new TextBox();
            campUpdateContatosSobrenome = new TextBox();
            campUpdateContatosTelefone = new TextBox();
            campUpdateContatosEmail = new TextBox();
            lbUpdateContatosNome = new Label();
            lbUpdateContatosSobrenome = new Label();
            lbUpdateContatosTelefone = new Label();
            lbUpdateContatosEmail = new Label();
            lbUpdateContatosId = new Label();
            campUpdateContatosId = new TextBox();
            lbUpdateContatosEmailInvalid = new Label();
            SuspendLayout();
            // 
            // lbUpdateContatosTitulo
            // 
            lbUpdateContatosTitulo.AutoSize = true;
            lbUpdateContatosTitulo.BackColor = Color.Transparent;
            lbUpdateContatosTitulo.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUpdateContatosTitulo.Location = new Point(68, 36);
            lbUpdateContatosTitulo.Name = "lbUpdateContatosTitulo";
            lbUpdateContatosTitulo.Size = new Size(221, 37);
            lbUpdateContatosTitulo.TabIndex = 0;
            lbUpdateContatosTitulo.Text = "Atualizar Contato";
            // 
            // btUpdateContatosCriar
            // 
            btUpdateContatosCriar.Location = new Point(47, 382);
            btUpdateContatosCriar.Name = "btUpdateContatosCriar";
            btUpdateContatosCriar.Size = new Size(118, 37);
            btUpdateContatosCriar.TabIndex = 1;
            btUpdateContatosCriar.Text = "Atualizar";
            btUpdateContatosCriar.UseVisualStyleBackColor = true;
            btUpdateContatosCriar.Click += btUpdateContatosAtualizar_Click;
            // 
            // btUpdateContatosCancelar
            // 
            btUpdateContatosCancelar.Location = new Point(199, 382);
            btUpdateContatosCancelar.Name = "btUpdateContatosCancelar";
            btUpdateContatosCancelar.Size = new Size(118, 37);
            btUpdateContatosCancelar.TabIndex = 2;
            btUpdateContatosCancelar.Text = "Cancelar";
            btUpdateContatosCancelar.UseVisualStyleBackColor = true;
            btUpdateContatosCancelar.Click += btUpdateContatosCancelar_Click;
            // 
            // campUpdateContatosNome
            // 
            campUpdateContatosNome.Location = new Point(131, 157);
            campUpdateContatosNome.Name = "campUpdateContatosNome";
            campUpdateContatosNome.Size = new Size(156, 23);
            campUpdateContatosNome.TabIndex = 4;
            campUpdateContatosNome.TextChanged += Campos_TextChanged;
            campUpdateContatosNome.KeyPress += campUpdateContatosNome_KeyPress;
            // 
            // campUpdateContatosSobrenome
            // 
            campUpdateContatosSobrenome.Location = new Point(131, 186);
            campUpdateContatosSobrenome.Name = "campUpdateContatosSobrenome";
            campUpdateContatosSobrenome.Size = new Size(156, 23);
            campUpdateContatosSobrenome.TabIndex = 5;
            campUpdateContatosSobrenome.TextChanged += Campos_TextChanged;
            campUpdateContatosSobrenome.KeyPress += campUpdateContatosSobrenome_KeyPress;
            // 
            // campUpdateContatosTelefone
            // 
            campUpdateContatosTelefone.Location = new Point(131, 215);
            campUpdateContatosTelefone.Name = "campUpdateContatosTelefone";
            campUpdateContatosTelefone.Size = new Size(156, 23);
            campUpdateContatosTelefone.TabIndex = 6;
            campUpdateContatosTelefone.TextChanged += Campos_TextChanged;
            campUpdateContatosTelefone.KeyPress += campUpdateContatosTelefone_KeyPress;
            // 
            // campUpdateContatosEmail
            // 
            campUpdateContatosEmail.Location = new Point(131, 244);
            campUpdateContatosEmail.Name = "campUpdateContatosEmail";
            campUpdateContatosEmail.Size = new Size(156, 23);
            campUpdateContatosEmail.TabIndex = 7;
            campUpdateContatosEmail.TextChanged += Campos_TextChanged;
            campUpdateContatosEmail.Validating += campUpdateContatosEmail_Validating;
            // 
            // lbUpdateContatosNome
            // 
            lbUpdateContatosNome.AutoSize = true;
            lbUpdateContatosNome.Location = new Point(56, 160);
            lbUpdateContatosNome.Name = "lbUpdateContatosNome";
            lbUpdateContatosNome.Size = new Size(40, 15);
            lbUpdateContatosNome.TabIndex = 9;
            lbUpdateContatosNome.Text = "Nome";
            // 
            // lbUpdateContatosSobrenome
            // 
            lbUpdateContatosSobrenome.AutoSize = true;
            lbUpdateContatosSobrenome.Location = new Point(40, 189);
            lbUpdateContatosSobrenome.Name = "lbUpdateContatosSobrenome";
            lbUpdateContatosSobrenome.Size = new Size(68, 15);
            lbUpdateContatosSobrenome.TabIndex = 10;
            lbUpdateContatosSobrenome.Text = "Sobrenome";
            // 
            // lbUpdateContatosTelefone
            // 
            lbUpdateContatosTelefone.AutoSize = true;
            lbUpdateContatosTelefone.Location = new Point(47, 218);
            lbUpdateContatosTelefone.Name = "lbUpdateContatosTelefone";
            lbUpdateContatosTelefone.Size = new Size(52, 15);
            lbUpdateContatosTelefone.TabIndex = 11;
            lbUpdateContatosTelefone.Text = "Telefone";
            // 
            // lbUpdateContatosEmail
            // 
            lbUpdateContatosEmail.AutoSize = true;
            lbUpdateContatosEmail.Location = new Point(56, 247);
            lbUpdateContatosEmail.Name = "lbUpdateContatosEmail";
            lbUpdateContatosEmail.Size = new Size(36, 15);
            lbUpdateContatosEmail.TabIndex = 12;
            lbUpdateContatosEmail.Text = "Email";
            // 
            // lbUpdateContatosId
            // 
            lbUpdateContatosId.AutoSize = true;
            lbUpdateContatosId.Location = new Point(68, 131);
            lbUpdateContatosId.Name = "lbUpdateContatosId";
            lbUpdateContatosId.Size = new Size(18, 15);
            lbUpdateContatosId.TabIndex = 13;
            lbUpdateContatosId.Text = "ID";
            // 
            // campUpdateContatosId
            // 
            campUpdateContatosId.Location = new Point(133, 128);
            campUpdateContatosId.Name = "campUpdateContatosId";
            campUpdateContatosId.Size = new Size(156, 23);
            campUpdateContatosId.TabIndex = 14;
            campUpdateContatosId.TextChanged += Campos_TextChanged;
            campUpdateContatosId.KeyPress += campUpdateContatosId_KeyPress;
            // 
            // lbUpdateContatosEmailInvalid
            // 
            lbUpdateContatosEmailInvalid.AutoSize = true;
            lbUpdateContatosEmailInvalid.ForeColor = Color.Red;
            lbUpdateContatosEmailInvalid.Location = new Point(168, 270);
            lbUpdateContatosEmailInvalid.Name = "lbUpdateContatosEmailInvalid";
            lbUpdateContatosEmailInvalid.Size = new Size(81, 15);
            lbUpdateContatosEmailInvalid.TabIndex = 15;
            lbUpdateContatosEmailInvalid.Text = "Email Inválido";
            // 
            // UpdateContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(367, 450);
            ControlBox = false;
            Controls.Add(lbUpdateContatosEmailInvalid);
            Controls.Add(campUpdateContatosId);
            Controls.Add(lbUpdateContatosId);
            Controls.Add(lbUpdateContatosEmail);
            Controls.Add(lbUpdateContatosTelefone);
            Controls.Add(lbUpdateContatosSobrenome);
            Controls.Add(lbUpdateContatosNome);
            Controls.Add(campUpdateContatosEmail);
            Controls.Add(campUpdateContatosTelefone);
            Controls.Add(campUpdateContatosSobrenome);
            Controls.Add(campUpdateContatosNome);
            Controls.Add(btUpdateContatosCancelar);
            Controls.Add(btUpdateContatosCriar);
            Controls.Add(lbUpdateContatosTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateContato";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Atualizar Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUpdateContatosTitulo;
        private Button btUpdateContatosCriar;
        private Button btUpdateContatosCancelar;
        private TextBox campUpdateContatosNome;
        private TextBox campUpdateContatosSobrenome;
        private TextBox campUpdateContatosTelefone;
        private TextBox campUpdateContatosEmail;
        private Label lbUpdateContatosNome;
        private Label lbUpdateContatosSobrenome;
        private Label lbUpdateContatosTelefone;
        private Label lbUpdateContatosEmail;
        private Label lbUpdateContatosId;
        private TextBox campUpdateContatosId;
        private Label lbUpdateContatosEmailInvalid;
    }
}