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
            this.lbEditLembreteDiaSelecionado = new System.Windows.Forms.Label();
            this.panelEditLembreteSecoes = new System.Windows.Forms.TableLayoutPanel();
            this.lbEditLembreteNome = new System.Windows.Forms.Label();
            this.campEditLembreteNome = new System.Windows.Forms.TextBox();
            this.btEditLembreteSalvar = new System.Windows.Forms.Button();
            this.btEditLembreteDeletar = new System.Windows.Forms.Button();
            this.btEditLembreteCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEditLembreteDiaSelecionado
            // 
            this.lbEditLembreteDiaSelecionado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbEditLembreteDiaSelecionado.Location = new System.Drawing.Point(20, 20);
            this.lbEditLembreteDiaSelecionado.Name = "lbEditLembreteDiaSelecionado";
            this.lbEditLembreteDiaSelecionado.Size = new System.Drawing.Size(200, 30);
            this.lbEditLembreteDiaSelecionado.TabIndex = 0;
            this.lbEditLembreteDiaSelecionado.Text = "Data";
            // 
            // panelEditLembreteSecoes
            // 
            this.panelEditLembreteSecoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditLembreteSecoes.AutoScroll = true;
            this.panelEditLembreteSecoes.ColumnCount = 1;
            this.panelEditLembreteSecoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelEditLembreteSecoes.Location = new System.Drawing.Point(20, 70);
            this.panelEditLembreteSecoes.Name = "panelEditLembreteSecoes";
            this.panelEditLembreteSecoes.RowCount = 1;
            this.panelEditLembreteSecoes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelEditLembreteSecoes.Size = new System.Drawing.Size(400, 180);
            this.panelEditLembreteSecoes.TabIndex = 1;
            // 
            // lbEditLembreteNome
            // 
            this.lbEditLembreteNome.Location = new System.Drawing.Point(20, 270);
            this.lbEditLembreteNome.Name = "lbEditLembreteNome";
            this.lbEditLembreteNome.Size = new System.Drawing.Size(100, 23);
            this.lbEditLembreteNome.TabIndex = 2;
            this.lbEditLembreteNome.Text = "Nome:";
            // 
            // campEditLembreteNome
            // 
            this.campEditLembreteNome.Location = new System.Drawing.Point(120, 270);
            this.campEditLembreteNome.Name = "campEditLembreteNome";
            this.campEditLembreteNome.Size = new System.Drawing.Size(250, 27);
            this.campEditLembreteNome.TabIndex = 3;
            this.campEditLembreteNome.TextChanged += new System.EventHandler(this.campEditLembreteNome_TextChanged);
            // 
            // btEditLembreteSalvar
            // 
            this.btEditLembreteSalvar.Location = new System.Drawing.Point(20, 320);
            this.btEditLembreteSalvar.Name = "btEditLembreteSalvar";
            this.btEditLembreteSalvar.Size = new System.Drawing.Size(100, 30);
            this.btEditLembreteSalvar.TabIndex = 4;
            this.btEditLembreteSalvar.Text = "Salvar";
            this.btEditLembreteSalvar.Click += new System.EventHandler(this.btEditLembreteSalvar_Click);
            // 
            // btEditLembreteDeletar
            // 
            this.btEditLembreteDeletar.Location = new System.Drawing.Point(130, 320);
            this.btEditLembreteDeletar.Name = "btEditLembreteDeletar";
            this.btEditLembreteDeletar.Size = new System.Drawing.Size(100, 30);
            this.btEditLembreteDeletar.TabIndex = 5;
            this.btEditLembreteDeletar.Text = "Deletar";
            this.btEditLembreteDeletar.Click += new System.EventHandler(this.btEditLembreteDeletar_Click);
            // 
            // btEditLembreteCancelar
            // 
            this.btEditLembreteCancelar.Location = new System.Drawing.Point(240, 320);
            this.btEditLembreteCancelar.Name = "btEditLembreteCancelar";
            this.btEditLembreteCancelar.Size = new System.Drawing.Size(100, 30);
            this.btEditLembreteCancelar.TabIndex = 6;
            this.btEditLembreteCancelar.Text = "Cancelar";
            this.btEditLembreteCancelar.Click += new System.EventHandler(this.btEditLembreteCancelar_Click);
            // 
            // EditLembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.Controls.Add(this.btEditLembreteCancelar);
            this.Controls.Add(this.btEditLembreteDeletar);
            this.Controls.Add(this.btEditLembreteSalvar);
            this.Controls.Add(this.campEditLembreteNome);
            this.Controls.Add(this.lbEditLembreteNome);
            this.Controls.Add(this.panelEditLembreteSecoes);
            this.Controls.Add(this.lbEditLembreteDiaSelecionado);
            this.Name = "EditLembrete";
            this.Text = "Editar Lembrete";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}