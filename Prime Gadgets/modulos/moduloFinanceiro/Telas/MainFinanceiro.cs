using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloFinanceiro
{
    public partial class MainFinanceiro : Form
    {
        private int mesAtual;
        private int anoAtual;

        public MainFinanceiro()
        {
            InitializeComponent();

            // Inicializa variáveis com mês e ano atuais
            DateTime dataAtual = DateTime.Now;
            mesAtual = dataAtual.Month;
            anoAtual = dataAtual.Year;

            // Preenche ComboBox de ano (2000-2100)
            ddmainFinaceiroAnoSelect.Items.Clear();
            for (int ano = 2000; ano <= 2100; ano++)
                ddmainFinaceiroAnoSelect.Items.Add(ano.ToString());

            // Seleciona ano e mês atuais nos ComboBox
            ddmainFinaceiroAnoSelect.SelectedItem = anoAtual.ToString();
            ddmainFinaceiroMesSelect.SelectedIndex = mesAtual - 1;

            // Atualiza labels
            AtualizarLabels();

            // Eventos de seleção
            ddmainFinaceiroMesSelect.SelectedIndexChanged += DdmainFinaceiroMesSelect_SelectedIndexChanged;
            ddmainFinaceiroAnoSelect.SelectedIndexChanged += DdmainFinaceiroAnoSelect_SelectedIndexChanged;
            btMainFinaceiroNext.Click += BtMainFinaceiroNext_Click;
            btMainFinaceiroBack.Click += BtMainFinaceiroBack_Click;
        }

        private void AtualizarFinanceiro()
        {
            // Aqui você pode atualizar os dados financeiros conforme o mês/ano selecionados
            // Exemplo: recarregar DataGridView, etc.
        }

        private void AtualizarLabels()
        {
            // Atualiza label do mês
            string nomeMes = CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat.GetMonthName(mesAtual);
            nomeMes = char.ToUpper(nomeMes[0]) + nomeMes.Substring(1);
            lbMainFinaceiroMes.Text = nomeMes;

            // Atualiza label do ano
            lbMainFinaceiroAno.Text = anoAtual.ToString();

            AtualizarFinanceiro();
        }

        private void DdmainFinaceiroMesSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesAtual = ddmainFinaceiroMesSelect.SelectedIndex + 1;
            AtualizarLabels();
        }

        private void DdmainFinaceiroAnoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ddmainFinaceiroAnoSelect.SelectedItem?.ToString(), out int ano))
            {
                anoAtual = ano;
                AtualizarLabels();
            }
        }

        private void BtMainFinaceiroNext_Click(object sender, EventArgs e)
        {
            if (mesAtual < 12)
            {
                mesAtual++;
            }
            else
            {
                mesAtual = 1;
                if (anoAtual < 2100)
                    anoAtual++;
            }
            ddmainFinaceiroMesSelect.SelectedIndex = mesAtual - 1;
            ddmainFinaceiroAnoSelect.SelectedItem = anoAtual.ToString();
            AtualizarLabels();
        }

        private void BtMainFinaceiroBack_Click(object sender, EventArgs e)
        {
            if (mesAtual > 1)
            {
                mesAtual--;
            }
            else
            {
                mesAtual = 12;
                if (anoAtual > 2000)
                    anoAtual--;
            }
            ddmainFinaceiroMesSelect.SelectedIndex = mesAtual - 1;
            ddmainFinaceiroAnoSelect.SelectedItem = anoAtual.ToString();
            AtualizarLabels();
        }
    }
}
