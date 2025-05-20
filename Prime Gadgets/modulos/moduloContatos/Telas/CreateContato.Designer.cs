namespace Prime_Gadgets.modulos.moduloContatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    partial class CreateContato
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CreateContato));
            lbAddContatosTitulo = new Label();
            btAddContatosCriar = new Button();
            btAddContatosCancelar = new Button();
            campAddContatosNome = new TextBox();
            campAddContatosSobrenome = new TextBox();
            campAddContatosTelefone = new TextBox();
            campAddContatosEmail = new TextBox();
            lbAddContatosNome = new Label();
            lbAddContatosSobrenome = new Label();
            lbAddContatosTelefone = new Label();
            lbAddContatosEmail = new Label();
            lbAddContatoEmailInvalid = new Label();
            SuspendLayout();
            // 
            // lbAddContatosTitulo
            // 
            lbAddContatosTitulo.AutoSize = true;
            lbAddContatosTitulo.BackColor = Color.Transparent;
            lbAddContatosTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddContatosTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbAddContatosTitulo.Location = new Point(49, 47);
            lbAddContatosTitulo.Name = "lbAddContatosTitulo";
            lbAddContatosTitulo.Size = new Size(265, 36);
            lbAddContatosTitulo.TabIndex = 0;
            lbAddContatosTitulo.Text = "Adicionar Contato";
            // 
            // btAddContatosCriar
            // 
            btAddContatosCriar.BackColor = Color.FromArgb(52, 60, 76);
            btAddContatosCriar.Enabled = false;
            btAddContatosCriar.FlatAppearance.BorderSize = 0;
            btAddContatosCriar.FlatStyle = FlatStyle.Flat;
            btAddContatosCriar.Font = new Font("Arial", 12.75F);
            btAddContatosCriar.ForeColor = Color.FromArgb(183, 190, 191);
            btAddContatosCriar.Location = new Point(47, 382);
            btAddContatosCriar.Name = "btAddContatosCriar";
            btAddContatosCriar.Size = new Size(118, 37);
            btAddContatosCriar.TabIndex = 1;
            btAddContatosCriar.Text = "Criar";
            btAddContatosCriar.UseVisualStyleBackColor = false;
            btAddContatosCriar.EnabledChanged += btContatoAddCriar_EnabledChanged;
            btAddContatosCriar.Click += btContatoAddCriar_Click;
            // 
            // btAddContatosCancelar
            // 
            btAddContatosCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btAddContatosCancelar.FlatAppearance.BorderSize = 0;
            btAddContatosCancelar.FlatStyle = FlatStyle.Flat;
            btAddContatosCancelar.Font = new Font("Arial", 12.75F);
            btAddContatosCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btAddContatosCancelar.Location = new Point(199, 382);
            btAddContatosCancelar.Name = "btAddContatosCancelar";
            btAddContatosCancelar.Size = new Size(118, 37);
            btAddContatosCancelar.TabIndex = 2;
            btAddContatosCancelar.Text = "Cancelar";
            btAddContatosCancelar.UseVisualStyleBackColor = false;
            btAddContatosCancelar.Click += btContatoAddCancelar_Click;
            // 
            // campAddContatosNome
            // 
            campAddContatosNome.BackColor = Color.FromArgb(255, 252, 237);
            campAddContatosNome.BorderStyle = BorderStyle.None;
            campAddContatosNome.Font = new Font("Arial", 12.75F);
            campAddContatosNome.ForeColor = Color.FromArgb(230, 34, 34);
            campAddContatosNome.Location = new Point(131, 157);
            campAddContatosNome.Name = "campAddContatosNome";
            campAddContatosNome.Size = new Size(156, 20);
            campAddContatosNome.TabIndex = 4;
            campAddContatosNome.TextChanged += Campos_TextChanged;
            // 
            // campAddContatosSobrenome
            // 
            campAddContatosSobrenome.BackColor = Color.FromArgb(255, 252, 237);
            campAddContatosSobrenome.BorderStyle = BorderStyle.None;
            campAddContatosSobrenome.Font = new Font("Arial", 12.75F);
            campAddContatosSobrenome.ForeColor = Color.FromArgb(230, 34, 34);
            campAddContatosSobrenome.Location = new Point(131, 186);
            campAddContatosSobrenome.Name = "campAddContatosSobrenome";
            campAddContatosSobrenome.Size = new Size(156, 20);
            campAddContatosSobrenome.TabIndex = 5;
            // 
            // campAddContatosTelefone
            // 
            campAddContatosTelefone.BackColor = Color.FromArgb(255, 252, 237);
            campAddContatosTelefone.BorderStyle = BorderStyle.None;
            campAddContatosTelefone.Font = new Font("Arial", 12.75F);
            campAddContatosTelefone.ForeColor = Color.FromArgb(230, 34, 34);
            campAddContatosTelefone.Location = new Point(131, 215);
            campAddContatosTelefone.Name = "campAddContatosTelefone";
            campAddContatosTelefone.Size = new Size(156, 20);
            campAddContatosTelefone.TabIndex = 6;
            campAddContatosTelefone.TextChanged += Campos_TextChanged;
            campAddContatosTelefone.KeyPress += campAddContatosTelefone_KeyPress;
            // 
            // campAddContatosEmail
            // 
            campAddContatosEmail.BackColor = Color.FromArgb(255, 252, 237);
            campAddContatosEmail.BorderStyle = BorderStyle.None;
            campAddContatosEmail.Font = new Font("Arial", 12.75F);
            campAddContatosEmail.ForeColor = Color.FromArgb(230, 34, 34);
            campAddContatosEmail.Location = new Point(131, 244);
            campAddContatosEmail.Name = "campAddContatosEmail";
            campAddContatosEmail.Size = new Size(156, 20);
            campAddContatosEmail.TabIndex = 7;
            campAddContatosEmail.TextChanged += Campos_TextChanged;
            campAddContatosEmail.Validating += campAddContatosEmail_Validating;
            // 
            // lbAddContatosNome
            // 
            lbAddContatosNome.AutoSize = true;
            lbAddContatosNome.Font = new Font("Arial", 12.75F);
            lbAddContatosNome.ForeColor = Color.FromArgb(52, 60, 76);
            lbAddContatosNome.Location = new Point(54, 161);
            lbAddContatosNome.Name = "lbAddContatosNome";
            lbAddContatosNome.Size = new Size(51, 19);
            lbAddContatosNome.TabIndex = 9;
            lbAddContatosNome.Text = "Nome";
            // 
            // lbAddContatosSobrenome
            // 
            lbAddContatosSobrenome.AutoSize = true;
            lbAddContatosSobrenome.Font = new Font("Arial", 12.75F);
            lbAddContatosSobrenome.ForeColor = Color.FromArgb(52, 60, 76);
            lbAddContatosSobrenome.Location = new Point(32, 190);
            lbAddContatosSobrenome.Name = "lbAddContatosSobrenome";
            lbAddContatosSobrenome.Size = new Size(93, 19);
            lbAddContatosSobrenome.TabIndex = 10;
            lbAddContatosSobrenome.Text = "Sobrenome";
            // 
            // lbAddContatosTelefone
            // 
            lbAddContatosTelefone.AutoSize = true;
            lbAddContatosTelefone.Font = new Font("Arial", 12.75F);
            lbAddContatosTelefone.ForeColor = Color.FromArgb(52, 60, 76);
            lbAddContatosTelefone.Location = new Point(47, 219);
            lbAddContatosTelefone.Name = "lbAddContatosTelefone";
            lbAddContatosTelefone.Size = new Size(69, 19);
            lbAddContatosTelefone.TabIndex = 11;
            lbAddContatosTelefone.Text = "Telefone";
            // 
            // lbAddContatosEmail
            // 
            lbAddContatosEmail.AutoSize = true;
            lbAddContatosEmail.Font = new Font("Arial", 12.75F);
            lbAddContatosEmail.ForeColor = Color.FromArgb(52, 60, 76);
            lbAddContatosEmail.Location = new Point(56, 248);
            lbAddContatosEmail.Name = "lbAddContatosEmail";
            lbAddContatosEmail.Size = new Size(49, 19);
            lbAddContatosEmail.TabIndex = 12;
            lbAddContatosEmail.Text = "Email";
            // 
            // lbAddContatoEmailInvalid
            // 
            lbAddContatoEmailInvalid.AutoSize = true;
            lbAddContatoEmailInvalid.Font = new Font("Arial", 9F);
            lbAddContatoEmailInvalid.ForeColor = Color.FromArgb(230, 34, 34);
            lbAddContatoEmailInvalid.Location = new Point(168, 270);
            lbAddContatoEmailInvalid.Name = "lbAddContatoEmailInvalid";
            lbAddContatoEmailInvalid.Size = new Size(84, 15);
            lbAddContatoEmailInvalid.TabIndex = 13;
            lbAddContatoEmailInvalid.Text = "Email Inválido";
            // 
            // CreateContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(367, 450);
            ControlBox = false;
            Controls.Add(lbAddContatoEmailInvalid);
            Controls.Add(lbAddContatosEmail);
            Controls.Add(lbAddContatosTelefone);
            Controls.Add(lbAddContatosSobrenome);
            Controls.Add(lbAddContatosNome);
            Controls.Add(campAddContatosEmail);
            Controls.Add(campAddContatosTelefone);
            Controls.Add(campAddContatosSobrenome);
            Controls.Add(campAddContatosNome);
            Controls.Add(btAddContatosCancelar);
            Controls.Add(btAddContatosCriar);
            Controls.Add(lbAddContatosTitulo);
            ForeColor = Color.FromArgb(52, 60, 76);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreateContato";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Adicionar Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAddContatosTitulo;
        private Button btAddContatosCriar;
        private Button btAddContatosCancelar;
        private TextBox campAddContatosNome;
        private TextBox campAddContatosSobrenome;
        private TextBox campAddContatosTelefone;
        private TextBox campAddContatosEmail;
        private Label lbAddContatosNome;
        private Label lbAddContatosSobrenome;
        private Label lbAddContatosTelefone;
        private Label lbAddContatosEmail;
        private Label lbAddContatoEmailInvalid;
    }
}