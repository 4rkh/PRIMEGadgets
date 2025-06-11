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

            // Adiciona o evento para deletar linha ao pressionar 'Del'
            dtMainFinanceiroGastos.KeyDown += DtMainFinanceiroGastos_KeyDown;

            // Adiciona o evento para configurar o ComboBox e restringir entrada na coluna "Valor"
            dtMainFinanceiroGastos.EditingControlShowing += DtMainFinanceiroGastos_EditingControlShowing;

            // Adiciona o evento para tratar erros de dados
            dtMainFinanceiroGastos.DataError += DtMainFinanceiroGastos_DataError;
        }

        private void AtualizarFinanceiro()
        {
            var financeiroAccess = new FinanceiroAccess();
            var gastos = financeiroAccess.FiltrarGastosPorMesAno(mesAtual, anoAtual);

            var dt = new DataTable();
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Valor", typeof(decimal));
            dt.Columns.Add("Dia", typeof(int));
            dt.Columns.Add("Categoria", typeof(string));
            dt.Columns.Add("Forma de Pagamento", typeof(string));
            dt.Columns.Add("Observações", typeof(string));

            var formasValidas = new[] { "A vista", "Cartão de Crédito" };
            foreach (var gasto in gastos)
            {
                var forma = formasValidas.Contains(gasto.FormaPagamento) ? gasto.FormaPagamento : formasValidas[0];
                dt.Rows.Add(
                    gasto.Descricao,
                    gasto.Valor,
                    gasto.Data.Day,
                    gasto.Categoria,
                    forma,
                    gasto.Observacoes
                );
            }

            dtMainFinanceiroGastos.DataSource = null;
            dtMainFinanceiroGastos.Columns.Clear();
            dtMainFinanceiroGastos.AutoGenerateColumns = false;

            // Adiciona as colunas manualmente
            dtMainFinanceiroGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descrição",
                HeaderText = "Descrição"
            });
            dtMainFinanceiroGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Valor",
                HeaderText = "Valor"
            });
            dtMainFinanceiroGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Dia",
                HeaderText = "Dia"
            });
            dtMainFinanceiroGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoria"
            });
            dtMainFinanceiroGastos.Columns.Add(new DataGridViewComboBoxColumn
            {
                DataPropertyName = "Forma de Pagamento",
                HeaderText = "Forma de Pagamento",
                Name = "Forma de Pagamento",
                DataSource = formasValidas,
                Width = 120
            });
            dtMainFinanceiroGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observações",
                HeaderText = "Observações"
            });

            dtMainFinanceiroGastos.DataSource = dt;
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

        private void btMainFinanceiroSalvar_Click(object sender, EventArgs e)
        {
            var financeiroAccess = new FinanceiroAccess();
            financeiroAccess.SalvarGastos(dtMainFinanceiroGastos, mesAtual, anoAtual);

            MessageBox.Show("Gastos salvos com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btMainFinanceiroReset_Click(object sender, EventArgs e)
        {
            AtualizarFinanceiro();
        }

        private void DtMainFinanceiroGastos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dtMainFinanceiroGastos.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dtMainFinanceiroGastos.Rows.Remove(row);
                    }
                }
                e.Handled = true;
            }
        }

        private void DtMainFinanceiroGastos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtMainFinanceiroGastos.CurrentCell.ColumnIndex == dtMainFinanceiroGastos.Columns["Forma de Pagamento"].Index)
            {
                if (e.Control is ComboBox combo)
                {
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
        }

        private void DtMainFinanceiroGastos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Evita a caixa de erro padrão e pode exibir uma mensagem customizada se desejar
            e.ThrowException = false;
        }
    }
}
