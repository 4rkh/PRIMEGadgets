using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloRotina
{
    public partial class MainRotina : Form
    {
        private DateTime _dataSelecionada = DateTime.Now.Date;

        public MainRotina()
        {
            InitializeComponent();
            AtualizarData();
            PreencherRotina();
        }

        private void AtualizarData()
        {
            var cultura = new System.Globalization.CultureInfo("pt-BR");
            string diaSemana = _dataSelecionada.ToString("dddd", cultura);
            string dataFormatada = _dataSelecionada.ToString("dd/MM/yyyy");
            lbMainRotinaData.Text = $"{char.ToUpper(diaSemana[0]) + diaSemana.Substring(1)}, {dataFormatada}";
        }

        private void PreencherRotina()
        {
            panelMainRotinaSecoes.SuspendLayout();
            panelMainRotinaSecoes.Controls.Clear();
            panelMainRotinaSecoes.RowStyles.Clear();
            panelMainRotinaSecoes.RowCount = 0;
            panelMainRotinaSecoes.ColumnCount = 1;

            var rotinaAccess = new RotinaAccess();
            var atividades = rotinaAccess.FiltrarAtividadesPorDia(_dataSelecionada.DayOfWeek);

            const float alturaLinha = 30F;

            for (int i = 0; i < atividades.Count; i++)
            {
                panelMainRotinaSecoes.RowStyles.Add(new RowStyle(SizeType.Absolute, alturaLinha));
                panelMainRotinaSecoes.RowCount = panelMainRotinaSecoes.RowStyles.Count;

                var lbl = new Label
                {
                    Text = $"{atividades[i].Nome} - {atividades[i].Horario:HH\\:mm}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10),
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Margin = new Padding(0),
                    AutoSize = false
                };
                panelMainRotinaSecoes.Controls.Add(lbl, 0, i);
            }
            panelMainRotinaSecoes.ResumeLayout();
        }

        private void btMainRotinaBack_Click(object sender, EventArgs e)
        {
            _dataSelecionada = _dataSelecionada.AddDays(-1);
            AtualizarData();
            PreencherRotina();
        }

        private void btMainRotinaNext_Click(object sender, EventArgs e)
        {
            _dataSelecionada = _dataSelecionada.AddDays(1);
            AtualizarData();
            PreencherRotina();
        }

        private void btMainRotinaCreate_Click(object sender, EventArgs e)
        {
            using (var createRotina = new CreateRotina(_dataSelecionada.DayOfWeek))
            {
                createRotina.ShowDialog(this);
            }
            PreencherRotina();
        }

        private void btMainRotinaUpdate_Click(object sender, EventArgs e)
        {
            using (var editRotina = new EditRotina(_dataSelecionada))
            {
                editRotina.ShowDialog(this);
            }
            PreencherRotina();
        }

        private void btMainRotinaSemana_Click(object sender, EventArgs e)
        {
            using (var semanaRotina = new SemanaRotina())
            {
                semanaRotina.ShowDialog(this);
            }
        }        
    }
}
