namespace Prime_Gadgets.modulos.moduloContatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    partial class MainContato
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainContato));
            btPrincipalContatosCreate = new Button();
            btPrincipalContatosUpdate = new Button();
            btPrincipalContatosDelete = new Button();
            label1 = new Label();
            ContatosTable = new DataGridView();
            menu1 = new Menu();
            ((ISupportInitialize)ContatosTable).BeginInit();
            SuspendLayout();
            // 
            // btPrincipalContatosCreate
            // 
            btPrincipalContatosCreate.BackColor = Color.Lime;
            btPrincipalContatosCreate.Location = new Point(242, 78);
            btPrincipalContatosCreate.Name = "btPrincipalContatosCreate";
            btPrincipalContatosCreate.Size = new Size(191, 37);
            btPrincipalContatosCreate.TabIndex = 1;
            btPrincipalContatosCreate.Text = "Create";
            btPrincipalContatosCreate.UseVisualStyleBackColor = false;
            btPrincipalContatosCreate.Click += Create_Click;
            // 
            // btPrincipalContatosUpdate
            // 
            btPrincipalContatosUpdate.Anchor = AnchorStyles.Top;
            btPrincipalContatosUpdate.Location = new Point(589, 78);
            btPrincipalContatosUpdate.Name = "btPrincipalContatosUpdate";
            btPrincipalContatosUpdate.Size = new Size(191, 37);
            btPrincipalContatosUpdate.TabIndex = 2;
            btPrincipalContatosUpdate.Text = "Update";
            btPrincipalContatosUpdate.UseVisualStyleBackColor = true;
            btPrincipalContatosUpdate.Click += btPrincipalContatosUpdate_Click;
            // 
            // btPrincipalContatosDelete
            // 
            btPrincipalContatosDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btPrincipalContatosDelete.Location = new Point(936, 78);
            btPrincipalContatosDelete.Name = "btPrincipalContatosDelete";
            btPrincipalContatosDelete.Size = new Size(191, 37);
            btPrincipalContatosDelete.TabIndex = 3;
            btPrincipalContatosDelete.Text = "Delete";
            btPrincipalContatosDelete.UseVisualStyleBackColor = true;
            btPrincipalContatosDelete.Click += btPrincipalContatosDelete_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(578, 11);
            label1.Name = "label1";
            label1.Size = new Size(208, 56);
            label1.TabIndex = 4;
            label1.Text = "Lista de Contatos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContatosTable
            // 
            ContatosTable.AllowUserToAddRows = false;
            ContatosTable.AllowUserToDeleteRows = false;
            ContatosTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContatosTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ContatosTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ContatosTable.Location = new Point(242, 140);
            ContatosTable.MultiSelect = false;
            ContatosTable.Name = "ContatosTable";
            ContatosTable.RowHeadersVisible = false;
            ContatosTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContatosTable.Size = new Size(885, 476);
            ContatosTable.TabIndex = 5;
            // 
            // menu1
            // 
            menu1.BackColor = Color.FromArgb(230, 34, 34);
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(212, 648);
            menu1.TabIndex = 6;
            // 
            // MainContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1153, 648);
            Controls.Add(menu1);
            Controls.Add(ContatosTable);
            Controls.Add(label1);
            Controls.Add(btPrincipalContatosDelete);
            Controls.Add(btPrincipalContatosUpdate);
            Controls.Add(btPrincipalContatosCreate);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(689, 643);
            Name = "MainContato";
            Text = "Contatos";
            WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)ContatosTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btPrincipalContatosCreate;
        private Button btPrincipalContatosUpdate;
        private Button btPrincipalContatosDelete;
        private Label label1;
        private DataGridView ContatosTable;
        private Menu menu1;
    }
}
