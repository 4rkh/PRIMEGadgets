namespace Prime_Gadgets.modulos.moduloRotina
{
    partial class EditRotina
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbEditRotinaDiaSelecionado;
        private System.Windows.Forms.TableLayoutPanel panelEditRotinaSecoes;
        private System.Windows.Forms.Label lbEditRotinaNome;
        private System.Windows.Forms.TextBox campEditRotinaNome;
        private System.Windows.Forms.Label lbEditRotinaHorario;
        private System.Windows.Forms.TextBox campEditRotinaHorario;
        private System.Windows.Forms.Label lbEditRotinaHorarioInvalid;
        private System.Windows.Forms.Button btEditRotinaSalvar;
        private System.Windows.Forms.Button btEditRotinaCancelar;
        private System.Windows.Forms.Button btEditRotinaDeletar;

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
            lbEditRotinaDiaSelecionado = new Label();
            panelEditRotinaSecoes = new TableLayoutPanel();
            lbEditRotinaNome = new Label();
            campEditRotinaNome = new TextBox();
            lbEditRotinaHorario = new Label();
            campEditRotinaHorario = new TextBox();
            lbEditRotinaHorarioInvalid = new Label();
            btEditRotinaSalvar = new Button();
            btEditRotinaCancelar = new Button();
            btEditRotinaDeletar = new Button();
            lbUpdateEventoTitulo = new Label();
            SuspendLayout();
            // 
            // lbEditRotinaDiaSelecionado
            // 
            lbEditRotinaDiaSelecionado.AutoSize = true;
            lbEditRotinaDiaSelecionado.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEditRotinaDiaSelecionado.ForeColor = Color.FromArgb(52, 60, 76);
            lbEditRotinaDiaSelecionado.Location = new Point(48, 45);
            lbEditRotinaDiaSelecionado.Name = "lbEditRotinaDiaSelecionado";
            lbEditRotinaDiaSelecionado.Size = new Size(227, 19);
            lbEditRotinaDiaSelecionado.TabIndex = 0;
            lbEditRotinaDiaSelecionado.Text = "Dia da Semana, dd/MM/yyyy";
            // 
            // panelEditRotinaSecoes
            // 
            panelEditRotinaSecoes.Anchor = AnchorStyles.Top;
            panelEditRotinaSecoes.AutoScroll = true;
            panelEditRotinaSecoes.AutoSize = true;
            panelEditRotinaSecoes.BackColor = Color.FromArgb(255, 252, 237);
            panelEditRotinaSecoes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelEditRotinaSecoes.ColumnCount = 1;
            panelEditRotinaSecoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelEditRotinaSecoes.Font = new Font("Arial", 12.75F);
            panelEditRotinaSecoes.ForeColor = Color.FromArgb(230, 34, 34);
            panelEditRotinaSecoes.Location = new Point(48, 85);
            panelEditRotinaSecoes.Name = "panelEditRotinaSecoes";
            panelEditRotinaSecoes.RowCount = 1;
            panelEditRotinaSecoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            panelEditRotinaSecoes.Size = new Size(378, 65);
            panelEditRotinaSecoes.TabIndex = 1;
            panelEditRotinaSecoes.TabStop = true;
            // 
            // lbEditRotinaNome
            // 
            lbEditRotinaNome.Anchor = AnchorStyles.Bottom;
            lbEditRotinaNome.AutoSize = true;
            lbEditRotinaNome.Font = new Font("Arial", 12.75F);
            lbEditRotinaNome.ForeColor = Color.FromArgb(52, 60, 76);
            lbEditRotinaNome.Location = new Point(75, 191);
            lbEditRotinaNome.Name = "lbEditRotinaNome";
            lbEditRotinaNome.Size = new Size(51, 19);
            lbEditRotinaNome.TabIndex = 2;
            lbEditRotinaNome.Text = "Nome";
            // 
            // campEditRotinaNome
            // 
            campEditRotinaNome.Anchor = AnchorStyles.Bottom;
            campEditRotinaNome.BackColor = Color.FromArgb(255, 252, 237);
            campEditRotinaNome.Font = new Font("Arial", 12.75F);
            campEditRotinaNome.ForeColor = Color.FromArgb(230, 34, 34);
            campEditRotinaNome.Location = new Point(149, 183);
            campEditRotinaNome.Name = "campEditRotinaNome";
            campEditRotinaNome.Size = new Size(226, 27);
            campEditRotinaNome.TabIndex = 3;
            campEditRotinaNome.TextChanged += Campos_TextChanged;
            // 
            // lbEditRotinaHorario
            // 
            lbEditRotinaHorario.Anchor = AnchorStyles.Bottom;
            lbEditRotinaHorario.AutoSize = true;
            lbEditRotinaHorario.Font = new Font("Arial", 12.75F);
            lbEditRotinaHorario.ForeColor = Color.FromArgb(52, 60, 76);
            lbEditRotinaHorario.Location = new Point(70, 219);
            lbEditRotinaHorario.Name = "lbEditRotinaHorario";
            lbEditRotinaHorario.Size = new Size(63, 19);
            lbEditRotinaHorario.TabIndex = 4;
            lbEditRotinaHorario.Text = "Horário";
            // 
            // campEditRotinaHorario
            // 
            campEditRotinaHorario.Anchor = AnchorStyles.Bottom;
            campEditRotinaHorario.BackColor = Color.FromArgb(255, 252, 237);
            campEditRotinaHorario.Font = new Font("Arial", 12.75F);
            campEditRotinaHorario.ForeColor = Color.FromArgb(230, 34, 34);
            campEditRotinaHorario.Location = new Point(149, 216);
            campEditRotinaHorario.Name = "campEditRotinaHorario";
            campEditRotinaHorario.Size = new Size(226, 27);
            campEditRotinaHorario.TabIndex = 5;
            campEditRotinaHorario.TextChanged += Campos_TextChanged;
            campEditRotinaHorario.Validating += campEditRotinaHorario_Validating;
            // 
            // lbEditRotinaHorarioInvalid
            // 
            lbEditRotinaHorarioInvalid.Anchor = AnchorStyles.Bottom;
            lbEditRotinaHorarioInvalid.AutoSize = true;
            lbEditRotinaHorarioInvalid.ForeColor = Color.Red;
            lbEditRotinaHorarioInvalid.Location = new Point(149, 246);
            lbEditRotinaHorarioInvalid.Name = "lbEditRotinaHorarioInvalid";
            lbEditRotinaHorarioInvalid.Size = new Size(146, 15);
            lbEditRotinaHorarioInvalid.TabIndex = 6;
            lbEditRotinaHorarioInvalid.Text = "Horário inválido (HH:mm)";
            // 
            // btEditRotinaSalvar
            // 
            btEditRotinaSalvar.Anchor = AnchorStyles.Bottom;
            btEditRotinaSalvar.BackColor = Color.FromArgb(230, 34, 34);
            btEditRotinaSalvar.FlatAppearance.BorderSize = 0;
            btEditRotinaSalvar.FlatStyle = FlatStyle.Flat;
            btEditRotinaSalvar.Font = new Font("Arial", 12.75F);
            btEditRotinaSalvar.ForeColor = Color.FromArgb(255, 252, 237);
            btEditRotinaSalvar.Location = new Point(20, 268);
            btEditRotinaSalvar.Name = "btEditRotinaSalvar";
            btEditRotinaSalvar.Size = new Size(120, 35);
            btEditRotinaSalvar.TabIndex = 7;
            btEditRotinaSalvar.Text = "Salvar";
            btEditRotinaSalvar.UseVisualStyleBackColor = false;
            btEditRotinaSalvar.EnabledChanged += btEditRotinaSalvar_EnabledChanged;
            btEditRotinaSalvar.Click += btEditRotinaSalvar_Click;
            // 
            // btEditRotinaCancelar
            // 
            btEditRotinaCancelar.Anchor = AnchorStyles.Bottom;
            btEditRotinaCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btEditRotinaCancelar.FlatAppearance.BorderSize = 0;
            btEditRotinaCancelar.FlatStyle = FlatStyle.Flat;
            btEditRotinaCancelar.Font = new Font("Arial", 12.75F);
            btEditRotinaCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btEditRotinaCancelar.Location = new Point(329, 268);
            btEditRotinaCancelar.Name = "btEditRotinaCancelar";
            btEditRotinaCancelar.Size = new Size(120, 35);
            btEditRotinaCancelar.TabIndex = 8;
            btEditRotinaCancelar.Text = "Cancelar";
            btEditRotinaCancelar.UseVisualStyleBackColor = false;
            btEditRotinaCancelar.Click += btEditRotinaCancelar_Click;
            // 
            // btEditRotinaDeletar
            // 
            btEditRotinaDeletar.Anchor = AnchorStyles.Bottom;
            btEditRotinaDeletar.BackColor = Color.FromArgb(230, 34, 34);
            btEditRotinaDeletar.FlatAppearance.BorderSize = 0;
            btEditRotinaDeletar.FlatStyle = FlatStyle.Flat;
            btEditRotinaDeletar.Font = new Font("Arial", 12.75F);
            btEditRotinaDeletar.ForeColor = Color.FromArgb(255, 252, 237);
            btEditRotinaDeletar.Location = new Point(175, 268);
            btEditRotinaDeletar.Name = "btEditRotinaDeletar";
            btEditRotinaDeletar.Size = new Size(120, 35);
            btEditRotinaDeletar.TabIndex = 0;
            btEditRotinaDeletar.Text = "Deletar";
            btEditRotinaDeletar.UseVisualStyleBackColor = false;
            btEditRotinaDeletar.Click += btEditRotinaDeletar_Click;
            // 
            // lbUpdateEventoTitulo
            // 
            lbUpdateEventoTitulo.AutoSize = true;
            lbUpdateEventoTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUpdateEventoTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbUpdateEventoTitulo.Location = new Point(118, 9);
            lbUpdateEventoTitulo.Name = "lbUpdateEventoTitulo";
            lbUpdateEventoTitulo.Size = new Size(231, 36);
            lbUpdateEventoTitulo.TabIndex = 9;
            lbUpdateEventoTitulo.Text = "Editar Atividade";
            // 
            // EditRotina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(473, 336);
            Controls.Add(lbUpdateEventoTitulo);
            Controls.Add(lbEditRotinaDiaSelecionado);
            Controls.Add(panelEditRotinaSecoes);
            Controls.Add(lbEditRotinaNome);
            Controls.Add(campEditRotinaNome);
            Controls.Add(lbEditRotinaHorario);
            Controls.Add(campEditRotinaHorario);
            Controls.Add(lbEditRotinaHorarioInvalid);
            Controls.Add(btEditRotinaSalvar);
            Controls.Add(btEditRotinaCancelar);
            Controls.Add(btEditRotinaDeletar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditRotina";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Atividade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUpdateEventoTitulo;
    }
}