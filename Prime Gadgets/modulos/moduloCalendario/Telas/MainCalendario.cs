using Prime_Gadgets.modulos.moduloContatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloCalendario
{
    public partial class MainCalendario : Form
    {
        Color desativado = Color.FromArgb(128, 128, 128);
        Color ativado = Color.FromArgb(192, 255, 255);
        Color evento = Color.FromArgb(230, 34, 34); // Cor para eventos
        public MainCalendario()
        {
            InitializeComponent();

            // Cria uma variável com a data atual
            DateTime dataAtual = DateTime.Now;

            // Inicializa o campo de seleção de ano com o ano atual
            campMainCalendarioSelectAno.Text = dataAtual.Year.ToString();

            // Define o ano atual no label
            lbMainCalendarioAno.Text = dataAtual.Year.ToString();

            // Define o mês atual no ComboBox e no label
            string nomeMesAtual = dataAtual.ToString("MMMM", new System.Globalization.CultureInfo("pt-BR"));
            nomeMesAtual = char.ToUpper(nomeMesAtual[0]) + nomeMesAtual.Substring(1); // Primeira letra maiúscula

            // Procura o mês no ComboBox e seleciona
            int indiceMes = ddMainCalendarioSelectMes.Items.IndexOf(nomeMesAtual);
            if (indiceMes >= 0)
            {
                ddMainCalendarioSelectMes.SelectedIndex = indiceMes;
            }
            else
            {
                ddMainCalendarioSelectMes.SelectedIndex = 0; // fallback
            }

            // Atualiza o label do mês
            lbMainCalendarioMes.Text = ddMainCalendarioSelectMes.SelectedItem?.ToString();
        }

        private void lbMainCalendarioDia1_Click(object sender, EventArgs e)
        {

            if (lbMainCalendarioDia1.BackColor != desativado)
            {
                lbMainCalendarioDia1.BackColor = desativado;
            }
            else
            {
                lbMainCalendarioDia1.BackColor = ativado;
            }
        }

        private void btMainCalendarioBack_Click(object sender, EventArgs e)
        {
            int mesAtual = ddMainCalendarioSelectMes.SelectedIndex;
            int totalMeses = ddMainCalendarioSelectMes.Items.Count;

            if (mesAtual > 0)
            {
                ddMainCalendarioSelectMes.SelectedIndex = mesAtual - 1;
            }
            else
            {
                // Se está em Janeiro, volta para Dezembro e diminui o ano
                ddMainCalendarioSelectMes.SelectedIndex = totalMeses - 1;
                if (int.TryParse(campMainCalendarioSelectAno.Text, out int anoAtual))
                {
                    anoAtual--;
                    campMainCalendarioSelectAno.Text = anoAtual.ToString();
                    lbMainCalendarioAno.Text = anoAtual.ToString();
                }
            }
        }

        private void btMainCalendarioNext_Click(object sender, EventArgs e)
        {
            int mesAtual = ddMainCalendarioSelectMes.SelectedIndex;
            int totalMeses = ddMainCalendarioSelectMes.Items.Count;

            if (mesAtual < totalMeses - 1)
            {
                ddMainCalendarioSelectMes.SelectedIndex = mesAtual + 1;
            }
            else
            {
                // Se está em Dezembro, avança para Janeiro e soma o ano
                ddMainCalendarioSelectMes.SelectedIndex = 0;
                if (int.TryParse(campMainCalendarioSelectAno.Text, out int anoAtual))
                {
                    anoAtual++;
                    campMainCalendarioSelectAno.Text = anoAtual.ToString();
                    lbMainCalendarioAno.Text = anoAtual.ToString();
                }
            }
        }

        private void ddMainCalendarioSelectMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Atualiza o label para refletir o mês selecionado no ComboBox
            lbMainCalendarioMes.Text = ddMainCalendarioSelectMes.SelectedItem?.ToString();
        }

        private void btMainCalendarioChangeAno_Click(object sender, EventArgs e)
        {
            // Atualiza o label do ano para o valor do campo de seleção de ano
            lbMainCalendarioAno.Text = campMainCalendarioSelectAno.Text;
        }

        private void debugbtMainCalendarioCreate_Click(object sender, EventArgs e)
        {
            CreateEvento createEvento = new CreateEvento();
            createEvento.ShowDialog();
        }
    }
}
