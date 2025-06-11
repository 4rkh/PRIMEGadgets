using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using Prime_Gadgets.modulos.moduloRotina;
using System.Text; // Necessário para Encoding

namespace Prime_Gadgets.modulos.moduloLembretes
{
        public class LembreteAccess
    {
        public string caminhoRelativo = "modulos\\moduloLembretes\\Repositorios\\Lembrete.prime";
        public string caminho;
        public string conteudo;

        public LembreteAccess()
        {
            try
            {
                string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                caminho = Path.Combine(diretorioProjeto, caminhoRelativo);

                // Garante que o diretório existe
                Directory.CreateDirectory(Path.GetDirectoryName(caminho));

                if (!File.Exists(caminho))
                {
                    File.Create(caminho).Dispose();
                    conteudo = string.Empty;
                }
                conteudo = File.ReadAllText(caminho, Encoding.UTF8);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar ler o arquivo Lembrete.prime: " + e.Message);
                conteudo = string.Empty;
            }
        }

        public List<Lembrete> LerLembretes()
        {
            var lembretes = new List<Lembrete>();
            try
            {
                var linhas = conteudo.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (var linha in linhas)
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        var campos = linha.Split(',');
                        if (campos.Length >= 2)
                        {
                            if (DateOnly.TryParse(campos[0], out DateOnly dia))
                            {
                                lembretes.Add(new Lembrete
                                {
                                    Dia = dia,
                                    Nome = campos[1]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar exibir os lembretes: " + e.Message);
            }
            return lembretes.OrderBy(d => d.Dia).ToList();
        }

        public void AdicionarLembrete(Lembrete lembrete)
        {
            try
            {
                string linha = $"{lembrete.Dia:yyyy-MM-dd},{lembrete.Nome}";
                bool arquivoTemConteudo = new FileInfo(caminho).Length > 0;
                string prefixo = arquivoTemConteudo ? Environment.NewLine : string.Empty;
                File.AppendAllText(caminho, prefixo + linha, Encoding.UTF8);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar adicionar o lembrete: " + e.Message);
            }
        }

        public void DeletarLembrete(DateOnly dia, string nome)
        {
            try
            {
                List<Lembrete> lista = LerLembretes();
                var lembreteParaRemover = lista.Find(l => l.Dia == dia && l.Nome == nome);

                if (lembreteParaRemover != null)
                {
                    lista.Remove(lembreteParaRemover);
                    File.Delete(caminho);

                    using (var sw = new StreamWriter(caminho, false, Encoding.UTF8))
                    {
                        foreach (var lembrete in lista)
                        {
                            string linha = $"{lembrete.Dia:yyyy-MM-dd},{lembrete.Nome}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lembrete não encontrado.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar deletar o lembrete: " + e.Message);
            }
        }

        public void UpdateLembrete(Lembrete updatedLembrete, DateOnly oldDia, string oldNome)
        {
            try
            {
                List<Lembrete> lista = LerLembretes();
                var lembreteParaAtualizar = lista.Find(l => l.Dia == oldDia && l.Nome == oldNome);

                if (lembreteParaAtualizar != null)
                {
                    lembreteParaAtualizar.Dia = updatedLembrete.Dia;
                    lembreteParaAtualizar.Nome = updatedLembrete.Nome;

                    File.Delete(caminho);

                    using (var sw = new StreamWriter(caminho, false, Encoding.UTF8))
                    {
                        foreach (var lembrete in lista)
                        {
                            string linha = $"{lembrete.Dia:yyyy-MM-dd},{lembrete.Nome}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lembrete não encontrado.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar atualizar o lembrete: " + e.Message);
            }
        }
    }
}