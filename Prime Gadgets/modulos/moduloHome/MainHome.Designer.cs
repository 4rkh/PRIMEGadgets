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
            label2 = new Label();
            SuspendLayout();
            // 
            // menuMainHome
            // 
            menuMainHome.BackColor = Color.FromArgb(230, 34, 34);
            menuMainHome.Dock = DockStyle.Left;
            menuMainHome.Location = new Point(0, 0);
            menuMainHome.Name = "menuMainHome";
            menuMainHome.Size = new Size(212, 1100);
            menuMainHome.TabIndex = 0;
            // 
            // lbMainHomeGreetings
            // 
            lbMainHomeGreetings.Anchor = AnchorStyles.Top;
            lbMainHomeGreetings.BackColor = Color.Transparent;
            lbMainHomeGreetings.FlatStyle = FlatStyle.Flat;
            lbMainHomeGreetings.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbMainHomeGreetings.ForeColor = Color.FromArgb(230, 34, 34);
            lbMainHomeGreetings.Location = new Point(887, 26);
            lbMainHomeGreetings.Name = "lbMainHomeGreetings";
            lbMainHomeGreetings.Size = new Size(518, 47);
            lbMainHomeGreetings.TabIndex = 1;
            lbMainHomeGreetings.Text = "Bem-vindo ao PRIME Gadgets™!";
            lbMainHomeGreetings.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 252, 237);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(521, 82);
            label2.Name = "label2";
            label2.Size = new Size(1243, 933);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainHome
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(183, 190, 191);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1940, 1100);
            Controls.Add(lbMainHomeGreetings);
            Controls.Add(menuMainHome);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 650);
            Name = "MainHome";
            Text = "telaHome";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Menu menuMainHome;
        private Label lbMainHomeGreetings;
        private Label label2;
    }
}