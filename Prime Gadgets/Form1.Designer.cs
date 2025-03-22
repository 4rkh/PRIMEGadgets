namespace Prime_Gadgets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Create = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            contatosTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)contatosTable).BeginInit();
            SuspendLayout();
            // 
            // Create
            // 
            Create.Location = new Point(23, 78);
            Create.Name = "Create";
            Create.Size = new Size(191, 37);
            Create.TabIndex = 1;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(241, 78);
            button1.Name = "button1";
            button1.Size = new Size(191, 37);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(456, 78);
            button2.Name = "button2";
            button2.Size = new Size(191, 37);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(624, 56);
            label1.TabIndex = 4;
            label1.Text = "Lista de Contatos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contatosTable
            // 
            contatosTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contatosTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            contatosTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contatosTable.Location = new Point(23, 131);
            contatosTable.MultiSelect = false;
            contatosTable.Name = "contatosTable";
            contatosTable.RowHeadersVisible = false;
            contatosTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contatosTable.Size = new Size(624, 446);
            contatosTable.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 604);
            Controls.Add(contatosTable);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Create);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)contatosTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Create;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridView contatosTable;
    }
}
