using Prime_Gadgets.modulos.moduloContatos.Modelos;
using Prime_Gadgets.modulos.moduloContatos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.Models
{
    public partial class CreateContato : Form
    {
        public CreateContato()
        {
            InitializeComponent();
            btAddContatosCriar.Enabled = false; // Desabilita o botão "Criar" inicialmente
            AtualizarCorBotao(); // Atualiza a cor do botão inicialmente
        }

        private void btContatoAddCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btContatoAddCriar_Click(object sender, EventArgs e)
        {
            Contatos contato = new Contatos();
            var contatoAccess = new ContatoAccess();

            contato.Id = contatoAccess.LerUltimoId() + 1;
            contato.Nome = campAddContatosNome.Text;
            contato.Sobrenome = campAddContatosSobrenome.Text;
            contato.Telefone = campAddContatosTelefone.Text;
            contato.Email = campAddContatosEmail.Text;

            
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

        private void campAddContatosTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void campAddContatosEmail_Validating(object sender, CancelEventArgs e)
        {
            // Valida o formato do e-mail
            var email = campAddContatosEmail.Text;
            if (!IsValidEmail(email))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, insira um endereço de e-mail válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bool camposPreenchidos = !string.IsNullOrWhiteSpace(campAddContatosNome.Text) &&
                                     !string.IsNullOrWhiteSpace(campAddContatosSobrenome.Text) &&
                                     !string.IsNullOrWhiteSpace(campAddContatosTelefone.Text) &&
                                     !string.IsNullOrWhiteSpace(campAddContatosEmail.Text) &&
                                     IsValidEmail(campAddContatosEmail.Text);

            btAddContatosCriar.Enabled = camposPreenchidos;
            AtualizarCorBotao();
        }

        private void AtualizarCorBotao()
        {
            if (btAddContatosCriar.Enabled)
            {
                btAddContatosCriar.BackColor = Color.Green; // Cor quando o botão está ativado
            }
            else
            {
                btAddContatosCriar.BackColor = Color.Red; // Cor quando o botão está desativado
            }
        }

        private void btContatoAddCriar_EnabledChanged(object sender, EventArgs e)
        {
            AtualizarCorBotao();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}