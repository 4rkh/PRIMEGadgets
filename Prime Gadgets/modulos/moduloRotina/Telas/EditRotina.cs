using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Prime_Gadgets.modulos.moduloRotina
{
    public partial class EditRotina : Form
    {
        private readonly RotinaAccess _rotinaAccess = new RotinaAccess();
        private DateTime _dataSelecionada;
        private Atividade _atividadeSelecionada;

        public EditRotina(DateTime dataSelecionada)
        {
            InitializeComponent();
            _dataSelecionada = dataSelecionada;
            AtualizarDisplayDia();
            PreencherRotinaDisplay();
            lbEditRotinaHorarioInvalid.Hide();
            btEditRotinaSalvar.Enabled = false;
            AtualizarCorBotao();
        }

        public EditRotina() : this(DateTime.Now.Date) { }

        private void AtualizarDisplayDia()
        {
            var cultura = new CultureInfo("pt-BR");
            string diaSemana = _dataSelecionada.ToString("dddd", cultura);
            lbEditRotinaDiaSelecionado.Text = char.ToUpper(diaSemana[0]) + diaSemana.Substring(1);
        }

        private void PreencherRotinaDisplay()
        {
            panelEditRotinaSecoes.SuspendLayout();
            panelEditRotinaSecoes.Controls.Clear();
            panelEditRotinaSecoes.RowStyles.Clear();
            panelEditRotinaSecoes.RowCount = 0;
            panelEditRotinaSecoes.ColumnCount = 1;

            var atividades = _rotinaAccess.FiltrarAtividadesPorDia(_dataSelecionada.DayOfWeek);
            const float alturaLinha = 24F;

            for (int i = 0; i < atividades.Count; i++)
            {
                panelEditRotinaSecoes.RowStyles.Add(new RowStyle(SizeType.Absolute, alturaLinha));
                panelEditRotinaSecoes.RowCount = panelEditRotinaSecoes.RowStyles.Count;

                var chk = new CheckBox
                {
                    Text = $"{atividades[i].Nome} - {atividades[i].Horario:HH\\:mm}",
                    Tag = atividades[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 9),
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Margin = new Padding(0),
                    AutoSize = false
                };
                chk.CheckedChanged += CheckBoxAtividade_CheckedChanged;
                panelEditRotinaSecoes.Controls.Add(chk, 0, i);
            }
            panelEditRotinaSecoes.ResumeLayout();
        }

        private void CheckBoxAtividade_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelEditRotinaSecoes.Controls)
            {
                if (ctrl is CheckBox chk && chk != sender)
                    chk.Checked = false;
            }

            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.Checked)
            {
                _atividadeSelecionada = checkBox.Tag as Atividade;
                campEditRotinaNome.Text = _atividadeSelecionada.Nome;
                campEditRotinaHorario.Text = _atividadeSelecionada.Horario.ToString("HH\\:mm");
            }
            else
            {
                _atividadeSelecionada = null;
                campEditRotinaNome.Text = "";
                campEditRotinaHorario.Text = "";
            }
            VerificarCampos();
        }

        private void btEditRotinaSalvar_Click(object sender, EventArgs e)
        {
            if (_atividadeSelecionada == null)
                return;

            var novaAtividade = new Atividade
            {
                DiaDaSemana = _atividadeSelecionada.DiaDaSemana,
                Nome = campEditRotinaNome.Text,
                Horario = TimeOnly.Parse(campEditRotinaHorario.Text)
            };

            _rotinaAccess.UpdateAtividade(
                novaAtividade,
                _atividadeSelecionada.DiaDaSemana,
                _atividadeSelecionada.Nome,
                _atividadeSelecionada.Horario
            );

            MessageBox.Show("Atividade atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btEditRotinaDeletar_Click(object sender, EventArgs e)
        {
            if (_atividadeSelecionada == null)
            {
                MessageBox.Show("Selecione uma atividade para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Deseja realmente deletar a atividade \"{_atividadeSelecionada.Nome}\"?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _rotinaAccess.DeletarAtividade(
                    _atividadeSelecionada.DiaDaSemana,
                    _atividadeSelecionada.Nome,
                    _atividadeSelecionada.Horario
                );
                MessageBox.Show("Atividade deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _atividadeSelecionada = null;
                campEditRotinaNome.Text = "";
                campEditRotinaHorario.Text = "";
                VerificarCampos();
                PreencherRotinaDisplay();
            }
        }

        private void campEditRotinaHorario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!TimeOnly.TryParse(campEditRotinaHorario.Text, out _))
            {
                e.Cancel = true;
                lbEditRotinaHorarioInvalid.Show();
            }
            else
            {
                lbEditRotinaHorarioInvalid.Hide();
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
                !string.IsNullOrWhiteSpace(campEditRotinaNome.Text) &&
                !string.IsNullOrWhiteSpace(campEditRotinaHorario.Text) &&
                TimeOnly.TryParse(campEditRotinaHorario.Text, out _);

            btEditRotinaSalvar.Enabled = camposPreenchidos;
            AtualizarCorBotao();
        }

        private void AtualizarCorBotao()
        {
            if (btEditRotinaSalvar.Enabled)
            {
                btEditRotinaSalvar.BackColor = Color.FromArgb(230, 34, 34);
                btEditRotinaSalvar.ForeColor = Color.FromArgb(255, 252, 237);
            }
            else
            {
                btEditRotinaSalvar.BackColor = Color.FromArgb(52, 60, 76);
                btEditRotinaSalvar.ForeColor = Color.FromArgb(183, 190, 191);
            }
        }

        private void btEditRotinaSalvar_EnabledChanged(object sender, EventArgs e)
        {
            AtualizarCorBotao();
        }

        private void btEditRotinaCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        } 
    }
}
