using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prime_Gadgets.modulos.moduloCalendario;

namespace Prime_Gadgets.modulos.moduloCalendario
{
    public partial class CreateEvento : Form
    {
        public CreateEvento()
        {
            InitializeComponent();
            btCreateEventoCancelar.CausesValidation = false; // Desabilita a validação de campos para o botão "Cancelar"
            btCreateEventoCriar.Enabled = false; // Desabilita o botão "Criar" inicialmente
            AtualizarCorBotao(); // Atualiza a cor do botão inicialmente
        }

        private void btCreateEventoCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCreateEventoCriar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            var eventoAccess = new EventoAccess();

            evento.Id = eventoAccess.LerUltimoId() + 1;
            evento.Data = campCreateEventoData.Value.Date;
            evento.Local = campCreateEventoLocal.Text;
            evento.Descricao = campCreateEventoDescricao.Text;

            eventoAccess.AdicionarEvento(evento);
            this.Dispose();
        }

        private void Campos_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            // Verifica se todos os campos estão preenchidos
            bool camposPreenchidos = campCreateEventoData.Value != null &&
                                     !string.IsNullOrWhiteSpace(campCreateEventoLocal.Text) &&
                                     !string.IsNullOrWhiteSpace(campCreateEventoDescricao.Text);

            btCreateEventoCriar.Enabled = camposPreenchidos;
            AtualizarCorBotao();
        }

        private void AtualizarCorBotao()
        {
            if (btCreateEventoCriar.Enabled)
            {
                btCreateEventoCriar.BackColor = Color.FromArgb(230, 34, 34); // Cor quando o botão está ativado
                btCreateEventoCriar.ForeColor = Color.FromArgb(255, 252, 237);
            }
            else
            {
                btCreateEventoCriar.BackColor = Color.FromArgb(52, 60, 76); // Cor quando o botão está desativado
                btCreateEventoCriar.ForeColor = Color.FromArgb(183, 190, 191);
            }
        }

        private void btCreateEventoCriar_EnabledChanged(object sender, EventArgs e)
        {
            AtualizarCorBotao();
        }
    }
}