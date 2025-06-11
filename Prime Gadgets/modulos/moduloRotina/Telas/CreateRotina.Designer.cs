namespace Prime_Gadgets.modulos.moduloRotina
{
    partial class CreateRotina
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbCreateRotinaDiaSelecionado;
        private System.Windows.Forms.ComboBox cbCreateRotinaDia;
        private System.Windows.Forms.Label lbCreateRotinaNome;
        private System.Windows.Forms.TextBox campCreateRotinaNome;
        private System.Windows.Forms.Label lbCreateRotinaHorario;
        private System.Windows.Forms.TextBox campCreateRotinaHorario;
        private System.Windows.Forms.Label lbCreateRotinaHorarioInvalid;
        private System.Windows.Forms.Button btCreateRotinaCriar;
        private System.Windows.Forms.Button btCreateRotinaCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRotina));
            lbCreateRotinaDiaSelecionado = new Label();
            cbCreateRotinaDia = new ComboBox();
            lbCreateRotinaNome = new Label();
            campCreateRotinaNome = new TextBox();
            lbCreateRotinaHorario = new Label();
            campCreateRotinaHorario = new TextBox();
            lbCreateRotinaHorarioInvalid = new Label();
            btCreateRotinaCriar = new Button();
            btCreateRotinaCancelar = new Button();
            lbCreateContatosTitulo = new Label();
            SuspendLayout();
            // 
            // lbCreateRotinaDiaSelecionado
            // 
            lbCreateRotinaDiaSelecionado.AutoSize = true;
            lbCreateRotinaDiaSelecionado.Font = new Font("Arial", 10F, FontStyle.Bold);
            lbCreateRotinaDiaSelecionado.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateRotinaDiaSelecionado.Location = new Point(102, 62);
            lbCreateRotinaDiaSelecionado.Name = "lbCreateRotinaDiaSelecionado";
            lbCreateRotinaDiaSelecionado.Size = new Size(197, 16);
            lbCreateRotinaDiaSelecionado.TabIndex = 0;
            lbCreateRotinaDiaSelecionado.Text = "Dia da Semana, dd/MM/yyyy";
            // 
            // cbCreateRotinaDia
            // 
            cbCreateRotinaDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCreateRotinaDia.Enabled = false;
            cbCreateRotinaDia.Font = new Font("Arial", 12.75F);
            cbCreateRotinaDia.FormattingEnabled = true;
            cbCreateRotinaDia.Items.AddRange(new object[] { DayOfWeek.Sunday, DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday });
            cbCreateRotinaDia.Location = new Point(104, 88);
            cbCreateRotinaDia.Name = "cbCreateRotinaDia";
            cbCreateRotinaDia.Size = new Size(226, 27);
            cbCreateRotinaDia.TabIndex = 1;
            // 
            // lbCreateRotinaNome
            // 
            lbCreateRotinaNome.AutoSize = true;
            lbCreateRotinaNome.Font = new Font("Arial", 12.75F);
            lbCreateRotinaNome.Location = new Point(39, 130);
            lbCreateRotinaNome.Name = "lbCreateRotinaNome";
            lbCreateRotinaNome.Size = new Size(51, 19);
            lbCreateRotinaNome.TabIndex = 2;
            lbCreateRotinaNome.Text = "Nome";
            // 
            // campCreateRotinaNome
            // 
            campCreateRotinaNome.BackColor = Color.FromArgb(255, 252, 237);
            campCreateRotinaNome.Font = new Font("Arial", 12.75F);
            campCreateRotinaNome.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateRotinaNome.Location = new Point(104, 123);
            campCreateRotinaNome.Name = "campCreateRotinaNome";
            campCreateRotinaNome.Size = new Size(226, 27);
            campCreateRotinaNome.TabIndex = 3;
            campCreateRotinaNome.TextChanged += Campos_TextChanged;
            // 
            // lbCreateRotinaHorario
            // 
            lbCreateRotinaHorario.AutoSize = true;
            lbCreateRotinaHorario.Font = new Font("Arial", 12.75F);
            lbCreateRotinaHorario.Location = new Point(33, 166);
            lbCreateRotinaHorario.Name = "lbCreateRotinaHorario";
            lbCreateRotinaHorario.Size = new Size(63, 19);
            lbCreateRotinaHorario.TabIndex = 4;
            lbCreateRotinaHorario.Text = "Horário";
            // 
            // campCreateRotinaHorario
            // 
            campCreateRotinaHorario.BackColor = Color.FromArgb(255, 252, 237);
            campCreateRotinaHorario.Font = new Font("Arial", 12.75F);
            campCreateRotinaHorario.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateRotinaHorario.Location = new Point(104, 158);
            campCreateRotinaHorario.Name = "campCreateRotinaHorario";
            campCreateRotinaHorario.Size = new Size(226, 27);
            campCreateRotinaHorario.TabIndex = 5;
            campCreateRotinaHorario.TextChanged += Campos_TextChanged;
            campCreateRotinaHorario.Validating += campCreateRotinaHorario_Validating;
            // 
            // lbCreateRotinaHorarioInvalid
            // 
            lbCreateRotinaHorarioInvalid.AutoSize = true;
            lbCreateRotinaHorarioInvalid.ForeColor = Color.Red;
            lbCreateRotinaHorarioInvalid.Location = new Point(104, 187);
            lbCreateRotinaHorarioInvalid.Name = "lbCreateRotinaHorarioInvalid";
            lbCreateRotinaHorarioInvalid.Size = new Size(146, 15);
            lbCreateRotinaHorarioInvalid.TabIndex = 6;
            lbCreateRotinaHorarioInvalid.Text = "Horário inválido (HH:mm)";
            // 
            // btCreateRotinaCriar
            // 
            btCreateRotinaCriar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateRotinaCriar.FlatAppearance.BorderSize = 0;
            btCreateRotinaCriar.FlatStyle = FlatStyle.Flat;
            btCreateRotinaCriar.Font = new Font("Arial", 12.75F);
            btCreateRotinaCriar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateRotinaCriar.Location = new Point(33, 214);
            btCreateRotinaCriar.Name = "btCreateRotinaCriar";
            btCreateRotinaCriar.Size = new Size(120, 35);
            btCreateRotinaCriar.TabIndex = 7;
            btCreateRotinaCriar.Text = "Criar";
            btCreateRotinaCriar.UseVisualStyleBackColor = false;
            btCreateRotinaCriar.EnabledChanged += btCreateRotinaCriar_EnabledChanged;
            btCreateRotinaCriar.Click += btCreateRotinaCriar_Click;
            // 
            // btCreateRotinaCancelar
            // 
            btCreateRotinaCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateRotinaCancelar.FlatAppearance.BorderSize = 0;
            btCreateRotinaCancelar.FlatStyle = FlatStyle.Flat;
            btCreateRotinaCancelar.Font = new Font("Arial", 12.75F);
            btCreateRotinaCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateRotinaCancelar.Location = new Point(212, 214);
            btCreateRotinaCancelar.Name = "btCreateRotinaCancelar";
            btCreateRotinaCancelar.Size = new Size(120, 35);
            btCreateRotinaCancelar.TabIndex = 8;
            btCreateRotinaCancelar.Text = "Cancelar";
            btCreateRotinaCancelar.UseVisualStyleBackColor = false;
            btCreateRotinaCancelar.Click += btCreateRotinaCancelar_Click;
            // 
            // lbCreateContatosTitulo
            // 
            lbCreateContatosTitulo.AutoSize = true;
            lbCreateContatosTitulo.BackColor = Color.Transparent;
            lbCreateContatosTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCreateContatosTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateContatosTitulo.Location = new Point(50, 9);
            lbCreateContatosTitulo.Name = "lbCreateContatosTitulo";
            lbCreateContatosTitulo.Size = new Size(280, 36);
            lbCreateContatosTitulo.TabIndex = 9;
            lbCreateContatosTitulo.Text = "Adicionar Atividade";
            // 
            // CreateRotina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(376, 269);
            Controls.Add(lbCreateContatosTitulo);
            Controls.Add(lbCreateRotinaDiaSelecionado);
            Controls.Add(cbCreateRotinaDia);
            Controls.Add(lbCreateRotinaNome);
            Controls.Add(campCreateRotinaNome);
            Controls.Add(lbCreateRotinaHorario);
            Controls.Add(campCreateRotinaHorario);
            Controls.Add(lbCreateRotinaHorarioInvalid);
            Controls.Add(btCreateRotinaCriar);
            Controls.Add(btCreateRotinaCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateRotina";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Atividade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreateContatosTitulo;
    }
}