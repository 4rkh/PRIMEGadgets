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
            menu1 = new Menu();
            ((System.ComponentModel.ISupportInitialize)tbMainSenhasDados).BeginInit();
            SuspendLayout();
            // 
            // btMainSenhasCreate
            // 
            btMainSenhasCreate.Location = new Point(235, 92);
            btMainSenhasCreate.Name = "btMainSenhasCreate";
            btMainSenhasCreate.Size = new Size(191, 37);
            btMainSenhasCreate.TabIndex = 0;
            btMainSenhasCreate.Text = "Create";
            btMainSenhasCreate.UseVisualStyleBackColor = true;
            btMainSenhasCreate.Click += btMainSenhasCreate_Click;
            // 
            // btMainSenhasUpdate
            // 
            btMainSenhasUpdate.Anchor = AnchorStyles.Top;
            btMainSenhasUpdate.Location = new Point(575, 92);
            btMainSenhasUpdate.Name = "btMainSenhasUpdate";
            btMainSenhasUpdate.Size = new Size(191, 37);
            btMainSenhasUpdate.TabIndex = 1;
            btMainSenhasUpdate.Text = "Update";
            btMainSenhasUpdate.UseVisualStyleBackColor = true;
            btMainSenhasUpdate.Click += btMainSenhasUpdate_Click;
            // 
            // lbMainSenhasTitulo
            // 
            lbMainSenhasTitulo.Anchor = AnchorStyles.Top;
            lbMainSenhasTitulo.AutoSize = true;
            lbMainSenhasTitulo.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMainSenhasTitulo.Location = new Point(593, 28);
            lbMainSenhasTitulo.Name = "lbMainSenhasTitulo";
            lbMainSenhasTitulo.Size = new Size(153, 29);
            lbMainSenhasTitulo.TabIndex = 2;
            lbMainSenhasTitulo.Text = "Lista de Senhas";
            // 
            // btMainSenhasDelete
            // 
            btMainSenhasDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btMainSenhasDelete.Location = new Point(947, 92);
            btMainSenhasDelete.Name = "btMainSenhasDelete";
            btMainSenhasDelete.Size = new Size(191, 37);
            btMainSenhasDelete.TabIndex = 3;
            btMainSenhasDelete.Text = "Delete";
            btMainSenhasDelete.UseVisualStyleBackColor = true;
            btMainSenhasDelete.Click += btMainSenhasDelete_Click;
            // 
            // tbMainSenhasDados
            // 
            tbMainSenhasDados.AllowUserToAddRows = false;
            tbMainSenhasDados.AllowUserToDeleteRows = false;
            tbMainSenhasDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMainSenhasDados.BackgroundColor = Color.FromArgb(255, 252, 237);
            tbMainSenhasDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbMainSenhasDados.Location = new Point(235, 144);
            tbMainSenhasDados.MultiSelect = false;
            tbMainSenhasDados.Name = "tbMainSenhasDados";
            tbMainSenhasDados.RowHeadersVisible = false;
            tbMainSenhasDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbMainSenhasDados.Size = new Size(903, 473);
            tbMainSenhasDados.TabIndex = 5;
            // 
            // menu1
            // 
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(212, 629);
            menu1.TabIndex = 6;
            // 
            // MainSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1160, 629);
            Controls.Add(menu1);
            Controls.Add(tbMainSenhasDados);
            Controls.Add(btMainSenhasDelete);
            Controls.Add(lbMainSenhasTitulo);
            Controls.Add(btMainSenhasUpdate);
            Controls.Add(btMainSenhasCreate);
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
        private Menu menu1;
    }
}