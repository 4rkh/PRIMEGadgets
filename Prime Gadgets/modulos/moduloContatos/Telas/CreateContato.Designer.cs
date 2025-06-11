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
            lbCreateContatosTitulo = new Label();
            btCreateContatosCriar = new Button();
            btCreateContatosCancelar = new Button();
            campCreateContatosNome = new TextBox();
            campCreateContatosSobrenome = new TextBox();
            campCreateContatosTelefone = new TextBox();
            campCreateContatosEmail = new TextBox();
            lbCreateContatosNome = new Label();
            lbCreateContatosSobrenome = new Label();
            lbCreateContatosTelefone = new Label();
            lbCreateContatosEmail = new Label();
            lbCreateContatoEmailInvalid = new Label();
            SuspendLayout();
            // 
            // lbCreateContatosTitulo
            // 
            lbCreateContatosTitulo.AutoSize = true;
            lbCreateContatosTitulo.BackColor = Color.Transparent;
            lbCreateContatosTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCreateContatosTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateContatosTitulo.Location = new Point(95, 9);
            lbCreateContatosTitulo.Name = "lbCreateContatosTitulo";
            lbCreateContatosTitulo.Size = new Size(265, 36);
            lbCreateContatosTitulo.TabIndex = 0;
            lbCreateContatosTitulo.Text = "Adicionar Contato";
            // 
            // btCreateContatosCriar
            // 
            btCreateContatosCriar.BackColor = Color.FromArgb(52, 60, 76);
            btCreateContatosCriar.Enabled = false;
            btCreateContatosCriar.FlatAppearance.BorderSize = 0;
            btCreateContatosCriar.FlatStyle = FlatStyle.Flat;
            btCreateContatosCriar.Font = new Font("Arial", 12.75F);
            btCreateContatosCriar.ForeColor = Color.FromArgb(183, 190, 191);
            btCreateContatosCriar.Location = new Point(30, 219);
            btCreateContatosCriar.Name = "btCreateContatosCriar";
            btCreateContatosCriar.Size = new Size(118, 37);
            btCreateContatosCriar.TabIndex = 1;
            btCreateContatosCriar.Text = "Criar";
            btCreateContatosCriar.UseVisualStyleBackColor = false;
            btCreateContatosCriar.EnabledChanged += btCreateContatoCriar_EnabledChanged;
            btCreateContatosCriar.Click += btCreateContatoCriar_Click;
            // 
            // btCreateContatosCancelar
            // 
            btCreateContatosCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateContatosCancelar.FlatAppearance.BorderSize = 0;
            btCreateContatosCancelar.FlatStyle = FlatStyle.Flat;
            btCreateContatosCancelar.Font = new Font("Arial", 12.75F);
            btCreateContatosCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateContatosCancelar.Location = new Point(280, 219);
            btCreateContatosCancelar.Name = "btCreateContatosCancelar";
            btCreateContatosCancelar.Size = new Size(118, 37);
            btCreateContatosCancelar.TabIndex = 2;
            btCreateContatosCancelar.Text = "Cancelar";
            btCreateContatosCancelar.UseVisualStyleBackColor = false;
            btCreateContatosCancelar.Click += btCreateContatoCancelar_Click;
            // 
            // campCreateContatosNome
            // 
            campCreateContatosNome.BackColor = Color.FromArgb(255, 252, 237);
            campCreateContatosNome.BorderStyle = BorderStyle.None;
            campCreateContatosNome.Font = new Font("Arial", 12.75F);
            campCreateContatosNome.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateContatosNome.Location = new Point(172, 85);
            campCreateContatosNome.Name = "campCreateContatosNome";
            campCreateContatosNome.Size = new Size(226, 20);
            campCreateContatosNome.TabIndex = 4;
            campCreateContatosNome.TextChanged += Campos_TextChanged;
            // 
            // campCreateContatosSobrenome
            // 
            campCreateContatosSobrenome.BackColor = Color.FromArgb(255, 252, 237);
            campCreateContatosSobrenome.BorderStyle = BorderStyle.None;
            campCreateContatosSobrenome.Font = new Font("Arial", 12.75F);
            campCreateContatosSobrenome.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateContatosSobrenome.Location = new Point(172, 111);
            campCreateContatosSobrenome.Name = "campCreateContatosSobrenome";
            campCreateContatosSobrenome.Size = new Size(226, 20);
            campCreateContatosSobrenome.TabIndex = 5;
            // 
            // campCreateContatosTelefone
            // 
            campCreateContatosTelefone.BackColor = Color.FromArgb(255, 252, 237);
            campCreateContatosTelefone.BorderStyle = BorderStyle.None;
            campCreateContatosTelefone.Font = new Font("Arial", 12.75F);
            campCreateContatosTelefone.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateContatosTelefone.Location = new Point(172, 137);
            campCreateContatosTelefone.Name = "campCreateContatosTelefone";
            campCreateContatosTelefone.Size = new Size(226, 20);
            campCreateContatosTelefone.TabIndex = 6;
            campCreateContatosTelefone.TextChanged += Campos_TextChanged;
            campCreateContatosTelefone.KeyPress += campCreateContatosTelefone_KeyPress;
            // 
            // campCreateContatosEmail
            // 
            campCreateContatosEmail.BackColor = Color.FromArgb(255, 252, 237);
            campCreateContatosEmail.BorderStyle = BorderStyle.None;
            campCreateContatosEmail.Font = new Font("Arial", 12.75F);
            campCreateContatosEmail.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateContatosEmail.Location = new Point(172, 163);
            campCreateContatosEmail.Name = "campCreateContatosEmail";
            campCreateContatosEmail.Size = new Size(226, 20);
            campCreateContatosEmail.TabIndex = 7;
            campCreateContatosEmail.TextChanged += Campos_TextChanged;
            campCreateContatosEmail.Validating += campCreateContatosEmail_Validating;
            // 
            // lbCreateContatosNome
            // 
            lbCreateContatosNome.AutoSize = true;
            lbCreateContatosNome.Font = new Font("Arial", 12.75F);
            lbCreateContatosNome.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateContatosNome.Location = new Point(64, 86);
            lbCreateContatosNome.Name = "lbCreateContatosNome";
            lbCreateContatosNome.Size = new Size(51, 19);
            lbCreateContatosNome.TabIndex = 9;
            lbCreateContatosNome.Text = "Nome";
            // 
            // lbCreateContatosSobrenome
            // 
            lbCreateContatosSobrenome.AutoSize = true;
            lbCreateContatosSobrenome.Font = new Font("Arial", 12.75F);
            lbCreateContatosSobrenome.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateContatosSobrenome.Location = new Point(46, 112);
            lbCreateContatosSobrenome.Name = "lbCreateContatosSobrenome";
            lbCreateContatosSobrenome.Size = new Size(93, 19);
            lbCreateContatosSobrenome.TabIndex = 10;
            lbCreateContatosSobrenome.Text = "Sobrenome";
            // 
            // lbCreateContatosTelefone
            // 
            lbCreateContatosTelefone.AutoSize = true;
            lbCreateContatosTelefone.Font = new Font("Arial", 12.75F);
            lbCreateContatosTelefone.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateContatosTelefone.Location = new Point(55, 138);
            lbCreateContatosTelefone.Name = "lbCreateContatosTelefone";
            lbCreateContatosTelefone.Size = new Size(69, 19);
            lbCreateContatosTelefone.TabIndex = 11;
            lbCreateContatosTelefone.Text = "Telefone";
            // 
            // lbCreateContatosEmail
            // 
            lbCreateContatosEmail.AutoSize = true;
            lbCreateContatosEmail.Font = new Font("Arial", 12.75F);
            lbCreateContatosEmail.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateContatosEmail.Location = new Point(64, 164);
            lbCreateContatosEmail.Name = "lbCreateContatosEmail";
            lbCreateContatosEmail.Size = new Size(49, 19);
            lbCreateContatosEmail.TabIndex = 12;
            lbCreateContatosEmail.Text = "Email";
            // 
            // lbCreateContatoEmailInvalid
            // 
            lbCreateContatoEmailInvalid.AutoSize = true;
            lbCreateContatoEmailInvalid.Font = new Font("Arial", 9F);
            lbCreateContatoEmailInvalid.ForeColor = Color.FromArgb(230, 34, 34);
            lbCreateContatoEmailInvalid.Location = new Point(172, 192);
            lbCreateContatoEmailInvalid.Name = "lbCreateContatoEmailInvalid";
            lbCreateContatoEmailInvalid.Size = new Size(84, 15);
            lbCreateContatoEmailInvalid.TabIndex = 13;
            lbCreateContatoEmailInvalid.Text = "Email Inválido";
            // 
            // CreateContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(437, 275);
            Controls.Add(lbCreateContatoEmailInvalid);
            Controls.Add(lbCreateContatosEmail);
            Controls.Add(lbCreateContatosTelefone);
            Controls.Add(lbCreateContatosSobrenome);
            Controls.Add(lbCreateContatosNome);
            Controls.Add(campCreateContatosEmail);
            Controls.Add(campCreateContatosTelefone);
            Controls.Add(campCreateContatosSobrenome);
            Controls.Add(campCreateContatosNome);
            Controls.Add(btCreateContatosCancelar);
            Controls.Add(btCreateContatosCriar);
            Controls.Add(lbCreateContatosTitulo);
            ForeColor = Color.FromArgb(52, 60, 76);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateContato";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Adicionar Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreateContatosTitulo;
        private Button btCreateContatosCriar;
        private Button btCreateContatosCancelar;
        private TextBox campCreateContatosNome;
        private TextBox campCreateContatosSobrenome;
        private TextBox campCreateContatosTelefone;
        private TextBox campCreateContatosEmail;
        private Label lbCreateContatosNome;
        private Label lbCreateContatosSobrenome;
        private Label lbCreateContatosTelefone;
        private Label lbCreateContatosEmail;
        private Label lbCreateContatoEmailInvalid;
    }
}