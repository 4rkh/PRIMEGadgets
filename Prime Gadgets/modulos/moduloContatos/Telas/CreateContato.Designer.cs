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
            lbAddContatosTitulo.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddContatosTitulo.Location = new Point(68, 36);
            lbAddContatosTitulo.Name = "lbAddContatosTitulo";
            lbAddContatosTitulo.Size = new Size(229, 37);
            lbAddContatosTitulo.TabIndex = 0;
            lbAddContatosTitulo.Text = "Adicionar Contato";
            // 
            // btAddContatosCriar
            // 
            btAddContatosCriar.Location = new Point(47, 382);
            btAddContatosCriar.Name = "btAddContatosCriar";
            btAddContatosCriar.Size = new Size(118, 37);
            btAddContatosCriar.TabIndex = 1;
            btAddContatosCriar.Text = "Criar";
            btAddContatosCriar.UseVisualStyleBackColor = true;
            btAddContatosCriar.EnabledChanged += btContatoAddCriar_EnabledChanged;
            btAddContatosCriar.Click += btContatoAddCriar_Click;
            // 
            // btAddContatosCancelar
            // 
            btAddContatosCancelar.Location = new Point(199, 382);
            btAddContatosCancelar.Name = "btAddContatosCancelar";
            btAddContatosCancelar.Size = new Size(118, 37);
            btAddContatosCancelar.TabIndex = 2;
            btAddContatosCancelar.Text = "Cancelar";
            btAddContatosCancelar.UseVisualStyleBackColor = true;
            btAddContatosCancelar.Click += btContatoAddCancelar_Click;
            // 
            // campAddContatosNome
            // 
            campAddContatosNome.Location = new Point(131, 157);
            campAddContatosNome.Name = "campAddContatosNome";
            campAddContatosNome.Size = new Size(156, 23);
            campAddContatosNome.TabIndex = 4;
            campAddContatosNome.TextChanged += Campos_TextChanged;
            // 
            // campAddContatosSobrenome
            // 
            campAddContatosSobrenome.Location = new Point(131, 186);
            campAddContatosSobrenome.Name = "campAddContatosSobrenome";
            campAddContatosSobrenome.Size = new Size(156, 23);
            campAddContatosSobrenome.TabIndex = 5;
            // 
            // campAddContatosTelefone
            // 
            campAddContatosTelefone.Location = new Point(131, 215);
            campAddContatosTelefone.Name = "campAddContatosTelefone";
            campAddContatosTelefone.Size = new Size(156, 23);
            campAddContatosTelefone.TabIndex = 6;
            campAddContatosTelefone.TextChanged += Campos_TextChanged;
            campAddContatosTelefone.KeyPress += campAddContatosTelefone_KeyPress;
            // 
            // campAddContatosEmail
            // 
            campAddContatosEmail.Location = new Point(131, 244);
            campAddContatosEmail.Name = "campAddContatosEmail";
            campAddContatosEmail.Size = new Size(156, 23);
            campAddContatosEmail.TabIndex = 7;
            campAddContatosEmail.TextChanged += Campos_TextChanged;
            campAddContatosEmail.Validating += campAddContatosEmail_Validating;
            // 
            // lbAddContatosNome
            // 
            lbAddContatosNome.AutoSize = true;
            lbAddContatosNome.Location = new Point(56, 160);
            lbAddContatosNome.Name = "lbAddContatosNome";
            lbAddContatosNome.Size = new Size(40, 15);
            lbAddContatosNome.TabIndex = 9;
            lbAddContatosNome.Text = "Nome";
            // 
            // lbAddContatosSobrenome
            // 
            lbAddContatosSobrenome.AutoSize = true;
            lbAddContatosSobrenome.Location = new Point(40, 189);
            lbAddContatosSobrenome.Name = "lbAddContatosSobrenome";
            lbAddContatosSobrenome.Size = new Size(68, 15);
            lbAddContatosSobrenome.TabIndex = 10;
            lbAddContatosSobrenome.Text = "Sobrenome";
            // 
            // lbAddContatosTelefone
            // 
            lbAddContatosTelefone.AutoSize = true;
            lbAddContatosTelefone.Location = new Point(47, 218);
            lbAddContatosTelefone.Name = "lbAddContatosTelefone";
            lbAddContatosTelefone.Size = new Size(52, 15);
            lbAddContatosTelefone.TabIndex = 11;
            lbAddContatosTelefone.Text = "Telefone";
            // 
            // lbAddContatosEmail
            // 
            lbAddContatosEmail.AutoSize = true;
            lbAddContatosEmail.Location = new Point(56, 247);
            lbAddContatosEmail.Name = "lbAddContatosEmail";
            lbAddContatosEmail.Size = new Size(36, 15);
            lbAddContatosEmail.TabIndex = 12;
            lbAddContatosEmail.Text = "Email";
            // 
            // lbAddContatoEmailInvalid
            // 
            lbAddContatoEmailInvalid.AutoSize = true;
            lbAddContatoEmailInvalid.ForeColor = Color.Red;
            lbAddContatoEmailInvalid.Location = new Point(164, 270);
            lbAddContatoEmailInvalid.Name = "lbAddContatoEmailInvalid";
            lbAddContatoEmailInvalid.Size = new Size(81, 15);
            lbAddContatoEmailInvalid.TabIndex = 13;
            lbAddContatoEmailInvalid.Text = "Email Inválido";
            // 
            // CreateContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
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