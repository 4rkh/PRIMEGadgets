using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloSenhas
{
    public partial class UpdateSenhas : Form
    {
        public Senhas UpdatedSenha { get; private set; }
        public UpdateSenhas(Senhas senha)
        {
            InitializeComponent();
            btUpdateSenhasCancelar.CausesValidation = false;
            lbUpdateSenhasEmailInvalido.Hide();
            btUpdateSenhasMostrar.CausesValidation = false;
            btUpdateSenhasGerar.CausesValidation = false;
            lbUpdateSenhasSenhaInvalida.Hide();
            UpdatedSenha = senha;
            PreencherCampos();
        }
        private void PreencherCampos()
        {
            campUpdateSenhasId.Text = UpdatedSenha.Id.ToString();
            campUpdateSenhasNome.Text = UpdatedSenha.NomeDeUsuario;
            campUpdateSenhasEmail.Text = UpdatedSenha.Email;
            campUpdateSenhasSenha.Text = UpdatedSenha.Senha;
            campUpdateSenhasOrigem.Text = UpdatedSenha.Origem;
        }
        private void campUpdateSenhasId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void campUpdateSenhasNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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
            bool camposValidos = !string.IsNullOrWhiteSpace(campUpdateSenhasId.Text) &&
                                 !string.IsNullOrWhiteSpace(campUpdateSenhasNome.Text) &&
                                 !string.IsNullOrWhiteSpace(campUpdateSenhasSenha.Text) &&
                                 !string.IsNullOrWhiteSpace(campUpdateSenhasOrigem.Text) &&
                                 IsValidEmail(campUpdateSenhasEmail.Text);

            btUpdateSenhasAtualizar.Enabled = camposValidos;
            btUpdateSenhasAtualizar.BackColor = camposValidos ? Color.Lime : Color.Gray;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                lbUpdateSenhasEmailInvalido.Hide();
                return addr.Address == email;
            }
            catch
            {
                lbUpdateSenhasEmailInvalido.Show();
                return false;
            }
        }
        private void campUpdateSenhasEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = campUpdateSenhasEmail.Text;

            if (!IsValidEmail(email))
            {

                e.Cancel = true;
            }
            VerificarCampos();

        }
        private void btUpdateSenhasAtualizar_Click(object sender, EventArgs e)
        {
            string mensagem = $"Deseja atualizar o contato?\n" +
                              $"ID: {UpdatedSenha.Id} -> {campUpdateSenhasId.Text}\n" +
                              $"Nome: {UpdatedSenha.NomeDeUsuario} -> {campUpdateSenhasNome.Text}\n" +
                              $"E-mail: {UpdatedSenha.Email} -> {campUpdateSenhasEmail.Text}\n" +
                              $"Senha: {UpdatedSenha.Senha} -> {campUpdateSenhasSenha.Text}\n" +
                              $"Origem: {UpdatedSenha.Origem} -> {campUpdateSenhasOrigem.Text}";

            DialogResult resultado = MessageBox.Show(mensagem, "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SenhaAccess senhaAccess = new SenhaAccess();
                int oldId = UpdatedSenha.Id;
                Senhas senha = new Senhas
                {
                    Id = int.Parse(campUpdateSenhasId.Text),
                    NomeDeUsuario = campUpdateSenhasNome.Text,
                    Email = campUpdateSenhasEmail.Text,
                    Senha = campUpdateSenhasSenha.Text,
                    Origem = campUpdateSenhasOrigem.Text
                };
                senhaAccess.UpdateSenha(senha, oldId);
                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
        private void PasswordValidator(object sender, CancelEventArgs e)
        {
            var senha = campUpdateSenhasSenha.Text;
            string caracteresEspeciais = @"[!@#$%^&*(),.?""':;{}|<>]";
            var erros = new System.Text.StringBuilder();
            lbUpdateSenhasSenhaInvalida.Text = string.Empty;
            if (senha.Length < 8)
            {
                erros.AppendLine("*A senha deve ter pelo menos 8 caracteres.");
            }
            if (!Regex.IsMatch(senha, @"[A-Z]"))
            {
                erros.AppendLine("*A senha deve conter pelo menos uma letra maiúscula.");
            }
            if (!Regex.IsMatch(senha, @"[a-z]"))
            {
                erros.AppendLine("*A senha deve conter pelo menos uma letra minúscula.");
            }
            if (!Regex.IsMatch(senha, @"\d"))
            {
                erros.AppendLine("*A senha deve conter pelo menos um número.");
            }
            if (!Regex.IsMatch(senha, caracteresEspeciais))
            {
                erros.AppendLine("*A senha deve conter pelo menos um caractere especial.");
            }
            if (erros.Length > 0)
            {
                e.Cancel = true;
                lbUpdateSenhasSenhaInvalida.Text = "Senha inválida.\n" + erros.ToString();
                lbUpdateSenhasSenhaInvalida.Show();
            }
            else
            {
                lbUpdateSenhasSenhaInvalida.Hide();
            }
            VerificarCampos();
        }
        private void btUpdateSenhasCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private string GerarSenha(int comprimento)
        {
            const string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            const string numeros = "0123456789";
            const string especiais = "'!@#$%^&*(),.?{}|<:;>";

            string todosCaracteres = letrasMaiusculas + letrasMinusculas + numeros + especiais;
            var random = new Random();
            var senha = new StringBuilder();

            senha.Append(letrasMaiusculas[random.Next(letrasMaiusculas.Length)]);
            senha.Append(letrasMinusculas[random.Next(letrasMinusculas.Length)]);
            senha.Append(numeros[random.Next(numeros.Length)]);
            senha.Append(especiais[random.Next(especiais.Length)]);

            for (int i = 4; i < comprimento; i++)
            {
                senha.Append(todosCaracteres[random.Next(todosCaracteres.Length)]);
            }

            return new string(senha.ToString().OrderBy(c => random.Next()).ToArray());
        }
        private void btUpdateSenhasGerar_Click(object sender, EventArgs e)
        {
            campUpdateSenhasSenha.Text = GerarSenha(15);
        }

        private void btUpdateSenhasMostrar_Click(object sender, EventArgs e)
        {
            if (campUpdateSenhasSenha.UseSystemPasswordChar)
            {
                campUpdateSenhasSenha.UseSystemPasswordChar = false;
                btUpdateSenhasMostrar.Text = "Ocultar";
            }
            else
            {
                campUpdateSenhasSenha.UseSystemPasswordChar = true;
                btUpdateSenhasMostrar.Text = "Mostrar";
            }
        }
    }
}
