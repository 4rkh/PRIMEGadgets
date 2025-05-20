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
    public partial class UpdateContato : Form
    {
        public Contatos UpdatedContato { get; private set; }
        public UpdateContato(Contatos contato)
        {
            InitializeComponent();
            btUpdateContatosCancelar.CausesValidation = false; // Desabilita a validação de campos para o botão "Cancelar"
            lbUpdateContatosEmailInvalid.Hide();
            UpdatedContato = contato;
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            campUpdateContatosId.Text = UpdatedContato.Id.ToString();
            campUpdateContatosNome.Text = UpdatedContato.Nome;
            campUpdateContatosSobrenome.Text = UpdatedContato.Sobrenome;
            campUpdateContatosTelefone.Text = UpdatedContato.Telefone;
            campUpdateContatosEmail.Text = UpdatedContato.Email;
        }

        private void btUpdateContatosCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void campUpdateContatosNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas letras e controle (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void campUpdateContatosSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas letras e controle (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void campUpdateContatosTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e controle (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void campUpdateContatosEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = campUpdateContatosEmail.Text;

            // Valida o formato do e-mail
            if (!IsValidEmail(email))
            {

                e.Cancel = true;
            }
            VerificarCampos();

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                lbUpdateContatosEmailInvalid.Hide();
                return addr.Address == email;
            }
            catch
            {
                lbUpdateContatosEmailInvalid.Show();
                return false;
            }
        }

        private void campUpdateContatosId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e controle (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Campos_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }
        private void VerificarCampos()
        {
            bool camposValidos = !string.IsNullOrWhiteSpace(campUpdateContatosNome.Text) &&
                                 !string.IsNullOrWhiteSpace(campUpdateContatosSobrenome.Text) &&
                                 !string.IsNullOrWhiteSpace(campUpdateContatosTelefone.Text) &&
                                 !string.IsNullOrWhiteSpace(campUpdateContatosEmail.Text) &&
                                 IsValidEmail(campUpdateContatosEmail.Text);

            btUpdateContatosCriar.Enabled = camposValidos;
            btUpdateContatosCriar.BackColor = camposValidos ? Color.FromArgb(230, 34, 34) : Color.FromArgb(52, 60, 76);
        }

        private void btUpdateContatosAtualizar_Click(object sender, EventArgs e)
        {
            string mensagem = $"Deseja atualizar o contato?\n" +
                              $"Id: {UpdatedContato.Id} -> {campUpdateContatosId.Text}\n" +
                              $"Nome: {UpdatedContato.Nome} -> {campUpdateContatosNome.Text}\n" +
                              $"Sobrenome: {UpdatedContato.Sobrenome} -> {campUpdateContatosSobrenome.Text}\n" +
                              $"Telefone: {UpdatedContato.Telefone} -> {campUpdateContatosTelefone.Text}\n" +
                              $"Email: {UpdatedContato.Email} -> {campUpdateContatosEmail.Text}";

            DialogResult resultado = MessageBox.Show(mensagem, "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                ContatoAccess contatoAccess = new ContatoAccess();
                int oldId = UpdatedContato.Id;
                Contatos contato = new Contatos
                {
                    Id = int.Parse(campUpdateContatosId.Text),
                    Nome = campUpdateContatosNome.Text,
                    Sobrenome = campUpdateContatosSobrenome.Text,
                    Telefone = campUpdateContatosTelefone.Text,
                    Email = campUpdateContatosEmail.Text
                };
                contatoAccess.UpdateContato(contato, oldId);
                MessageBox.Show("Contato atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}