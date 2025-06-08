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
            tbMainSenhasDados.Size = new Size(925, 491);
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
            // MainSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1193, 663);
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
        }

        #endregion

        private Button btMainSenhasCreate;
        private Button btMainSenhasUpdate;
        private Button btMainSenhasDelete;
        private Label lbMainSenhasTitulo;
        private DataGridView tbMainSenhasDados;
        private Menu menuGlobal;
    }
}