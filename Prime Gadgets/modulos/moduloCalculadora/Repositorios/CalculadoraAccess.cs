using Prime_Gadgets.modulos.moduloSenhas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                var linhas = File.ReadAllLines(caminho);
                int idAtual = 1; // Se ainda quiser dar um ID incremental interno

                foreach (var linha in linhas)
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        string expressao = linha.Trim(); // Agora o arquivo não contém mais ID

                        // Expressão regex para capturar: número1, operador, número2 e resultado
                        var match = Regex.Match(expressao, @"([0-9.,]+)\s*([\+\-\*/])\s*([0-9.,]+)\s*=\s*([0-9.,]+)");

                        if (match.Success)
                        {
                            var conta = new Contas
                            {
                                Id = idAtual++,
                                Numero1 = double.Parse(match.Groups[1].Value.Replace(",", "."), CultureInfo.InvariantCulture),
                                Operador = match.Groups[2].Value,
                                Numero2 = double.Parse(match.Groups[3].Value.Replace(",", "."), CultureInfo.InvariantCulture),
                                Resultado = double.Parse(match.Groups[4].Value.Replace(",", "."), CultureInfo.InvariantCulture)
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
                string linha = $"{conta.Numero1} {conta.Operador} {conta.Numero2} = {conta.Resultado}";
                File.AppendAllText(caminho, linha + Environment.NewLine);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar adicionar a conta ao histórico: " + e.Message);
            }
        }

        public void DeleteHistorico(int id)
        {
            try
            {
                File.WriteAllText(caminho, string.Empty);
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao tentar deletar histórico: " + e.Message);
            }
        }
    }
}
