#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Prime_Gadgets.modulos.moduloContatos.Modelos;

namespace Prime_Gadgets.modulos.moduloContatos.Repositorios
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
                // Esta função somada com a próxima linha de código, serve para encontrar o diretório do arquivo pois
                // o visual studio tem um diretório meio estranho para rodar o projeto
                string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

                //Para usar os caminho relativos basta usar esta variavel e alterar o caminhoRelativo com a mesma estrutura de pastas que voce vê no visual code
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
                Console.WriteLine("Problema ao tentar ler o arquivo Contatos.prime: " + e.Message);
                conteudo = string.Empty;
            }
        }

        public List<Contatos> exibirContatos()
        {
            var contatos = new List<Contatos>();
            try
            {
                //Divide o arquivo .prime em linhas
                var linhas = conteudo.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

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
            }
            catch (Exception e)
            {
                Console.WriteLine("Problema ao tentar exibir os contatos: " + e.Message);
            }

            return contatos;
        }
    }
}