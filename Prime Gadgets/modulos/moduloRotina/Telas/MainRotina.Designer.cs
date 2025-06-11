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
            lbMainRotinaTitulo.Font = new Font("Comic Sans MS", 18F);
            lbMainRotinaTitulo.ForeColor = Color.White;
            lbMainRotinaTitulo.Location = new Point(645, 23);
            lbMainRotinaTitulo.Name = "lbMainRotinaTitulo";
            lbMainRotinaTitulo.Size = new Size(85, 33);
            lbMainRotinaTitulo.TabIndex = 0;
            lbMainRotinaTitulo.Text = "Rotina";            
            // 
            // lbMainRotinaData
            // 
            lbMainRotinaData.Anchor = AnchorStyles.Top;
            lbMainRotinaData.AutoSize = true;
            lbMainRotinaData.Font = new Font("Comic Sans MS", 14F);
            lbMainRotinaData.ForeColor = Color.White;
            lbMainRotinaData.Location = new Point(522, 65);
            lbMainRotinaData.Name = "lbMainRotinaData";
            lbMainRotinaData.Size = new Size(0, 26);
            lbMainRotinaData.TabIndex = 1;
            // 
            // btMainRotinaCreate
            // 
            btMainRotinaCreate.Anchor = AnchorStyles.Top;
            btMainRotinaCreate.BackColor = Color.FromArgb(230, 34, 34);
            btMainRotinaCreate.FlatAppearance.BorderColor = Color.White;
            btMainRotinaCreate.FlatAppearance.BorderSize = 2;
            btMainRotinaCreate.FlatStyle = FlatStyle.Flat;
            btMainRotinaCreate.Font = new Font("Comic Sans MS", 10F);
            btMainRotinaCreate.ForeColor = Color.White;
            btMainRotinaCreate.Location = new Point(928, 190);
            btMainRotinaCreate.Name = "btMainRotinaCreate";
            btMainRotinaCreate.Size = new Size(140, 45);
            btMainRotinaCreate.TabIndex = 3;
            btMainRotinaCreate.Text = "Criar Rotina";
            btMainRotinaCreate.UseVisualStyleBackColor = false;
            btMainRotinaCreate.Click += btMainRotinaCreate_Click;
            // 
            // btMainRotinaUpdate
            // 
            btMainRotinaUpdate.Anchor = AnchorStyles.Top;
            btMainRotinaUpdate.BackColor = Color.FromArgb(230, 34, 34);
            btMainRotinaUpdate.FlatAppearance.BorderColor = Color.White;
            btMainRotinaUpdate.FlatAppearance.BorderSize = 2;
            btMainRotinaUpdate.FlatStyle = FlatStyle.Flat;
            btMainRotinaUpdate.Font = new Font("Comic Sans MS", 10F);
            btMainRotinaUpdate.ForeColor = Color.White;
            btMainRotinaUpdate.Location = new Point(928, 250);
            btMainRotinaUpdate.Name = "btMainRotinaUpdate";
            btMainRotinaUpdate.Size = new Size(140, 45);
            btMainRotinaUpdate.TabIndex = 4;
            btMainRotinaUpdate.Text = "Editar Rotina";
            btMainRotinaUpdate.UseVisualStyleBackColor = false;
            btMainRotinaUpdate.Click += btMainRotinaUpdate_Click;
            // 
            // btMainRotinaSemana
            // 
            btMainRotinaSemana.Anchor = AnchorStyles.Top;
            btMainRotinaSemana.BackColor = Color.FromArgb(230, 34, 34);
            btMainRotinaSemana.FlatAppearance.BorderColor = Color.White;
            btMainRotinaSemana.FlatAppearance.BorderSize = 2;
            btMainRotinaSemana.FlatStyle = FlatStyle.Flat;
            btMainRotinaSemana.Font = new Font("Comic Sans MS", 10F);
            btMainRotinaSemana.ForeColor = Color.White;
            btMainRotinaSemana.Location = new Point(928, 310);
            btMainRotinaSemana.Name = "btMainRotinaSemana";
            btMainRotinaSemana.Size = new Size(140, 45);
            btMainRotinaSemana.TabIndex = 5;
            btMainRotinaSemana.Text = "Ver Semana";
            btMainRotinaSemana.UseVisualStyleBackColor = false;
            btMainRotinaSemana.Click += btMainRotinaSemana_Click;
            // 
            // btMainRotinaBack
            // 
            btMainRotinaBack.Anchor = AnchorStyles.Top;
            btMainRotinaBack.BackColor = Color.FromArgb(52, 60, 76);
            btMainRotinaBack.FlatAppearance.BorderColor = Color.White;
            btMainRotinaBack.FlatAppearance.BorderSize = 0;
            btMainRotinaBack.FlatStyle = FlatStyle.Flat;
            btMainRotinaBack.Font = new Font("Comic Sans MS", 18F);
            btMainRotinaBack.ForeColor = Color.FromArgb(183, 190, 191);
            btMainRotinaBack.Location = new Point(629, 562);
            btMainRotinaBack.Name = "btMainRotinaBack";
            btMainRotinaBack.Size = new Size(60, 45);
            btMainRotinaBack.TabIndex = 6;
            btMainRotinaBack.Text = "←";
            btMainRotinaBack.UseVisualStyleBackColor = false;
            btMainRotinaBack.Click += btMainRotinaBack_Click;
            // 
            // btMainRotinaNext
            // 
            btMainRotinaNext.Anchor = AnchorStyles.Top;
            btMainRotinaNext.BackColor = Color.FromArgb(52, 60, 76);
            btMainRotinaNext.FlatAppearance.BorderColor = Color.White;
            btMainRotinaNext.FlatAppearance.BorderSize = 0;
            btMainRotinaNext.FlatStyle = FlatStyle.Flat;
            btMainRotinaNext.Font = new Font("Comic Sans MS", 18F);
            btMainRotinaNext.ForeColor = Color.FromArgb(183, 190, 191);
            btMainRotinaNext.Location = new Point(719, 562);
            btMainRotinaNext.Name = "btMainRotinaNext";
            btMainRotinaNext.Size = new Size(60, 45);
            btMainRotinaNext.TabIndex = 7;
            btMainRotinaNext.Text = "→";
            btMainRotinaNext.UseVisualStyleBackColor = false;
            btMainRotinaNext.Click += btMainRotinaNext_Click;
            // 
            // menu1
            // 
            menu1.BackColor = Color.FromArgb(230, 34, 34);
            menu1.Location = new Point(1, -2);
            menu1.Name = "menu1";
            menu1.Size = new Size(212, 1000);
            menu1.TabIndex = 8;
            // 
            // panelMainRotinaSecoes
            // 
            panelMainRotinaSecoes.Anchor = AnchorStyles.Top;
            panelMainRotinaSecoes.AutoScroll = true;
            panelMainRotinaSecoes.AutoScrollMinSize = new Size(300, 0);
            panelMainRotinaSecoes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelMainRotinaSecoes.ColumnCount = 1;
            panelMainRotinaSecoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelMainRotinaSecoes.Location = new Point(507, 94);
            panelMainRotinaSecoes.Name = "panelMainRotinaSecoes";
            panelMainRotinaSecoes.RowCount = 1;
            panelMainRotinaSecoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            panelMainRotinaSecoes.Size = new Size(386, 462);
            panelMainRotinaSecoes.TabIndex = 2;
            // 
            // MainRotina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1163, 643);
            Controls.Add(lbMainRotinaTitulo);
            Controls.Add(lbMainRotinaData);
            Controls.Add(panelMainRotinaSecoes);
            Controls.Add(btMainRotinaCreate);
            Controls.Add(btMainRotinaUpdate);
            Controls.Add(btMainRotinaSemana);
            Controls.Add(btMainRotinaBack);
            Controls.Add(btMainRotinaNext);
            Controls.Add(menu1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainRotina";
            Text = "MainRotina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}