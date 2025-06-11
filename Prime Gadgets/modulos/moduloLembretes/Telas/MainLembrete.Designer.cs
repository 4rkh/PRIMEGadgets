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
            panelMainLembreteSecoes.Anchor = AnchorStyles.Top;
            panelMainLembreteSecoes.AutoScroll = true;
            panelMainLembreteSecoes.ColumnCount = 1;
            panelMainLembreteSecoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelMainLembreteSecoes.Location = new Point(512, 75);
            panelMainLembreteSecoes.Margin = new Padding(3, 2, 3, 2);
            panelMainLembreteSecoes.Name = "panelMainLembreteSecoes";
            panelMainLembreteSecoes.RowCount = 1;
            panelMainLembreteSecoes.RowStyles.Add(new RowStyle());
            panelMainLembreteSecoes.Size = new Size(402, 518);
            panelMainLembreteSecoes.TabIndex = 5;
            // 
            // menu1
            // 
            menu1.BackColor = Color.FromArgb(230, 34, 34);
            menu1.Location = new Point(1, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(212, 1000);
            menu1.TabIndex = 6;
            // 
            // btMainLembreteCreate
            // 
            btMainLembreteCreate.Anchor = AnchorStyles.Top;
            btMainLembreteCreate.BackColor = Color.FromArgb(230, 34, 34);
            btMainLembreteCreate.FlatAppearance.BorderColor = Color.White;
            btMainLembreteCreate.FlatAppearance.BorderSize = 2;
            btMainLembreteCreate.FlatStyle = FlatStyle.Flat;
            btMainLembreteCreate.Font = new Font("Comic Sans MS", 10F);
            btMainLembreteCreate.ForeColor = Color.White;
            btMainLembreteCreate.Location = new Point(939, 235);
            btMainLembreteCreate.Name = "btMainLembreteCreate";
            btMainLembreteCreate.Size = new Size(140, 45);
            btMainLembreteCreate.TabIndex = 7;
            btMainLembreteCreate.Text = "Criar Lembrete";
            btMainLembreteCreate.UseVisualStyleBackColor = false;
            btMainLembreteCreate.Click += btMainLembreteCreate_Click;
            // 
            // btMainLembreteEdit
            // 
            btMainLembreteEdit.Anchor = AnchorStyles.Top;
            btMainLembreteEdit.BackColor = Color.FromArgb(230, 34, 34);
            btMainLembreteEdit.FlatAppearance.BorderColor = Color.White;
            btMainLembreteEdit.FlatAppearance.BorderSize = 2;
            btMainLembreteEdit.FlatStyle = FlatStyle.Flat;
            btMainLembreteEdit.Font = new Font("Comic Sans MS", 10F);
            btMainLembreteEdit.ForeColor = Color.White;
            btMainLembreteEdit.Location = new Point(939, 350);
            btMainLembreteEdit.Name = "btMainLembreteEdit";
            btMainLembreteEdit.Size = new Size(140, 45);
            btMainLembreteEdit.TabIndex = 8;
            btMainLembreteEdit.Text = "Editar Lembrete";
            btMainLembreteEdit.UseVisualStyleBackColor = false;
            btMainLembreteEdit.Click += btMainLembreteEdit_Click;
            // 
            // lbMainRotinaTitulo
            // 
            lbMainRotinaTitulo.Anchor = AnchorStyles.Top;
            lbMainRotinaTitulo.AutoSize = true;
            lbMainRotinaTitulo.Font = new Font("Comic Sans MS", 18F);
            lbMainRotinaTitulo.ForeColor = Color.White;
            lbMainRotinaTitulo.Location = new Point(657, 24);
            lbMainRotinaTitulo.Name = "lbMainRotinaTitulo";
            lbMainRotinaTitulo.Size = new Size(132, 33);
            lbMainRotinaTitulo.TabIndex = 9;
            lbMainRotinaTitulo.Text = "Lembretes";
            // 
            // MainLembrete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1147, 604);
            Controls.Add(lbMainRotinaTitulo);
            Controls.Add(btMainLembreteCreate);
            Controls.Add(btMainLembreteEdit);
            Controls.Add(menu1);
            Controls.Add(panelMainLembreteSecoes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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