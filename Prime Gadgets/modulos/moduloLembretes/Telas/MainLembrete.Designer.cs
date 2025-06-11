namespace Prime_Gadgets.modulos.moduloLembretes
{
    partial class MainLembrete
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel panelMainLembreteSecoes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMainLembreteSecoes = new TableLayoutPanel();
            menu1 = new Menu();
            btMainLembreteCreate = new Button();
            btMainLembreteEdit = new Button();
            lbMainRotinaTitulo = new Label();
            SuspendLayout();
            // 
            // panelMainLembreteSecoes
            // 
            panelMainLembreteSecoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelMainLembreteSecoes.AutoScroll = true;
            panelMainLembreteSecoes.BackColor = Color.FromArgb(255, 252, 237);
            panelMainLembreteSecoes.ColumnCount = 1;
            panelMainLembreteSecoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelMainLembreteSecoes.Font = new Font("Arial", 9F);
            panelMainLembreteSecoes.ForeColor = Color.FromArgb(230, 34, 34);
            panelMainLembreteSecoes.Location = new Point(480, 92);
            panelMainLembreteSecoes.Margin = new Padding(3, 2, 3, 2);
            panelMainLembreteSecoes.Name = "panelMainLembreteSecoes";
            panelMainLembreteSecoes.RowCount = 1;
            panelMainLembreteSecoes.RowStyles.Add(new RowStyle());
            panelMainLembreteSecoes.Size = new Size(386, 527);
            panelMainLembreteSecoes.TabIndex = 5;
            // 
            // menu1
            // 
            menu1.BackColor = Color.FromArgb(230, 34, 34);
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(212, 650);
            menu1.TabIndex = 6;
            // 
            // btMainLembreteCreate
            // 
            btMainLembreteCreate.Anchor = AnchorStyles.Top;
            btMainLembreteCreate.BackColor = Color.FromArgb(230, 34, 34);
            btMainLembreteCreate.FlatAppearance.BorderColor = Color.White;
            btMainLembreteCreate.FlatAppearance.BorderSize = 0;
            btMainLembreteCreate.FlatStyle = FlatStyle.Flat;
            btMainLembreteCreate.Font = new Font("Arial", 12.75F);
            btMainLembreteCreate.ForeColor = Color.FromArgb(255, 252, 237);
            btMainLembreteCreate.Location = new Point(248, 92);
            btMainLembreteCreate.Name = "btMainLembreteCreate";
            btMainLembreteCreate.Size = new Size(191, 37);
            btMainLembreteCreate.TabIndex = 7;
            btMainLembreteCreate.Text = "Adicionar";
            btMainLembreteCreate.UseVisualStyleBackColor = false;
            btMainLembreteCreate.Click += btMainLembreteCreate_Click;
            // 
            // btMainLembreteEdit
            // 
            btMainLembreteEdit.Anchor = AnchorStyles.Top;
            btMainLembreteEdit.BackColor = Color.FromArgb(230, 34, 34);
            btMainLembreteEdit.FlatAppearance.BorderColor = Color.White;
            btMainLembreteEdit.FlatAppearance.BorderSize = 0;
            btMainLembreteEdit.FlatStyle = FlatStyle.Flat;
            btMainLembreteEdit.Font = new Font("Arial", 12.75F);
            btMainLembreteEdit.ForeColor = Color.FromArgb(255, 252, 237);
            btMainLembreteEdit.Location = new Point(248, 151);
            btMainLembreteEdit.Name = "btMainLembreteEdit";
            btMainLembreteEdit.Size = new Size(191, 37);
            btMainLembreteEdit.TabIndex = 8;
            btMainLembreteEdit.Text = "Editar";
            btMainLembreteEdit.UseVisualStyleBackColor = false;
            btMainLembreteEdit.Click += btMainLembreteEdit_Click;
            // 
            // lbMainRotinaTitulo
            // 
            lbMainRotinaTitulo.Anchor = AnchorStyles.Top;
            lbMainRotinaTitulo.AutoSize = true;
            lbMainRotinaTitulo.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbMainRotinaTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainRotinaTitulo.Location = new Point(582, 27);
            lbMainRotinaTitulo.Name = "lbMainRotinaTitulo";
            lbMainRotinaTitulo.Size = new Size(180, 37);
            lbMainRotinaTitulo.TabIndex = 9;
            lbMainRotinaTitulo.Text = "Lembretes";
            // 
            // MainLembrete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1000, 650);
            Controls.Add(lbMainRotinaTitulo);
            Controls.Add(btMainLembreteCreate);
            Controls.Add(btMainLembreteEdit);
            Controls.Add(menu1);
            Controls.Add(panelMainLembreteSecoes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1000, 650);
            Name = "MainLembrete";
            Text = "Lembretes";
            ResumeLayout(false);
            PerformLayout();
        }
        private Menu menu1;
        private Button btMainLembreteCreate;
        private Button btMainLembreteEdit;
        private Label lbMainRotinaTitulo;
    }
}