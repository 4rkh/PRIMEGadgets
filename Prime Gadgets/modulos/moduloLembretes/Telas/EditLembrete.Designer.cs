namespace Prime_Gadgets.modulos.moduloLembretes
{
    partial class EditLembrete
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbEditLembreteDiaSelecionado;
        private System.Windows.Forms.TableLayoutPanel panelEditLembreteSecoes;
        private System.Windows.Forms.Label lbEditLembreteNome;
        private System.Windows.Forms.TextBox campEditLembreteNome;
        private System.Windows.Forms.Button btEditLembreteSalvar;
        private System.Windows.Forms.Button btEditLembreteDeletar;
        private System.Windows.Forms.Button btEditLembreteCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLembrete));
            lbEditLembreteDiaSelecionado = new Label();
            panelEditLembreteSecoes = new TableLayoutPanel();
            lbEditLembreteNome = new Label();
            campEditLembreteNome = new TextBox();
            btEditLembreteSalvar = new Button();
            btEditLembreteDeletar = new Button();
            btEditLembreteCancelar = new Button();
            lbUpdateEventoTitulo = new Label();
            SuspendLayout();
            // 
            // lbEditLembreteDiaSelecionado
            // 
            lbEditLembreteDiaSelecionado.AutoSize = true;
            lbEditLembreteDiaSelecionado.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEditLembreteDiaSelecionado.ForeColor = Color.FromArgb(52, 60, 76);
            lbEditLembreteDiaSelecionado.Location = new Point(192, 56);
            lbEditLembreteDiaSelecionado.Name = "lbEditLembreteDiaSelecionado";
            lbEditLembreteDiaSelecionado.Size = new Size(44, 19);
            lbEditLembreteDiaSelecionado.TabIndex = 0;
            lbEditLembreteDiaSelecionado.Text = "Data";
            // 
            // panelEditLembreteSecoes
            // 
            panelEditLembreteSecoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEditLembreteSecoes.AutoScroll = true;
            panelEditLembreteSecoes.BackColor = Color.FromArgb(255, 252, 237);
            panelEditLembreteSecoes.ColumnCount = 1;
            panelEditLembreteSecoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelEditLembreteSecoes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelEditLembreteSecoes.ForeColor = Color.FromArgb(230, 34, 34);
            panelEditLembreteSecoes.Location = new Point(20, 80);
            panelEditLembreteSecoes.Margin = new Padding(3, 2, 3, 2);
            panelEditLembreteSecoes.Name = "panelEditLembreteSecoes";
            panelEditLembreteSecoes.RowCount = 1;
            panelEditLembreteSecoes.RowStyles.Add(new RowStyle());
            panelEditLembreteSecoes.Size = new Size(429, 135);
            panelEditLembreteSecoes.TabIndex = 1;
            // 
            // lbEditLembreteNome
            // 
            lbEditLembreteNome.Font = new Font("Arial", 12.75F);
            lbEditLembreteNome.ForeColor = Color.FromArgb(52, 60, 76);
            lbEditLembreteNome.Location = new Point(82, 230);
            lbEditLembreteNome.Name = "lbEditLembreteNome";
            lbEditLembreteNome.Size = new Size(61, 23);
            lbEditLembreteNome.TabIndex = 2;
            lbEditLembreteNome.Text = "Nome";
            // 
            // campEditLembreteNome
            // 
            campEditLembreteNome.BackColor = Color.FromArgb(255, 252, 237);
            campEditLembreteNome.Font = new Font("Arial", 12.75F);
            campEditLembreteNome.ForeColor = Color.FromArgb(230, 34, 34);
            campEditLembreteNome.Location = new Point(149, 226);
            campEditLembreteNome.Margin = new Padding(3, 2, 3, 2);
            campEditLembreteNome.Name = "campEditLembreteNome";
            campEditLembreteNome.Size = new Size(226, 27);
            campEditLembreteNome.TabIndex = 3;
            campEditLembreteNome.TextChanged += campEditLembreteNome_TextChanged;
            // 
            // btEditLembreteSalvar
            // 
            btEditLembreteSalvar.BackColor = Color.FromArgb(230, 34, 34);
            btEditLembreteSalvar.FlatAppearance.BorderSize = 0;
            btEditLembreteSalvar.FlatStyle = FlatStyle.Flat;
            btEditLembreteSalvar.Font = new Font("Arial", 12.75F);
            btEditLembreteSalvar.ForeColor = Color.FromArgb(255, 252, 237);
            btEditLembreteSalvar.Location = new Point(20, 268);
            btEditLembreteSalvar.Margin = new Padding(3, 2, 3, 2);
            btEditLembreteSalvar.Name = "btEditLembreteSalvar";
            btEditLembreteSalvar.Size = new Size(120, 35);
            btEditLembreteSalvar.TabIndex = 4;
            btEditLembreteSalvar.Text = "Salvar";
            btEditLembreteSalvar.UseVisualStyleBackColor = false;
            btEditLembreteSalvar.Click += btEditLembreteSalvar_Click;
            // 
            // btEditLembreteDeletar
            // 
            btEditLembreteDeletar.BackColor = Color.FromArgb(230, 34, 34);
            btEditLembreteDeletar.FlatAppearance.BorderSize = 0;
            btEditLembreteDeletar.FlatStyle = FlatStyle.Flat;
            btEditLembreteDeletar.Font = new Font("Arial", 12.75F);
            btEditLembreteDeletar.ForeColor = Color.FromArgb(255, 252, 237);
            btEditLembreteDeletar.Location = new Point(175, 268);
            btEditLembreteDeletar.Margin = new Padding(3, 2, 3, 2);
            btEditLembreteDeletar.Name = "btEditLembreteDeletar";
            btEditLembreteDeletar.Size = new Size(120, 35);
            btEditLembreteDeletar.TabIndex = 5;
            btEditLembreteDeletar.Text = "Deletar";
            btEditLembreteDeletar.UseVisualStyleBackColor = false;
            btEditLembreteDeletar.Click += btEditLembreteDeletar_Click;
            // 
            // btEditLembreteCancelar
            // 
            btEditLembreteCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btEditLembreteCancelar.FlatAppearance.BorderSize = 0;
            btEditLembreteCancelar.FlatStyle = FlatStyle.Flat;
            btEditLembreteCancelar.Font = new Font("Arial", 12.75F);
            btEditLembreteCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btEditLembreteCancelar.Location = new Point(329, 268);
            btEditLembreteCancelar.Margin = new Padding(3, 2, 3, 2);
            btEditLembreteCancelar.Name = "btEditLembreteCancelar";
            btEditLembreteCancelar.Size = new Size(120, 35);
            btEditLembreteCancelar.TabIndex = 6;
            btEditLembreteCancelar.Text = "Cancelar";
            btEditLembreteCancelar.UseVisualStyleBackColor = false;
            btEditLembreteCancelar.Click += btEditLembreteCancelar_Click;
            // 
            // lbUpdateEventoTitulo
            // 
            lbUpdateEventoTitulo.AutoSize = true;
            lbUpdateEventoTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUpdateEventoTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbUpdateEventoTitulo.Location = new Point(118, 9);
            lbUpdateEventoTitulo.Name = "lbUpdateEventoTitulo";
            lbUpdateEventoTitulo.Size = new Size(239, 36);
            lbUpdateEventoTitulo.TabIndex = 7;
            lbUpdateEventoTitulo.Text = "Editar Lembrete";
            // 
            // EditLembrete
            // 
            StartPosition = FormStartPosition.CenterParent;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(473, 336);
            Controls.Add(lbUpdateEventoTitulo);
            Controls.Add(btEditLembreteCancelar);
            Controls.Add(btEditLembreteDeletar);
            Controls.Add(btEditLembreteSalvar);
            Controls.Add(campEditLembreteNome);
            Controls.Add(lbEditLembreteNome);
            Controls.Add(panelEditLembreteSecoes);
            Controls.Add(lbEditLembreteDiaSelecionado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditLembrete";
            Text = "Editar Lembrete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUpdateEventoTitulo;
    }
}