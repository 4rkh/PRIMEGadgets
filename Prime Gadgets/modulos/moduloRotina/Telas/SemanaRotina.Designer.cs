namespace Prime_Gadgets.modulos.moduloRotina
{
    partial class SemanaRotina
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSemana;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InicializarLayoutSemana()
        {
            InitializeComponent();
            this.dataGridViewSemana = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // Configuração geral do DataGridView            
            this.dataGridViewSemana.Dock = DockStyle.Fill;
            this.dataGridViewSemana.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSemana.Name = "dataGridViewSemana";
            this.dataGridViewSemana.RowHeadersVisible = false;            
            this.dataGridViewSemana.ReadOnly = true;
            this.dataGridViewSemana.AllowUserToAddRows = false;
            this.dataGridViewSemana.AllowUserToResizeRows = false;
            this.dataGridViewSemana.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSemana.ColumnCount = 8;         

            // Configuração das colunas
            this.dataGridViewSemana.Columns[0].Name = "Horário";
            this.dataGridViewSemana.Columns[0].Width = 60;

            var cultura = new System.Globalization.CultureInfo("pt-BR");
            for (int i = 1; i < 8; i++)
            {
                var diaSemana = (DayOfWeek)((i - 1) % 7);
                var nomeDia = cultura.DateTimeFormat.GetDayName(diaSemana);
                nomeDia = char.ToUpper(nomeDia[0]) + nomeDia.Substring(1);
                this.dataGridViewSemana.Columns[i].Name = nomeDia;
            }

            // Adicionando linhas com horários
            for (int hora = 0; hora < 24; hora++)
            {
                this.dataGridViewSemana.Rows.Add($"{hora:00}:00");
            }

            // Adicionando DataGridView ao Form
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.dataGridViewSemana);
            this.Name = "SemanaRotina";
            this.Text = "Rotinas da Semana";

            this.ResumeLayout(false);
        }


        // Mantém o método padrão para compatibilidade
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemanaRotina));
            SuspendLayout();
            // 
            // SemanaRotina
            // 
            BackColor = Color.FromArgb(255, 252, 237);
            ClientSize = new Size(670, 500);
            Font = new Font("Arial", 9F);
            ForeColor = Color.FromArgb(230, 34, 34);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SemanaRotina";
            Text = "Semana";
            ResumeLayout(false);
        }

        #endregion
    }
}