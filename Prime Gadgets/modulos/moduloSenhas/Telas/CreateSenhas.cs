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
    public partial class CreateSenhas : Form
    {
        public CreateSenhas()
        {
            InitializeComponent();
            btCreateSenhasCancelar.CausesValidation = false;
            lbCreateSenhasEmailInvalido.Hide();
            btCreateSenhasMostrar.CausesValidation = false;
            btCreateSenhasGerar.CausesValidation = false;
            lbCreateSenhasSenhaInvalida.Hide();
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
        private void PasswordValidator(object sender, CancelEventArgs e)
        {
            var senha = campCreateSenhasSenha.Text;
            var erros = new System.Text.StringBuilder();
            lbCreateSenhasSenhaInvalida.Text = string.Empty;
            if (senha.Length < 8)
            {
                erros.AppendLine("*A senha deve ter pelo menos 8 caracteres.");
            }
            if (!Regex.IsMatch(senha, @"\d"))
            {
                erros.AppendLine("*A senha deve conter pelo menos um número.");
            }
            if (erros.Length > 0)
            {
                e.Cancel = true;
                lbCreateSenhasSenhaInvalida.Text = "Senha inválida.\n" + erros.ToString();
                lbCreateSenhasSenhaInvalida.Show();
            }
            else
            {
                lbCreateSenhasSenhaInvalida.Hide();
            }
            VerificarCampos();
        }
        private void AtualizarCorBotao()
        {
            if (btCreateSenhasCriar.Enabled)
            {
                btCreateSenhasCriar.BackColor = Color.FromArgb(230, 34, 34); // Cor quando o botão está ativado
                btCreateSenhasCriar.ForeColor = Color.FromArgb(255, 252, 237);
            }
            else
            {
                btCreateSenhasCriar.BackColor = Color.FromArgb(52, 60, 76); // Cor quando o botão está desativado
                btCreateSenhasCriar.ForeColor = Color.FromArgb(183, 190, 191);
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
        private string GerarSenha(int comprimento, bool letraMa, bool letraMi, bool CaracterEs)
        {
            const string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            const string especiais = "'!@#$%^&*(),.?{}|<:;>";
            const string numeros = "0123456789";
            int comprimentoSenha = 1;

            string todosCaracteres = numeros;
            var random = new Random();
            var senha = new StringBuilder();

            if (letraMa == true)
            {
                todosCaracteres+= letrasMaiusculas;
                comprimentoSenha++;
                senha.Append(letrasMaiusculas[random.Next(letrasMaiusculas.Length)]);
            }
            if (letraMi == true)
            {
                todosCaracteres += letrasMinusculas;
                comprimentoSenha++;
                senha.Append(letrasMinusculas[random.Next(letrasMinusculas.Length)]);
            }
            if (CaracterEs == true)
            {
                todosCaracteres += especiais;
                comprimentoSenha++;
                senha.Append(especiais[random.Next(especiais.Length)]);
            }
            senha.Append(numeros[random.Next(numeros.Length)]);

            for (int i = comprimentoSenha; i < comprimento; i++)
            {
                senha.Append(todosCaracteres[random.Next(todosCaracteres.Length)]);
            }

            return new string(senha.ToString().OrderBy(c => random.Next()).ToArray());
        }
        private void btCreateSenhasGerar_Click(object sender, EventArgs e)
        {
            campCreateSenhasSenha.Text = GerarSenha(SenhaPreferences.comprimento, SenhaPreferences.letraMa, SenhaPreferences.letraMi, SenhaPreferences.CaracterEs);
        }
        Bitmap btmShow = Properties.Resources.showon;
        Bitmap btmHide = Properties.Resources.showoff;
        private void btCreateSenhasMostrar_Click(object sender, EventArgs e)
        {
            if (campCreateSenhasSenha.UseSystemPasswordChar)
            {
                campCreateSenhasSenha.UseSystemPasswordChar = false;
                btCreateSenhasMostrar.Image = btmHide;
            }
            else
            {
                campCreateSenhasSenha.UseSystemPasswordChar = true;
                btCreateSenhasMostrar.Image = btmShow;
            }
        }

        private void btCreateSenhasGeradorConfig_Click(object sender, EventArgs e)
        {
            GeradorSenhas geradorSenhas = new GeradorSenhas();
            geradorSenhas.ShowDialog();
        }
    }
}
