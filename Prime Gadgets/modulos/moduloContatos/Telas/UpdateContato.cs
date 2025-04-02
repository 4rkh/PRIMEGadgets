using Prime_Gadgets.modulos.moduloContatos.Modelos;
using Prime_Gadgets.modulos.moduloContatos.Repositorios;
using System.ComponentModel;

namespace Prime_Gadgets.modulos.moduloContatos.Telas
{
    public partial class UpdateContato : Form
    {
        private bool cancelClicked = true; // Esta variavel serve para consertar um bug no bota cancelar
        public Contatos UpdatedContato { get; private set; }
        public UpdateContato(Contatos contato)
        {
            InitializeComponent();
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
            if (cancelClicked)
            {
                return;

            }
            else
            {
                if (!IsValidEmail(email))
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, insira um endereço de e-mail válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                VerificarCampos();
            }
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
            btUpdateContatosCriar.BackColor = camposValidos ? Color.Lime : Color.Gray;
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