namespace Prime_Gadgets.modulos.moduloHome
{
    partial class MainHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHome));
            menuMainHome = new Menu();
            lbMainHomeGreetings = new Label();
            SuspendLayout();
            // 
            // menuMainHome
            // 
            menuMainHome.BackColor = Color.FromArgb(230, 34, 34);
            menuMainHome.Dock = DockStyle.Left;
            menuMainHome.Location = new Point(0, 0);
            menuMainHome.Name = "menuMainHome";
            menuMainHome.Size = new Size(212, 518);
            menuMainHome.TabIndex = 0;
            // 
            // lbMainHomeGreetings
            // 
            lbMainHomeGreetings.AutoSize = true;
            lbMainHomeGreetings.Font = new Font("Arial", 18F, FontStyle.Bold);
            lbMainHomeGreetings.ForeColor = Color.FromArgb(52, 60, 76);
            lbMainHomeGreetings.Location = new Point(827, 64);
            lbMainHomeGreetings.Name = "lbMainHomeGreetings";
            lbMainHomeGreetings.Size = new Size(369, 29);
            lbMainHomeGreetings.TabIndex = 1;
            lbMainHomeGreetings.Text = "Bem-Vindo ao PRIME Gadgets!";
            // 
            // MainHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(1357, 518);
            Controls.Add(lbMainHomeGreetings);
            Controls.Add(menuMainHome);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainHome";
            Text = "telaHome";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Menu menuMainHome;
        private Label lbMainHomeGreetings;
    }
}