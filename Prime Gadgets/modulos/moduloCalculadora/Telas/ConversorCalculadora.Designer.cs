namespace Prime_Gadgets.modulos.moduloCalculadora.Telas
{
    partial class ConversorCalculadora
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
            campConversorCalculadoraNumero2 = new TextBox();
            cbConversorCalculadoraUnidade2 = new ComboBox();
            lbConversorCalculadoraEqual = new Label();
            campConversorCalculadoraNumero1 = new TextBox();
            cbConversorCalculadoraUnidade1 = new ComboBox();
            cbConversorCalculadoraTipo = new ComboBox();
            btConversorCalculadoraCancelar = new Button();
            btConversorCalculadoraConverter = new Button();
            SuspendLayout();
            // 
            // campConversorCalculadoraNumero2
            // 
            campConversorCalculadoraNumero2.Location = new Point(348, 68);
            campConversorCalculadoraNumero2.Name = "campConversorCalculadoraNumero2";
            campConversorCalculadoraNumero2.Size = new Size(100, 23);
            campConversorCalculadoraNumero2.TabIndex = 9;
            // 
            // cbConversorCalculadoraUnidade2
            // 
            cbConversorCalculadoraUnidade2.FormattingEnabled = true;
            cbConversorCalculadoraUnidade2.Location = new Point(454, 68);
            cbConversorCalculadoraUnidade2.Name = "cbConversorCalculadoraUnidade2";
            cbConversorCalculadoraUnidade2.Size = new Size(121, 23);
            cbConversorCalculadoraUnidade2.TabIndex = 8;
            // 
            // lbConversorCalculadoraEqual
            // 
            lbConversorCalculadoraEqual.AutoSize = true;
            lbConversorCalculadoraEqual.Location = new Point(309, 71);
            lbConversorCalculadoraEqual.Name = "lbConversorCalculadoraEqual";
            lbConversorCalculadoraEqual.Size = new Size(15, 15);
            lbConversorCalculadoraEqual.TabIndex = 7;
            lbConversorCalculadoraEqual.Text = "=";
            // 
            // campConversorCalculadoraNumero1
            // 
            campConversorCalculadoraNumero1.Location = new Point(64, 68);
            campConversorCalculadoraNumero1.Name = "campConversorCalculadoraNumero1";
            campConversorCalculadoraNumero1.Size = new Size(100, 23);
            campConversorCalculadoraNumero1.TabIndex = 6;
            // 
            // cbConversorCalculadoraUnidade1
            // 
            cbConversorCalculadoraUnidade1.FormattingEnabled = true;
            cbConversorCalculadoraUnidade1.Location = new Point(170, 68);
            cbConversorCalculadoraUnidade1.Name = "cbConversorCalculadoraUnidade1";
            cbConversorCalculadoraUnidade1.Size = new Size(121, 23);
            cbConversorCalculadoraUnidade1.TabIndex = 5;
            // 
            // cbConversorCalculadoraTipo
            // 
            cbConversorCalculadoraTipo.FormattingEnabled = true;
            cbConversorCalculadoraTipo.Location = new Point(49, 30);
            cbConversorCalculadoraTipo.Name = "cbConversorCalculadoraTipo";
            cbConversorCalculadoraTipo.Size = new Size(555, 23);
            cbConversorCalculadoraTipo.TabIndex = 11;
            // 
            // btConversorCalculadoraCancelar
            // 
            btConversorCalculadoraCancelar.Location = new Point(216, 112);
            btConversorCalculadoraCancelar.Name = "btConversorCalculadoraCancelar";
            btConversorCalculadoraCancelar.Size = new Size(75, 23);
            btConversorCalculadoraCancelar.TabIndex = 12;
            btConversorCalculadoraCancelar.Text = "Cancelar";
            btConversorCalculadoraCancelar.UseVisualStyleBackColor = true;
            btConversorCalculadoraCancelar.Click += btConversorCalculadoraCancelar_Click;
            // 
            // btConversorCalculadoraConverter
            // 
            btConversorCalculadoraConverter.Location = new Point(348, 112);
            btConversorCalculadoraConverter.Name = "btConversorCalculadoraConverter";
            btConversorCalculadoraConverter.Size = new Size(75, 23);
            btConversorCalculadoraConverter.TabIndex = 13;
            btConversorCalculadoraConverter.Text = "Converter";
            btConversorCalculadoraConverter.UseVisualStyleBackColor = true;
            btConversorCalculadoraConverter.Click += btConversorCalculadoraConverter_Click;
            // 
            // ConversorCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(649, 147);
            Controls.Add(btConversorCalculadoraConverter);
            Controls.Add(btConversorCalculadoraCancelar);
            Controls.Add(cbConversorCalculadoraTipo);
            Controls.Add(campConversorCalculadoraNumero2);
            Controls.Add(cbConversorCalculadoraUnidade2);
            Controls.Add(lbConversorCalculadoraEqual);
            Controls.Add(campConversorCalculadoraNumero1);
            Controls.Add(cbConversorCalculadoraUnidade1);
            Name = "ConversorCalculadora";
            Text = "ConversorCalculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campConversorCalculadoraNumero2;
        private ComboBox cbConversorCalculadoraUnidade2;
        private Label lbConversorCalculadoraEqual;
        private TextBox campConversorCalculadoraNumero1;
        private ComboBox cbConversorCalculadoraUnidade1;
        private Label label2;
        private ComboBox cbConversorCalculadoraTipo;
        private Button btConversorCalculadoraCancelar;
        private Button btConversorCalculadoraConverter;
    }
}