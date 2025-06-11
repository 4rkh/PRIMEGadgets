using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Prime_Gadgets.modulos.moduloFinanceiro.Telas
{
    public partial class Resumo : Form
    {
        private int mes;
        private int ano;

        public Resumo(int mes, int ano)
        {
            InitializeComponent();
            this.mes = mes;
            this.ano = ano;

            AtualizarResumo();
        }

        private void AtualizarResumo()
        {
            // Atualiza label do mês/ano
            string nomeMes = System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat.GetMonthName(mes);
            nomeMes = char.ToUpper(nomeMes[0]) + nomeMes.Substring(1);
            lbResumoMesAno.Text = $"{nomeMes} de {ano}";

            AtualizarTotalGastos();
            AtualizarTabelaGastos();
            AtualizarGraficoGastos();
        }

        private void AtualizarTotalGastos()
        {
            var financeiroAccess = new FinanceiroAccess();
            var gastos = financeiroAccess.FiltrarGastosPorMesAno(mes, ano);
            decimal total = gastos.Sum(g => g.Valor);

            lbResumoGastoTotal.Text = $"Total gasto ({mes}/{ano}): " + total.ToString("C2");
        }

        private void AtualizarTabelaGastos()
        {
            var financeiroAccess = new FinanceiroAccess();
            var gastos = financeiroAccess.FiltrarGastosPorMesAno(mes, ano);

            var dt = new DataTable();
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Valor", typeof(decimal));
            dt.Columns.Add("Dia", typeof(int));
            dt.Columns.Add("Observação", typeof(string));

            foreach (var gasto in gastos)
            {
                dt.Rows.Add(gasto.Descricao, gasto.Valor, gasto.Data.Day, gasto.Observacoes);
            }

            tbResumoGastosMes.DataSource = dt;
        }

        private void AtualizarGraficoGastos()
        {
            var financeiroAccess = new FinanceiroAccess();
            var gastosMes = financeiroAccess.FiltrarGastosPorMesAno(mes, ano);

            ctResumoMes.Series.Clear();
            ctResumoMes.ChartAreas.Clear();

            var area = new ChartArea("AreaGastos");
            // Fundo suave
            area.BackColor = Color.FromArgb(255, 252, 237);
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(230, 34, 34);
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.BorderColor = Color.FromArgb(230, 34, 34);
            area.BorderDashStyle = ChartDashStyle.Solid;
            ctResumoMes.ChartAreas.Add(area);

            var serie = new Series("Gastos no Mês")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                IsXValueIndexed = false,
                Color = Color.FromArgb(230, 34, 34), // Vermelho do menu
                BorderWidth = 0
            };

            // Exibir cada gasto como uma coluna separada no gráfico
            foreach (var gasto in gastosMes)
            {
                string eixoX = $"{gasto.Data.Day:D2}/{mes:D2} - {gasto.Descricao}";
                int idx = serie.Points.AddXY(eixoX, (double)gasto.Valor);
                // Valor acima da coluna
                serie.Points[idx].Label = gasto.Valor.ToString("C2");
                serie.Points[idx].LabelForeColor = Color.FromArgb(52, 60, 76);
                serie.Points[idx].Font = new Font("Segoe UI", 8, FontStyle.Bold);
            }

            serie["PointWidth"] = "0.6";
            serie["DrawingStyle"] = "Cylinder"; // Colunas arredondadas

            ctResumoMes.Series.Add(serie);

            var chartArea = ctResumoMes.ChartAreas[0];
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Title = "Gastos";
            chartArea.AxisY.Title = "Valor (R$)";
            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(52, 60, 76);
            chartArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(52, 60, 76);
            chartArea.AxisX.TitleForeColor = Color.FromArgb(52, 60, 76);
            chartArea.AxisY.TitleForeColor = Color.FromArgb(52, 60, 76);

            // Remove legendas e bordas extras
            ctResumoMes.Legends.Clear();
            ctResumoMes.BorderlineColor = Color.FromArgb(230, 34, 34);
            ctResumoMes.BorderlineDashStyle = ChartDashStyle.Solid;
            ctResumoMes.BackColor = Color.FromArgb(255, 252, 237);

            ctResumoMes.Update();
            ctResumoMes.Refresh();
            ctResumoMes.Invalidate();
        }


        private void btResumoVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btResumoAvancarMes_Click(object sender, EventArgs e)
        {
            if (mes < 12)
            {
                mes++;
            }
            else
            {
                mes = 1;
                if (ano < 2100)
                    ano++;
            }
            AtualizarResumo();
        }

        private void btResumoAnteriorMes_Click(object sender, EventArgs e)
        {
            if (mes > 1)
            {
                mes--;
            }
            else
            {
                mes = 12;
                if (ano > 2000)
                    ano--;
            }
            AtualizarResumo();
        }
    }
}
