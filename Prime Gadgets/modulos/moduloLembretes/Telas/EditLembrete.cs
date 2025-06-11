using System;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloLembretes
{
    public partial class EditLembrete : Form
    {
        private readonly LembreteAccess _lembreteAccess = new LembreteAccess();
        private DateOnly _dataSelecionada;
        private Lembrete _lembreteSelecionado;

        public EditLembrete(DateOnly dataSelecionada)
        {
            InitializeComponent();
            _dataSelecionada = dataSelecionada;
            lbEditLembreteDiaSelecionado.Text = _dataSelecionada.ToString("dd/MM/yyyy");
            PreencherLembretesDisplay();
            btEditLembreteSalvar.Enabled = false;
            AtualizarCorBotao();
        }

        private void PreencherLembretesDisplay()
        {
            panelEditLembreteSecoes.SuspendLayout();
            panelEditLembreteSecoes.Controls.Clear();
            panelEditLembreteSecoes.RowStyles.Clear();
            panelEditLembreteSecoes.RowCount = 0;
            panelEditLembreteSecoes.ColumnCount = 1;

            var lembretes = _lembreteAccess.LerLembretes();
            const float alturaLinha = 24F;

            for (int i = 0; i < lembretes.Count; i++)
            {
                panelEditLembreteSecoes.RowStyles.Add(new RowStyle(SizeType.Absolute, alturaLinha));
                panelEditLembreteSecoes.RowCount = panelEditLembreteSecoes.RowStyles.Count;

                var chk = new CheckBox
                {
                    Text = lembretes[i].Nome,
                    Tag = lembretes[i],
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("Segoe UI", 9),
                    BackColor = System.Drawing.Color.White,
                    ForeColor = System.Drawing.Color.Black,
                    Margin = new Padding(0),
                    AutoSize = false
                };
                chk.CheckedChanged += CheckBoxLembrete_CheckedChanged;
                panelEditLembreteSecoes.Controls.Add(chk, 0, i);
            }
            panelEditLembreteSecoes.ResumeLayout();
        }

        private void CheckBoxLembrete_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelEditLembreteSecoes.Controls)
            {
                if (ctrl is CheckBox chk && chk != sender)
                    chk.Checked = false;
            }

            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.Checked)
            {
                _lembreteSelecionado = checkBox.Tag as Lembrete;
                campEditLembreteNome.Text = _lembreteSelecionado.Nome;
            }
            else
            {
                _lembreteSelecionado = null;
                campEditLembreteNome.Text = "";
            }
            VerificarCampos();
        }

        private void btEditLembreteSalvar_Click(object sender, EventArgs e)
        {
            if (_lembreteSelecionado == null)
                return;

            var novoLembrete = new Lembrete
            {
                Dia = _lembreteSelecionado.Dia,
                Nome = campEditLembreteNome.Text
            };

            _lembreteAccess.UpdateLembrete(
                novoLembrete,
                _lembreteSelecionado.Dia,
                _lembreteSelecionado.Nome
            );

            MessageBox.Show("Lembrete atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btEditLembreteDeletar_Click(object sender, EventArgs e)
        {
            if (_lembreteSelecionado == null)
            {
                MessageBox.Show("Selecione um lembrete para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Deseja realmente deletar o lembrete \"{_lembreteSelecionado.Nome}\"?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _lembreteAccess.DeletarLembrete(
                    _lembreteSelecionado.Dia,
                    _lembreteSelecionado.Nome
                );
                MessageBox.Show("Lembrete deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _lembreteSelecionado = null;
                campEditLembreteNome.Text = "";
                VerificarCampos();
                PreencherLembretesDisplay();
            }
        }

        private void campEditLembreteNome_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            bool camposPreenchidos = !string.IsNullOrWhiteSpace(campEditLembreteNome.Text);
            btEditLembreteSalvar.Enabled = camposPreenchidos;
            AtualizarCorBotao();
        }

        private void AtualizarCorBotao()
        {
            if (btEditLembreteSalvar.Enabled)
            {
                btEditLembreteSalvar.BackColor = System.Drawing.Color.FromArgb(230, 34, 34);
                btEditLembreteSalvar.ForeColor = System.Drawing.Color.FromArgb(255, 252, 237);
            }
            else
            {
                btEditLembreteSalvar.BackColor = System.Drawing.Color.FromArgb(52, 60, 76);
                btEditLembreteSalvar.ForeColor = System.Drawing.Color.FromArgb(183, 190, 191);
            }
        }

        private void btEditLembreteCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
