namespace Prime_Gadgets.modulos.moduloSenhas.Telas
{
    partial class CreateSenhas
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
            lbCreateSenhasTitulo = new Label();
            SuspendLayout();
            // 
            // lbCreateSenhasTitulo
            // 
            lbCreateSenhasTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCreateSenhasTitulo.AutoSize = true;
            lbCreateSenhasTitulo.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCreateSenhasTitulo.Location = new Point(81, 33);
            lbCreateSenhasTitulo.Name = "lbCreateSenhasTitulo";
            lbCreateSenhasTitulo.Size = new Size(207, 37);
            lbCreateSenhasTitulo.TabIndex = 0;
            lbCreateSenhasTitulo.Text = "Adicionar Conta";
            // 
            // CreateSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 450);
            Controls.Add(lbCreateSenhasTitulo);
            Name = "CreateSenhas";
            Text = "CreateSenhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreateSenhasTitulo;
    }
}