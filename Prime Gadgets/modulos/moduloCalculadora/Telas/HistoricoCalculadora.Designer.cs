namespace Prime_Gadgets.modulos.moduloCalculadora
{
    partial class HistoricoCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoCalculadora));
            lvHistoricoCalculadoraHistorico = new ListView();
            btHistoricoCalculadoraVoltar = new Button();
            btHistoricoCalculadoraClear = new Button();
            SuspendLayout();
            // 
            // lvHistoricoCalculadoraHistorico
            // 
            lvHistoricoCalculadoraHistorico.BackColor = Color.FromArgb(255, 252, 237);
            lvHistoricoCalculadoraHistorico.Location = new Point(12, 12);
            lvHistoricoCalculadoraHistorico.Name = "lvHistoricoCalculadoraHistorico";
            lvHistoricoCalculadoraHistorico.Size = new Size(635, 426);
            lvHistoricoCalculadoraHistorico.TabIndex = 0;
            lvHistoricoCalculadoraHistorico.UseCompatibleStateImageBehavior = false;
            // 
            // btHistoricoCalculadoraVoltar
            // 
            btHistoricoCalculadoraVoltar.BackColor = Color.FromArgb(230, 34, 34);
            btHistoricoCalculadoraVoltar.FlatAppearance.BorderSize = 0;
            btHistoricoCalculadoraVoltar.FlatStyle = FlatStyle.Flat;
            btHistoricoCalculadoraVoltar.Image = (Image)resources.GetObject("btHistoricoCalculadoraVoltar.Image");
            btHistoricoCalculadoraVoltar.Location = new Point(653, 11);
            btHistoricoCalculadoraVoltar.Name = "btHistoricoCalculadoraVoltar";
            btHistoricoCalculadoraVoltar.Size = new Size(60, 60);
            btHistoricoCalculadoraVoltar.TabIndex = 1;
            btHistoricoCalculadoraVoltar.UseVisualStyleBackColor = false;
            btHistoricoCalculadoraVoltar.Click += btHistoricoCalculadoraVoltar_Click;
            // 
            // btHistoricoCalculadoraClear
            // 
            btHistoricoCalculadoraClear.BackColor = Color.FromArgb(230, 34, 34);
            btHistoricoCalculadoraClear.FlatAppearance.BorderSize = 0;
            btHistoricoCalculadoraClear.FlatStyle = FlatStyle.Flat;
            btHistoricoCalculadoraClear.Image = (Image)resources.GetObject("btHistoricoCalculadoraClear.Image");
            btHistoricoCalculadoraClear.Location = new Point(653, 77);
            btHistoricoCalculadoraClear.Name = "btHistoricoCalculadoraClear";
            btHistoricoCalculadoraClear.Size = new Size(60, 60);
            btHistoricoCalculadoraClear.TabIndex = 2;
            btHistoricoCalculadoraClear.UseVisualStyleBackColor = false;
            btHistoricoCalculadoraClear.Click += btHistoricoCalculadoraClear_Click;
            // 
            // HistoricoCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(724, 450);
            Controls.Add(btHistoricoCalculadoraClear);
            Controls.Add(btHistoricoCalculadoraVoltar);
            Controls.Add(lvHistoricoCalculadoraHistorico);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HistoricoCalculadora";
            Text = "HistoricoCalculadora";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvHistoricoCalculadoraHistorico;
        private Button btHistoricoCalculadoraVoltar;
        private Button btHistoricoCalculadoraClear;
    }
}