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
        Color evento = Color.FromArgb(230, 34, 34);
        EventoAccess eventoAccess = new EventoAccess();
        private Label[] dias;
        private ToolTip toolTipEventos = new ToolTip();

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

            dias = new Label[]
            {
                lbMainCalendarioDia1, lbMainCalendarioDia2, lbMainCalendarioDia3, lbMainCalendarioDia4, lbMainCalendarioDia5, lbMainCalendarioDia6, lbMainCalendarioDia7,
                lbMainCalendarioDia8, lbMainCalendarioDia9, lbMainCalendarioDia10, lbMainCalendarioDia11, lbMainCalendarioDia12, lbMainCalendarioDia13, lbMainCalendarioDia14,
                lbMainCalendarioDia15, lbMainCalendarioDia16, lbMainCalendarioDia17, lbMainCalendarioDia18, lbMainCalendarioDia19, lbMainCalendarioDia20, lbMainCalendarioDia21,
                lbMainCalendarioDia22, lbMainCalendarioDia23, lbMainCalendarioDia24, lbMainCalendarioDia25, lbMainCalendarioDia26, lbMainCalendarioDia27, lbMainCalendarioDia28,
                lbMainCalendarioDia29, lbMainCalendarioDia30, lbMainCalendarioDia31, lbMainCalendarioDia32, lbMainCalendarioDia33, lbMainCalendarioDia34, lbMainCalendarioDia35, 
                lbMainCalendarioDia36, lbMainCalendarioDia37, lbMainCalendarioDia38, lbMainCalendarioDia39, lbMainCalendarioDia40, lbMainCalendarioDia41, lbMainCalendarioDia42
            };

            // Associa o mesmo evento de clique para todos os labels de dias
            foreach (var label in dias)
            {
                label.Click += DiaLabel_Click;
                label.MouseHover += DiaLabel_MouseHover;
                label.MouseLeave += DiaLabel_MouseLeave;
            }

            // Atualiza o label do mês
            lbMainCalendarioMes.Text = ddMainCalendarioSelectMes.SelectedItem?.ToString();
            AtualizarCalendario(lbMainCalendarioMes.Text, lbMainCalendarioAno.Text);
        }

        private void lbMainCalendarioDia1_Click(object sender, EventArgs e)
        {

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

            AtualizarCalendario(lbMainCalendarioMes.Text, lbMainCalendarioAno.Text);
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

            AtualizarCalendario(lbMainCalendarioMes.Text, lbMainCalendarioAno.Text);
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
            AtualizarCalendario(lbMainCalendarioMes.Text, lbMainCalendarioAno.Text);
        }

        private void debugbtMainCalendarioCreate_Click(object sender, EventArgs e)
        {
            CreateEvento createEvento = new CreateEvento();
            createEvento.ShowDialog();
            AtualizarCalendario(lbMainCalendarioMes.Text, lbMainCalendarioAno.Text);
        }

        private void DiaLabel_Click(object sender, EventArgs e)
        {
            Label labelDia = sender as Label;
            if (labelDia == null || string.IsNullOrWhiteSpace(labelDia.Text))
                return;

            int dia = int.Parse(labelDia.Text);
            int mes = DateTime.ParseExact(lbMainCalendarioMes.Text, "MMMM", new System.Globalization.CultureInfo("pt-BR")).Month;
            int ano = int.Parse(lbMainCalendarioAno.Text);

            DateTime dataSelecionada = new DateTime(ano, mes, dia);

            // Busca evento para o dia
            var eventos = eventoAccess.LerEventos();
            var eventoDoDia = eventos.FirstOrDefault(ev => ev.Data.Date == dataSelecionada.Date);

            if (eventoDoDia != null)
            {
                // Abre tela de atualização
                UpdateEvento updateEvento = new UpdateEvento(eventoDoDia);
                updateEvento.ShowDialog();
            }
            else
            {
                // Abre tela de criação já preenchida
                CreateEvento createEvento = new CreateEvento();
                // Preenche o campo de data se existir
                var campoData = createEvento.Controls.Find("campCreateEventoData", true).FirstOrDefault() as DateTimePicker;
                if (campoData != null)
                    campoData.Value = dataSelecionada;

                createEvento.ShowDialog();
            }

            // Atualiza o calendário após qualquer alteração
            AtualizarCalendario(lbMainCalendarioMes.Text, lbMainCalendarioAno.Text);
        }

        private void DiaLabel_MouseHover(object sender, EventArgs e)
        {
            Label labelDia = sender as Label;
            if (labelDia == null || string.IsNullOrWhiteSpace(labelDia.Text))
                return;

            int dia = int.Parse(labelDia.Text);
            int mes = DateTime.ParseExact(lbMainCalendarioMes.Text, "MMMM", new System.Globalization.CultureInfo("pt-BR")).Month;
            int ano = int.Parse(lbMainCalendarioAno.Text);

            DateTime dataSelecionada = new DateTime(ano, mes, dia);

            var eventos = eventoAccess.LerEventos();
            var eventoDoDia = eventos.FirstOrDefault(ev => ev.Data.Date == dataSelecionada.Date);

            if (eventoDoDia != null)
            {
                toolTipEventos.SetToolTip(labelDia, eventoDoDia.Descricao);
            }
            else
            {
                toolTipEventos.SetToolTip(labelDia, null);
            }
        }

        private void DiaLabel_MouseLeave(object sender, EventArgs e)
        {
            Label labelDia = sender as Label;
            if (labelDia != null)
            {
                toolTipEventos.SetToolTip(labelDia, null);
            }
        }

        private void AtualizarCalendario(string nomeMes, string ano)
        {
            // Converter nome do mês para número
            int mes = DateTime.ParseExact(nomeMes, "MMMM", new System.Globalization.CultureInfo("pt-BR")).Month;
            int anoInt = int.Parse(ano);
            List<Evento> eventosMes = eventoAccess.LerEventos();

            // Filtrar apenas eventos do mês e ano selecionados
            eventosMes = eventosMes
                .Where(ev => ev.Data.Month == mes && ev.Data.Year == anoInt)
                .ToList();

            // Primeiro dia do mês
            DateTime primeiroDia = new DateTime(anoInt, mes, 1);
            // Quantos dias tem o mês
            int diasNoMes = DateTime.DaysInMonth(anoInt, mes);
            // Dia da semana do primeiro dia (0 = domingo, 1 = segunda, ...)
            int inicioSemana = (int)primeiroDia.DayOfWeek;

            // Preencher os dias do calendário
            int contador = 1;
            for (int i = 0; i < dias.Length; i++)
            {
                if (i >= inicioSemana && contador <= diasNoMes)
                {
                    dias[i].Text = contador.ToString();

                    // Verifica se existe evento neste dia
                    bool temEvento = eventosMes.Any(ev => ev.Data.Day == contador);
                    if (temEvento)
                    {
                        dias[i].BackColor = evento;
                    }
                    else
                    {
                        dias[i].BackColor = ativado;
                    }
                    contador++;
                }
                else
                {
                    dias[i].Text = "";
                    dias[i].BackColor = desativado;
                }
            }
        }
    }
}
