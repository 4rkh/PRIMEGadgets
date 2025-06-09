namespace Prime_Gadgets.modulos.moduloSenhas
{
    partial class MainSenhas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSenhas));
            btMainSenhasCreate = new Button();
            btMainSenhasUpdate = new Button();
            lbMainSenhasTitulo = new Label();
            btMainSenhasDelete = new Button();
            tbMainSenhasDados = new DataGridView();
            menuGlobal = new Menu();
            lbMainSenhasPgFinal = new Label();
            lbMainSenhasTexto1 = new Label();
            lbMainSenhasPgAtual = new Label();
            btMainSenhasFirst = new Button();
            btMainSenhasBack = new Button();
            btMainSenhasLast = new Button();
            btMainSenhasNext = new Button();
            ((System.ComponentModel.ISupportInitialize)tbMainSenhasDados).BeginInit();
            SuspendLayout();
            // 
            // btMainSenhasCreate
            // 
            btMainSenhasCreate.BackColor = Color.FromArgb(230, 34, 34);
            btMainSenhasCreate.FlatAppearance.BorderSize = 0;
            btMainSenhasCreate.FlatStyle = FlatStyle.Flat;
            btMainSenhasCreate.Font = new Font("Arial", 12.75F);
            btMainSenhasCreate.ForeColor = Color.FromArgb(255, 252, 237);
            btMainSenhasCreate.Location = new Point(242, 78);
            btMainSenhasCreate.Name = "btMainSenhasCreate";
            btMainSenhasCreate.Size = new Size(191, 37);
            btMainSenhasCreate.TabIndex = 0;
            btMainSenhasCreate.Text = "Adicionar";
            btMainSenhasCreate.UseVisualStyleBackColor = false;
            btMainSenhasCreate.Click += btMainSenhasCreate_Click;
            // 
            // btMainSenhasUpdate
            // 
            btMainSenhasUpdate.Anchor = AnchorStyles.Top;
            btMainSenhasUpdate.BackColor = Color.FromArgb(230, 34, 34);
            btMainSenhasUpdate.FlatAppearance.BorderSize = 0;
            btMainSenhasUpdate.FlatStyle = FlatStyle.Flat;
            btMainSenhasUpdate.Font = new Font("Arial", 12.75F);
            btMainSenhasUpdate.ForeColor = Color.FromArgb(255, 252, 237);
            btMainSenhasUpdate.Location = new Point(609, 78);
            btMainSenhasUpdate.Name = "btMainSenhasUpdate";
            btMainSenhasUpdate.Size = new Size(191, 37);
            btMainSenhasUpdate.TabIndex = 1;
            btMainSenhasUpdate.Text = "Atualizar";
            btMainSenhasUpdate.UseVisualStyleBackColor = false;
            btMainSenhasUpdate.Click += btMainSenhasUpdate_Click;
            // 
            // lbMainSenhasTitulo
            // 
            lbMainSenhasTitulo.Anchor = AnchorStyles.Top;
            lbMainSenhasTitulo.AutoSize = true;
            lbMainSenhasTitulo.Font = new Font("Arial", 18F, FontStyle.Bold);
            lbMainSenhasTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainSenhasTitulo.Location = new Point(605, 23);
            lbMainSenhasTitulo.Name = "lbMainSenhasTitulo";
            lbMainSenhasTitulo.Size = new Size(196, 29);
            lbMainSenhasTitulo.TabIndex = 2;
            lbMainSenhasTitulo.Text = "Lista de Senhas";
            // 
            // btMainSenhasDelete
            // 
            btMainSenhasDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btMainSenhasDelete.BackColor = Color.FromArgb(230, 34, 34);
            btMainSenhasDelete.FlatAppearance.BorderSize = 0;
            btMainSenhasDelete.FlatStyle = FlatStyle.Flat;
            btMainSenhasDelete.Font = new Font("Arial", 12.75F);
            btMainSenhasDelete.ForeColor = Color.FromArgb(255, 252, 237);
            btMainSenhasDelete.Location = new Point(976, 78);
            btMainSenhasDelete.Name = "btMainSenhasDelete";
            btMainSenhasDelete.Size = new Size(191, 37);
            btMainSenhasDelete.TabIndex = 3;
            btMainSenhasDelete.Text = "Excluir";
            btMainSenhasDelete.UseVisualStyleBackColor = false;
            btMainSenhasDelete.Click += btMainSenhasDelete_Click;
            // 
            // tbMainSenhasDados
            // 
            tbMainSenhasDados.AllowUserToAddRows = false;
            tbMainSenhasDados.AllowUserToDeleteRows = false;
            tbMainSenhasDados.AllowUserToResizeColumns = false;
            tbMainSenhasDados.AllowUserToResizeRows = false;
            tbMainSenhasDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMainSenhasDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbMainSenhasDados.BackgroundColor = Color.FromArgb(255, 252, 237);
            tbMainSenhasDados.BorderStyle = BorderStyle.None;
            tbMainSenhasDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbMainSenhasDados.Location = new Point(242, 140);
            tbMainSenhasDados.MultiSelect = false;
            tbMainSenhasDados.Name = "tbMainSenhasDados";
            tbMainSenhasDados.ReadOnly = true;
            tbMainSenhasDados.RowHeadersVisible = false;
            tbMainSenhasDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbMainSenhasDados.Size = new Size(925, 458);
            tbMainSenhasDados.TabIndex = 5;
            // 
            // menuGlobal
            // 
            menuGlobal.BackColor = Color.FromArgb(230, 34, 34);
            menuGlobal.Dock = DockStyle.Left;
            menuGlobal.Location = new Point(0, 0);
            menuGlobal.Name = "menuGlobal";
            menuGlobal.Size = new Size(212, 663);
            menuGlobal.TabIndex = 6;
            // 
            // lbMainSenhasPgFinal
            // 
            lbMainSenhasPgFinal.Anchor = AnchorStyles.Bottom;
            lbMainSenhasPgFinal.AutoSize = true;
            lbMainSenhasPgFinal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMainSenhasPgFinal.ForeColor = Color.FromArgb(0, 0, 192);
            lbMainSenhasPgFinal.Location = new Point(750, 617);
            lbMainSenhasPgFinal.Name = "lbMainSenhasPgFinal";
            lbMainSenhasPgFinal.Size = new Size(23, 25);
            lbMainSenhasPgFinal.TabIndex = 20;
            lbMainSenhasPgFinal.Text = "1";
            // 
            // lbMainSenhasTexto1
            // 
            lbMainSenhasTexto1.Anchor = AnchorStyles.Bottom;
            lbMainSenhasTexto1.AutoSize = true;
            lbMainSenhasTexto1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMainSenhasTexto1.Location = new Point(699, 622);
            lbMainSenhasTexto1.Name = "lbMainSenhasTexto1";
            lbMainSenhasTexto1.Size = new Size(26, 20);
            lbMainSenhasTexto1.TabIndex = 19;
            lbMainSenhasTexto1.Text = "de";
            // 
            // lbMainSenhasPgAtual
            // 
            lbMainSenhasPgAtual.Anchor = AnchorStyles.Bottom;
            lbMainSenhasPgAtual.AutoSize = true;
            lbMainSenhasPgAtual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMainSenhasPgAtual.ForeColor = Color.Red;
            lbMainSenhasPgAtual.Location = new Point(654, 620);
            lbMainSenhasPgAtual.Name = "lbMainSenhasPgAtual";
            lbMainSenhasPgAtual.Size = new Size(19, 21);
            lbMainSenhasPgAtual.TabIndex = 18;
            lbMainSenhasPgAtual.Text = "1";
            // 
            // btMainSenhasFirst
            // 
            btMainSenhasFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btMainSenhasFirst.Image = Properties.Resources.left;
            btMainSenhasFirst.Location = new Point(457, 604);
            btMainSenhasFirst.Name = "btMainSenhasFirst";
            btMainSenhasFirst.Size = new Size(55, 59);
            btMainSenhasFirst.TabIndex = 17;
            btMainSenhasFirst.UseVisualStyleBackColor = true;
            btMainSenhasFirst.Click += btMainSenhasFirst_Click;
            // 
            // btMainSenhasBack
            // 
            btMainSenhasBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btMainSenhasBack.Image = Properties.Resources.left;
            btMainSenhasBack.Location = new Point(531, 604);
            btMainSenhasBack.Name = "btMainSenhasBack";
            btMainSenhasBack.Size = new Size(55, 59);
            btMainSenhasBack.TabIndex = 16;
            btMainSenhasBack.UseVisualStyleBackColor = true;
            btMainSenhasBack.Click += btMainSenhasBack_Click;
            // 
            // btMainSenhasLast
            // 
            btMainSenhasLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btMainSenhasLast.BackgroundImage = Properties.Resources.right;
            btMainSenhasLast.BackgroundImageLayout = ImageLayout.Center;
            btMainSenhasLast.Location = new Point(927, 604);
            btMainSenhasLast.Name = "btMainSenhasLast";
            btMainSenhasLast.Size = new Size(55, 59);
            btMainSenhasLast.TabIndex = 15;
            btMainSenhasLast.UseVisualStyleBackColor = true;
            btMainSenhasLast.Click += btMainSenhasLast_Click;
            // 
            // btMainSenhasNext
            // 
            btMainSenhasNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btMainSenhasNext.BackgroundImage = Properties.Resources.right;
            btMainSenhasNext.BackgroundImageLayout = ImageLayout.Center;
            btMainSenhasNext.Location = new Point(851, 604);
            btMainSenhasNext.Name = "btMainSenhasNext";
            btMainSenhasNext.Size = new Size(55, 59);
            btMainSenhasNext.TabIndex = 14;
            btMainSenhasNext.UseVisualStyleBackColor = true;
            btMainSenhasNext.Click += btMainSenhasNext_Click;
            // 
            // MainSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1193, 663);
            Controls.Add(lbMainSenhasPgFinal);
            Controls.Add(lbMainSenhasTexto1);
            Controls.Add(lbMainSenhasPgAtual);
            Controls.Add(btMainSenhasFirst);
            Controls.Add(btMainSenhasBack);
            Controls.Add(btMainSenhasLast);
            Controls.Add(btMainSenhasNext);
            Controls.Add(menuGlobal);
            Controls.Add(tbMainSenhasDados);
            Controls.Add(btMainSenhasDelete);
            Controls.Add(lbMainSenhasTitulo);
            Controls.Add(btMainSenhasUpdate);
            Controls.Add(btMainSenhasCreate);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainSenhas";
            Text = "MainSenhas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)tbMainSenhasDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
            this.VisibleChanged += MainSenhas_VisibleChanged;
        }

        #endregion

        private Button btMainSenhasCreate;
        private Button btMainSenhasUpdate;
        private Button btMainSenhasDelete;
        private Label lbMainSenhasTitulo;
        private DataGridView tbMainSenhasDados;
        private Menu menuGlobal;
        private Label lbMainSenhasPgFinal;
        private Label lbMainSenhasTexto1;
        private Label lbMainSenhasPgAtual;
        private Button btMainSenhasFirst;
        private Button btMainSenhasBack;
        private Button btMainSenhasLast;
        private Button btMainSenhasNext;
    }
}