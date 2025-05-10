using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloSenhas
{
    public partial class CreateSenhas : Form
    {
        public CreateSenhas()
        {
            InitializeComponent();
            btCreateSenhasCancelar.CausesValidation = false;
            lbCreateSenhasEmailInvalido.Hide();
            btCreateSenhasCriar.Enabled = false;
            AtualizarCorBotao();
        }

        private void btCreateSenhasCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCreateSenhasCriar_Click(object sender, EventArgs e)
        {
            Senhas senha = new Senhas();
            var senhaAccess = new SenhaAccess();

            senha.Id = senhaAccess.LerUltimoId() + 1;
            senha.NomeDeUsuario = campCreateSenhasNome.Text;
            senha.Email = campCreateSenhasEmail.Text;
            senha.Senha = campCreateSenhasSenha.Text;
            senha.Origem = campCreateSenhasOrigem.Text;

            senhaAccess.AdicionarSenha(senha);
            this.Dispose();
        }
        private void campCreateSenhasEmail_Validating(object sender, CancelEventArgs e)
        {

            // Valida o formato do e-mail
            var email = campCreateSenhasEmail.Text;
            if (!IsValidEmail(email))
            {
                e.Cancel = true;
                lbCreateSenhasEmailInvalido.Show();
            }
            VerificarCampos();
        }
        private void Campos_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }
        private void VerificarCampos()
        {
            // Verifica se todos os campos estão preenchidos e se o e-mail é válido
            bool camposPreenchidos = !string.IsNullOrWhiteSpace(campCreateSenhasNome.Text) &&
                                     !string.IsNullOrWhiteSpace(campCreateSenhasEmail.Text) &&
                                     !string.IsNullOrWhiteSpace(campCreateSenhasSenha.Text) &&
                                     !string.IsNullOrWhiteSpace(campCreateSenhasOrigem.Text) &&
                                     IsValidEmail(campCreateSenhasEmail.Text);

            btCreateSenhasCriar.Enabled = camposPreenchidos;
            AtualizarCorBotao();
        }

        private void AtualizarCorBotao()
        {
            if (btCreateSenhasCriar.Enabled)
            {
                btCreateSenhasCriar.BackColor = Color.Green; // Cor quando o botão está ativado
            }
            else
            {
                btCreateSenhasCriar.BackColor = Color.Red; // Cor quando o botão está desativado
            }
        }
        private void btCreateSenhasCriar_EnabledChanged(object sender, EventArgs e)
        {
            AtualizarCorBotao();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                lbCreateSenhasEmailInvalido.Hide();
                return addr.Address == email;
            }
            catch
            {
                lbCreateSenhasEmailInvalido.Show();
                return false;
            }
        }
    }
}
