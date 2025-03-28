namespace Prime_Gadgets
{
    partial class MenuPrincipal
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
            button1 = new Button();
            button2 = new Button();
            btMenuPrincipalContatos = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Location = new Point(24, 37);
            button1.Name = "button1";
            button1.Size = new Size(95, 47);
            button1.TabIndex = 0;
            button1.Text = "Calculadora";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            button2.FlatAppearance.BorderSize = 100;
            button2.FlatAppearance.MouseDownBackColor = Color.Blue;
            button2.Location = new Point(141, 37);
            button2.Name = "button2";
            button2.Size = new Size(86, 47);
            button2.TabIndex = 1;
            button2.Text = "Calendário";
            button2.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalContatos
            // 
            btMenuPrincipalContatos.BackColor = Color.LimeGreen;
            btMenuPrincipalContatos.Location = new Point(248, 37);
            btMenuPrincipalContatos.Name = "btMenuPrincipalContatos";
            btMenuPrincipalContatos.Size = new Size(87, 47);
            btMenuPrincipalContatos.TabIndex = 2;
            btMenuPrincipalContatos.Text = "Contatos";
            btMenuPrincipalContatos.UseVisualStyleBackColor = false;
            btMenuPrincipalContatos.Click += btMenuPrincipalContatos_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Location = new Point(355, 37);
            button4.Name = "button4";
            button4.Size = new Size(82, 47);
            button4.TabIndex = 3;
            button4.Text = "Finaceiro";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Location = new Point(455, 37);
            button5.Name = "button5";
            button5.Size = new Size(90, 47);
            button5.TabIndex = 4;
            button5.Text = "Lembretes";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.Location = new Point(568, 37);
            button6.Name = "button6";
            button6.Size = new Size(90, 47);
            button6.TabIndex = 5;
            button6.Text = "Rotina";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.FlatAppearance.BorderColor = Color.Blue;
            button7.Location = new Point(678, 37);
            button7.Name = "button7";
            button7.Size = new Size(97, 47);
            button7.TabIndex = 6;
            button7.Text = "Senhas";
            button7.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 116);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btMenuPrincipalContatos);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btMenuPrincipalContatos;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}