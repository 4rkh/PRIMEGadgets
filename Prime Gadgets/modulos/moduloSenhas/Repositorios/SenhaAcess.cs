using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Prime_Gadgets.modulos.moduloSenhas;
using System.Net.NetworkInformation;

namespace Prime_Gadgets.modulos.moduloSenhas
{
    public class SenhaAcess
    {

        public string caminhoRelativo = "modulos\\moduloSenhas\\Repositorios\\Senhas.prime";
        public string caminho;
        public string conteudo;

        public SenhaAcess()
        {
            try
            {
                string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                caminho = Path.Combine(diretorioProjeto, caminhoRelativo);

                if (!File.Exists(caminho))
                {
                    File.Create(caminho).Dispose();
                    conteudo = string.Empty;
                }
                conteudo = File.ReadAllText(caminho);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao ler o arquivo Senhas.prime: " + e.Message);
                conteudo = string.Empty;
            }
        }

        public List<Senhas> LerSenhas()
        {
            var senhas = new List<Senhas>();
            try
            {
                var linhas = conteudo.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                senhas = OrdenarSenhasPorId(senhas);
                foreach (var linha in linhas)
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        var campos = linha.Split(',');

                        if (campos.Length == 5)
                        {
                            var senha = new Senhas
                            {
                                Id = int.Parse(campos[0]),
                                NomeDeUsuario = campos[1],
                                Email = campos[2],
                                Senha = campos[3],
                                Origem = campos[4]
                            };
                            senhas.Add(senha);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao exibir as senhas: " + e.Message);
            }

            return senhas;
        }

        public void AdicionarSenha(Senhas senha)
        {
            try
            {
                string linha = $"{senha.Id},{senha.NomeDeUsuario},{senha.Email},{senha.Senha},{senha.Origem}";
                File.AppendAllText(caminho, linha + Environment.NewLine);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao adicionar a senha: " + e.Message);
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
                MessageBox.Show("Erro ao ler o último ID: " + e.Message);
                return -1;
            }
        }

        public List<Senhas> OrdenarSenhasPorId(List<Senhas> lista)
        {
            return lista.OrderBy(s => s.Id).ToList();
        }
    }
}
