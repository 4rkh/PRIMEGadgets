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
            btMainContatosCreate = new Button();
            btMainContatosUpdate = new Button();
            btMainContatosDelete = new Button();
            lbMainContatosTitulo = new Label();
            dtMainContatosLista = new DataGridView();
            menuGlobal = new Menu();
            btMainContatosNext = new Button();
            btMainContatosLast = new Button();
            btMainContatosBack = new Button();
            btMainContatosFirst = new Button();
            lbMainContatosPgAtual = new Label();
            lbMainContatosTexto1 = new Label();
            lbMainContatosPgFinal = new Label();
            ((ISupportInitialize)dtMainContatosLista).BeginInit();
            SuspendLayout();
            // 
            // btMainContatosCreate
            // 
            btMainContatosCreate.BackColor = Color.FromArgb(230, 34, 34);
            btMainContatosCreate.FlatAppearance.BorderSize = 0;
            btMainContatosCreate.FlatStyle = FlatStyle.Flat;
            btMainContatosCreate.Font = new Font("Arial", 12.75F);
            btMainContatosCreate.ForeColor = Color.FromArgb(255, 252, 237);
            btMainContatosCreate.Location = new Point(242, 78);
            btMainContatosCreate.Name = "btMainContatosCreate";
            btMainContatosCreate.Size = new Size(191, 37);
            btMainContatosCreate.TabIndex = 1;
            btMainContatosCreate.Text = "Adicionar";
            btMainContatosCreate.UseVisualStyleBackColor = false;
            btMainContatosCreate.Click += Create_Click;
            // 
            // btMainContatosUpdate
            // 
            btMainContatosUpdate.Anchor = AnchorStyles.Top;
            btMainContatosUpdate.BackColor = Color.FromArgb(230, 34, 34);
            btMainContatosUpdate.FlatAppearance.BorderSize = 0;
            btMainContatosUpdate.FlatStyle = FlatStyle.Flat;
            btMainContatosUpdate.Font = new Font("Arial", 12.75F);
            btMainContatosUpdate.ForeColor = Color.FromArgb(255, 252, 237);
            btMainContatosUpdate.Location = new Point(609, 78);
            btMainContatosUpdate.Name = "btMainContatosUpdate";
            btMainContatosUpdate.Size = new Size(191, 37);
            btMainContatosUpdate.TabIndex = 2;
            btMainContatosUpdate.Text = "Atualizar";
            btMainContatosUpdate.UseVisualStyleBackColor = false;
            btMainContatosUpdate.Click += btMainContatosUpdate_Click;
            // 
            // btMainContatosDelete
            // 
            btMainContatosDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btMainContatosDelete.BackColor = Color.FromArgb(230, 34, 34);
            btMainContatosDelete.FlatAppearance.BorderSize = 0;
            btMainContatosDelete.FlatStyle = FlatStyle.Flat;
            btMainContatosDelete.Font = new Font("Arial", 12.75F);
            btMainContatosDelete.ForeColor = Color.FromArgb(255, 252, 237);
            btMainContatosDelete.Location = new Point(976, 78);
            btMainContatosDelete.Name = "btMainContatosDelete";
            btMainContatosDelete.Size = new Size(191, 37);
            btMainContatosDelete.TabIndex = 3;
            btMainContatosDelete.Text = "Excluir";
            btMainContatosDelete.UseVisualStyleBackColor = false;
            btMainContatosDelete.Click += btMainContatosDelete_Click;
            // 
            // lbMainContatosTitulo
            // 
            lbMainContatosTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbMainContatosTitulo.BackColor = Color.Transparent;
            lbMainContatosTitulo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMainContatosTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainContatosTitulo.Location = new Point(578, 11);
            lbMainContatosTitulo.Name = "lbMainContatosTitulo";
            lbMainContatosTitulo.Size = new Size(248, 56);
            lbMainContatosTitulo.TabIndex = 4;
            lbMainContatosTitulo.Text = "Lista de Contatos";
            lbMainContatosTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtMainContatosLista
            // 
            dtMainContatosLista.AllowUserToAddRows = false;
            dtMainContatosLista.AllowUserToDeleteRows = false;
            dtMainContatosLista.AllowUserToResizeColumns = false;
            dtMainContatosLista.AllowUserToResizeRows = false;
            dtMainContatosLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtMainContatosLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtMainContatosLista.BackgroundColor = Color.FromArgb(255, 252, 237);
            dtMainContatosLista.BorderStyle = BorderStyle.None;
            dtMainContatosLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMainContatosLista.GridColor = SystemColors.WindowText;
            dtMainContatosLista.Location = new Point(242, 140);
            dtMainContatosLista.MultiSelect = false;
            dtMainContatosLista.Name = "dtMainContatosLista";
            dtMainContatosLista.ReadOnly = true;
            dtMainContatosLista.RowHeadersVisible = false;
            dtMainContatosLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtMainContatosLista.Size = new Size(925, 458);
            dtMainContatosLista.TabIndex = 5;
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
            // btMainContatosNext
            // 
            btMainContatosNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btMainContatosNext.BackgroundImage = Properties.Resources.right;
            btMainContatosNext.BackgroundImageLayout = ImageLayout.Center;
            btMainContatosNext.Location = new Point(851, 604);
            btMainContatosNext.Name = "btMainContatosNext";
            btMainContatosNext.Size = new Size(55, 59);
            btMainContatosNext.TabIndex = 7;
            btMainContatosNext.UseVisualStyleBackColor = true;
            btMainContatosNext.Click += btMainContatosNext_Click;
            // 
            // btMainContatosLast
            // 
            btMainContatosLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btMainContatosLast.BackgroundImage = Properties.Resources.right;
            btMainContatosLast.BackgroundImageLayout = ImageLayout.Center;
            btMainContatosLast.Location = new Point(927, 604);
            btMainContatosLast.Name = "btMainContatosLast";
            btMainContatosLast.Size = new Size(55, 59);
            btMainContatosLast.TabIndex = 8;
            btMainContatosLast.UseVisualStyleBackColor = true;
            btMainContatosLast.Click += btMainContatosLast_Click;
            // 
            // btMainContatosBack
            // 
            btMainContatosBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btMainContatosBack.Image = Properties.Resources.left;
            btMainContatosBack.Location = new Point(531, 604);
            btMainContatosBack.Name = "btMainContatosBack";
            btMainContatosBack.Size = new Size(55, 59);
            btMainContatosBack.TabIndex = 9;
            btMainContatosBack.UseVisualStyleBackColor = true;
            btMainContatosBack.Click += btMainContatosBack_Click;
            // 
            // btMainContatosFirst
            // 
            btMainContatosFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btMainContatosFirst.Image = Properties.Resources.left;
            btMainContatosFirst.Location = new Point(457, 604);
            btMainContatosFirst.Name = "btMainContatosFirst";
            btMainContatosFirst.Size = new Size(55, 59);
            btMainContatosFirst.TabIndex = 10;
            btMainContatosFirst.UseVisualStyleBackColor = true;
            btMainContatosFirst.Click += btMainContatosFirst_Click;
            // 
            // lbMainContatosPgAtual
            // 
            lbMainContatosPgAtual.Anchor = AnchorStyles.Bottom;
            lbMainContatosPgAtual.AutoSize = true;
            lbMainContatosPgAtual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMainContatosPgAtual.ForeColor = Color.Red;
            lbMainContatosPgAtual.Location = new Point(654, 620);
            lbMainContatosPgAtual.Name = "lbMainContatosPgAtual";
            lbMainContatosPgAtual.Size = new Size(19, 21);
            lbMainContatosPgAtual.TabIndex = 11;
            lbMainContatosPgAtual.Text = "1";
            // 
            // lbMainContatosTexto1
            // 
            lbMainContatosTexto1.Anchor = AnchorStyles.Bottom;
            lbMainContatosTexto1.AutoSize = true;
            lbMainContatosTexto1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMainContatosTexto1.Location = new Point(699, 622);
            lbMainContatosTexto1.Name = "lbMainContatosTexto1";
            lbMainContatosTexto1.Size = new Size(26, 20);
            lbMainContatosTexto1.TabIndex = 12;
            lbMainContatosTexto1.Text = "de";
            // 
            // lbMainContatosPgFinal
            // 
            lbMainContatosPgFinal.Anchor = AnchorStyles.Bottom;
            lbMainContatosPgFinal.AutoSize = true;
            lbMainContatosPgFinal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMainContatosPgFinal.ForeColor = Color.FromArgb(0, 0, 192);
            lbMainContatosPgFinal.Location = new Point(750, 617);
            lbMainContatosPgFinal.Name = "lbMainContatosPgFinal";
            lbMainContatosPgFinal.Size = new Size(23, 25);
            lbMainContatosPgFinal.TabIndex = 13;
            lbMainContatosPgFinal.Text = "1";
            // 
            // MainContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1193, 663);
            Controls.Add(lbMainContatosPgFinal);
            Controls.Add(lbMainContatosTexto1);
            Controls.Add(lbMainContatosPgAtual);
            Controls.Add(btMainContatosFirst);
            Controls.Add(btMainContatosBack);
            Controls.Add(btMainContatosLast);
            Controls.Add(btMainContatosNext);
            Controls.Add(menuGlobal);
            Controls.Add(dtMainContatosLista);
            Controls.Add(lbMainContatosTitulo);
            Controls.Add(btMainContatosDelete);
            Controls.Add(btMainContatosUpdate);
            Controls.Add(btMainContatosCreate);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(689, 643);
            Name = "MainContato";
            Text = "Contatos";
            WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)dtMainContatosLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btMainContatosCreate;
        private Button btMainContatosUpdate;
        private Button btMainContatosDelete;
        private Label lbMainContatosTitulo;
        private DataGridView dtMainContatosLista;
        private Menu menuGlobal;
        private Button btMainContatosNext;
        private Button btMainContatosLast;
        private Button btMainContatosBack;
        private Button btMainContatosFirst;
        private Label lbMainContatosPgAtual;
        private Label lbMainContatosTexto1;
        private Label lbMainContatosPgFinal;
    }
}
