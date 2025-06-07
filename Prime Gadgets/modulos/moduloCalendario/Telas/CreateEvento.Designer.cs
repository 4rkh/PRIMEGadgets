namespace Prime_Gadgets.modulos.moduloCalendario
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
    partial class CreateEvento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CreateEvento));
            lbCreateEventoTitulo = new Label();
            btCreateEventoCriar = new Button();
            btCreateEventoCancelar = new Button();
            campCreateEventoData = new DateTimePicker();
            campCreateEventoLocal = new TextBox();
            campCreateEventoDescricao = new TextBox();
            lbCreateEventoData = new Label();
            lbCreateEventoLocal = new Label();
            lbCreateEventoDescricao = new Label();
            SuspendLayout();
            // 
            // lbCreateEventoTitulo
            // 
            lbCreateEventoTitulo.AutoSize = true;
            lbCreateEventoTitulo.BackColor = Color.Transparent;
            lbCreateEventoTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCreateEventoTitulo.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateEventoTitulo.Location = new Point(49, 47);
            lbCreateEventoTitulo.Name = "lbCreateEventoTitulo";
            lbCreateEventoTitulo.Size = new Size(246, 36);
            lbCreateEventoTitulo.TabIndex = 0;
            lbCreateEventoTitulo.Text = "Adicionar Evento";
            // 
            // btCreateEventoCriar
            // 
            btCreateEventoCriar.BackColor = Color.FromArgb(52, 60, 76);
            btCreateEventoCriar.Enabled = false;
            btCreateEventoCriar.FlatAppearance.BorderSize = 0;
            btCreateEventoCriar.FlatStyle = FlatStyle.Flat;
            btCreateEventoCriar.Font = new Font("Arial", 12.75F);
            btCreateEventoCriar.ForeColor = Color.FromArgb(183, 190, 191);
            btCreateEventoCriar.Location = new Point(47, 320);
            btCreateEventoCriar.Name = "btCreateEventoCriar";
            btCreateEventoCriar.Size = new Size(118, 37);
            btCreateEventoCriar.TabIndex = 1;
            btCreateEventoCriar.Text = "Criar";
            btCreateEventoCriar.UseVisualStyleBackColor = false;
            btCreateEventoCriar.EnabledChanged += btCreateEventoCriar_EnabledChanged;
            btCreateEventoCriar.Click += btCreateEventoCriar_Click;
            // 
            // btCreateEventoCancelar
            // 
            btCreateEventoCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btCreateEventoCancelar.FlatAppearance.BorderSize = 0;
            btCreateEventoCancelar.FlatStyle = FlatStyle.Flat;
            btCreateEventoCancelar.Font = new Font("Arial", 12.75F);
            btCreateEventoCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btCreateEventoCancelar.Location = new Point(199, 320);
            btCreateEventoCancelar.Name = "btCreateEventoCancelar";
            btCreateEventoCancelar.Size = new Size(118, 37);
            btCreateEventoCancelar.TabIndex = 2;
            btCreateEventoCancelar.Text = "Cancelar";
            btCreateEventoCancelar.UseVisualStyleBackColor = false;
            btCreateEventoCancelar.Click += btCreateEventoCancelar_Click;
            // 
            // campCreateEventoData
            // 
            campCreateEventoData.Font = new Font("Arial", 12.75F);
            campCreateEventoData.Format = DateTimePickerFormat.Short;
            campCreateEventoData.Location = new Point(131, 157);
            campCreateEventoData.Name = "campCreateEventoData";
            campCreateEventoData.Size = new Size(156, 27);
            campCreateEventoData.TabIndex = 4;
            campCreateEventoData.ValueChanged += Campos_TextChanged;
            // 
            // campCreateEventoLocal
            // 
            campCreateEventoLocal.BackColor = Color.FromArgb(255, 252, 237);
            campCreateEventoLocal.BorderStyle = BorderStyle.None;
            campCreateEventoLocal.Font = new Font("Arial", 12.75F);
            campCreateEventoLocal.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateEventoLocal.Location = new Point(131, 200);
            campCreateEventoLocal.Name = "campCreateEventoLocal";
            campCreateEventoLocal.Size = new Size(156, 20);
            campCreateEventoLocal.TabIndex = 5;
            campCreateEventoLocal.TextChanged += Campos_TextChanged;
            // 
            // campCreateEventoDescricao
            // 
            campCreateEventoDescricao.BackColor = Color.FromArgb(255, 252, 237);
            campCreateEventoDescricao.BorderStyle = BorderStyle.None;
            campCreateEventoDescricao.Font = new Font("Arial", 12.75F);
            campCreateEventoDescricao.ForeColor = Color.FromArgb(230, 34, 34);
            campCreateEventoDescricao.Location = new Point(131, 243);
            campCreateEventoDescricao.Multiline = true;
            campCreateEventoDescricao.Name = "campCreateEventoDescricao";
            campCreateEventoDescricao.Size = new Size(156, 50);
            campCreateEventoDescricao.TabIndex = 6;
            campCreateEventoDescricao.TextChanged += Campos_TextChanged;
            // 
            // lbCreateEventoData
            // 
            lbCreateEventoData.AutoSize = true;
            lbCreateEventoData.Font = new Font("Arial", 12.75F);
            lbCreateEventoData.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateEventoData.Location = new Point(54, 161);
            lbCreateEventoData.Name = "lbCreateEventoData";
            lbCreateEventoData.Size = new Size(44, 19);
            lbCreateEventoData.TabIndex = 9;
            lbCreateEventoData.Text = "Data";
            // 
            // lbCreateEventoLocal
            // 
            lbCreateEventoLocal.AutoSize = true;
            lbCreateEventoLocal.Font = new Font("Arial", 12.75F);
            lbCreateEventoLocal.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateEventoLocal.Location = new Point(54, 200);
            lbCreateEventoLocal.Name = "lbCreateEventoLocal";
            lbCreateEventoLocal.Size = new Size(48, 19);
            lbCreateEventoLocal.TabIndex = 10;
            lbCreateEventoLocal.Text = "Local";
            // 
            // lbCreateEventoDescricao
            // 
            lbCreateEventoDescricao.AutoSize = true;
            lbCreateEventoDescricao.Font = new Font("Arial", 12.75F);
            lbCreateEventoDescricao.ForeColor = Color.FromArgb(52, 60, 76);
            lbCreateEventoDescricao.Location = new Point(32, 243);
            lbCreateEventoDescricao.Name = "lbCreateEventoDescricao";
            lbCreateEventoDescricao.Size = new Size(78, 19);
            lbCreateEventoDescricao.TabIndex = 11;
            lbCreateEventoDescricao.Text = "Descrição";
            // 
            // CreateEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(367, 400);
            ControlBox = false;
            Controls.Add(lbCreateEventoDescricao);
            Controls.Add(lbCreateEventoLocal);
            Controls.Add(lbCreateEventoData);
            Controls.Add(campCreateEventoDescricao);
            Controls.Add(campCreateEventoLocal);
            Controls.Add(campCreateEventoData);
            Controls.Add(btCreateEventoCancelar);
            Controls.Add(btCreateEventoCriar);
            Controls.Add(lbCreateEventoTitulo);
            ForeColor = Color.FromArgb(52, 60, 76);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreateEvento";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Adicionar Evento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreateEventoTitulo;
        private Button btCreateEventoCriar;
        private Button btCreateEventoCancelar;
        private DateTimePicker campCreateEventoData;
        private TextBox campCreateEventoLocal;
        private TextBox campCreateEventoDescricao;
        private Label lbCreateEventoData;
        private Label lbCreateEventoLocal;
        private Label lbCreateEventoDescricao;
    }
}