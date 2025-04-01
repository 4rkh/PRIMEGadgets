namespace Prime_Gadgets.Models
{
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
            label1 = new Label();
            btContatoAddCriar = new Button();
            btContatoAddCancelar = new Button();
            campAddContatosNome = new TextBox();
            campAddContatosSobrenome = new TextBox();
            campAddContatosTelefone = new TextBox();
            campAddContatosEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 36);
            label1.Name = "label1";
            label1.Size = new Size(229, 37);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Contato";
            // 
            // btContatoAddCriar
            // 
            btContatoAddCriar.Location = new Point(47, 382);
            btContatoAddCriar.Name = "btContatoAddCriar";
            btContatoAddCriar.Size = new Size(118, 37);
            btContatoAddCriar.TabIndex = 1;
            btContatoAddCriar.Text = "Criar";
            btContatoAddCriar.UseVisualStyleBackColor = true;
            btContatoAddCriar.EnabledChanged += btContatoAddCriar_EnabledChanged;
            btContatoAddCriar.Click += btContatoAddCriar_Click;
            // 
            // btContatoAddCancelar
            // 
            btContatoAddCancelar.Location = new Point(199, 382);
            btContatoAddCancelar.Name = "btContatoAddCancelar";
            btContatoAddCancelar.Size = new Size(118, 37);
            btContatoAddCancelar.TabIndex = 2;
            btContatoAddCancelar.Text = "Cancelar";
            btContatoAddCancelar.UseVisualStyleBackColor = true;
            btContatoAddCancelar.Click += btContatoAddCancelar_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 160);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 189);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 10;
            label4.Text = "Sobrenome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 218);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 11;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 247);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // CreateContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(367, 450);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(campAddContatosEmail);
            Controls.Add(campAddContatosTelefone);
            Controls.Add(campAddContatosSobrenome);
            Controls.Add(campAddContatosNome);
            Controls.Add(btContatoAddCancelar);
            Controls.Add(btContatoAddCriar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateContato";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Adicionar Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btContatoAddCriar;
        private Button btContatoAddCancelar;
        private TextBox campAddContatosNome;
        private TextBox campAddContatosSobrenome;
        private TextBox campAddContatosTelefone;
        private TextBox campAddContatosEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}