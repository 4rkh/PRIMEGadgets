using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloContatos
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(UpdateContato));
            lbUpdateContatosTitulo = new Label();
            btUpdateContatosCriar = new Button();
            btUpdateContatosCancelar = new Button();
            campUpdateContatosNome = new TextBox();
            campUpdateContatosSobrenome = new TextBox();
            campUpdateContatosTelefone = new TextBox();
            campUpdateContatosEmail = new TextBox();
            lbUpdateContatosNome = new Label();
            lbUpdateContatosSobrenome = new Label();
            lbUpdateContatosEmail = new Label();
            lbUpdateContatosId = new Label();
            campUpdateContatosId = new TextBox();
            lbUpdateContatosEmailInvalid = new Label();
            lbUpdateContatosTelefone = new Label();
            SuspendLayout();
            // 
            // lbUpdateContatosTitulo
            // 
            lbUpdateContatosTitulo.AutoSize = true;
            lbUpdateContatosTitulo.BackColor = Color.Transparent;
            lbUpdateContatosTitulo.Font = new Font("Arial", 24F);
            lbUpdateContatosTitulo.Location = new Point(32, 27);
            lbUpdateContatosTitulo.Name = "lbUpdateContatosTitulo";
            lbUpdateContatosTitulo.Size = new Size(256, 36);
            lbUpdateContatosTitulo.TabIndex = 0;
            lbUpdateContatosTitulo.Text = "Atualizar Contato";
            // 
            // btUpdateContatosCriar
            // 
            btUpdateContatosCriar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateContatosCriar.FlatAppearance.BorderSize = 0;
            btUpdateContatosCriar.FlatStyle = FlatStyle.Flat;
            btUpdateContatosCriar.Font = new Font("Arial", 12.75F);
            btUpdateContatosCriar.ForeColor = Color.FromArgb(255, 252, 237);
            btUpdateContatosCriar.Location = new Point(22, 257);
            btUpdateContatosCriar.Name = "btUpdateContatosCriar";
            btUpdateContatosCriar.Size = new Size(118, 37);
            btUpdateContatosCriar.TabIndex = 1;
            btUpdateContatosCriar.Text = "Atualizar";
            btUpdateContatosCriar.UseVisualStyleBackColor = false;
            btUpdateContatosCriar.Click += btUpdateContatosAtualizar_Click;
            // 
            // btUpdateContatosCancelar
            // 
            btUpdateContatosCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateContatosCancelar.FlatAppearance.BorderSize = 0;
            btUpdateContatosCancelar.FlatStyle = FlatStyle.Flat;
            btUpdateContatosCancelar.Font = new Font("Arial", 12.75F);
            btUpdateContatosCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btUpdateContatosCancelar.Location = new Point(186, 257);
            btUpdateContatosCancelar.Name = "btUpdateContatosCancelar";
            btUpdateContatosCancelar.Size = new Size(118, 37);
            btUpdateContatosCancelar.TabIndex = 2;
            btUpdateContatosCancelar.Text = "Cancelar";
            btUpdateContatosCancelar.UseVisualStyleBackColor = false;
            btUpdateContatosCancelar.Click += btUpdateContatosCancelar_Click;
            // 
            // campUpdateContatosNome
            // 
            campUpdateContatosNome.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateContatosNome.BorderStyle = BorderStyle.None;
            campUpdateContatosNome.Font = new Font("Arial", 12.75F);
            campUpdateContatosNome.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateContatosNome.Location = new Point(121, 112);
            campUpdateContatosNome.Name = "campUpdateContatosNome";
            campUpdateContatosNome.Size = new Size(156, 20);
            campUpdateContatosNome.TabIndex = 4;
            campUpdateContatosNome.TextChanged += Campos_TextChanged;
            campUpdateContatosNome.KeyPress += campUpdateContatosNome_KeyPress;
            // 
            // campUpdateContatosSobrenome
            // 
            campUpdateContatosSobrenome.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateContatosSobrenome.BorderStyle = BorderStyle.None;
            campUpdateContatosSobrenome.Font = new Font("Arial", 12.75F);
            campUpdateContatosSobrenome.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateContatosSobrenome.Location = new Point(121, 141);
            campUpdateContatosSobrenome.Name = "campUpdateContatosSobrenome";
            campUpdateContatosSobrenome.Size = new Size(156, 20);
            campUpdateContatosSobrenome.TabIndex = 5;
            campUpdateContatosSobrenome.TextChanged += Campos_TextChanged;
            campUpdateContatosSobrenome.KeyPress += campUpdateContatosSobrenome_KeyPress;
            // 
            // campUpdateContatosTelefone
            // 
            campUpdateContatosTelefone.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateContatosTelefone.BorderStyle = BorderStyle.None;
            campUpdateContatosTelefone.Font = new Font("Arial", 12.75F);
            campUpdateContatosTelefone.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateContatosTelefone.Location = new Point(121, 170);
            campUpdateContatosTelefone.Name = "campUpdateContatosTelefone";
            campUpdateContatosTelefone.Size = new Size(156, 20);
            campUpdateContatosTelefone.TabIndex = 6;
            campUpdateContatosTelefone.TextChanged += Campos_TextChanged;
            campUpdateContatosTelefone.KeyPress += campUpdateContatosTelefone_KeyPress;
            // 
            // campUpdateContatosEmail
            // 
            campUpdateContatosEmail.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateContatosEmail.BorderStyle = BorderStyle.None;
            campUpdateContatosEmail.Font = new Font("Arial", 12.75F);
            campUpdateContatosEmail.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateContatosEmail.Location = new Point(121, 199);
            campUpdateContatosEmail.Name = "campUpdateContatosEmail";
            campUpdateContatosEmail.Size = new Size(156, 20);
            campUpdateContatosEmail.TabIndex = 7;
            campUpdateContatosEmail.TextChanged += Campos_TextChanged;
            campUpdateContatosEmail.Validating += campUpdateContatosEmail_Validating;
            // 
            // lbUpdateContatosNome
            // 
            lbUpdateContatosNome.AutoSize = true;
            lbUpdateContatosNome.Font = new Font("Arial", 12.75F);
            lbUpdateContatosNome.Location = new Point(44, 116);
            lbUpdateContatosNome.Name = "lbUpdateContatosNome";
            lbUpdateContatosNome.Size = new Size(51, 19);
            lbUpdateContatosNome.TabIndex = 9;
            lbUpdateContatosNome.Text = "Nome";
            // 
            // lbUpdateContatosSobrenome
            // 
            lbUpdateContatosSobrenome.AutoSize = true;
            lbUpdateContatosSobrenome.Font = new Font("Arial", 12.75F);
            lbUpdateContatosSobrenome.Location = new Point(22, 145);
            lbUpdateContatosSobrenome.Name = "lbUpdateContatosSobrenome";
            lbUpdateContatosSobrenome.Size = new Size(93, 19);
            lbUpdateContatosSobrenome.TabIndex = 10;
            lbUpdateContatosSobrenome.Text = "Sobrenome";
            // 
            // lbUpdateContatosEmail
            // 
            lbUpdateContatosEmail.AutoSize = true;
            lbUpdateContatosEmail.Font = new Font("Arial", 12.75F);
            lbUpdateContatosEmail.Location = new Point(46, 203);
            lbUpdateContatosEmail.Name = "lbUpdateContatosEmail";
            lbUpdateContatosEmail.Size = new Size(49, 19);
            lbUpdateContatosEmail.TabIndex = 12;
            lbUpdateContatosEmail.Text = "Email";
            // 
            // lbUpdateContatosId
            // 
            lbUpdateContatosId.AutoSize = true;
            lbUpdateContatosId.Font = new Font("Arial", 12.75F);
            lbUpdateContatosId.Location = new Point(55, 86);
            lbUpdateContatosId.Name = "lbUpdateContatosId";
            lbUpdateContatosId.Size = new Size(26, 19);
            lbUpdateContatosId.TabIndex = 13;
            lbUpdateContatosId.Text = "ID";
            // 
            // campUpdateContatosId
            // 
            campUpdateContatosId.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateContatosId.BorderStyle = BorderStyle.None;
            campUpdateContatosId.Font = new Font("Arial", 12.75F);
            campUpdateContatosId.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateContatosId.Location = new Point(121, 83);
            campUpdateContatosId.Name = "campUpdateContatosId";
            campUpdateContatosId.Size = new Size(156, 20);
            campUpdateContatosId.TabIndex = 14;
            campUpdateContatosId.TextChanged += Campos_TextChanged;
            campUpdateContatosId.KeyPress += campUpdateContatosId_KeyPress;
            // 
            // lbUpdateContatosEmailInvalid
            // 
            lbUpdateContatosEmailInvalid.AutoSize = true;
            lbUpdateContatosEmailInvalid.Font = new Font("Arial", 9F);
            lbUpdateContatosEmailInvalid.ForeColor = Color.FromArgb(230, 34, 34);
            lbUpdateContatosEmailInvalid.Location = new Point(158, 225);
            lbUpdateContatosEmailInvalid.Name = "lbUpdateContatosEmailInvalid";
            lbUpdateContatosEmailInvalid.Size = new Size(84, 15);
            lbUpdateContatosEmailInvalid.TabIndex = 15;
            lbUpdateContatosEmailInvalid.Text = "Email Inválido";
            // 
            // lbUpdateContatosTelefone
            // 
            lbUpdateContatosTelefone.AutoSize = true;
            lbUpdateContatosTelefone.Font = new Font("Arial", 12.75F);
            lbUpdateContatosTelefone.Location = new Point(37, 174);
            lbUpdateContatosTelefone.Name = "lbUpdateContatosTelefone";
            lbUpdateContatosTelefone.Size = new Size(69, 19);
            lbUpdateContatosTelefone.TabIndex = 11;
            lbUpdateContatosTelefone.Text = "Telefone";
            // 
            // UpdateContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(328, 317);
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
            ForeColor = Color.FromArgb(52, 60, 76);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label lbUpdateContatosEmail;
        private Label lbUpdateContatosId;
        private TextBox campUpdateContatosId;
        private Label lbUpdateContatosEmailInvalid;
        private Label lbUpdateContatosTelefone;
    }
}