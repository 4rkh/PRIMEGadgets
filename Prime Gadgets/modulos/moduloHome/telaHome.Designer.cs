namespace Prime_Gadgets.modulos.moduloHome
{
    partial class telaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaHome));
            menu1 = new Menu();
            label1 = new Label();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.BackColor = Color.FromArgb(230, 34, 34);
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(212, 518);
            menu1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(52, 60, 76);
            label1.Location = new Point(827, 64);
            label1.Name = "label1";
            label1.Size = new Size(369, 29);
            label1.TabIndex = 1;
            label1.Text = "Bem-Vindo ao PRIME Gadgets!";
            // 
            // telaHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1357, 518);
            Controls.Add(label1);
            Controls.Add(menu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telaHome";
            Text = "telaHome";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Menu menu1;
        private Label label1;
    }
}