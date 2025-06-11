using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloFinanceiro
{
    internal class FinanceiroAccess
    {
        public string caminhoRelativo = "modulos\\moduloFinanceiro\\repositorios\\Gastos.prime";
        public string caminho;

        public FinanceiroAccess()
        {
            try
            {
                string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                caminho = Path.Combine(diretorioProjeto, caminhoRelativo);

                if (!File.Exists(caminho))
                {
                    File.Create(caminho).Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar acessar o arquivo Gastos.prime: " + e.Message);
            }
        }

        // Salva todo o conteúdo do DataGridView no arquivo Gastos.prime
        public void SalvarGastos(DataGridView dgv)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(caminho, false, Encoding.UTF8))
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;
                        // Espera-se que as colunas estejam na ordem: Id, Descricao, Valor, Data, Categoria, FormaPagamento, Observacoes
                        string id = row.Cells[0].Value?.ToString() ?? "";
                        string descricao = row.Cells[1].Value?.ToString() ?? "";
                        string valor = row.Cells[2].Value?.ToString() ?? "";
                        string data = "";
                        if (row.Cells[3].Value is DateTime dt)
                            data = dt.ToString("yyyy-MM-dd");
                        else
                            data = row.Cells[3].Value?.ToString() ?? "";
                        string categoria = row.Cells[4].Value?.ToString() ?? "";
                        string formaPagamento = row.Cells[5].Value?.ToString() ?? "";
                        string observacoes = row.Cells[6].Value?.ToString() ?? "";

                        string linha = $"{id},{descricao},{valor},{data},{categoria},{formaPagamento},{observacoes}";
                        sw.WriteLine(linha);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar os gastos: " + e.Message);
            }
        }

        // Salva os gastos do DataGridView no arquivo Gastos.prime, filtrando por mês e ano
        public void SalvarGastos(DataGridView dgv, int mes, int ano)
        {
            try
            {
                // 1. Lê todos os gastos existentes
                var todosGastos = LerGastos();

                // 2. Filtra os gastos do mês/ano atual
                var gastosMesAno = todosGastos.Where(g => g.Data.Year == ano && g.Data.Month == mes).ToList();

                // 3. Atualiza/adiciona os gastos do DataGridView (apenas para o mês/ano selecionados)
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    int dia = int.TryParse(row.Cells[2].Value?.ToString(), out var d) ? d : 1;
                    DateTime data = new DateTime(ano, mes, dia);

                    string descricao = row.Cells[0].Value?.ToString() ?? "";
                    decimal valor = decimal.TryParse(row.Cells[1].Value?.ToString(), out var v) ? v : 0;
                    string categoria = row.Cells[3].Value?.ToString() ?? "";
                    string formaPagamento = row.Cells[4].Value?.ToString() ?? "";
                    string observacoes = row.Cells[5].Value?.ToString() ?? "";

                    // Procura se já existe um gasto igual para este mês/ano/dia
                    var gastoExistente = gastosMesAno.FirstOrDefault(g =>
                        g.Data.Day == dia &&
                        g.Descricao == descricao &&
                        g.Valor == valor &&
                        g.Categoria == categoria &&
                        g.FormaPagamento == formaPagamento &&
                        g.Observacoes == observacoes
                    );

                    if (gastoExistente != null)
                    {
                        // Atualiza o registro existente
                        gastoExistente.Descricao = descricao;
                        gastoExistente.Valor = valor;
                        gastoExistente.Data = data;
                        gastoExistente.Categoria = categoria;
                        gastoExistente.FormaPagamento = formaPagamento;
                        gastoExistente.Observacoes = observacoes;
                    }
                    else
                    {
                        int novoId = todosGastos.Any() ? todosGastos.Max(g => g.Id) + 1 : 1;
                        var novoGasto = new Gasto
                        {
                            Id = novoId,
                            Descricao = descricao,
                            Valor = valor,
                            Data = data,
                            Categoria = categoria,
                            FormaPagamento = formaPagamento,
                            Observacoes = observacoes
                        };
                        todosGastos.Add(novoGasto);
                        gastosMesAno.Add(novoGasto);
                    }
                }

                // 4. Salva todos os gastos de volta no arquivo
                using (StreamWriter sw = new StreamWriter(caminho, false, Encoding.UTF8))
                {
                    foreach (var g in todosGastos)
                    {
                        string linha = $"{g.Id},{g.Descricao},{g.Valor},{g.Data:yyyy-MM-dd},{g.Categoria},{g.FormaPagamento},{g.Observacoes}";
                        sw.WriteLine(linha);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar os gastos: " + e.Message);
            }
        }

        // Lê todos os gastos do arquivo Gastos.prime
        public List<Gasto> LerGastos()
        {
            var gastos = new List<Gasto>();
            try
            {
                var linhas = File.ReadAllLines(caminho, Encoding.UTF8);
                foreach (var linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;
                    var campos = linha.Split(',');
                    if (campos.Length >= 7)
                    {
                        gastos.Add(new Gasto
                        {
                            Id = int.TryParse(campos[0], out int id) ? id : 0,
                            Descricao = campos[1],
                            Valor = decimal.TryParse(campos[2], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor) ? valor : 0,
                            Data = DateTime.TryParse(campos[3], out DateTime data) ? data : DateTime.MinValue,
                            Categoria = campos[4],
                            FormaPagamento = campos[5],
                            Observacoes = campos[6]
                        });
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao ler os gastos: " + e.Message);
            }
            return gastos;
        }

        // Filtra os gastos por mês e ano
        public List<Gasto> FiltrarGastosPorMesAno(int mes, int ano)
        {
            var todos = LerGastos();
            return todos.Where(g => g.Data.Month == mes && g.Data.Year == ano).ToList();
        }
    }
}
