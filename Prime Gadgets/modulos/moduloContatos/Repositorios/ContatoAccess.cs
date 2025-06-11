#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Prime_Gadgets.modulos.moduloContatos;
using System.Net.NetworkInformation;

namespace Prime_Gadgets.modulos.moduloContatos
{
    public class ContatoAccess
    {

        public string caminhoRelativo = "modulos\\moduloContatos\\Repositorios\\Contatos.prime";
        public string caminho;
        public string conteudo;

        public ContatoAccess()
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
                conteudo = File.ReadAllText(caminho);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar ler o arquivo Contatos.prime: " + e.Message);
                conteudo = string.Empty;
            }
        }

        public List<Contatos> LerContatos()
        {
            var contatos = new List<Contatos>();
            try
            {
                //Divide o arquivo .prime em linhas
                var linhas = conteudo.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                contatos = OrdenarContatosPorId(contatos);
                foreach (var linha in linhas)
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        //Divide as linhas em campos separados pela virgula
                        //A função split gera um array de strings com cada campo que serao os atributos de um instancia da classe Contatos
                        var campos = linha.Split(',');

                        if (campos.Length == 5)
                        {
                            var contato = new Contatos
                            {
                                Id = int.Parse(campos[0]),
                                Nome = campos[1],
                                Sobrenome = campos[2],
                                Telefone = campos[3],
                                Email = campos[4]
                            };

                            contatos.Add(contato);
                        }
                    }
                }
                // Ordena a lista de contatos por ID
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar exibir os contatos: " + e.Message);
            }

            return contatos;
        }

        public void AdicionarContato(Contatos contato)
        {
            try
            {
                // Deixa os valores no padrão do arquivo
                string linha = $"{contato.Id},{contato.Nome},{contato.Sobrenome},{contato.Telefone},{contato.Email}";

                // Adiciona a linha ao arquivo
                File.AppendAllText(caminho, linha + Environment.NewLine);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar adicionar o contato: " + e.Message);
            }
        }
        public int LerUltimoId()
        {
            try
            {
                var linhas = File.ReadAllLines(caminho);
                if (linhas.Length == 0)
                {
                    return 0; // Retorna 0 se o arquivo estiver vazio
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
                return -1; // Retorna -1 em caso de erro
            }
        }
        public void DeleteContato(int id)
        {
            try
            {
                List<Contatos> lista = LerContatos();
                var contatoParaRemover = lista.Find(c => c.Id == id);

                if (contatoParaRemover != null)
                {
                    // Remove o contato da lista
                    lista.Remove(contatoParaRemover);

                    // Deleta o arquivo existente
                    File.Delete(caminho);
                    lista = OrdenarContatosPorId(lista);

                    // Cria novamente o arquivo e adiciona a nova lista de contatos
                    using (StreamWriter sw = File.CreateText(caminho))
                    {
                        foreach (var contato in lista)
                        {
                            string linha = $"{contato.Id},{contato.Nome},{contato.Sobrenome},{contato.Telefone},{contato.Email}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contato não encontrado.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar deletar o contato: " + e.Message);
            }
        }
        public void UpdateContato(Contatos updatedContato,int oldId)
        {
            try
            {
                List<Contatos> lista = LerContatos();
                var contatoParaAtualizar = lista.Find(c => c.Id == oldId);

                if (contatoParaAtualizar != null)
                {
                    // Atualiza as propriedades do contato encontrado
                    contatoParaAtualizar.Id = updatedContato.Id;
                    contatoParaAtualizar.Nome = updatedContato.Nome;
                    contatoParaAtualizar.Sobrenome = updatedContato.Sobrenome;
                    contatoParaAtualizar.Telefone = updatedContato.Telefone;
                    contatoParaAtualizar.Email = updatedContato.Email;

                    lista = OrdenarContatosPorId(lista);

                    // Deleta o arquivo existente
                    File.Delete(caminho);

                    // Cria novamente o arquivo e adiciona a nova lista de contatos
                    using (StreamWriter sw = File.CreateText(caminho))
                    {
                        foreach (var contato in lista)
                        {
                            string linha = $"{contato.Id},{contato.Nome},{contato.Sobrenome},{contato.Telefone},{contato.Email}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contato não encontrado.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar atualizar o contato: " + e.Message);
            }
        }
        public List<Contatos> OrdenarContatosPorId(List<Contatos> lista)
        {
            return lista.OrderBy(c => c.Id).ToList();
        }
    }
}