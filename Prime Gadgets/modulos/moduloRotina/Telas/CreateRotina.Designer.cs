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
            this.lbCreateRotinaDiaSelecionado = new System.Windows.Forms.Label();
            this.cbCreateRotinaDia = new System.Windows.Forms.ComboBox();
            this.lbCreateRotinaNome = new System.Windows.Forms.Label();
            this.campCreateRotinaNome = new System.Windows.Forms.TextBox();
            this.lbCreateRotinaHorario = new System.Windows.Forms.Label();
            this.campCreateRotinaHorario = new System.Windows.Forms.TextBox();
            this.lbCreateRotinaHorarioInvalid = new System.Windows.Forms.Label();
            this.btCreateRotinaCriar = new System.Windows.Forms.Button();
            this.btCreateRotinaCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCreateRotinaDiaSelecionado
            // 
            this.lbCreateRotinaDiaSelecionado.AutoSize = true;
            this.lbCreateRotinaDiaSelecionado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCreateRotinaDiaSelecionado.Location = new System.Drawing.Point(30, 15);
            this.lbCreateRotinaDiaSelecionado.Name = "lbCreateRotinaDiaSelecionado";
            this.lbCreateRotinaDiaSelecionado.Size = new System.Drawing.Size(180, 19);
            this.lbCreateRotinaDiaSelecionado.TabIndex = 0;
            this.lbCreateRotinaDiaSelecionado.Text = "Dia da Semana, dd/MM/yyyy";
            // 
            // cbCreateRotinaDia
            // 
            this.cbCreateRotinaDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreateRotinaDia.FormattingEnabled = true;
            this.cbCreateRotinaDia.Location = new System.Drawing.Point(30, 40);
            this.cbCreateRotinaDia.Name = "cbCreateRotinaDia";
            this.cbCreateRotinaDia.Size = new System.Drawing.Size(180, 23);
            this.cbCreateRotinaDia.TabIndex = 1;
            this.cbCreateRotinaDia.Items.AddRange(new object[] {
                System.DayOfWeek.Sunday,
                System.DayOfWeek.Monday,
                System.DayOfWeek.Tuesday,
                System.DayOfWeek.Wednesday,
                System.DayOfWeek.Thursday,
                System.DayOfWeek.Friday,
                System.DayOfWeek.Saturday
            });
            this.cbCreateRotinaDia.Enabled = false;
            // 
            // lbCreateRotinaNome
            // 
            this.lbCreateRotinaNome.AutoSize = true;
            this.lbCreateRotinaNome.Location = new System.Drawing.Point(30, 75);
            this.lbCreateRotinaNome.Name = "lbCreateRotinaNome";
            this.lbCreateRotinaNome.Size = new System.Drawing.Size(43, 15);
            this.lbCreateRotinaNome.TabIndex = 2;
            this.lbCreateRotinaNome.Text = "Nome:";
            // 
            // campCreateRotinaNome
            // 
            this.campCreateRotinaNome.Location = new System.Drawing.Point(30, 95);
            this.campCreateRotinaNome.Name = "campCreateRotinaNome";
            this.campCreateRotinaNome.Size = new System.Drawing.Size(180, 23);
            this.campCreateRotinaNome.TabIndex = 3;
            this.campCreateRotinaNome.TextChanged += new System.EventHandler(this.Campos_TextChanged);
            // 
            // lbCreateRotinaHorario
            // 
            this.lbCreateRotinaHorario.AutoSize = true;
            this.lbCreateRotinaHorario.Location = new System.Drawing.Point(30, 130);
            this.lbCreateRotinaHorario.Name = "lbCreateRotinaHorario";
            this.lbCreateRotinaHorario.Size = new System.Drawing.Size(52, 15);
            this.lbCreateRotinaHorario.TabIndex = 4;
            this.lbCreateRotinaHorario.Text = "Horário:";
            // 
            // campCreateRotinaHorario
            // 
            this.campCreateRotinaHorario.Location = new System.Drawing.Point(30, 150);
            this.campCreateRotinaHorario.Name = "campCreateRotinaHorario";
            this.campCreateRotinaHorario.Size = new System.Drawing.Size(180, 23);
            this.campCreateRotinaHorario.TabIndex = 5;
            this.campCreateRotinaHorario.TextChanged += new System.EventHandler(this.Campos_TextChanged);
            this.campCreateRotinaHorario.Validating += new System.ComponentModel.CancelEventHandler(this.campCreateRotinaHorario_Validating);
            // 
            // lbCreateRotinaHorarioInvalid
            // 
            this.lbCreateRotinaHorarioInvalid.AutoSize = true;
            this.lbCreateRotinaHorarioInvalid.ForeColor = System.Drawing.Color.Red;
            this.lbCreateRotinaHorarioInvalid.Location = new System.Drawing.Point(30, 176);
            this.lbCreateRotinaHorarioInvalid.Name = "lbCreateRotinaHorarioInvalid";
            this.lbCreateRotinaHorarioInvalid.Size = new System.Drawing.Size(120, 15);
            this.lbCreateRotinaHorarioInvalid.TabIndex = 6;
            this.lbCreateRotinaHorarioInvalid.Text = "Horário inválido (HH:mm)";
            // 
            // btCreateRotinaCriar
            // 
            this.btCreateRotinaCriar.Location = new System.Drawing.Point(30, 210);
            this.btCreateRotinaCriar.Name = "btCreateRotinaCriar";
            this.btCreateRotinaCriar.Size = new System.Drawing.Size(80, 30);
            this.btCreateRotinaCriar.TabIndex = 7;
            this.btCreateRotinaCriar.Text = "Criar";
            this.btCreateRotinaCriar.UseVisualStyleBackColor = true;
            this.btCreateRotinaCriar.Click += new System.EventHandler(this.btCreateRotinaCriar_Click);
            this.btCreateRotinaCriar.EnabledChanged += new System.EventHandler(this.btCreateRotinaCriar_EnabledChanged);
            // 
            // btCreateRotinaCancelar
            // 
            this.btCreateRotinaCancelar.Location = new System.Drawing.Point(130, 210);
            this.btCreateRotinaCancelar.Name = "btCreateRotinaCancelar";
            this.btCreateRotinaCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCreateRotinaCancelar.TabIndex = 8;
            this.btCreateRotinaCancelar.Text = "Cancelar";
            this.btCreateRotinaCancelar.UseVisualStyleBackColor = true;
            this.btCreateRotinaCancelar.Click += new System.EventHandler(this.btCreateRotinaCancelar_Click);
            // 
            // CreateRotina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 270);
            this.Controls.Add(this.lbCreateRotinaDiaSelecionado);
            this.Controls.Add(this.cbCreateRotinaDia);
            this.Controls.Add(this.lbCreateRotinaNome);
            this.Controls.Add(this.campCreateRotinaNome);
            this.Controls.Add(this.lbCreateRotinaHorario);
            this.Controls.Add(this.campCreateRotinaHorario);
            this.Controls.Add(this.lbCreateRotinaHorarioInvalid);
            this.Controls.Add(this.btCreateRotinaCriar);
            this.Controls.Add(this.btCreateRotinaCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRotina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Atividade";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}