using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Gadgets.modulos.moduloSenhas
{
    class Criptografia
    {
        public static void CriptografarArquivo(string caminhoArquivo, string senha)
        {
            using (Aes aes = Aes.Create())
            {
                // Gera chave e IV com base na senha
                byte[] chave = GerarChave(senha);
                byte[] iv = aes.IV;

                using (FileStream fsCriptografado = new FileStream(caminhoArquivo + ".aes", FileMode.Create))
                {
                    // Grava o IV no início do arquivo
                    fsCriptografado.Write(iv, 0, iv.Length);

                    using (CryptoStream cs = new CryptoStream(fsCriptografado, aes.CreateEncryptor(chave, iv), CryptoStreamMode.Write))
                    using (FileStream fsOriginal = new FileStream(caminhoArquivo, FileMode.Open))
                    {
                        fsOriginal.CopyTo(cs);
                        Console.WriteLine("Arquivo criptografado com sucesso!");
                    }
                }
            }
        }
        public static void DescriptografarArquivo(string caminhoArquivo, string senha)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] chave = GerarChave(senha);

                using (FileStream fsCriptografado = new FileStream(caminhoArquivo, FileMode.Open))
                {
                    // Lê o IV do arquivo criptografado
                    byte[] iv = new byte[16];
                    fsCriptografado.Read(iv, 0, iv.Length);

                    using (CryptoStream cs = new CryptoStream(fsCriptografado, aes.CreateDecryptor(chave, iv), CryptoStreamMode.Read))
                    using (FileStream fsDescriptografado = new FileStream(caminhoArquivo.Replace(".aes", "_dec.txt"), FileMode.Create))
                    {
                        cs.CopyTo(fsDescriptografado);
                        Console.WriteLine("Arquivo descriptografado com sucesso!");
                    }
                }
            }
        }
        private static byte[] GerarChave(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
            }
        }
    }
}
