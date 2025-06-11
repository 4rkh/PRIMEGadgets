namespace Prime_Gadgets.modulos.moduloLembretes
{
    partial class CreateLembrete
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbCreateLembreteDiaSelecionado;
        private System.Windows.Forms.Label lbCreateLembreteNome;
        private System.Windows.Forms.TextBox campCreateLembreteNome;
        private System.Windows.Forms.Button btCreateLembreteCriar;
        private System.Windows.Forms.Button btCreateLembreteCancelar;
        private System.Windows.Forms.DateTimePicker dtpCreateLembreteDia;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLembrete));
            lbCreateLembreteDiaSelecionado = new Label();
            dtpCreateLembreteDia = new DateTimePicker();
            lbCreateLembreteNome = new Label();
            campCreateLembreteNome = new TextBox();
            btCreateLembreteCriar = new Button();
            btCreateLembreteCancelar = new Button();
            lbUpdateEventoTitulo = new Label();
            SuspendLayout();
            // 
            // lbCreateLembreteDiaSelecionado
            // 
            lbCreateLembreteDiaSelecionado.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCreateLembreteDiaSelecionado.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateLembreteDiaSelecionado.Location = new Point(38, 67);
            lbCreateLembreteDiaSelecionado.Name = "lbCreateLembreteDiaSelecionado";
            lbCreateLembreteDiaSelecionado.Size = new Size(56, 22);
            lbCreateLembreteDiaSelecionado.TabIndex = 0;
            lbCreateLembreteDiaSelecionado.Text = "Data:";
            // 
            // dtpCreateLembreteDia
            // 
            dtpCreateLembreteDia.CalendarMonthBackground = Color.FromArgb(255, 252, 237);
            dtpCreateLembreteDia.Format = DateTimePickerFormat.Short;
            dtpCreateLembreteDia.Location = new Point(101, 64);
            dtpCreateLembreteDia.Margin = new Padding(3, 2, 3, 2);
            dtpCreateLembreteDia.Name = "dtpCreateLembreteDia";
            dtpCreateLembreteDia.Size = new Size(226, 23);
            dtpCreateLembreteDia.TabIndex = 1;
            // 
            // lbCreateLembreteNome
            // 
            lbCreateLembreteNome.Font = new Font("Arial", 12.75F);
            lbCreateLembreteNome.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateLembreteNome.Location = new Point(36, 100);
            lbCreateLembreteNome.Name = "lbCreateLembreteNome";
            lbCreateLembreteNome.Size = new Size(59, 23);
            lbCreateLembreteNome.TabIndex = 2;
            lbCreateLembreteNome.Text = "Nome";
            // 
            // campCreateLembreteNome
            // 
            campCreateLembreteNome.BackColor = Color.FromArgb(255, 252, 237);
            campCreateLembreteNome.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateLembreteNome.Location = new Point(101, 100);
            campCreateLembreteNome.Margin = new Padding(3, 2, 3, 2);
            campCreateLembreteNome.Name = "campCreateLembreteNome";
            campCreateLembreteNome.Size = new Size(226, 23);
            campCreateLembreteNome.TabIndex = 3;
            campCreateLembreteNome.TextChanged += campCreateLembreteNome_TextChanged;
            // 
            // btCreateLembreteCriar
            // 
            btCreateLembreteCriar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateLembreteCriar.FlatAppearance.BorderSize = 0;
            btCreateLembreteCriar.FlatStyle = FlatStyle.Flat;
            btCreateLembreteCriar.Font = new Font("Arial", 12.75F);
            btCreateLembreteCriar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateLembreteCriar.Location = new Point(20, 150);
            btCreateLembreteCriar.Margin = new Padding(3, 2, 3, 2);
            btCreateLembreteCriar.Name = "btCreateLembreteCriar";
            btCreateLembreteCriar.Size = new Size(120, 35);
            btCreateLembreteCriar.TabIndex = 4;
            btCreateLembreteCriar.Text = "Criar";
            btCreateLembreteCriar.UseVisualStyleBackColor = false;
            btCreateLembreteCriar.Click += btCreateLembreteCriar_Click;
            // 
            // btCreateLembreteCancelar
            // 
            btCreateLembreteCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateLembreteCancelar.FlatAppearance.BorderSize = 0;
            btCreateLembreteCancelar.FlatStyle = FlatStyle.Flat;
            btCreateLembreteCancelar.Font = new Font("Arial", 12.75F);
            btCreateLembreteCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateLembreteCancelar.Location = new Point(207, 150);
            btCreateLembreteCancelar.Margin = new Padding(3, 2, 3, 2);
            btCreateLembreteCancelar.Name = "btCreateLembreteCancelar";
            btCreateLembreteCancelar.Size = new Size(120, 35);
            btCreateLembreteCancelar.TabIndex = 5;
            btCreateLembreteCancelar.Text = "Cancelar";
            btCreateLembreteCancelar.UseVisualStyleBackColor = false;
            btCreateLembreteCancelar.Click += btCreateLembreteCancelar_Click;
            // 
            // lbUpdateEventoTitulo
            // 
            lbUpdateEventoTitulo.AutoSize = true;
            lbUpdateEventoTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUpdateEventoTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbUpdateEventoTitulo.Location = new Point(32, 13);
            lbUpdateEventoTitulo.Name = "lbUpdateEventoTitulo";
            lbUpdateEventoTitulo.Size = new Size(288, 36);
            lbUpdateEventoTitulo.TabIndex = 6;
            lbUpdateEventoTitulo.Text = "Adicionar Lembrete";
            // 
            // CreateLembrete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(350, 204);
            Controls.Add(lbUpdateEventoTitulo);
            Controls.Add(btCreateLembreteCancelar);
            Controls.Add(btCreateLembreteCriar);
            Controls.Add(campCreateLembreteNome);
            Controls.Add(lbCreateLembreteNome);
            Controls.Add(dtpCreateLembreteDia);
            Controls.Add(lbCreateLembreteDiaSelecionado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateLembrete";
            Text = "Adicionar Lembrete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUpdateEventoTitulo;
    }
}