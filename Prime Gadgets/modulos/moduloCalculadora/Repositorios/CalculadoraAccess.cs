using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prime_Gadgets.modulos.moduloSenhas;

namespace Prime_Gadgets.modulos.moduloCalculadora
{
    public class CalculadoraAccess
    {
        public string caminhoRelativo = "modulos\\moduloCalculadora\\Repositorios\\HistoricoCalculadora.prime";
        public string caminho;
        public string conteudo;

        public CalculadoraAccess()
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
                MessageBox.Show("Problema ao tentar ler o arquivo HistoricoCalculadora.prime: " + e.Message);
                conteudo = string.Empty;
            }
        }
        public List<Contas> LerHistorico()
        {
            var contas = new List<Contas>();
            try
            {
                var linhas = conteudo.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (var linha in linhas)
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        var campos = linha.Split(',');
                        if (campos.Length == 5)
                        {
                            var conta = new Contas
                            {
                                Id = int.Parse(campos[0]),
                                Numero1 = double.Parse(campos[1]),
                                Operador = campos[2],
                                Numero2 = double.Parse(campos[3]),
                                Resultado = double.Parse(campos[4])
                            };
                            contas.Add(conta);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar ler o arquivo HistoricoCalculadora.prime: " + e.Message);
            }
            return contas;
        }
        public void AdicionarConta(Contas conta)
        {
            try
            {
                string linha = $"{conta.Id},{conta.Numero1},{conta.Operador},{conta.Numero2},={conta.Resultado}";
                File.AppendAllText(caminho, linha + Environment.NewLine);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar adicionar a conta ao histórico: " + e.Message);
            }
        }
        public void DeleteConta(int id)
        {
            try
            {
                List<Contas> lista = LerHistorico();
                var contaParaRemover = lista.Find(s => s.Id == id);

                if (contaParaRemover != null)
                {
                    lista.Remove(contaParaRemover);
                    File.Delete(caminho);
                    lista = OrdenarContasPorId(lista);

                    using (StreamWriter sw = File.CreateText(caminho))
                    {
                        foreach (var conta in lista)
                        {
                            string linha = $"{conta.Id},{conta.Numero1},{conta.Operador},{conta.Numero2},={conta.Resultado}";
                            sw.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Conta não encontrada.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar deletar a conta: " + e.Message);
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
        public List<Contas> OrdenarContasPorId(List<Contas> lista)
        {
            return lista.OrderBy(s => s.Id).ToList();
        }
    }
}
