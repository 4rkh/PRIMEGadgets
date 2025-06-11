#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloCalendario
{
    public class EventoAccess
    {
        public string caminhoRelativo = "modulos\\moduloCalendario\\Repositorios\\Eventos.prime";
        public string caminho;
        public string conteudo;

        public EventoAccess()
        {
            try
            {
                string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                caminho = Path.Combine(diretorioProjeto, caminhoRelativo);

                Directory.CreateDirectory(Path.GetDirectoryName(caminho));
                if (!File.Exists(caminho))
                {
                    File.Create(caminho).Dispose();
                    conteudo = string.Empty;
                }
                conteudo = File.ReadAllText(caminho);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar ler o arquivo Eventos.prime: " + e.Message);
                conteudo = string.Empty;
            }
        }

        public List<Evento> LerEventos()
        {
            var eventos = new List<Evento>();
            try
            {
                // Leia o conteúdo do arquivo sempre que for chamado
                string conteudoAtual = File.ReadAllText(caminho);
                var linhas = conteudoAtual.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                eventos = OrdenarEventosPorId(eventos);
                foreach (var linha in linhas)
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        var campos = linha.Split(',');

                        if (campos.Length == 4)
                        {
                            var evento = new Evento
                            {
                                Id = int.Parse(campos[0]),
                                Data = DateTime.Parse(campos[1]),
                                Local = campos[2],
                                Descricao = campos[3]
                            };

                            eventos.Add(evento);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar exibir os eventos: " + e.Message);
            }

            return eventos;
        }

        public void AdicionarEvento(Evento evento)
        {
            try
            {
                string linha = $"{evento.Id},{evento.Data:yyyy-MM-dd},{evento.Local},{evento.Descricao}";
                File.AppendAllText(caminho, linha + Environment.NewLine);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar adicionar o evento: " + e.Message);
            }
        }

        public int LerUltimoId()
        {
            try
            {
                var linhas = File.ReadAllLines(caminho);
                if (linhas.Length == 0)
                {
                    return 0;
                }

                var ultimaLinha = linhas[^1];
                var match = Regex.Match(ultimaLinha, @"^(\d+),");

                if (match.Success)
                {
                    return int.Parse(match.Groups[1].Value);
                }
                else
                {
                    throw new Exception("Formato de linha inválido.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar ler o último ID do arquivo: " + e.Message);
                return -1;
            }
        }

        public void DeleteEvento(int id)
        {
            try
            {
                List<Evento> lista = LerEventos();
                var eventoParaRemover = lista.Find(e => e.Id == id);

                if (eventoParaRemover != null)
                {
                    lista.Remove(eventoParaRemover);

                    File.Delete(caminho);
                    lista = OrdenarEventosPorId(lista);

                    using (StreamWriter sw = File.CreateText(caminho))
                    {
                        foreach (var evento in lista)
                        {
                            string linha = $"{evento.Id},{evento.Data:yyyy-MM-dd},{evento.Local},{evento.Descricao}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Evento não encontrado.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar deletar o evento: " + e.Message);
            }
        }

        public void UpdateEvento(Evento updatedEvento, int oldId)
        {
            try
            {
                List<Evento> lista = LerEventos();
                var eventoParaAtualizar = lista.Find(e => e.Id == oldId);

                if (eventoParaAtualizar != null)
                {
                    eventoParaAtualizar.Id = updatedEvento.Id;
                    eventoParaAtualizar.Data = updatedEvento.Data;
                    eventoParaAtualizar.Local = updatedEvento.Local;
                    eventoParaAtualizar.Descricao = updatedEvento.Descricao;

                    lista = OrdenarEventosPorId(lista);

                    File.Delete(caminho);

                    using (StreamWriter sw = File.CreateText(caminho))
                    {
                        foreach (var evento in lista)
                        {
                            string linha = $"{evento.Id},{evento.Data:yyyy-MM-dd},{evento.Local},{evento.Descricao}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Evento não encontrado.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar atualizar o evento: " + e.Message);
            }
        }

        public List<Evento> OrdenarEventosPorId(List<Evento> lista)
        {
            return lista.OrderBy(e => e.Id).ToList();
        }
    }
}