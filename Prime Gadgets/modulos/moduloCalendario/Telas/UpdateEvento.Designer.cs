using Prime_Gadgets.modulos.moduloContatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloCalendario
{
    partial class UpdateEvento
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
            lbUpdateEventoTitulo = new Label();
            btUpdateEventoAtualizar = new Button();
            btUpdateEventoCancelar = new Button();
            campUpdateEventoId = new TextBox();
            lbUpdateEventoId = new Label();
            campUpdateEventoData = new DateTimePicker();
            lbUpdateEventoData = new Label();
            campUpdateEventoLocal = new TextBox();
            lbUpdateEventoLocal = new Label();
            campUpdateEventoDescricao = new TextBox();
            lbUpdateEventoDescricao = new Label();
            btUpdateEventoDeletar = new Button();
            SuspendLayout();
            // 
            // lbUpdateEventoTitulo
            // 
            lbUpdateEventoTitulo.AutoSize = true;
            lbUpdateEventoTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUpdateEventoTitulo.Location = new Point(41, 27);
            lbUpdateEventoTitulo.Name = "lbUpdateEventoTitulo";
            lbUpdateEventoTitulo.Size = new Size(243, 36);
            lbUpdateEventoTitulo.TabIndex = 0;
            lbUpdateEventoTitulo.Text = "Atualizar Evento";
            // 
            // btUpdateEventoAtualizar
            // 
            btUpdateEventoAtualizar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateEventoAtualizar.FlatAppearance.BorderSize = 0;
            btUpdateEventoAtualizar.FlatStyle = FlatStyle.Flat;
            btUpdateEventoAtualizar.Font = new Font("Arial", 12.75F);
            btUpdateEventoAtualizar.ForeColor = Color.FromArgb(255, 252, 237);
            btUpdateEventoAtualizar.Location = new Point(30, 270);
            btUpdateEventoAtualizar.Name = "btUpdateEventoAtualizar";
            btUpdateEventoAtualizar.Size = new Size(120, 35);
            btUpdateEventoAtualizar.TabIndex = 9;
            btUpdateEventoAtualizar.Text = "Atualizar";
            btUpdateEventoAtualizar.UseVisualStyleBackColor = false;
            btUpdateEventoAtualizar.Click += btUpdateEventoAtualizar_Click;
            // 
            // btUpdateEventoCancelar
            // 
            btUpdateEventoCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateEventoCancelar.FlatAppearance.BorderSize = 0;
            btUpdateEventoCancelar.FlatStyle = FlatStyle.Flat;
            btUpdateEventoCancelar.Font = new Font("Arial", 12.75F);
            btUpdateEventoCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btUpdateEventoCancelar.Location = new Point(179, 270);
            btUpdateEventoCancelar.Name = "btUpdateEventoCancelar";
            btUpdateEventoCancelar.Size = new Size(120, 35);
            btUpdateEventoCancelar.TabIndex = 10;
            btUpdateEventoCancelar.Text = "Cancelar";
            btUpdateEventoCancelar.UseVisualStyleBackColor = false;
            btUpdateEventoCancelar.Click += btUpdateEventoCancelar_Click;
            // 
            // campUpdateEventoId
            // 
            campUpdateEventoId.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateEventoId.BorderStyle = BorderStyle.None;
            campUpdateEventoId.Font = new Font("Arial", 12.75F);
            campUpdateEventoId.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateEventoId.Location = new Point(121, 83);
            campUpdateEventoId.Name = "campUpdateEventoId";
            campUpdateEventoId.ReadOnly = true;
            campUpdateEventoId.Size = new Size(156, 20);
            campUpdateEventoId.TabIndex = 2;
            // 
            // lbUpdateEventoId
            // 
            lbUpdateEventoId.AutoSize = true;
            lbUpdateEventoId.Font = new Font("Arial", 12.75F);
            lbUpdateEventoId.Location = new Point(55, 86);
            lbUpdateEventoId.Name = "lbUpdateEventoId";
            lbUpdateEventoId.Size = new Size(26, 19);
            lbUpdateEventoId.TabIndex = 1;
            lbUpdateEventoId.Text = "ID";
            // 
            // campUpdateEventoData
            // 
            campUpdateEventoData.CalendarForeColor = Color.FromArgb(230, 34, 34);
            campUpdateEventoData.Font = new Font("Arial", 12.75F);
            campUpdateEventoData.Format = DateTimePickerFormat.Short;
            campUpdateEventoData.Location = new Point(121, 112);
            campUpdateEventoData.Name = "campUpdateEventoData";
            campUpdateEventoData.Size = new Size(156, 27);
            campUpdateEventoData.TabIndex = 4;
            // 
            // lbUpdateEventoData
            // 
            lbUpdateEventoData.AutoSize = true;
            lbUpdateEventoData.Font = new Font("Arial", 12.75F);
            lbUpdateEventoData.Location = new Point(49, 118);
            lbUpdateEventoData.Name = "lbUpdateEventoData";
            lbUpdateEventoData.Size = new Size(43, 19);
            lbUpdateEventoData.TabIndex = 3;
            lbUpdateEventoData.Text = "Data";
            // 
            // campUpdateEventoLocal
            // 
            campUpdateEventoLocal.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateEventoLocal.BorderStyle = BorderStyle.None;
            campUpdateEventoLocal.Font = new Font("Arial", 12.75F);
            campUpdateEventoLocal.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateEventoLocal.Location = new Point(121, 148);
            campUpdateEventoLocal.Name = "campUpdateEventoLocal";
            campUpdateEventoLocal.Size = new Size(156, 20);
            campUpdateEventoLocal.TabIndex = 6;
            campUpdateEventoLocal.TextChanged += Campos_TextChanged;
            // 
            // lbUpdateEventoLocal
            // 
            lbUpdateEventoLocal.AutoSize = true;
            lbUpdateEventoLocal.Font = new Font("Arial", 12.75F);
            lbUpdateEventoLocal.Location = new Point(48, 148);
            lbUpdateEventoLocal.Name = "lbUpdateEventoLocal";
            lbUpdateEventoLocal.Size = new Size(48, 19);
            lbUpdateEventoLocal.TabIndex = 5;
            lbUpdateEventoLocal.Text = "Local";
            // 
            // campUpdateEventoDescricao
            // 
            campUpdateEventoDescricao.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateEventoDescricao.BorderStyle = BorderStyle.None;
            campUpdateEventoDescricao.Font = new Font("Arial", 12.75F);
            campUpdateEventoDescricao.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateEventoDescricao.Location = new Point(121, 179);
            campUpdateEventoDescricao.Multiline = true;
            campUpdateEventoDescricao.Name = "campUpdateEventoDescricao";
            campUpdateEventoDescricao.Size = new Size(156, 77);
            campUpdateEventoDescricao.TabIndex = 8;
            campUpdateEventoDescricao.TextChanged += Campos_TextChanged;
            // 
            // lbUpdateEventoDescricao
            // 
            lbUpdateEventoDescricao.AutoSize = true;
            lbUpdateEventoDescricao.Font = new Font("Arial", 12.75F);
            lbUpdateEventoDescricao.Location = new Point(31, 179);
            lbUpdateEventoDescricao.Name = "lbUpdateEventoDescricao";
            lbUpdateEventoDescricao.Size = new Size(84, 19);
            lbUpdateEventoDescricao.TabIndex = 7;
            lbUpdateEventoDescricao.Text = "Descrição";
            // 
            // btUpdateEventoDeletar
            // 
            btUpdateEventoDeletar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateEventoDeletar.FlatAppearance.BorderSize = 0;
            btUpdateEventoDeletar.FlatStyle = FlatStyle.Flat;
            btUpdateEventoDeletar.Font = new Font("Arial", 12.75F);
            btUpdateEventoDeletar.ForeColor = Color.FromArgb(255, 252, 237);
            btUpdateEventoDeletar.Location = new Point(98, 320);
            btUpdateEventoDeletar.Name = "btUpdateEventoDeletar";
            btUpdateEventoDeletar.Size = new Size(133, 36);
            btUpdateEventoDeletar.TabIndex = 11;
            btUpdateEventoDeletar.Text = "Deletar";
            btUpdateEventoDeletar.UseVisualStyleBackColor = false;
            btUpdateEventoDeletar.Click += btUpdateEventoDeletar_Click;
            // 
            // UpdateEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(328, 373);
            ControlBox = false;
            Controls.Add(btUpdateEventoDeletar);
            Controls.Add(btUpdateEventoCancelar);
            Controls.Add(btUpdateEventoAtualizar);
            Controls.Add(campUpdateEventoDescricao);
            Controls.Add(lbUpdateEventoDescricao);
            Controls.Add(campUpdateEventoLocal);
            Controls.Add(lbUpdateEventoLocal);
            Controls.Add(campUpdateEventoData);
            Controls.Add(lbUpdateEventoData);
            Controls.Add(campUpdateEventoId);
            Controls.Add(lbUpdateEventoId);
            Controls.Add(lbUpdateEventoTitulo);
            ForeColor = Color.FromArgb(52, 60, 76);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateEvento";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Atualizar Evento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbUpdateEventoTitulo;
        private System.Windows.Forms.Button btUpdateEventoAtualizar;
        private System.Windows.Forms.Button btUpdateEventoCancelar;
        private System.Windows.Forms.TextBox campUpdateEventoId;
        private System.Windows.Forms.Label lbUpdateEventoId;
        private System.Windows.Forms.DateTimePicker campUpdateEventoData;
        private System.Windows.Forms.Label lbUpdateEventoData;
        private System.Windows.Forms.TextBox campUpdateEventoLocal;
        private System.Windows.Forms.Label lbUpdateEventoLocal;
        private System.Windows.Forms.TextBox campUpdateEventoDescricao;
        private System.Windows.Forms.Label lbUpdateEventoDescricao;
        private Button btUpdateEventoDeletar;
    }
}