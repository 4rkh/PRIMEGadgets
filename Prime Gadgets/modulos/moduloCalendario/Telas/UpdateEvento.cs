using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloCalendario
{
    public partial class UpdateEvento : Form
    {
        public Evento UpdatedEvento { get; private set; }

        public UpdateEvento(Evento evento)
        {
            InitializeComponent();
            btUpdateEventoCancelar.CausesValidation = false;
            UpdatedEvento = evento;
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            campUpdateEventoId.Text = UpdatedEvento.Id.ToString();
            campUpdateEventoData.Value = UpdatedEvento.Data;
            campUpdateEventoLocal.Text = UpdatedEvento.Local;
            campUpdateEventoDescricao.Text = UpdatedEvento.Descricao;
        }

        private void btUpdateEventoCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Campos_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            bool camposValidos =
                !string.IsNullOrWhiteSpace(campUpdateEventoLocal.Text) &&
                !string.IsNullOrWhiteSpace(campUpdateEventoDescricao.Text);

            btUpdateEventoAtualizar.Enabled = camposValidos;
            btUpdateEventoAtualizar.BackColor = camposValidos ? Color.FromArgb(230, 34, 34) : Color.FromArgb(52, 60, 76);
        }

        private void btUpdateEventoAtualizar_Click(object sender, EventArgs e)
        {
            string mensagem = $"Deseja atualizar o evento?\n" +
                              $"Id: {UpdatedEvento.Id} -> {campUpdateEventoId.Text}\n" +
                              $"Data: {UpdatedEvento.Data:dd/MM/yyyy} -> {campUpdateEventoData.Value:dd/MM/yyyy}\n" +
                              $"Local: {UpdatedEvento.Local} -> {campUpdateEventoLocal.Text}\n" +
                              $"Descrição: {UpdatedEvento.Descricao} -> {campUpdateEventoDescricao.Text}";

            DialogResult resultado = MessageBox.Show(mensagem, "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                EventoAccess eventoAccess = new EventoAccess();
                int oldId = UpdatedEvento.Id;
                Evento evento = new Evento
                {
                    Id = int.Parse(campUpdateEventoId.Text),
                    Data = campUpdateEventoData.Value.Date,
                    Local = campUpdateEventoLocal.Text,
                    Descricao = campUpdateEventoDescricao.Text
                };
                eventoAccess.UpdateEvento(evento, oldId);
                MessageBox.Show("Evento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void btUpdateEventoDeletar_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Deseja realmente deletar este evento?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                EventoAccess eventoAccess = new EventoAccess();
                eventoAccess.DeleteEvento(UpdatedEvento.Id);
                MessageBox.Show("Evento deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
