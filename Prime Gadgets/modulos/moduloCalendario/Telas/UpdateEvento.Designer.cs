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
            lbUpdateEventoTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbUpdateEventoTitulo.Location = new Point(30, 20);
            lbUpdateEventoTitulo.Name = "lbUpdateEventoTitulo";
            lbUpdateEventoTitulo.Size = new Size(183, 30);
            lbUpdateEventoTitulo.TabIndex = 0;
            lbUpdateEventoTitulo.Text = "Atualizar Evento";
            // 
            // btUpdateEventoAtualizar
            // 
            btUpdateEventoAtualizar.Location = new Point(120, 270);
            btUpdateEventoAtualizar.Name = "btUpdateEventoAtualizar";
            btUpdateEventoAtualizar.Size = new Size(120, 35);
            btUpdateEventoAtualizar.TabIndex = 9;
            btUpdateEventoAtualizar.Text = "Atualizar";
            btUpdateEventoAtualizar.UseVisualStyleBackColor = true;
            btUpdateEventoAtualizar.Click += btUpdateEventoAtualizar_Click;
            // 
            // btUpdateEventoCancelar
            // 
            btUpdateEventoCancelar.Location = new Point(250, 270);
            btUpdateEventoCancelar.Name = "btUpdateEventoCancelar";
            btUpdateEventoCancelar.Size = new Size(120, 35);
            btUpdateEventoCancelar.TabIndex = 10;
            btUpdateEventoCancelar.Text = "Cancelar";
            btUpdateEventoCancelar.UseVisualStyleBackColor = true;
            btUpdateEventoCancelar.Click += btUpdateEventoCancelar_Click;
            // 
            // campUpdateEventoId
            // 
            campUpdateEventoId.Location = new Point(120, 67);
            campUpdateEventoId.Name = "campUpdateEventoId";
            campUpdateEventoId.ReadOnly = true;
            campUpdateEventoId.Size = new Size(80, 23);
            campUpdateEventoId.TabIndex = 2;
            // 
            // lbUpdateEventoId
            // 
            lbUpdateEventoId.AutoSize = true;
            lbUpdateEventoId.Location = new Point(30, 70);
            lbUpdateEventoId.Name = "lbUpdateEventoId";
            lbUpdateEventoId.Size = new Size(18, 15);
            lbUpdateEventoId.TabIndex = 1;
            lbUpdateEventoId.Text = "ID";
            // 
            // campUpdateEventoData
            // 
            campUpdateEventoData.Format = DateTimePickerFormat.Short;
            campUpdateEventoData.Location = new Point(120, 107);
            campUpdateEventoData.Name = "campUpdateEventoData";
            campUpdateEventoData.Size = new Size(120, 23);
            campUpdateEventoData.TabIndex = 4;
            // 
            // lbUpdateEventoData
            // 
            lbUpdateEventoData.AutoSize = true;
            lbUpdateEventoData.Location = new Point(30, 110);
            lbUpdateEventoData.Name = "lbUpdateEventoData";
            lbUpdateEventoData.Size = new Size(31, 15);
            lbUpdateEventoData.TabIndex = 3;
            lbUpdateEventoData.Text = "Data";
            // 
            // campUpdateEventoLocal
            // 
            campUpdateEventoLocal.Location = new Point(120, 147);
            campUpdateEventoLocal.Name = "campUpdateEventoLocal";
            campUpdateEventoLocal.Size = new Size(250, 23);
            campUpdateEventoLocal.TabIndex = 6;
            campUpdateEventoLocal.TextChanged += Campos_TextChanged;
            // 
            // lbUpdateEventoLocal
            // 
            lbUpdateEventoLocal.AutoSize = true;
            lbUpdateEventoLocal.Location = new Point(30, 150);
            lbUpdateEventoLocal.Name = "lbUpdateEventoLocal";
            lbUpdateEventoLocal.Size = new Size(35, 15);
            lbUpdateEventoLocal.TabIndex = 5;
            lbUpdateEventoLocal.Text = "Local";
            // 
            // campUpdateEventoDescricao
            // 
            campUpdateEventoDescricao.Location = new Point(120, 187);
            campUpdateEventoDescricao.Multiline = true;
            campUpdateEventoDescricao.Name = "campUpdateEventoDescricao";
            campUpdateEventoDescricao.Size = new Size(250, 60);
            campUpdateEventoDescricao.TabIndex = 8;
            campUpdateEventoDescricao.TextChanged += Campos_TextChanged;
            // 
            // lbUpdateEventoDescricao
            // 
            lbUpdateEventoDescricao.AutoSize = true;
            lbUpdateEventoDescricao.Location = new Point(30, 190);
            lbUpdateEventoDescricao.Name = "lbUpdateEventoDescricao";
            lbUpdateEventoDescricao.Size = new Size(58, 15);
            lbUpdateEventoDescricao.TabIndex = 7;
            lbUpdateEventoDescricao.Text = "Descrição";
            // 
            // btUpdateEventoDeletar
            // 
            btUpdateEventoDeletar.Location = new Point(176, 337);
            btUpdateEventoDeletar.Name = "btUpdateEventoDeletar";
            btUpdateEventoDeletar.Size = new Size(133, 36);
            btUpdateEventoDeletar.TabIndex = 11;
            btUpdateEventoDeletar.Text = "Deletar";
            btUpdateEventoDeletar.UseVisualStyleBackColor = true;
            btUpdateEventoDeletar.Click += btUpdateEventoDeletar_Click;
            // 
            // UpdateEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(472, 450);
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