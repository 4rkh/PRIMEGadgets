using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using Prime_Gadgets.modulos.moduloRotina;
using System.Text; // Necessário para Encoding

namespace Prime_Gadgets.modulos.moduloRotina
{
    public class RotinaAccess
    {
        public string caminhoRelativo = "modulos\\moduloRotina\\Repositorios\\Rotina.prime";
        public string caminho;
        public string conteudo;
        private static readonly CultureInfo CulturaPadrao = new CultureInfo("pt-BR");

        public RotinaAccess()
        {
            try
            {
                string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                caminho = Path.Combine(diretorioProjeto, caminhoRelativo);

                // Força a conversão do arquivo para UTF-8 se necessário
                ForcarConversaoParaUtf8(caminho);

                if (!File.Exists(caminho))
                {
                    File.Create(caminho).Dispose();
                    conteudo = string.Empty;
                }
                conteudo = File.ReadAllText(caminho, Encoding.UTF8);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar ler o arquivo Rotina.prime: " + e.Message);
                conteudo = string.Empty;
            }
        }

        /// <summary>
        /// Força a conversão do arquivo para UTF-8 se ele não estiver nessa codificação.
        /// </summary>
        private void ForcarConversaoParaUtf8(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
                return;

            // Detecta se o arquivo já está em UTF-8
            byte[] buffer = File.ReadAllBytes(caminhoArquivo);
            var utf8Preamble = Encoding.UTF8.GetPreamble();
            bool hasUtf8Bom = buffer.Length >= utf8Preamble.Length && utf8Preamble.SequenceEqual(buffer.Take(utf8Preamble.Length));

            // Se já tem BOM UTF-8, não faz nada
            if (hasUtf8Bom)
                return;

            // Tenta ler como UTF-8, se falhar, tenta como padrão do sistema e converte
            string texto;
            try
            {
                texto = File.ReadAllText(caminhoArquivo, Encoding.UTF8);
                // Se não houver caracteres inválidos, já está ok
                if (!texto.Contains("�"))
                    return;
            }
            catch
            {
                // Se falhar, tenta como padrão do sistema
                texto = File.ReadAllText(caminhoArquivo, Encoding.Default);
            }

            // Salva novamente em UTF-8 (sem BOM)
            File.WriteAllText(caminhoArquivo, texto, new UTF8Encoding(false));
        }

