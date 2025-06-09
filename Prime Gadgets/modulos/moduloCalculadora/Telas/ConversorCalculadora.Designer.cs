namespace Prime_Gadgets.modulos.moduloCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorCalculadora));
            campConversorCalculadoraNumero2 = new TextBox();
            cbConversorCalculadoraUnidade2 = new ComboBox();
            lbConversorCalculadoraEqual = new Label();
            campConversorCalculadoraNumero1 = new TextBox();
            cbConversorCalculadoraUnidade1 = new ComboBox();
            cbConversorCalculadoraTipo = new ComboBox();
            btConversorCalculadoraCancelar = new Button();
            btConversorCalculadoraConverter = new Button();
            btConversorCalculadoraInverter = new Button();
            SuspendLayout();
            // 
            // campConversorCalculadoraNumero2
            // 
            campConversorCalculadoraNumero2.Anchor = AnchorStyles.None;
            campConversorCalculadoraNumero2.BackColor = Color.FromArgb(255, 252, 237);
            campConversorCalculadoraNumero2.Font = new Font("Arial", 9F);
            campConversorCalculadoraNumero2.Location = new Point(353, 69);
            campConversorCalculadoraNumero2.Name = "campConversorCalculadoraNumero2";
            campConversorCalculadoraNumero2.Size = new Size(100, 21);
            campConversorCalculadoraNumero2.TabIndex = 9;
            // 
            // cbConversorCalculadoraUnidade2
            // 
            cbConversorCalculadoraUnidade2.Anchor = AnchorStyles.None;
            cbConversorCalculadoraUnidade2.BackColor = Color.FromArgb(255, 252, 237);
            cbConversorCalculadoraUnidade2.FormattingEnabled = true;
            cbConversorCalculadoraUnidade2.Location = new Point(459, 68);
            cbConversorCalculadoraUnidade2.Name = "cbConversorCalculadoraUnidade2";
            cbConversorCalculadoraUnidade2.Size = new Size(121, 23);
            cbConversorCalculadoraUnidade2.TabIndex = 8;
            // 
            // lbConversorCalculadoraEqual
            // 
            lbConversorCalculadoraEqual.Anchor = AnchorStyles.None;
            lbConversorCalculadoraEqual.AutoSize = true;
            lbConversorCalculadoraEqual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbConversorCalculadoraEqual.ForeColor = Color.FromArgb(52, 60, 76);
            lbConversorCalculadoraEqual.Location = new Point(317, 68);
            lbConversorCalculadoraEqual.Name = "lbConversorCalculadoraEqual";
            lbConversorCalculadoraEqual.Size = new Size(18, 19);
            lbConversorCalculadoraEqual.TabIndex = 7;
            lbConversorCalculadoraEqual.Text = "=";
            // 
            // campConversorCalculadoraNumero1
            // 
            campConversorCalculadoraNumero1.Anchor = AnchorStyles.None;
            campConversorCalculadoraNumero1.BackColor = Color.FromArgb(255, 252, 237);
            campConversorCalculadoraNumero1.Font = new Font("Arial", 9F);
            campConversorCalculadoraNumero1.Location = new Point(69, 68);
            campConversorCalculadoraNumero1.Name = "campConversorCalculadoraNumero1";
            campConversorCalculadoraNumero1.Size = new Size(100, 21);
            campConversorCalculadoraNumero1.TabIndex = 6;
            // 
            // cbConversorCalculadoraUnidade1
            // 
            cbConversorCalculadoraUnidade1.Anchor = AnchorStyles.None;
            cbConversorCalculadoraUnidade1.BackColor = Color.FromArgb(255, 252, 237);
            cbConversorCalculadoraUnidade1.FormattingEnabled = true;
            cbConversorCalculadoraUnidade1.Location = new Point(175, 68);
            cbConversorCalculadoraUnidade1.Name = "cbConversorCalculadoraUnidade1";
            cbConversorCalculadoraUnidade1.Size = new Size(121, 23);
            cbConversorCalculadoraUnidade1.TabIndex = 5;
            // 
            // cbConversorCalculadoraTipo
            // 
            cbConversorCalculadoraTipo.Anchor = AnchorStyles.None;
            cbConversorCalculadoraTipo.BackColor = Color.FromArgb(255, 252, 237);
            cbConversorCalculadoraTipo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbConversorCalculadoraTipo.FormattingEnabled = true;
            cbConversorCalculadoraTipo.Location = new Point(49, 30);
            cbConversorCalculadoraTipo.Name = "cbConversorCalculadoraTipo";
            cbConversorCalculadoraTipo.Size = new Size(555, 23);
            cbConversorCalculadoraTipo.TabIndex = 11;
            cbConversorCalculadoraTipo.SelectedIndexChanged += cbConversorCalculadoraTipo_SelectedIndexChanged;
            // 
            // btConversorCalculadoraCancelar
            // 
            btConversorCalculadoraCancelar.Anchor = AnchorStyles.Bottom;
            btConversorCalculadoraCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btConversorCalculadoraCancelar.FlatAppearance.BorderSize = 0;
            btConversorCalculadoraCancelar.FlatStyle = FlatStyle.Flat;
            btConversorCalculadoraCancelar.Image = (Image)resources.GetObject("btConversorCalculadoraCancelar.Image");
            btConversorCalculadoraCancelar.Location = new Point(204, 112);
            btConversorCalculadoraCancelar.Name = "btConversorCalculadoraCancelar";
            btConversorCalculadoraCancelar.Size = new Size(60, 45);
            btConversorCalculadoraCancelar.TabIndex = 12;
            btConversorCalculadoraCancelar.UseVisualStyleBackColor = false;
            btConversorCalculadoraCancelar.Click += btConversorCalculadoraCancelar_Click;
            // 
            // btConversorCalculadoraConverter
            // 
            btConversorCalculadoraConverter.Anchor = AnchorStyles.Bottom;
            btConversorCalculadoraConverter.BackColor = Color.FromArgb(230, 34, 34);
            btConversorCalculadoraConverter.FlatAppearance.BorderSize = 0;
            btConversorCalculadoraConverter.FlatStyle = FlatStyle.Flat;
            btConversorCalculadoraConverter.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConversorCalculadoraConverter.ForeColor = Color.FromArgb(255, 252, 237);
            btConversorCalculadoraConverter.Location = new Point(292, 112);
            btConversorCalculadoraConverter.Name = "btConversorCalculadoraConverter";
            btConversorCalculadoraConverter.Size = new Size(100, 45);
            btConversorCalculadoraConverter.TabIndex = 13;
            btConversorCalculadoraConverter.Text = "Converter";
            btConversorCalculadoraConverter.UseVisualStyleBackColor = false;
            btConversorCalculadoraConverter.Click += btConversorCalculadoraConverter_Click;
            // 
            // btConversorCalculadoraInverter
            // 
            btConversorCalculadoraInverter.Anchor = AnchorStyles.Bottom;
            btConversorCalculadoraInverter.BackColor = Color.FromArgb(230, 34, 34);
            btConversorCalculadoraInverter.FlatAppearance.BorderSize = 0;
            btConversorCalculadoraInverter.FlatStyle = FlatStyle.Flat;
            btConversorCalculadoraInverter.Image = (Image)resources.GetObject("btConversorCalculadoraInverter.Image");
            btConversorCalculadoraInverter.Location = new Point(413, 112);
            btConversorCalculadoraInverter.Name = "btConversorCalculadoraInverter";
            btConversorCalculadoraInverter.Size = new Size(60, 45);
            btConversorCalculadoraInverter.TabIndex = 14;
            btConversorCalculadoraInverter.UseVisualStyleBackColor = false;
            // 
            // ConversorCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(649, 193);
            Controls.Add(btConversorCalculadoraInverter);
            Controls.Add(btConversorCalculadoraConverter);
            Controls.Add(btConversorCalculadoraCancelar);
            Controls.Add(cbConversorCalculadoraTipo);
            Controls.Add(campConversorCalculadoraNumero2);
            Controls.Add(cbConversorCalculadoraUnidade2);
            Controls.Add(lbConversorCalculadoraEqual);
            Controls.Add(campConversorCalculadoraNumero1);
            Controls.Add(cbConversorCalculadoraUnidade1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
        private Button btConversorCalculadoraInverter;
    }
}