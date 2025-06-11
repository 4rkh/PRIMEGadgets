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
            SuspendLayout();
            // 
            // lbEditRotinaDiaSelecionado
            // 
            lbEditRotinaDiaSelecionado.AutoSize = true;
            lbEditRotinaDiaSelecionado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbEditRotinaDiaSelecionado.Location = new Point(30, 15);
            lbEditRotinaDiaSelecionado.Name = "lbEditRotinaDiaSelecionado";
            lbEditRotinaDiaSelecionado.Size = new Size(205, 19);
            lbEditRotinaDiaSelecionado.TabIndex = 0;
            lbEditRotinaDiaSelecionado.Text = "Dia da Semana, dd/MM/yyyy";
            // 
            // panelEditRotinaSecoes
            // 
            panelEditRotinaSecoes.Anchor = AnchorStyles.Top;
            panelEditRotinaSecoes.AutoScroll = true;
            panelEditRotinaSecoes.AutoSize = true;
            panelEditRotinaSecoes.BackColor = SystemColors.Control;
            panelEditRotinaSecoes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelEditRotinaSecoes.ColumnCount = 1;
            panelEditRotinaSecoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelEditRotinaSecoes.Location = new Point(30, 47);
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
            lbEditRotinaNome.Location = new Point(30, 115);
            lbEditRotinaNome.Name = "lbEditRotinaNome";
            lbEditRotinaNome.Size = new Size(43, 15);
            lbEditRotinaNome.TabIndex = 2;
            lbEditRotinaNome.Text = "Nome:";
            // 
            // campEditRotinaNome
            // 
            campEditRotinaNome.Anchor = AnchorStyles.Bottom;
            campEditRotinaNome.Location = new Point(30, 135);
            campEditRotinaNome.Name = "campEditRotinaNome";
            campEditRotinaNome.Size = new Size(180, 23);
            campEditRotinaNome.TabIndex = 3;
            campEditRotinaNome.TextChanged += Campos_TextChanged;
            // 
            // lbEditRotinaHorario
            // 
            lbEditRotinaHorario.Anchor = AnchorStyles.Bottom;
            lbEditRotinaHorario.AutoSize = true;
            lbEditRotinaHorario.Location = new Point(30, 170);
            lbEditRotinaHorario.Name = "lbEditRotinaHorario";
            lbEditRotinaHorario.Size = new Size(50, 15);
            lbEditRotinaHorario.TabIndex = 4;
            lbEditRotinaHorario.Text = "Horário:";
            // 
            // campEditRotinaHorario
            // 
            campEditRotinaHorario.Anchor = AnchorStyles.Bottom;
            campEditRotinaHorario.Location = new Point(30, 190);
            campEditRotinaHorario.Name = "campEditRotinaHorario";
            campEditRotinaHorario.Size = new Size(180, 23);
            campEditRotinaHorario.TabIndex = 5;
            campEditRotinaHorario.TextChanged += Campos_TextChanged;
            campEditRotinaHorario.Validating += campEditRotinaHorario_Validating;
            // 
            // lbEditRotinaHorarioInvalid
            // 
            lbEditRotinaHorarioInvalid.Anchor = AnchorStyles.Bottom;
            lbEditRotinaHorarioInvalid.AutoSize = true;
            lbEditRotinaHorarioInvalid.ForeColor = Color.Red;
            lbEditRotinaHorarioInvalid.Location = new Point(30, 216);
            lbEditRotinaHorarioInvalid.Name = "lbEditRotinaHorarioInvalid";
            lbEditRotinaHorarioInvalid.Size = new Size(146, 15);
            lbEditRotinaHorarioInvalid.TabIndex = 6;
            lbEditRotinaHorarioInvalid.Text = "Horário inválido (HH:mm)";
            // 
            // btEditRotinaSalvar
            // 
            btEditRotinaSalvar.Anchor = AnchorStyles.Bottom;
            btEditRotinaSalvar.Location = new Point(30, 250);
            btEditRotinaSalvar.Name = "btEditRotinaSalvar";
            btEditRotinaSalvar.Size = new Size(80, 30);
            btEditRotinaSalvar.TabIndex = 7;
            btEditRotinaSalvar.Text = "Salvar";
            btEditRotinaSalvar.UseVisualStyleBackColor = true;
            btEditRotinaSalvar.EnabledChanged += btEditRotinaSalvar_EnabledChanged;
            btEditRotinaSalvar.Click += btEditRotinaSalvar_Click;
            // 
            // btEditRotinaCancelar
            // 
            btEditRotinaCancelar.Anchor = AnchorStyles.Bottom;
            btEditRotinaCancelar.Location = new Point(222, 251);
            btEditRotinaCancelar.Name = "btEditRotinaCancelar";
            btEditRotinaCancelar.Size = new Size(80, 30);
            btEditRotinaCancelar.TabIndex = 8;
            btEditRotinaCancelar.Text = "Cancelar";
            btEditRotinaCancelar.UseVisualStyleBackColor = true;
            btEditRotinaCancelar.Click += btEditRotinaCancelar_Click;
            // 
            // btEditRotinaDeletar
            // 
            btEditRotinaDeletar.Anchor = AnchorStyles.Bottom;
            btEditRotinaDeletar.BackColor = Color.FromArgb(230, 34, 34);
            btEditRotinaDeletar.ForeColor = Color.FromArgb(255, 252, 237);
            btEditRotinaDeletar.Location = new Point(116, 250);
            btEditRotinaDeletar.Name = "btEditRotinaDeletar";
            btEditRotinaDeletar.Size = new Size(100, 32);
            btEditRotinaDeletar.TabIndex = 0;
            btEditRotinaDeletar.Text = "Deletar";
            btEditRotinaDeletar.UseVisualStyleBackColor = false;
            btEditRotinaDeletar.Click += btEditRotinaDeletar_Click;
            // 
            // EditRotina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(442, 285);
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
    }
}