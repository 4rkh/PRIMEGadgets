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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            btMainSenhasUpdate.Location = new Point(589, 78);
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
            lbMainSenhasTitulo.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbMainSenhasTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainSenhasTitulo.Location = new Point(550, 22);
            lbMainSenhasTitulo.Name = "lbMainSenhasTitulo";
            lbMainSenhasTitulo.Size = new Size(262, 37);
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
            btMainSenhasDelete.Location = new Point(935, 78);
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
            tbMainSenhasDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbMainSenhasDados.BackgroundColor = Color.FromArgb(255, 252, 237);
            tbMainSenhasDados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle1.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbMainSenhasDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbMainSenhasDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle2.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbMainSenhasDados.DefaultCellStyle = dataGridViewCellStyle2;
            tbMainSenhasDados.GridColor = Color.FromArgb(153, 117, 92);
            tbMainSenhasDados.Location = new Point(242, 140);
            tbMainSenhasDados.MultiSelect = false;
            tbMainSenhasDados.Name = "tbMainSenhasDados";
            tbMainSenhasDados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle3.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbMainSenhasDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbMainSenhasDados.RowHeadersVisible = false;
            tbMainSenhasDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbMainSenhasDados.Size = new Size(884, 343);
            tbMainSenhasDados.TabIndex = 5;
            // 
            // menuGlobal
            // 
            menuGlobal.BackColor = Color.FromArgb(230, 34, 34);
            menuGlobal.Dock = DockStyle.Left;
            menuGlobal.Location = new Point(0, 0);
            menuGlobal.Name = "menuGlobal";
            menuGlobal.Size = new Size(212, 643);
            menuGlobal.TabIndex = 6;
            // 
            // lbMainSenhasPgFinal
            // 
            lbMainSenhasPgFinal.Anchor = AnchorStyles.Bottom;
            lbMainSenhasPgFinal.AutoSize = true;
            lbMainSenhasPgFinal.Font = new Font("Arial", 18F, FontStyle.Bold);
            lbMainSenhasPgFinal.ForeColor = Color.FromArgb(230, 34, 34);
            lbMainSenhasPgFinal.Location = new Point(737, 547);
            lbMainSenhasPgFinal.Name = "lbMainSenhasPgFinal";
            lbMainSenhasPgFinal.Size = new Size(26, 29);
            lbMainSenhasPgFinal.TabIndex = 20;
            lbMainSenhasPgFinal.Text = "1";
            // 
            // lbMainSenhasTexto1
            // 
            lbMainSenhasTexto1.Anchor = AnchorStyles.Bottom;
            lbMainSenhasTexto1.AutoSize = true;
            lbMainSenhasTexto1.Font = new Font("Arial", 15.75F);
            lbMainSenhasTexto1.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainSenhasTexto1.Location = new Point(682, 551);
            lbMainSenhasTexto1.Name = "lbMainSenhasTexto1";
            lbMainSenhasTexto1.Size = new Size(33, 24);
            lbMainSenhasTexto1.TabIndex = 19;
            lbMainSenhasTexto1.Text = "de";
            // 
            // lbMainSenhasPgAtual
            // 
            lbMainSenhasPgAtual.Anchor = AnchorStyles.Bottom;
            lbMainSenhasPgAtual.AutoSize = true;
            lbMainSenhasPgAtual.Font = new Font("Arial", 18F);
            lbMainSenhasPgAtual.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainSenhasPgAtual.Location = new Point(640, 549);
            lbMainSenhasPgAtual.Name = "lbMainSenhasPgAtual";
            lbMainSenhasPgAtual.Size = new Size(25, 27);
            lbMainSenhasPgAtual.TabIndex = 18;
            lbMainSenhasPgAtual.Text = "1";
            // 
            // btMainSenhasFirst
            // 
            btMainSenhasFirst.Anchor = AnchorStyles.Bottom;
            btMainSenhasFirst.BackColor = Color.FromArgb(230, 34, 34);
            btMainSenhasFirst.FlatAppearance.BorderSize = 0;
            btMainSenhasFirst.FlatStyle = FlatStyle.Flat;
            btMainSenhasFirst.Image = Properties.Resources.primeira;
            btMainSenhasFirst.Location = new Point(461, 532);
            btMainSenhasFirst.Name = "btMainSenhasFirst";
            btMainSenhasFirst.Size = new Size(55, 59);
            btMainSenhasFirst.TabIndex = 17;
            btMainSenhasFirst.UseVisualStyleBackColor = false;
            btMainSenhasFirst.Click += btMainSenhasFirst_Click;
            // 
            // btMainSenhasBack
            // 
            btMainSenhasBack.Anchor = AnchorStyles.Bottom;
            btMainSenhasBack.BackColor = Color.FromArgb(230, 34, 34);
            btMainSenhasBack.FlatAppearance.BorderSize = 0;
            btMainSenhasBack.FlatStyle = FlatStyle.Flat;
            btMainSenhasBack.Image = Properties.Resources.voltar;
            btMainSenhasBack.Location = new Point(539, 532);
            btMainSenhasBack.Name = "btMainSenhasBack";
            btMainSenhasBack.Size = new Size(55, 59);
            btMainSenhasBack.TabIndex = 16;
            btMainSenhasBack.UseVisualStyleBackColor = false;
            btMainSenhasBack.Click += btMainSenhasBack_Click;
            // 
            // btMainSenhasLast
            // 
            btMainSenhasLast.Anchor = AnchorStyles.Bottom;
            btMainSenhasLast.BackColor = Color.FromArgb(230, 34, 34);
            btMainSenhasLast.BackgroundImage = Properties.Resources.ultima;
            btMainSenhasLast.BackgroundImageLayout = ImageLayout.Center;
            btMainSenhasLast.FlatAppearance.BorderSize = 0;
            btMainSenhasLast.FlatStyle = FlatStyle.Flat;
            btMainSenhasLast.Location = new Point(879, 532);
            btMainSenhasLast.Name = "btMainSenhasLast";
            btMainSenhasLast.Size = new Size(55, 59);
            btMainSenhasLast.TabIndex = 15;
            btMainSenhasLast.UseVisualStyleBackColor = false;
            btMainSenhasLast.Click += btMainSenhasLast_Click;
            // 
            // btMainSenhasNext
            // 
            btMainSenhasNext.Anchor = AnchorStyles.Bottom;
            btMainSenhasNext.BackColor = Color.FromArgb(230, 34, 34);
            btMainSenhasNext.BackgroundImage = Properties.Resources.avancar;
            btMainSenhasNext.BackgroundImageLayout = ImageLayout.Center;
            btMainSenhasNext.FlatAppearance.BorderSize = 0;
            btMainSenhasNext.FlatStyle = FlatStyle.Flat;
            btMainSenhasNext.Location = new Point(803, 532);
            btMainSenhasNext.Name = "btMainSenhasNext";
            btMainSenhasNext.Size = new Size(55, 59);
            btMainSenhasNext.TabIndex = 14;
            btMainSenhasNext.UseVisualStyleBackColor = false;
            btMainSenhasNext.Click += btMainSenhasNext_Click;
            // 
            // MainSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1152, 643);
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
            VisibleChanged += MainSenhas_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)tbMainSenhasDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
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