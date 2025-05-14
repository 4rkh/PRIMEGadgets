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
            btMenuPrincipalLembretes = new Button();
            btMenuPrincipalFinanceiro = new Button();
            btMenuPrincipalContatos = new Button();
            btMenuPrincipalCalendario = new Button();
            btMenuPrincipalCalculadora = new Button();
            btMenuPrincipalRotina = new Button();
            btMenuPrincipalSenhas = new Button();
            SuspendLayout();
            // 
            // btMenuPrincipalLembretes
            // 
            btMenuPrincipalLembretes.BackColor = Color.Gray;
            btMenuPrincipalLembretes.Location = new Point(12, 435);
            btMenuPrincipalLembretes.Name = "btMenuPrincipalLembretes";
            btMenuPrincipalLembretes.Size = new Size(95, 47);
            btMenuPrincipalLembretes.TabIndex = 4;
            btMenuPrincipalLembretes.Text = "Lembretes";
            btMenuPrincipalLembretes.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalFinanceiro
            // 
            btMenuPrincipalFinanceiro.BackColor = Color.Gray;
            btMenuPrincipalFinanceiro.Location = new Point(12, 368);
            btMenuPrincipalFinanceiro.Name = "btMenuPrincipalFinanceiro";
            btMenuPrincipalFinanceiro.Size = new Size(95, 47);
            btMenuPrincipalFinanceiro.TabIndex = 3;
            btMenuPrincipalFinanceiro.Text = "Finaceiro";
            btMenuPrincipalFinanceiro.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalContatos
            // 
            btMenuPrincipalContatos.BackColor = Color.LimeGreen;
            btMenuPrincipalContatos.Location = new Point(12, 305);
            btMenuPrincipalContatos.Name = "btMenuPrincipalContatos";
            btMenuPrincipalContatos.Size = new Size(95, 47);
            btMenuPrincipalContatos.TabIndex = 2;
            btMenuPrincipalContatos.Text = "Contatos";
            btMenuPrincipalContatos.UseVisualStyleBackColor = false;
            btMenuPrincipalContatos.Click += btMenuPrincipalContatos_Click;
            // 
            // btMenuPrincipalCalendario
            // 
            btMenuPrincipalCalendario.BackColor = Color.LimeGreen;
            btMenuPrincipalCalendario.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btMenuPrincipalCalendario.FlatAppearance.BorderSize = 100;
            btMenuPrincipalCalendario.FlatAppearance.MouseDownBackColor = Color.Blue;
            btMenuPrincipalCalendario.Location = new Point(12, 243);
            btMenuPrincipalCalendario.Name = "btMenuPrincipalCalendario";
            btMenuPrincipalCalendario.Size = new Size(95, 47);
            btMenuPrincipalCalendario.TabIndex = 1;
            btMenuPrincipalCalendario.Text = "Calendário";
            btMenuPrincipalCalendario.UseVisualStyleBackColor = false;
            btMenuPrincipalCalendario.Click += btMenuPrincipalCalendario_Click;
            // 
            // btMenuPrincipalCalculadora
            // 
            btMenuPrincipalCalculadora.BackColor = Color.DarkGray;
            btMenuPrincipalCalculadora.Location = new Point(12, 119);
            btMenuPrincipalCalculadora.Name = "btMenuPrincipalCalculadora";
            btMenuPrincipalCalculadora.Size = new Size(95, 47);
            btMenuPrincipalCalculadora.TabIndex = 0;
            btMenuPrincipalCalculadora.Text = "Calculadora";
            btMenuPrincipalCalculadora.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalRotina
            // 
            btMenuPrincipalRotina.BackColor = Color.Gray;
            btMenuPrincipalRotina.Location = new Point(12, 499);
            btMenuPrincipalRotina.Name = "btMenuPrincipalRotina";
            btMenuPrincipalRotina.Size = new Size(97, 47);
            btMenuPrincipalRotina.TabIndex = 5;
            btMenuPrincipalRotina.Text = "Rotina";
            btMenuPrincipalRotina.UseVisualStyleBackColor = false;
            // 
            // btMenuPrincipalSenhas
            // 
            btMenuPrincipalSenhas.BackColor = Color.LimeGreen;
            btMenuPrincipalSenhas.FlatAppearance.BorderColor = Color.Blue;
            btMenuPrincipalSenhas.Location = new Point(12, 181);
            btMenuPrincipalSenhas.Name = "btMenuPrincipalSenhas";
            btMenuPrincipalSenhas.Size = new Size(95, 47);
            btMenuPrincipalSenhas.TabIndex = 6;
            btMenuPrincipalSenhas.Text = "Senhas";
            btMenuPrincipalSenhas.UseVisualStyleBackColor = false;
            btMenuPrincipalSenhas.Click += btMenuPrincipalSenhas_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1405, 642);
            Controls.Add(btMenuPrincipalSenhas);
            Controls.Add(btMenuPrincipalRotina);
            Controls.Add(btMenuPrincipalLembretes);
            Controls.Add(btMenuPrincipalFinanceiro);
            Controls.Add(btMenuPrincipalContatos);
            Controls.Add(btMenuPrincipalCalendario);
            Controls.Add(btMenuPrincipalCalculadora);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btMenuPrincipalLembretes;
        private Button btMenuPrincipalFinanceiro;
        private Button btMenuPrincipalContatos;
        private Button btMenuPrincipalCalendario;
        private Button btMenuPrincipalCalculadora;
        private Button btMenuPrincipalRotina;
        private Button btMenuPrincipalSenhas;
    }
}