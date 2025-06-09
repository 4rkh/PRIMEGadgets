using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prime_Gadgets.modulos.moduloSenhas
{
    public class Criptografia
    {
        public string caminhoRelativo = "modulos\\moduloSenhas\\Repositorios\\Senhas.prime";
        public string caminho;
        public string conteudo;
        private string chavePath => Path.Combine(Path.GetDirectoryName(caminho), "chave.dat");

        private byte[] key;
        private byte[] iv;

        public Criptografia()
        {
            try
            {
                string diretorioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                caminho = Path.Combine(diretorioProjeto, caminhoRelativo);
                CarregarChaveIV(); // <- Aqui
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inicializar: {ex.Message}");
            }
        }


        /// <summary>
        /// Criptografa um arquivo usando AES.
        /// </summary>
        public void EncryptFile(string inputFile, string outputFile)
        {
            try
            {
                using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (Aes aes = Aes.Create())
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                {
                    inputFileStream.CopyTo(cryptoStream);
                }
                File.Delete(inputFile); // Remove o arquivo original após criptografar
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Erro de criptografia: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro de IO ao criptografar arquivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado ao criptografar arquivo: {ex.Message}");
            }

        }

        /// <summary>
        /// Descriptografa um arquivo usando AES.
        /// </summary>
        public void DecryptFile(string inputFile, string outputFile)
        {
            try
            {
                using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (Aes aes = Aes.Create())
                using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputFileStream);
                }
                File.Delete(inputFile); // Remove o arquivo criptografado após descriptografar
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Erro de criptografia: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro de IO ao descriptografar arquivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado ao descriptografar arquivo: {ex.Message}");
            }
        }

        /// <summary>
        /// Gera uma chave e IV seguros para uso com AES.
        /// </summary>
        public void GerarChaveIV()
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    this.key = aes.Key;
                    this.iv = aes.IV;
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Erro ao gerar chave/IV: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado ao gerar chave/IV: {ex.Message}");
            }
        }
        public void SalvarChaveIV()
        {
            try
            {
                string base64Key = Convert.ToBase64String(key);
                string base64IV = Convert.ToBase64String(iv);
                File.WriteAllLines(chavePath, new[] { base64Key, base64IV });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar chave/IV: {ex.Message}");
            }
        }

        public void CarregarChaveIV()
        {
            try
            {
                if (File.Exists(chavePath))
                {
                    string[] linhas = File.ReadAllLines(chavePath);
                    if (linhas.Length >= 2)
                    {
                        key = Convert.FromBase64String(linhas[0]);
                        iv = Convert.FromBase64String(linhas[1]);
                    }
                    else
                    {
                        Console.WriteLine("Arquivo de chave/IV inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Arquivo de chave/IV não encontrado. Gerando novos...");
                    GerarChaveIV();
                    SalvarChaveIV();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar chave/IV: {ex.Message}");
            }
        }
    }
}
