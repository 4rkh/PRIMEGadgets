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
            btMenuPrincipalCalculadora = new Button();
            btMenuPrincipalCalendario = new Button();
            btMenuPrincipalContatos = new Button();
            btMenuPrincipalFinanceiro = new Button();
            btMenuPrincipalLembretes = new Button();
            btMenuPrincipalRotina = new Button();
            btMenuPrincipalSenhas = new Button();
            SuspendLayout();
            // 
            // btMenuPrincipalCalculadora
            // 
            btMenuPrincipalCalculadora.BackColor = Color.DarkGray;
            btMenuPrincipalCalculadora.Location = new Point(24, 37);
            btMenuPrincipalCalculadora.Name = "btMenuPrincipalCalculadora";
            btMenuPrincipalCalculadora.Size = new Size(95, 47);
            btMenuPrincipalCalculadora.TabIndex = 0;
            btMenuPrincipalCalculadora.Text = "Calculadora";
            btMenuPrincipalCalculadora.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalCalendario
            // 
            btMenuPrincipalCalendario.BackColor = Color.LimeGreen;
            btMenuPrincipalCalendario.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btMenuPrincipalCalendario.FlatAppearance.BorderSize = 100;
            btMenuPrincipalCalendario.FlatAppearance.MouseDownBackColor = Color.Blue;
            btMenuPrincipalCalendario.Location = new Point(141, 37);
            btMenuPrincipalCalendario.Name = "btMenuPrincipalCalendario";
            btMenuPrincipalCalendario.Size = new Size(86, 47);
            btMenuPrincipalCalendario.TabIndex = 1;
            btMenuPrincipalCalendario.Text = "Calendário";
            btMenuPrincipalCalendario.UseVisualStyleBackColor = false;
            btMenuPrincipalCalendario.Click += btMenuPrincipalCalendario_Click;
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
            // btMenuPrincipalFinanceiro
            // 
            btMenuPrincipalFinanceiro.BackColor = Color.Gray;
            btMenuPrincipalFinanceiro.Location = new Point(355, 37);
            btMenuPrincipalFinanceiro.Name = "btMenuPrincipalFinanceiro";
            btMenuPrincipalFinanceiro.Size = new Size(82, 47);
            btMenuPrincipalFinanceiro.TabIndex = 3;
            btMenuPrincipalFinanceiro.Text = "Finaceiro";
            btMenuPrincipalFinanceiro.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalLembretes
            // 
            btMenuPrincipalLembretes.BackColor = Color.Gray;
            btMenuPrincipalLembretes.Location = new Point(455, 37);
            btMenuPrincipalLembretes.Name = "btMenuPrincipalLembretes";
            btMenuPrincipalLembretes.Size = new Size(90, 47);
            btMenuPrincipalLembretes.TabIndex = 4;
            btMenuPrincipalLembretes.Text = "Lembretes";
            btMenuPrincipalLembretes.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalRotina
            // 
            btMenuPrincipalRotina.BackColor = Color.Gray;
            btMenuPrincipalRotina.Location = new Point(568, 37);
            btMenuPrincipalRotina.Name = "btMenuPrincipalRotina";
            btMenuPrincipalRotina.Size = new Size(90, 47);
            btMenuPrincipalRotina.TabIndex = 5;
            btMenuPrincipalRotina.Text = "Rotina";
            btMenuPrincipalRotina.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalSenhas
            // 
            btMenuPrincipalSenhas.BackColor = Color.Gray;
            btMenuPrincipalSenhas.FlatAppearance.BorderColor = Color.Blue;
            btMenuPrincipalSenhas.Location = new Point(678, 37);
            btMenuPrincipalSenhas.Name = "btMenuPrincipalSenhas";
            btMenuPrincipalSenhas.Size = new Size(97, 47);
            btMenuPrincipalSenhas.TabIndex = 6;
            btMenuPrincipalSenhas.Text = "Senhas";
            btMenuPrincipalSenhas.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 116);
            Controls.Add(btMenuPrincipalSenhas);
            Controls.Add(btMenuPrincipalRotina);
            Controls.Add(btMenuPrincipalLembretes);
            Controls.Add(btMenuPrincipalFinanceiro);
            Controls.Add(btMenuPrincipalContatos);
            Controls.Add(btMenuPrincipalCalendario);
            Controls.Add(btMenuPrincipalCalculadora);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btMenuPrincipalCalculadora;
        private Button btMenuPrincipalCalendario;
        private Button btMenuPrincipalContatos;
        private Button btMenuPrincipalFinanceiro;
        private Button btMenuPrincipalLembretes;
        private Button btMenuPrincipalRotina;
        private Button btMenuPrincipalSenhas;
    }
}