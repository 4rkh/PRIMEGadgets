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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
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
            // 
            // btContatoAddCancelar
            // 
            btContatoAddCancelar.Location = new Point(199, 382);
            btContatoAddCancelar.Name = "btContatoAddCancelar";
            btContatoAddCancelar.Size = new Size(118, 37);
            btContatoAddCancelar.TabIndex = 2;
            btContatoAddCancelar.Text = "Cancelar";
            btContatoAddCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(131, 244);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 23);
            textBox5.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 131);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 8;
            label2.Text = "ID";
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
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btContatoAddCancelar);
            Controls.Add(btContatoAddCriar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateContato";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btContatoAddCriar;
        private Button btContatoAddCancelar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}