        public List<Atividade> LerAtividades()
        {
            var atividades = new List<Atividade>();
            try
            {
                var linhas = conteudo.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (var linha in linhas)
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        var campos = linha.Split(',');
                        Debug.WriteLine($"Linha: '{linha}' | Dia: '{(campos.Length > 0 ? campos[0] : "")}' | Nome: '{(campos.Length > 1 ? campos[1] : "")}' | Horário: '{(campos.Length > 2 ? campos[2] : "")}'");
                        if (campos.Length >= 3)
                        {
                            if (TryParseDiaSemanaPtBr(campos[0], out DayOfWeek dia) && TimeOnly.TryParse(campos[2], out TimeOnly horario))
                            {
                                Debug.WriteLine($"Dia convertido: {dia}");
                                var atividade = new Atividade
                                {
                                    DiaDaSemana = dia,
                                    Nome = campos[1],
                                    Horario = horario
                                };
                                atividades.Add(atividade);
                            }
                            else
                            {
                                Debug.WriteLine($"Falha ao converter dia ou horário: '{campos[0]}' / '{campos[2]}'");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar exibir as atividades: " + e.Message);
            }
            return atividades;
        }

        public List<Atividade> FiltrarAtividadesPorDia(DayOfWeek dia)
        {
            return LerAtividades()
                .Where(a => a.DiaDaSemana == dia)
                .OrderBy(a => a.Horario)
                .ToList();
        }

        public void AdicionarAtividade(Atividade atividade)
        {
            try
            {
                string diaSemanaPtBr = CulturaPadrao.DateTimeFormat.GetDayName(atividade.DiaDaSemana);
                diaSemanaPtBr = char.ToUpper(diaSemanaPtBr[0]) + diaSemanaPtBr.Substring(1);
                string linha = $"{diaSemanaPtBr},{atividade.Nome},{atividade.Horario:HH\\:mm}";

                // Verifica se o arquivo já possui conteúdo e adiciona uma quebra de linha antes, se necessário
                bool arquivoTemConteudo = new FileInfo(caminho).Length > 0;
                string prefixo = arquivoTemConteudo ? Environment.NewLine : string.Empty;

                File.AppendAllText(caminho, prefixo + linha, System.Text.Encoding.UTF8);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar adicionar a atividade: " + e.Message);
            }
        }

        public void DeletarAtividade(DayOfWeek dia, string nome, TimeOnly horario)
        {
            try
            {
                List<Atividade> lista = LerAtividades();
                var atividadeParaRemover = lista.Find(a => a.DiaDaSemana == dia && a.Nome == nome && a.Horario == horario);

                if (atividadeParaRemover != null)
                {
                    lista.Remove(atividadeParaRemover);
                    File.Delete(caminho);

                    using (var sw = new StreamWriter(caminho, false, Encoding.UTF8))
                    {
                        foreach (var atividade in lista)
                        {
                            string diaSemanaPtBr = CulturaPadrao.DateTimeFormat.GetDayName(atividade.DiaDaSemana);
                            diaSemanaPtBr = char.ToUpper(diaSemanaPtBr[0]) + diaSemanaPtBr.Substring(1);
                            string linha = $"{diaSemanaPtBr},{atividade.Nome},{atividade.Horario:HH\\:mm}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Atividade não encontrada.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar deletar a atividade: " + e.Message);
            }
        }

        public void UpdateAtividade(Atividade updatedAtividade, DayOfWeek oldDia, string oldNome, TimeOnly oldHorario)
        {
            try
            {
                List<Atividade> lista = LerAtividades();
                var atividadeParaAtualizar = lista.Find(a => a.DiaDaSemana == oldDia && a.Nome == oldNome && a.Horario == oldHorario);

                if (atividadeParaAtualizar != null)
                {
                    atividadeParaAtualizar.DiaDaSemana = updatedAtividade.DiaDaSemana;
                    atividadeParaAtualizar.Nome = updatedAtividade.Nome;
                    atividadeParaAtualizar.Horario = updatedAtividade.Horario;

                    File.Delete(caminho);

                    using (var sw = new StreamWriter(caminho, false, Encoding.UTF8))
                    {
                        foreach (var atividade in lista)
                        {
                            string diaSemanaPtBr = CulturaPadrao.DateTimeFormat.GetDayName(atividade.DiaDaSemana);
                            diaSemanaPtBr = char.ToUpper(diaSemanaPtBr[0]) + diaSemanaPtBr.Substring(1);
                            string linha = $"{diaSemanaPtBr},{atividade.Nome},{atividade.Horario:HH\\:mm}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Atividade não encontrada.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar atualizar a atividade: " + e.Message);
            }
        }

        public List<Atividade> OrdenarAtividadesPorHorario(List<Atividade> lista)
        {
            return lista.OrderBy(a => a.Horario).ToList();
        }

        private static bool TryParseDiaSemanaPtBr(string diaPtBr, out DayOfWeek dia)
        {
            string diaNormalizado = diaPtBr.Trim().ToLowerInvariant();

            var dias = new Dictionary<string, DayOfWeek>
            {
                { "domingo", DayOfWeek.Sunday },
                { "segunda-feira", DayOfWeek.Monday },
                { "segunda", DayOfWeek.Monday },
                { "terça-feira", DayOfWeek.Tuesday },
                { "terça", DayOfWeek.Tuesday },
                { "terca-feira", DayOfWeek.Tuesday },
                { "terca", DayOfWeek.Tuesday },
                { "quarta-feira", DayOfWeek.Wednesday },
                { "quarta", DayOfWeek.Wednesday },
                { "quinta-feira", DayOfWeek.Thursday },
                { "quinta", DayOfWeek.Thursday },
                { "sexta-feira", DayOfWeek.Friday },
                { "sexta", DayOfWeek.Friday },
                { "sábado", DayOfWeek.Saturday },
                { "sabado", DayOfWeek.Saturday }
            };

            if (dias.TryGetValue(diaNormalizado, out dia))
                return true;

            return Enum.TryParse(diaPtBr, true, out dia);
        }
    }
}