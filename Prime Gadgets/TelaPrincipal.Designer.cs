namespace Prime_Gadgets
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            panelPrime = new Panel();
            SuspendLayout();
            // 
            // panelPrime
            // 
            panelPrime.Dock = DockStyle.Fill;
            panelPrime.Location = new Point(0, 0);
            panelPrime.Name = "panelPrime";
            panelPrime.Size = new Size(1184, 611);
            panelPrime.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1184, 611);
            Controls.Add(panelPrime);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 650);
            Name = "TelaPrincipal";
            Text = "MenuPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += panelHome_Enter;
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPrime;
    }
}