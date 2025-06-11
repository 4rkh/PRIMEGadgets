namespace Prime_Gadgets.modulos.moduloRotina
{
    partial class MainRotina
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbMainRotinaTitulo;
        private System.Windows.Forms.Label lbMainRotinaData;
        private System.Windows.Forms.Button btMainRotinaCreate;
        private System.Windows.Forms.Button btMainRotinaUpdate;
        private System.Windows.Forms.Button btMainRotinaSemana;
        private System.Windows.Forms.Button btMainRotinaBack;
        private System.Windows.Forms.Button btMainRotinaNext;
        private Prime_Gadgets.Menu menu1;
        private System.Windows.Forms.TableLayoutPanel panelMainRotinaSecoes;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRotina));
            lbMainRotinaTitulo = new Label();
            lbMainRotinaData = new Label();
            btMainRotinaCreate = new Button();
            btMainRotinaUpdate = new Button();
            btMainRotinaSemana = new Button();
            btMainRotinaBack = new Button();
            btMainRotinaNext = new Button();
            menu1 = new Menu();
            panelMainRotinaSecoes = new TableLayoutPanel();
            SuspendLayout();
            // 
            // lbMainRotinaTitulo
            // 
            lbMainRotinaTitulo.Anchor = AnchorStyles.Top;
            lbMainRotinaTitulo.AutoSize = true;
            lbMainRotinaTitulo.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbMainRotinaTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainRotinaTitulo.Location = new Point(609, 15);
            lbMainRotinaTitulo.Name = "lbMainRotinaTitulo";
            lbMainRotinaTitulo.Size = new Size(116, 37);
            lbMainRotinaTitulo.TabIndex = 0;
            lbMainRotinaTitulo.Text = "Rotina";
            // 
            // lbMainRotinaData
            // 
            lbMainRotinaData.Anchor = AnchorStyles.Top;
            lbMainRotinaData.AutoSize = true;
            lbMainRotinaData.Font = new Font("Arial", 15F);
            lbMainRotinaData.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainRotinaData.Location = new Point(549, 52);
            lbMainRotinaData.Name = "lbMainRotinaData";
            lbMainRotinaData.Size = new Size(21, 23);
            lbMainRotinaData.TabIndex = 1;
            lbMainRotinaData.Text = "a";
            // 
            // btMainRotinaCreate
            // 
            btMainRotinaCreate.Anchor = AnchorStyles.Top;
            btMainRotinaCreate.BackColor = Color.FromArgb(230, 34, 34);
            btMainRotinaCreate.FlatAppearance.BorderColor = Color.White;
            btMainRotinaCreate.FlatAppearance.BorderSize = 0;
            btMainRotinaCreate.FlatStyle = FlatStyle.Flat;
            btMainRotinaCreate.Font = new Font("Arial", 12.75F);
            btMainRotinaCreate.ForeColor = Color.FromArgb(255, 252, 237);
            btMainRotinaCreate.Location = new Point(248, 92);
            btMainRotinaCreate.Name = "btMainRotinaCreate";
            btMainRotinaCreate.Size = new Size(191, 37);
            btMainRotinaCreate.TabIndex = 3;
            btMainRotinaCreate.Text = "Adicionar";
            btMainRotinaCreate.UseVisualStyleBackColor = false;
            btMainRotinaCreate.Click += btMainRotinaCreate_Click;
            // 
            // btMainRotinaUpdate
            // 
            btMainRotinaUpdate.Anchor = AnchorStyles.Top;
            btMainRotinaUpdate.BackColor = Color.FromArgb(230, 34, 34);
            btMainRotinaUpdate.FlatAppearance.BorderColor = Color.White;
            btMainRotinaUpdate.FlatAppearance.BorderSize = 0;
            btMainRotinaUpdate.FlatStyle = FlatStyle.Flat;
            btMainRotinaUpdate.Font = new Font("Arial", 12.75F);
            btMainRotinaUpdate.ForeColor = Color.FromArgb(255, 252, 237);
            btMainRotinaUpdate.Location = new Point(248, 151);
            btMainRotinaUpdate.Name = "btMainRotinaUpdate";
            btMainRotinaUpdate.Size = new Size(191, 37);
            btMainRotinaUpdate.TabIndex = 4;
            btMainRotinaUpdate.Text = "Editar";
            btMainRotinaUpdate.UseVisualStyleBackColor = false;
            btMainRotinaUpdate.Click += btMainRotinaUpdate_Click;
            // 
            // btMainRotinaSemana
            // 
            btMainRotinaSemana.Anchor = AnchorStyles.Top;
            btMainRotinaSemana.BackColor = Color.FromArgb(230, 34, 34);
            btMainRotinaSemana.FlatAppearance.BorderColor = Color.White;
            btMainRotinaSemana.FlatAppearance.BorderSize = 0;
            btMainRotinaSemana.FlatStyle = FlatStyle.Flat;
            btMainRotinaSemana.Font = new Font("Arial", 12.75F);
            btMainRotinaSemana.ForeColor = Color.FromArgb(255, 252, 237);
            btMainRotinaSemana.Location = new Point(248, 209);
            btMainRotinaSemana.Name = "btMainRotinaSemana";
            btMainRotinaSemana.Size = new Size(191, 37);
            btMainRotinaSemana.TabIndex = 5;
            btMainRotinaSemana.Text = "Exibir Semana";
            btMainRotinaSemana.UseVisualStyleBackColor = false;
            btMainRotinaSemana.Click += btMainRotinaSemana_Click;
            // 
            // btMainRotinaBack
            // 
            btMainRotinaBack.Anchor = AnchorStyles.Bottom;
            btMainRotinaBack.BackColor = Color.FromArgb(230, 34, 34);
            btMainRotinaBack.FlatAppearance.BorderColor = Color.White;
            btMainRotinaBack.FlatAppearance.BorderSize = 0;
            btMainRotinaBack.FlatStyle = FlatStyle.Flat;
            btMainRotinaBack.Font = new Font("Comic Sans MS", 18F);
            btMainRotinaBack.ForeColor = Color.FromArgb(183, 190, 191);
            btMainRotinaBack.Image = Properties.Resources.voltar;
            btMainRotinaBack.Location = new Point(578, 562);
            btMainRotinaBack.Name = "btMainRotinaBack";
            btMainRotinaBack.Size = new Size(60, 60);
            btMainRotinaBack.TabIndex = 6;
            btMainRotinaBack.UseVisualStyleBackColor = false;
            btMainRotinaBack.Click += btMainRotinaBack_Click;
            // 
            // btMainRotinaNext
            // 
            btMainRotinaNext.Anchor = AnchorStyles.Bottom;
            btMainRotinaNext.BackColor = Color.FromArgb(230, 34, 34);
            btMainRotinaNext.FlatAppearance.BorderColor = Color.White;
            btMainRotinaNext.FlatAppearance.BorderSize = 0;
            btMainRotinaNext.FlatStyle = FlatStyle.Flat;
            btMainRotinaNext.Font = new Font("Comic Sans MS", 18F);
            btMainRotinaNext.ForeColor = Color.FromArgb(183, 190, 191);
            btMainRotinaNext.Image = Properties.Resources.avancar;
            btMainRotinaNext.Location = new Point(709, 562);
            btMainRotinaNext.Name = "btMainRotinaNext";
            btMainRotinaNext.Size = new Size(60, 60);
            btMainRotinaNext.TabIndex = 7;
            btMainRotinaNext.UseVisualStyleBackColor = false;
            btMainRotinaNext.Click += btMainRotinaNext_Click;
            // 
            // menu1
            // 
            menu1.BackColor = Color.FromArgb(230, 34, 34);
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(212, 650);
            menu1.TabIndex = 8;
            // 
            // panelMainRotinaSecoes
            // 
            panelMainRotinaSecoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelMainRotinaSecoes.AutoScroll = true;
            panelMainRotinaSecoes.AutoScrollMinSize = new Size(300, 0);
            panelMainRotinaSecoes.BackColor = Color.FromArgb(255, 252, 237);
            panelMainRotinaSecoes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelMainRotinaSecoes.ColumnCount = 1;
            panelMainRotinaSecoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelMainRotinaSecoes.ForeColor = Color.FromArgb(230, 34, 34);
            panelMainRotinaSecoes.Location = new Point(480, 92);
            panelMainRotinaSecoes.Name = "panelMainRotinaSecoes";
            panelMainRotinaSecoes.RowCount = 1;
            panelMainRotinaSecoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            panelMainRotinaSecoes.Size = new Size(386, 451);
            panelMainRotinaSecoes.TabIndex = 2;
            // 
            // MainRotina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1000, 650);
            Controls.Add(lbMainRotinaTitulo);
            Controls.Add(lbMainRotinaData);
            Controls.Add(panelMainRotinaSecoes);
            Controls.Add(btMainRotinaUpdate);
            Controls.Add(btMainRotinaSemana);
            Controls.Add(btMainRotinaBack);
            Controls.Add(btMainRotinaNext);
            Controls.Add(menu1);
            Controls.Add(btMainRotinaCreate);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1000, 650);
            Name = "MainRotina";
            Text = "MainRotina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}