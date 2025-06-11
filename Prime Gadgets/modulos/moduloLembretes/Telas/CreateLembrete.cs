using System;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloLembretes
{
    public partial class CreateLembrete : Form
    {
        private readonly LembreteAccess lembreteAccess = new LembreteAccess();

        public CreateLembrete(DateOnly diaSelecionado)
        {
            InitializeComponent();
            dtpCreateLembreteDia.Value = diaSelecionado.ToDateTime(TimeOnly.MinValue); // Sugerir data inicial
            btCreateLembreteCriar.Enabled = false;
            AtualizarCorBotao();
        }

        public DateOnly DataSelecionada => DateOnly.FromDateTime(dtpCreateLembreteDia.Value.Date);

        private void btCreateLembreteCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCreateLembreteCriar_Click(object sender, EventArgs e)
        {
            var lembrete = new Lembrete
            {
                Dia = DateOnly.FromDateTime(dtpCreateLembreteDia.Value.Date),
                Nome = campCreateLembreteNome.Text
            };

            lembreteAccess.AdicionarLembrete(lembrete);
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void campCreateLembreteNome_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            bool camposPreenchidos = !string.IsNullOrWhiteSpace(campCreateLembreteNome.Text);
            btCreateLembreteCriar.Enabled = camposPreenchidos;
            AtualizarCorBotao();
        }

        private void AtualizarCorBotao()
        {
            if (btCreateLembreteCriar.Enabled)
            {
                btCreateLembreteCriar.BackColor = System.Drawing.Color.FromArgb(230, 34, 34);
                btCreateLembreteCriar.ForeColor = System.Drawing.Color.FromArgb(255, 252, 237);
            }
            else
            {
                btCreateLembreteCriar.BackColor = System.Drawing.Color.FromArgb(52, 60, 76);
                btCreateLembreteCriar.ForeColor = System.Drawing.Color.FromArgb(183, 190, 191);
            }
        }
    }
}
