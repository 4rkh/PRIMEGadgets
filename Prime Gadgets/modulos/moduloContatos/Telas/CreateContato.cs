
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloContatos
{
    public partial class CreateContato : Form
    {
        public CreateContato()
        {
            InitializeComponent();
            btCreateContatosCancelar.CausesValidation = false; // Desabilita a validação de campos para o botão "Cancelar"
            lbCreateContatoEmailInvalid.Hide();
            btCreateContatosCriar.Enabled = false; // Desabilita o botão "Criar" inicialmente
            AtualizarCorBotao(); // Atualiza a cor do botão inicialmente
        }

        private void btCreateContatoCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCreateContatoCriar_Click(object sender, EventArgs e)
        {
            Contatos contato = new Contatos();
            var contatoAccess = new ContatoAccess();

            contato.Id = contatoAccess.LerUltimoId() + 1;
            contato.Nome = campCreateContatosNome.Text;
            contato.Sobrenome = campCreateContatosSobrenome.Text;
            contato.Telefone = campCreateContatosTelefone.Text;
            contato.Email = campCreateContatosEmail.Text;

            
            contatoAccess.AdicionarContato(contato);
            this.Dispose();
        }

        private void campAddContatosId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void campCreateContatosTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void campCreateContatosEmail_Validating(object sender, CancelEventArgs e)
        {

                // Valida o formato do e-mail
                var email = campCreateContatosEmail.Text;
                if (!IsValidEmail(email))
                {
                    e.Cancel = true;
                   lbCreateContatoEmailInvalid.Show();
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
            bool camposPreenchidos = !string.IsNullOrWhiteSpace(campCreateContatosNome.Text) &&
                                     !string.IsNullOrWhiteSpace(campCreateContatosSobrenome.Text) &&
                                     !string.IsNullOrWhiteSpace(campCreateContatosTelefone.Text) &&
                                     !string.IsNullOrWhiteSpace(campCreateContatosEmail.Text) &&
                                     IsValidEmail(campCreateContatosEmail.Text);

            btCreateContatosCriar.Enabled = camposPreenchidos;
            AtualizarCorBotao();
        }

        private void AtualizarCorBotao()
        {
            if (btCreateContatosCriar.Enabled)
            {
                btCreateContatosCriar.BackColor = Color.FromArgb(230, 34, 34); // Cor quando o botão está ativado
                btCreateContatosCriar.ForeColor = Color.FromArgb(255, 252, 237);
            }
            else
            {
                btCreateContatosCriar.BackColor = Color.FromArgb(52, 60, 76); // Cor quando o botão está desativado
                btCreateContatosCriar.ForeColor = Color.FromArgb(183, 190, 191);
            }
        }

        private void btCreateContatoCriar_EnabledChanged(object sender, EventArgs e)
        {
            AtualizarCorBotao();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                lbCreateContatoEmailInvalid.Hide(); 
                return addr.Address == email;
            }
            catch
            {
                lbCreateContatoEmailInvalid.Show();
                return false;
            }
        }
    }
}