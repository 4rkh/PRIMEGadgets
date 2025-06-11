namespace Prime_Gadgets
{
    partial class Menu
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btMenuHome = new Button();
            btMenuRotina = new Button();
            btMenuSenhas = new Button();
            btMenuLembretes = new Button();
            btMenuCalculadora = new Button();
            btMenuFinanceiro = new Button();
            btMenuCalendario = new Button();
            btMenuContatos = new Button();
            SuspendLayout();
            // 
            // btMenuHome
            // 
            btMenuHome.BackColor = Color.FromArgb(230, 34, 34);
            btMenuHome.Cursor = Cursors.Hand;
            btMenuHome.FlatAppearance.BorderSize = 0;
            btMenuHome.FlatStyle = FlatStyle.Flat;
            btMenuHome.Font = new Font("Arial", 18F, FontStyle.Bold);
            btMenuHome.ForeColor = Color.FromArgb(255, 252, 237);
            btMenuHome.Image = (Image)resources.GetObject("btMenuHome.Image");
            btMenuHome.ImageAlign = ContentAlignment.TopCenter;
            btMenuHome.Location = new Point(0, 3);
            btMenuHome.Name = "btMenuHome";
            btMenuHome.Size = new Size(212, 131);
            btMenuHome.TabIndex = 17;
            btMenuHome.TextAlign = ContentAlignment.BottomCenter;
            btMenuHome.UseVisualStyleBackColor = false;
            btMenuHome.Click += btHome_Click;
            // 
            // btMenuRotina
            // 
            btMenuRotina.BackColor = Color.FromArgb(230, 34, 34);
            btMenuRotina.Cursor = Cursors.Hand;
            btMenuRotina.FlatAppearance.BorderSize = 0;
            btMenuRotina.FlatStyle = FlatStyle.Flat;
            btMenuRotina.Font = new Font("Arial", 12.75F);
            btMenuRotina.ForeColor = Color.FromArgb(255, 252, 237);
            btMenuRotina.Image = (Image)resources.GetObject("btMenuRotina.Image");
            btMenuRotina.ImageAlign = ContentAlignment.MiddleLeft;
            btMenuRotina.Location = new Point(0, 458);
            btMenuRotina.Name = "btMenuRotina";
            btMenuRotina.Size = new Size(212, 47);
            btMenuRotina.TabIndex = 15;
            btMenuRotina.Text = "Rotina";
            btMenuRotina.UseVisualStyleBackColor = false;
            btMenuRotina.Click += btMenuRotina_Click;
            // 
            // btMenuSenhas
            // 
            btMenuSenhas.BackColor = Color.FromArgb(230, 34, 34);
            btMenuSenhas.Cursor = Cursors.Hand;
            btMenuSenhas.FlatAppearance.BorderSize = 0;
            btMenuSenhas.FlatStyle = FlatStyle.Flat;
            btMenuSenhas.Font = new Font("Arial", 12.75F);
            btMenuSenhas.ForeColor = Color.FromArgb(255, 252, 237);
            btMenuSenhas.Image = (Image)resources.GetObject("btMenuSenhas.Image");
            btMenuSenhas.ImageAlign = ContentAlignment.MiddleLeft;
            btMenuSenhas.Location = new Point(0, 193);
            btMenuSenhas.Name = "btMenuSenhas";
            btMenuSenhas.Size = new Size(212, 47);
            btMenuSenhas.TabIndex = 16;
            btMenuSenhas.Text = "Senhas";
            btMenuSenhas.UseVisualStyleBackColor = false;
            btMenuSenhas.Click += btSenhas_Click;
            // 
            // btMenuLembretes
            // 
            btMenuLembretes.BackColor = Color.FromArgb(230, 34, 34);
            btMenuLembretes.Cursor = Cursors.Hand;
            btMenuLembretes.FlatAppearance.BorderSize = 0;
            btMenuLembretes.FlatStyle = FlatStyle.Flat;
            btMenuLembretes.Font = new Font("Arial", 12.75F);
            btMenuLembretes.ForeColor = Color.FromArgb(255, 252, 237);
            btMenuLembretes.Image = (Image)resources.GetObject("btMenuLembretes.Image");
            btMenuLembretes.ImageAlign = ContentAlignment.MiddleLeft;
            btMenuLembretes.Location = new Point(0, 405);
            btMenuLembretes.Name = "btMenuLembretes";
            btMenuLembretes.Size = new Size(212, 47);
            btMenuLembretes.TabIndex = 14;
            btMenuLembretes.Text = "Lembretes";
            btMenuLembretes.UseVisualStyleBackColor = false;
            btMenuLembretes.Click += btMenuLembretes_Click;
            // 
            // btMenuCalculadora
            // 
            btMenuCalculadora.BackColor = Color.FromArgb(230, 34, 34);
            btMenuCalculadora.Cursor = Cursors.Hand;
            btMenuCalculadora.FlatAppearance.BorderSize = 0;
            btMenuCalculadora.FlatStyle = FlatStyle.Flat;
            btMenuCalculadora.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMenuCalculadora.ForeColor = Color.FromArgb(255, 252, 237);
            btMenuCalculadora.Image = (Image)resources.GetObject("btMenuCalculadora.Image");
            btMenuCalculadora.ImageAlign = ContentAlignment.MiddleLeft;
            btMenuCalculadora.Location = new Point(0, 140);
            btMenuCalculadora.Name = "btMenuCalculadora";
            btMenuCalculadora.Size = new Size(212, 47);
            btMenuCalculadora.TabIndex = 10;
            btMenuCalculadora.Text = "Calculadora";
            btMenuCalculadora.UseVisualStyleBackColor = false;
            btMenuCalculadora.Click += btCalculadora_Click;
            // 
            // btMenuFinanceiro
            // 
            btMenuFinanceiro.BackColor = Color.FromArgb(230, 34, 34);
            btMenuFinanceiro.Cursor = Cursors.Hand;
            btMenuFinanceiro.FlatAppearance.BorderSize = 0;
            btMenuFinanceiro.FlatStyle = FlatStyle.Flat;
            btMenuFinanceiro.Font = new Font("Arial", 12.75F);
            btMenuFinanceiro.ForeColor = Color.FromArgb(255, 252, 237);
            btMenuFinanceiro.Image = (Image)resources.GetObject("btMenuFinanceiro.Image");
            btMenuFinanceiro.ImageAlign = ContentAlignment.MiddleLeft;
            btMenuFinanceiro.Location = new Point(0, 352);
            btMenuFinanceiro.Name = "btMenuFinanceiro";
            btMenuFinanceiro.Size = new Size(212, 47);
            btMenuFinanceiro.TabIndex = 13;
            btMenuFinanceiro.Text = "Financeiro";
            btMenuFinanceiro.UseVisualStyleBackColor = false;
            // 
            // btMenuCalendario
            // 
            btMenuCalendario.BackColor = Color.FromArgb(230, 34, 34);
            btMenuCalendario.Cursor = Cursors.Hand;
            btMenuCalendario.FlatAppearance.BorderSize = 0;
            btMenuCalendario.FlatStyle = FlatStyle.Flat;
            btMenuCalendario.Font = new Font("Arial", 12.75F);
            btMenuCalendario.ForeColor = Color.FromArgb(255, 252, 237);
            btMenuCalendario.Image = (Image)resources.GetObject("btMenuCalendario.Image");
            btMenuCalendario.ImageAlign = ContentAlignment.MiddleLeft;
            btMenuCalendario.Location = new Point(0, 246);
            btMenuCalendario.Name = "btMenuCalendario";
            btMenuCalendario.Size = new Size(212, 47);
            btMenuCalendario.TabIndex = 11;
            btMenuCalendario.Text = "Calendário";
            btMenuCalendario.UseVisualStyleBackColor = false;
            btMenuCalendario.Click += btCalendario_Click;
            // 
            // btMenuContatos
            // 
            btMenuContatos.BackColor = Color.FromArgb(230, 34, 34);
            btMenuContatos.Cursor = Cursors.Hand;
            btMenuContatos.FlatAppearance.BorderSize = 0;
            btMenuContatos.FlatStyle = FlatStyle.Flat;
            btMenuContatos.Font = new Font("Arial", 12.75F);
            btMenuContatos.ForeColor = Color.FromArgb(255, 252, 237);
            btMenuContatos.Image = (Image)resources.GetObject("btMenuContatos.Image");
            btMenuContatos.ImageAlign = ContentAlignment.MiddleLeft;
            btMenuContatos.Location = new Point(0, 299);
            btMenuContatos.Name = "btMenuContatos";
            btMenuContatos.Size = new Size(212, 47);
            btMenuContatos.TabIndex = 12;
            btMenuContatos.Text = "Contatos";
            btMenuContatos.UseVisualStyleBackColor = false;
            btMenuContatos.Click += btContatos_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 34, 34);
            Controls.Add(btMenuHome);
            Controls.Add(btMenuRotina);
            Controls.Add(btMenuSenhas);
            Controls.Add(btMenuLembretes);
            Controls.Add(btMenuCalculadora);
            Controls.Add(btMenuFinanceiro);
            Controls.Add(btMenuCalendario);
            Controls.Add(btMenuContatos);
            Name = "Menu";
            Size = new Size(212, 1000);
            ResumeLayout(false);
        }

        #endregion

        private Button btMenuHome;
        private Button btMenuRotina;
        private Button btMenuSenhas;
        private Button btMenuLembretes;
        private Button btMenuCalculadora;
        private Button btMenuFinanceiro;
        private Button btMenuCalendario;
        private Button btMenuContatos;
    }
}
