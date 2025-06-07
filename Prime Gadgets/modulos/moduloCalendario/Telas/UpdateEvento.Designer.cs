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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(UpdateEvento));
            lbUpdateEventoTitulo = new System.Windows.Forms.Label();
            btUpdateEventoAtualizar = new System.Windows.Forms.Button();
            btUpdateEventoCancelar = new System.Windows.Forms.Button();
            campUpdateEventoId = new System.Windows.Forms.TextBox();
            lbUpdateEventoId = new System.Windows.Forms.Label();
            campUpdateEventoData = new System.Windows.Forms.DateTimePicker();
            lbUpdateEventoData = new System.Windows.Forms.Label();
            campUpdateEventoLocal = new System.Windows.Forms.TextBox();
            lbUpdateEventoLocal = new System.Windows.Forms.Label();
            campUpdateEventoDescricao = new System.Windows.Forms.TextBox();
            lbUpdateEventoDescricao = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbUpdateEventoTitulo
            // 
            lbUpdateEventoTitulo.AutoSize = true;
            lbUpdateEventoTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lbUpdateEventoTitulo.Location = new System.Drawing.Point(30, 20);
            lbUpdateEventoTitulo.Name = "lbUpdateEventoTitulo";
            lbUpdateEventoTitulo.Size = new System.Drawing.Size(210, 30);
            lbUpdateEventoTitulo.TabIndex = 0;
            lbUpdateEventoTitulo.Text = "Atualizar Evento";
            // 
            // lbUpdateEventoId
            // 
            lbUpdateEventoId.AutoSize = true;
            lbUpdateEventoId.Location = new System.Drawing.Point(30, 70);
            lbUpdateEventoId.Name = "lbUpdateEventoId";
            lbUpdateEventoId.Size = new System.Drawing.Size(21, 15);
            lbUpdateEventoId.TabIndex = 1;
            lbUpdateEventoId.Text = "ID";
            // 
            // campUpdateEventoId
            // 
            campUpdateEventoId.Location = new System.Drawing.Point(120, 67);
            campUpdateEventoId.Name = "campUpdateEventoId";
            campUpdateEventoId.ReadOnly = true;
            campUpdateEventoId.Size = new System.Drawing.Size(80, 23);
            campUpdateEventoId.TabIndex = 2;
            // 
            // lbUpdateEventoData
            // 
            lbUpdateEventoData.AutoSize = true;
            lbUpdateEventoData.Location = new System.Drawing.Point(30, 110);
            lbUpdateEventoData.Name = "lbUpdateEventoData";
            lbUpdateEventoData.Size = new System.Drawing.Size(33, 15);
            lbUpdateEventoData.TabIndex = 3;
            lbUpdateEventoData.Text = "Data";
            // 
            // campUpdateEventoData
            // 
            campUpdateEventoData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            campUpdateEventoData.Location = new System.Drawing.Point(120, 107);
            campUpdateEventoData.Name = "campUpdateEventoData";
            campUpdateEventoData.Size = new System.Drawing.Size(120, 23);
            campUpdateEventoData.TabIndex = 4;
            // 
            // lbUpdateEventoLocal
            // 
            lbUpdateEventoLocal.AutoSize = true;
            lbUpdateEventoLocal.Location = new System.Drawing.Point(30, 150);
            lbUpdateEventoLocal.Name = "lbUpdateEventoLocal";
            lbUpdateEventoLocal.Size = new System.Drawing.Size(37, 15);
            lbUpdateEventoLocal.TabIndex = 5;
            lbUpdateEventoLocal.Text = "Local";
            // 
            // campUpdateEventoLocal
            // 
            campUpdateEventoLocal.Location = new System.Drawing.Point(120, 147);
            campUpdateEventoLocal.Name = "campUpdateEventoLocal";
            campUpdateEventoLocal.Size = new System.Drawing.Size(250, 23);
            campUpdateEventoLocal.TabIndex = 6;
            campUpdateEventoLocal.TextChanged += new System.EventHandler(Campos_TextChanged);
            // 
            // lbUpdateEventoDescricao
            // 
            lbUpdateEventoDescricao.AutoSize = true;
            lbUpdateEventoDescricao.Location = new System.Drawing.Point(30, 190);
            lbUpdateEventoDescricao.Name = "lbUpdateEventoDescricao";
            lbUpdateEventoDescricao.Size = new System.Drawing.Size(58, 15);
            lbUpdateEventoDescricao.TabIndex = 7;
            lbUpdateEventoDescricao.Text = "Descrição";
            // 
            // campUpdateEventoDescricao
            // 
            campUpdateEventoDescricao.Location = new System.Drawing.Point(120, 187);
            campUpdateEventoDescricao.Multiline = true;
            campUpdateEventoDescricao.Name = "campUpdateEventoDescricao";
            campUpdateEventoDescricao.Size = new System.Drawing.Size(250, 60);
            campUpdateEventoDescricao.TabIndex = 8;
            campUpdateEventoDescricao.TextChanged += new System.EventHandler(Campos_TextChanged);
            // 
            // btUpdateEventoAtualizar
            // 
            btUpdateEventoAtualizar.Location = new System.Drawing.Point(120, 270);
            btUpdateEventoAtualizar.Name = "btUpdateEventoAtualizar";
            btUpdateEventoAtualizar.Size = new System.Drawing.Size(120, 35);
            btUpdateEventoAtualizar.TabIndex = 9;
            btUpdateEventoAtualizar.Text = "Atualizar";
            btUpdateEventoAtualizar.UseVisualStyleBackColor = true;
            btUpdateEventoAtualizar.Click += new System.EventHandler(btUpdateEventoAtualizar_Click);
            // 
            // btUpdateEventoCancelar
            // 
            btUpdateEventoCancelar.Location = new System.Drawing.Point(250, 270);
            btUpdateEventoCancelar.Name = "btUpdateEventoCancelar";
            btUpdateEventoCancelar.Size = new System.Drawing.Size(120, 35);
            btUpdateEventoCancelar.TabIndex = 10;
            btUpdateEventoCancelar.Text = "Cancelar";
            btUpdateEventoCancelar.UseVisualStyleBackColor = true;
            btUpdateEventoCancelar.Click += new System.EventHandler(btUpdateEventoCancelar_Click);
            // 
            // UpdateEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(367, 450);
            ControlBox = false;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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


            
    }
}