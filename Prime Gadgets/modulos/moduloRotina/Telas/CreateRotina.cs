using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloRotina
{
    public partial class CreateRotina : Form
    {
        private readonly DayOfWeek _diaSelecionado;
        private readonly RotinaAccess _rotinaAccess = new RotinaAccess();

        public CreateRotina(DayOfWeek diaSelecionado)
        {
            InitializeComponent();
            _diaSelecionado = diaSelecionado;

            // Exibe apenas o dia da semana em português, sem a data
            var cultura = new System.Globalization.CultureInfo("pt-BR");
            string diaSemana = cultura.DateTimeFormat.GetDayName(_diaSelecionado);
            diaSemana = char.ToUpper(diaSemana[0]) + diaSemana.Substring(1);
            lbCreateRotinaDiaSelecionado.Text = diaSemana;

            lbCreateRotinaHorarioInvalid.Hide();
            btCreateRotinaCriar.Enabled = false;
            AtualizarCorBotao();
        }

        private void btCreateRotinaCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCreateRotinaCriar_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Atividade atividade = new Atividade
                {
                    DiaDaSemana = _diaSelecionado,
                    Nome = campCreateRotinaNome.Text,
                    Horario = TimeOnly.Parse(campCreateRotinaHorario.Text)
                };

                _rotinaAccess.AdicionarAtividade(atividade);

                var result = MessageBox.Show(
                    "Atividade adicionada com sucesso!\nDeseja adicionar outra atividade para este dia?",
                    "Adicionar Outra?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    campCreateRotinaNome.Text = "";
                    campCreateRotinaHorario.Text = "";
                    btCreateRotinaCriar.Enabled = false;
                    AtualizarCorBotao();
                    campCreateRotinaNome.Focus();
                    break; // Sai do loop para permitir novo preenchimento pelo usuário
                }
                else
                {
                    this.Dispose();
                    break;
                }
            }
        }

        private void campCreateRotinaHorario_Validating(object sender, CancelEventArgs e)
        {
            if (!TimeOnly.TryParse(campCreateRotinaHorario.Text, out _))
            {
                e.Cancel = true;
                lbCreateRotinaHorarioInvalid.Show();
            }
            else
            {
                lbCreateRotinaHorarioInvalid.Hide();
            }
            VerificarCampos();
        }

        private void Campos_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            bool camposPreenchidos =
                !string.IsNullOrWhiteSpace(campCreateRotinaNome.Text) &&
                !string.IsNullOrWhiteSpace(campCreateRotinaHorario.Text) &&
                TimeOnly.TryParse(campCreateRotinaHorario.Text, out _);

            btCreateRotinaCriar.Enabled = camposPreenchidos;
            AtualizarCorBotao();
        }

        private void AtualizarCorBotao()
        {
            if (btCreateRotinaCriar.Enabled)
            {
                btCreateRotinaCriar.BackColor = Color.FromArgb(230, 34, 34);
                btCreateRotinaCriar.ForeColor = Color.FromArgb(255, 252, 237);
            }
            else
            {
                btCreateRotinaCriar.BackColor = Color.FromArgb(52, 60, 76);
                btCreateRotinaCriar.ForeColor = Color.FromArgb(183, 190, 191);
            }
        }

        private void btCreateRotinaCriar_EnabledChanged(object sender, EventArgs e)
        {
            AtualizarCorBotao();
        }
    }
}
