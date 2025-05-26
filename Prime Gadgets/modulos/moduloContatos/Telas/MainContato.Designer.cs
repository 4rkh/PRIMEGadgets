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
            lbPrincipalContatosTitulo = new Label();
            ContatosTable = new DataGridView();
            menu1 = new Menu();
            btPrincipalContatosNext = new Button();
            btPrincipalContatosLast = new Button();
            btPrincipalContatosBack = new Button();
            btPrincipalContatosFirst = new Button();
            lbPrincipalContatosPgAtual = new Label();
            lbPrincipalContatosTexto1 = new Label();
            lbPrincipalContatosPgFinal = new Label();
            ((ISupportInitialize)ContatosTable).BeginInit();
            SuspendLayout();
            // 
            // btPrincipalContatosCreate
            // 
            btPrincipalContatosCreate.BackColor = Color.FromArgb(230, 34, 34);
            btPrincipalContatosCreate.FlatAppearance.BorderSize = 0;
            btPrincipalContatosCreate.FlatStyle = FlatStyle.Flat;
            btPrincipalContatosCreate.Font = new Font("Arial", 12.75F);
            btPrincipalContatosCreate.ForeColor = Color.FromArgb(255, 252, 237);
            btPrincipalContatosCreate.Location = new Point(242, 78);
            btPrincipalContatosCreate.Name = "btPrincipalContatosCreate";
            btPrincipalContatosCreate.Size = new Size(191, 37);
            btPrincipalContatosCreate.TabIndex = 1;
            btPrincipalContatosCreate.Text = "Adicionar";
            btPrincipalContatosCreate.UseVisualStyleBackColor = false;
            btPrincipalContatosCreate.Click += Create_Click;
            // 
            // btPrincipalContatosUpdate
            // 
            btPrincipalContatosUpdate.Anchor = AnchorStyles.Top;
            btPrincipalContatosUpdate.BackColor = Color.FromArgb(230, 34, 34);
            btPrincipalContatosUpdate.FlatAppearance.BorderSize = 0;
            btPrincipalContatosUpdate.FlatStyle = FlatStyle.Flat;
            btPrincipalContatosUpdate.Font = new Font("Arial", 12.75F);
            btPrincipalContatosUpdate.ForeColor = Color.FromArgb(255, 252, 237);
            btPrincipalContatosUpdate.Location = new Point(609, 78);
            btPrincipalContatosUpdate.Name = "btPrincipalContatosUpdate";
            btPrincipalContatosUpdate.Size = new Size(191, 37);
            btPrincipalContatosUpdate.TabIndex = 2;
            btPrincipalContatosUpdate.Text = "Atualizar";
            btPrincipalContatosUpdate.UseVisualStyleBackColor = false;
            btPrincipalContatosUpdate.Click += btPrincipalContatosUpdate_Click;
            // 
            // btPrincipalContatosDelete
            // 
            btPrincipalContatosDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btPrincipalContatosDelete.BackColor = Color.FromArgb(230, 34, 34);
            btPrincipalContatosDelete.FlatAppearance.BorderSize = 0;
            btPrincipalContatosDelete.FlatStyle = FlatStyle.Flat;
            btPrincipalContatosDelete.Font = new Font("Arial", 12.75F);
            btPrincipalContatosDelete.ForeColor = Color.FromArgb(255, 252, 237);
            btPrincipalContatosDelete.Location = new Point(976, 78);
            btPrincipalContatosDelete.Name = "btPrincipalContatosDelete";
            btPrincipalContatosDelete.Size = new Size(191, 37);
            btPrincipalContatosDelete.TabIndex = 3;
            btPrincipalContatosDelete.Text = "Excluir";
            btPrincipalContatosDelete.UseVisualStyleBackColor = false;
            btPrincipalContatosDelete.Click += btPrincipalContatosDelete_Click;
            // 
            // lbPrincipalContatosTitulo
            // 
            lbPrincipalContatosTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbPrincipalContatosTitulo.BackColor = Color.Transparent;
            lbPrincipalContatosTitulo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrincipalContatosTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbPrincipalContatosTitulo.Location = new Point(578, 11);
            lbPrincipalContatosTitulo.Name = "lbPrincipalContatosTitulo";
            lbPrincipalContatosTitulo.Size = new Size(248, 56);
            lbPrincipalContatosTitulo.TabIndex = 4;
            lbPrincipalContatosTitulo.Text = "Lista de Contatos";
            lbPrincipalContatosTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContatosTable
            // 
            ContatosTable.AllowUserToAddRows = false;
            ContatosTable.AllowUserToDeleteRows = false;
            ContatosTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContatosTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ContatosTable.BackgroundColor = Color.FromArgb(255, 252, 237);
            ContatosTable.BorderStyle = BorderStyle.None;
            ContatosTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ContatosTable.GridColor = SystemColors.WindowText;
            ContatosTable.Location = new Point(242, 140);
            ContatosTable.MultiSelect = false;
            ContatosTable.Name = "ContatosTable";
            ContatosTable.RowHeadersVisible = false;
            ContatosTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContatosTable.Size = new Size(925, 458);
            ContatosTable.TabIndex = 5;
            // 
            // menu1
            // 
            menu1.BackColor = Color.FromArgb(230, 34, 34);
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(212, 663);
            menu1.TabIndex = 6;
            // 
            // btPrincipalContatosNext
            // 
            btPrincipalContatosNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btPrincipalContatosNext.Image = (Image)resources.GetObject("btPrincipalContatosNext.Image");
            btPrincipalContatosNext.Location = new Point(851, 604);
            btPrincipalContatosNext.Name = "btPrincipalContatosNext";
            btPrincipalContatosNext.Size = new Size(55, 59);
            btPrincipalContatosNext.TabIndex = 7;
            btPrincipalContatosNext.UseVisualStyleBackColor = true;
            btPrincipalContatosNext.Click += btPrincipalContatosNext_Click;
            // 
            // btPrincipalContatosLast
            // 
            btPrincipalContatosLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btPrincipalContatosLast.Image = (Image)resources.GetObject("btPrincipalContatosLast.Image");
            btPrincipalContatosLast.Location = new Point(927, 604);
            btPrincipalContatosLast.Name = "btPrincipalContatosLast";
            btPrincipalContatosLast.Size = new Size(55, 59);
            btPrincipalContatosLast.TabIndex = 8;
            btPrincipalContatosLast.UseVisualStyleBackColor = true;
            btPrincipalContatosLast.Click += btPrincipalContatosLast_Click;
            // 
            // btPrincipalContatosBack
            // 
            btPrincipalContatosBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btPrincipalContatosBack.Image = Properties.Resources.icons8_à_esquerda_dentro_de_um_círculo_50;
            btPrincipalContatosBack.Location = new Point(531, 604);
            btPrincipalContatosBack.Name = "btPrincipalContatosBack";
            btPrincipalContatosBack.Size = new Size(55, 59);
            btPrincipalContatosBack.TabIndex = 9;
            btPrincipalContatosBack.UseVisualStyleBackColor = true;
            btPrincipalContatosBack.Click += btPrincipalContatosBack_Click;
            // 
            // btPrincipalContatosFirst
            // 
            btPrincipalContatosFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btPrincipalContatosFirst.Image = Properties.Resources.icons8_à_esquerda_dentro_de_um_círculo_50;
            btPrincipalContatosFirst.Location = new Point(457, 604);
            btPrincipalContatosFirst.Name = "btPrincipalContatosFirst";
            btPrincipalContatosFirst.Size = new Size(55, 59);
            btPrincipalContatosFirst.TabIndex = 10;
            btPrincipalContatosFirst.UseVisualStyleBackColor = true;
            btPrincipalContatosFirst.Click += btPrincipalContatosFirst_Click;
            // 
            // lbPrincipalContatosPgAtual
            // 
            lbPrincipalContatosPgAtual.Anchor = AnchorStyles.Bottom;
            lbPrincipalContatosPgAtual.AutoSize = true;
            lbPrincipalContatosPgAtual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrincipalContatosPgAtual.ForeColor = Color.Red;
            lbPrincipalContatosPgAtual.Location = new Point(654, 620);
            lbPrincipalContatosPgAtual.Name = "lbPrincipalContatosPgAtual";
            lbPrincipalContatosPgAtual.Size = new Size(19, 21);
            lbPrincipalContatosPgAtual.TabIndex = 11;
            lbPrincipalContatosPgAtual.Text = "1";
            // 
            // lbPrincipalContatosTexto1
            // 
            lbPrincipalContatosTexto1.Anchor = AnchorStyles.Bottom;
            lbPrincipalContatosTexto1.AutoSize = true;
            lbPrincipalContatosTexto1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrincipalContatosTexto1.Location = new Point(699, 622);
            lbPrincipalContatosTexto1.Name = "lbPrincipalContatosTexto1";
            lbPrincipalContatosTexto1.Size = new Size(26, 20);
            lbPrincipalContatosTexto1.TabIndex = 12;
            lbPrincipalContatosTexto1.Text = "de";
            // 
            // lbPrincipalContatosPgFinal
            // 
            lbPrincipalContatosPgFinal.Anchor = AnchorStyles.Bottom;
            lbPrincipalContatosPgFinal.AutoSize = true;
            lbPrincipalContatosPgFinal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrincipalContatosPgFinal.ForeColor = Color.FromArgb(0, 0, 192);
            lbPrincipalContatosPgFinal.Location = new Point(750, 617);
            lbPrincipalContatosPgFinal.Name = "lbPrincipalContatosPgFinal";
            lbPrincipalContatosPgFinal.Size = new Size(23, 25);
            lbPrincipalContatosPgFinal.TabIndex = 13;
            lbPrincipalContatosPgFinal.Text = "1";
            // 
            // MainContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1193, 663);
            Controls.Add(lbPrincipalContatosPgFinal);
            Controls.Add(lbPrincipalContatosTexto1);
            Controls.Add(lbPrincipalContatosPgAtual);
            Controls.Add(btPrincipalContatosFirst);
            Controls.Add(btPrincipalContatosBack);
            Controls.Add(btPrincipalContatosLast);
            Controls.Add(btPrincipalContatosNext);
            Controls.Add(menu1);
            Controls.Add(ContatosTable);
            Controls.Add(lbPrincipalContatosTitulo);
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
            PerformLayout();
        }

        #endregion

        private Button btPrincipalContatosCreate;
        private Button btPrincipalContatosUpdate;
        private Button btPrincipalContatosDelete;
        private Label lbPrincipalContatosTitulo;
        private DataGridView ContatosTable;
        private Menu menu1;
        private Button btPrincipalContatosNext;
        private Button btPrincipalContatosLast;
        private Button btPrincipalContatosBack;
        private Button btPrincipalContatosFirst;
        private Label lbPrincipalContatosPgAtual;
        private Label lbPrincipalContatosTexto1;
        private Label lbPrincipalContatosPgFinal;
    }
}
