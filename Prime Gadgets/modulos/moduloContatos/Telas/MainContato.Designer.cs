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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            btMainContatosUpdate.Location = new Point(589, 78);
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
            btMainContatosDelete.Location = new Point(935, 78);
            btMainContatosDelete.Name = "btMainContatosDelete";
            btMainContatosDelete.Size = new Size(191, 37);
            btMainContatosDelete.TabIndex = 3;
            btMainContatosDelete.Text = "Excluir";
            btMainContatosDelete.UseVisualStyleBackColor = false;
            btMainContatosDelete.Click += btMainContatosDelete_Click;
            // 
            // lbMainContatosTitulo
            // 
            lbMainContatosTitulo.Anchor = AnchorStyles.Top;
            lbMainContatosTitulo.BackColor = Color.Transparent;
            lbMainContatosTitulo.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbMainContatosTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainContatosTitulo.Location = new Point(520, 23);
            lbMainContatosTitulo.Name = "lbMainContatosTitulo";
            lbMainContatosTitulo.Size = new Size(310, 35);
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
            dtMainContatosLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtMainContatosLista.BackgroundColor = Color.FromArgb(255, 252, 237);
            dtMainContatosLista.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle1.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtMainContatosLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtMainContatosLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle2.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtMainContatosLista.DefaultCellStyle = dataGridViewCellStyle2;
            dtMainContatosLista.GridColor = Color.FromArgb(153, 117, 92);
            dtMainContatosLista.Location = new Point(242, 141);
            dtMainContatosLista.MultiSelect = false;
            dtMainContatosLista.Name = "dtMainContatosLista";
            dtMainContatosLista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle3.Font = new Font("Arial", 12.75F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 34, 34);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 252, 237);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtMainContatosLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtMainContatosLista.RowHeadersVisible = false;
            dtMainContatosLista.RowHeadersWidth = 40;
            dtMainContatosLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtMainContatosLista.Size = new Size(884, 343);
            dtMainContatosLista.TabIndex = 5;
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
            // btMainContatosNext
            // 
            btMainContatosNext.Anchor = AnchorStyles.Bottom;
            btMainContatosNext.BackColor = Color.FromArgb(230, 34, 34);
            btMainContatosNext.BackgroundImageLayout = ImageLayout.Center;
            btMainContatosNext.Cursor = Cursors.Hand;
            btMainContatosNext.FlatAppearance.BorderSize = 0;
            btMainContatosNext.FlatStyle = FlatStyle.Flat;
            btMainContatosNext.Image = Properties.Resources.avancar;
            btMainContatosNext.Location = new Point(803, 533);
            btMainContatosNext.Name = "btMainContatosNext";
            btMainContatosNext.Size = new Size(55, 59);
            btMainContatosNext.TabIndex = 7;
            btMainContatosNext.UseVisualStyleBackColor = false;
            btMainContatosNext.Click += btMainContatosNext_Click;
            // 
            // btMainContatosLast
            // 
            btMainContatosLast.Anchor = AnchorStyles.Bottom;
            btMainContatosLast.BackColor = Color.FromArgb(230, 34, 34);
            btMainContatosLast.BackgroundImageLayout = ImageLayout.Center;
            btMainContatosLast.Cursor = Cursors.Hand;
            btMainContatosLast.FlatAppearance.BorderSize = 0;
            btMainContatosLast.FlatStyle = FlatStyle.Flat;
            btMainContatosLast.Image = Properties.Resources.ultima;
            btMainContatosLast.Location = new Point(879, 532);
            btMainContatosLast.Name = "btMainContatosLast";
            btMainContatosLast.Size = new Size(55, 59);
            btMainContatosLast.TabIndex = 8;
            btMainContatosLast.UseVisualStyleBackColor = false;
            btMainContatosLast.Click += btMainContatosLast_Click;
            // 
            // btMainContatosBack
            // 
            btMainContatosBack.Anchor = AnchorStyles.Bottom;
            btMainContatosBack.BackColor = Color.FromArgb(230, 34, 34);
            btMainContatosBack.Cursor = Cursors.Hand;
            btMainContatosBack.FlatAppearance.BorderSize = 0;
            btMainContatosBack.FlatStyle = FlatStyle.Flat;
            btMainContatosBack.Image = Properties.Resources.voltar;
            btMainContatosBack.Location = new Point(539, 532);
            btMainContatosBack.Name = "btMainContatosBack";
            btMainContatosBack.Size = new Size(55, 59);
            btMainContatosBack.TabIndex = 9;
            btMainContatosBack.UseVisualStyleBackColor = false;
            btMainContatosBack.Click += btMainContatosBack_Click;
            // 
            // btMainContatosFirst
            // 
            btMainContatosFirst.Anchor = AnchorStyles.Bottom;
            btMainContatosFirst.BackColor = Color.FromArgb(230, 34, 34);
            btMainContatosFirst.BackgroundImageLayout = ImageLayout.None;
            btMainContatosFirst.Cursor = Cursors.Hand;
            btMainContatosFirst.FlatAppearance.BorderSize = 0;
            btMainContatosFirst.FlatStyle = FlatStyle.Flat;
            btMainContatosFirst.Image = Properties.Resources.primeira;
            btMainContatosFirst.Location = new Point(461, 533);
            btMainContatosFirst.Name = "btMainContatosFirst";
            btMainContatosFirst.Size = new Size(55, 59);
            btMainContatosFirst.TabIndex = 10;
            btMainContatosFirst.UseVisualStyleBackColor = false;
            btMainContatosFirst.Click += btMainContatosFirst_Click;
            // 
            // lbMainContatosPgAtual
            // 
            lbMainContatosPgAtual.Anchor = AnchorStyles.Bottom;
            lbMainContatosPgAtual.AutoSize = true;
            lbMainContatosPgAtual.Font = new Font("Arial", 18F);
            lbMainContatosPgAtual.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainContatosPgAtual.Location = new Point(640, 549);
            lbMainContatosPgAtual.Name = "lbMainContatosPgAtual";
            lbMainContatosPgAtual.Size = new Size(25, 27);
            lbMainContatosPgAtual.TabIndex = 11;
            lbMainContatosPgAtual.Text = "1";
            // 
            // lbMainContatosTexto1
            // 
            lbMainContatosTexto1.Anchor = AnchorStyles.Bottom;
            lbMainContatosTexto1.AutoSize = true;
            lbMainContatosTexto1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMainContatosTexto1.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainContatosTexto1.Location = new Point(682, 551);
            lbMainContatosTexto1.Name = "lbMainContatosTexto1";
            lbMainContatosTexto1.Size = new Size(33, 24);
            lbMainContatosTexto1.TabIndex = 12;
            lbMainContatosTexto1.Text = "de";
            // 
            // lbMainContatosPgFinal
            // 
            lbMainContatosPgFinal.Anchor = AnchorStyles.Bottom;
            lbMainContatosPgFinal.AutoSize = true;
            lbMainContatosPgFinal.Font = new Font("Arial", 18F, FontStyle.Bold);
            lbMainContatosPgFinal.ForeColor = Color.FromArgb(230, 34, 34);
            lbMainContatosPgFinal.Location = new Point(737, 547);
            lbMainContatosPgFinal.Name = "lbMainContatosPgFinal";
            lbMainContatosPgFinal.Size = new Size(26, 29);
            lbMainContatosPgFinal.TabIndex = 13;
            lbMainContatosPgFinal.Text = "1";
            // 
            // MainContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1152, 643);
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
