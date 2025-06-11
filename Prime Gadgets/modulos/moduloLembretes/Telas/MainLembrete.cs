using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloLembretes
{
    public partial class MainLembrete : Form
    {
        private DateOnly _dataSelecionada = DateOnly.FromDateTime(DateTime.Now);

        public MainLembrete()
        {
            InitializeComponent();
            PreencherLembretes();
        }

        private void PreencherLembretes()
        {
            panelMainLembreteSecoes.SuspendLayout();
            panelMainLembreteSecoes.Controls.Clear();
            panelMainLembreteSecoes.RowStyles.Clear();
            panelMainLembreteSecoes.RowCount = 0;
            panelMainLembreteSecoes.ColumnCount = 1;

            var lembreteAccess = new LembreteAccess();
            var lembretes = lembreteAccess.LerLembretes();

            const float alturaLinha = 30F;

            for (int i = 0; i < lembretes.Count; i++)
            {
                panelMainLembreteSecoes.RowStyles.Add(new RowStyle(SizeType.Absolute, alturaLinha));
                panelMainLembreteSecoes.RowCount = panelMainLembreteSecoes.RowStyles.Count;

                var lbl = new Label
                {
                    Text = lembretes[i].Nome + " - " + lembretes[i].Dia,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10),
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Margin = new Padding(0),
                    AutoSize = false
                };
                panelMainLembreteSecoes.Controls.Add(lbl, 0, i);
            }
            panelMainLembreteSecoes.ResumeLayout();
        }

        private void btMainLembreteCreate_Click(object sender, EventArgs e)
        {
            using (var createLembrete = new CreateLembrete(_dataSelecionada))
            {
                if (createLembrete.ShowDialog(this) == DialogResult.OK)
                {
                    // Supondo que você exponha a data escolhida em CreateLembrete:
                    _dataSelecionada = createLembrete.DataSelecionada;
                }
            }
            PreencherLembretes();
        }

        private void btMainLembreteEdit_Click(object sender, EventArgs e)
        {
            using (var editLembrete = new EditLembrete(_dataSelecionada))
            {
                editLembrete.ShowDialog(this);
            }
            PreencherLembretes();
        }
    }
}
