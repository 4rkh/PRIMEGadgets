namespace Prime_Gadgets.modulos.moduloCalculadora.Telas
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
            lvHistoricoCalculadoraHistorico = new ListView();
            btHistoricoCalculadoraVoltar = new Button();
            btHistoricoCalculadoraClear = new Button();
            SuspendLayout();
            // 
            // lvHistoricoCalculadoraHistorico
            // 
            lvHistoricoCalculadoraHistorico.Location = new Point(12, 12);
            lvHistoricoCalculadoraHistorico.Name = "lvHistoricoCalculadoraHistorico";
            lvHistoricoCalculadoraHistorico.Size = new Size(635, 426);
            lvHistoricoCalculadoraHistorico.TabIndex = 0;
            lvHistoricoCalculadoraHistorico.UseCompatibleStateImageBehavior = false;
            // 
            // btHistoricoCalculadoraVoltar
            // 
            btHistoricoCalculadoraVoltar.Location = new Point(679, 12);
            btHistoricoCalculadoraVoltar.Name = "btHistoricoCalculadoraVoltar";
            btHistoricoCalculadoraVoltar.Size = new Size(95, 26);
            btHistoricoCalculadoraVoltar.TabIndex = 1;
            btHistoricoCalculadoraVoltar.Text = "Voltar";
            btHistoricoCalculadoraVoltar.UseVisualStyleBackColor = true;
            btHistoricoCalculadoraVoltar.Click += btHistoricoCalculadoraVoltar_Click;
            // 
            // btHistoricoCalculadoraClear
            // 
            btHistoricoCalculadoraClear.Location = new Point(679, 54);
            btHistoricoCalculadoraClear.Name = "btHistoricoCalculadoraClear";
            btHistoricoCalculadoraClear.Size = new Size(95, 26);
            btHistoricoCalculadoraClear.TabIndex = 2;
            btHistoricoCalculadoraClear.Text = "Limpar";
            btHistoricoCalculadoraClear.UseVisualStyleBackColor = true;
            btHistoricoCalculadoraClear.Click += btHistoricoCalculadoraClear_Click;
            // 
            // HistoricoCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btHistoricoCalculadoraClear);
            Controls.Add(btHistoricoCalculadoraVoltar);
            Controls.Add(lvHistoricoCalculadoraHistorico);
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