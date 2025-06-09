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
            btHistoricoCalculadoraVoltar = new Button();
            btHistoricoCalculadoraClear = new Button();
            libHistoricoCalculadoraArm = new ListBox();
            SuspendLayout();
            // 
            // btHistoricoCalculadoraVoltar
            // 
            btHistoricoCalculadoraVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btHistoricoCalculadoraVoltar.BackColor = Color.FromArgb(230, 34, 34);
            btHistoricoCalculadoraVoltar.FlatAppearance.BorderSize = 0;
            btHistoricoCalculadoraVoltar.FlatStyle = FlatStyle.Flat;
            btHistoricoCalculadoraVoltar.Image = (Image)resources.GetObject("btHistoricoCalculadoraVoltar.Image");
            btHistoricoCalculadoraVoltar.Location = new Point(313, 11);
            btHistoricoCalculadoraVoltar.Name = "btHistoricoCalculadoraVoltar";
            btHistoricoCalculadoraVoltar.Size = new Size(60, 60);
            btHistoricoCalculadoraVoltar.TabIndex = 1;
            btHistoricoCalculadoraVoltar.UseVisualStyleBackColor = false;
            btHistoricoCalculadoraVoltar.Click += btHistoricoCalculadoraVoltar_Click;
            // 
            // btHistoricoCalculadoraClear
            // 
            btHistoricoCalculadoraClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btHistoricoCalculadoraClear.BackColor = Color.FromArgb(230, 34, 34);
            btHistoricoCalculadoraClear.FlatAppearance.BorderSize = 0;
            btHistoricoCalculadoraClear.FlatStyle = FlatStyle.Flat;
            btHistoricoCalculadoraClear.Image = (Image)resources.GetObject("btHistoricoCalculadoraClear.Image");
            btHistoricoCalculadoraClear.Location = new Point(313, 77);
            btHistoricoCalculadoraClear.Name = "btHistoricoCalculadoraClear";
            btHistoricoCalculadoraClear.Size = new Size(60, 60);
            btHistoricoCalculadoraClear.TabIndex = 2;
            btHistoricoCalculadoraClear.UseVisualStyleBackColor = false;
            btHistoricoCalculadoraClear.Click += btHistoricoCalculadoraClear_Click;
            // 
            // libHistoricoCalculadoraArm
            // 
            libHistoricoCalculadoraArm.Font = new Font("Segoe UI", 20F);
            libHistoricoCalculadoraArm.FormattingEnabled = true;
            libHistoricoCalculadoraArm.ItemHeight = 37;
            libHistoricoCalculadoraArm.Location = new Point(12, 12);
            libHistoricoCalculadoraArm.Name = "libHistoricoCalculadoraArm";
            libHistoricoCalculadoraArm.Size = new Size(295, 522);
            libHistoricoCalculadoraArm.TabIndex = 3;
            libHistoricoCalculadoraArm.DoubleClick += new System.EventHandler(this.libHistoricoCalculadoraArm_DoubleClick);
            // 
            // HistoricoCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(384, 561);
            Controls.Add(libHistoricoCalculadoraArm);
            Controls.Add(btHistoricoCalculadoraClear);
            Controls.Add(btHistoricoCalculadoraVoltar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 600);
            Name = "HistoricoCalculadora";
            Text = "HistoricoCalculadora";
            Load += HistoricoCalculadora_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btHistoricoCalculadoraVoltar;
        private Button btHistoricoCalculadoraClear;
        private ListBox libHistoricoCalculadoraArm;
    }
}