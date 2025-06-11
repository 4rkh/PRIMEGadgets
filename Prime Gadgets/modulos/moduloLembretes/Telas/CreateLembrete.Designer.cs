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
            this.lbCreateLembreteDiaSelecionado = new System.Windows.Forms.Label();
            this.dtpCreateLembreteDia = new System.Windows.Forms.DateTimePicker();
            this.lbCreateLembreteNome = new System.Windows.Forms.Label();
            this.campCreateLembreteNome = new System.Windows.Forms.TextBox();
            this.btCreateLembreteCriar = new System.Windows.Forms.Button();
            this.btCreateLembreteCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCreateLembreteDiaSelecionado
            // 
            this.lbCreateLembreteDiaSelecionado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbCreateLembreteDiaSelecionado.Location = new System.Drawing.Point(20, 20);
            this.lbCreateLembreteDiaSelecionado.Name = "lbCreateLembreteDiaSelecionado";
            this.lbCreateLembreteDiaSelecionado.Size = new System.Drawing.Size(100, 30);
            this.lbCreateLembreteDiaSelecionado.TabIndex = 0;
            this.lbCreateLembreteDiaSelecionado.Text = "Data:";
            // 
            // dtpCreateLembreteDia
            // 
            this.dtpCreateLembreteDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreateLembreteDia.Location = new System.Drawing.Point(120, 22);
            this.dtpCreateLembreteDia.Name = "dtpCreateLembreteDia";
            this.dtpCreateLembreteDia.Size = new System.Drawing.Size(150, 27);
            this.dtpCreateLembreteDia.TabIndex = 1;
            // 
            // lbCreateLembreteNome
            // 
            this.lbCreateLembreteNome.Location = new System.Drawing.Point(20, 70);
            this.lbCreateLembreteNome.Name = "lbCreateLembreteNome";
            this.lbCreateLembreteNome.Size = new System.Drawing.Size(100, 23);
            this.lbCreateLembreteNome.TabIndex = 2;
            this.lbCreateLembreteNome.Text = "Nome:";
            // 
            // campCreateLembreteNome
            // 
            this.campCreateLembreteNome.Location = new System.Drawing.Point(120, 70);
            this.campCreateLembreteNome.Name = "campCreateLembreteNome";
            this.campCreateLembreteNome.Size = new System.Drawing.Size(250, 27);
            this.campCreateLembreteNome.TabIndex = 3;
            this.campCreateLembreteNome.TextChanged += new System.EventHandler(this.campCreateLembreteNome_TextChanged);
            // 
            // btCreateLembreteCriar
            // 
            this.btCreateLembreteCriar.Location = new System.Drawing.Point(120, 120);
            this.btCreateLembreteCriar.Name = "btCreateLembreteCriar";
            this.btCreateLembreteCriar.Size = new System.Drawing.Size(100, 30);
            this.btCreateLembreteCriar.TabIndex = 4;
            this.btCreateLembreteCriar.Text = "Criar";
            this.btCreateLembreteCriar.Click += new System.EventHandler(this.btCreateLembreteCriar_Click);
            // 
            // btCreateLembreteCancelar
            // 
            this.btCreateLembreteCancelar.Location = new System.Drawing.Point(230, 120);
            this.btCreateLembreteCancelar.Name = "btCreateLembreteCancelar";
            this.btCreateLembreteCancelar.Size = new System.Drawing.Size(100, 30);
            this.btCreateLembreteCancelar.TabIndex = 5;
            this.btCreateLembreteCancelar.Text = "Cancelar";
            this.btCreateLembreteCancelar.Click += new System.EventHandler(this.btCreateLembreteCancelar_Click);
            // 
            // CreateLembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.btCreateLembreteCancelar);
            this.Controls.Add(this.btCreateLembreteCriar);
            this.Controls.Add(this.campCreateLembreteNome);
            this.Controls.Add(this.lbCreateLembreteNome);
            this.Controls.Add(this.dtpCreateLembreteDia);
            this.Controls.Add(this.lbCreateLembreteDiaSelecionado);
            this.Name = "CreateLembrete";
            this.Text = "Novo Lembrete";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}