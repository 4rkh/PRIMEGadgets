using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Prime_Gadgets.modulos.moduloRotina;

namespace Prime_Gadgets.modulos.moduloRotina
{
    public partial class SemanaRotina : Form
    {
        private DataGridView dataGridViewSemana;

        public SemanaRotina()
        {
            InitializeComponent();
            InicializarLayoutSemana();
            PreencherSemana();
        }      

        private void PreencherSemana()
        {
            var rotinaAccess = new RotinaAccess();
            var todasAtividades = rotinaAccess.LerAtividades();

            foreach (var atividade in todasAtividades)
            {
                int col = ((int)atividade.DiaDaSemana) + 1; // Dias: 1 a 7
                int row = atividade.Horario.Hour;           // Horas: 0 a 23

                dataGridViewSemana.Rows[row].Cells[col].Value = atividade.Nome;
            }
        }
    }
}