using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CriptoFile
{
	class Criptografia
	{
		// Declaração de CspParameters e RsaCryptoServiceProvider
		// Objetos com escopo global na classe.
		public static CspParameters cspp;
		public static RSACryptoServiceProvider rsa;

		// Caminhos variáveis para a fonte, pasta de criptografia
		// E pasta de descriptografia
		private static string _encrFolder;

		public static string EncrFolder
		{
			get 
			{ 
				return _encrFolder; 
			}
			set 
			{ 
				_encrFolder = value;
				PubKeyFile = _encrFolder + "rsaPublicKey.txt";
			}
		}

		public static string DecrFolder { get; set; }
		public static string SrcFolder { get; set; }

		// Arquivo de chave pública 
		private static string PubKeyFile = EncrFolder + "rsaPublicKey.txt";

		// Chave contendo o nome para private/public key value pair.
		public static string keyName;
		
		// Metodo para criar a chave publica
		public static string CreateAsmKeys()
		{
			string result = "";

            // Armazena uma key pair na key container.
            if (string.IsNullOrEmpty(keyName))
            {
				result = "Chave pública não definida";
				return result;
            }

			cspp.KeyContainerName = keyName;
			rsa = new RSACryptoServiceProvider(cspp);
			rsa.PersistKeyInCsp = true;
            
			if (rsa.PublicOnly)
            {
				result = "Key: " + cspp.KeyContainerName + " - Somente Pública";                
            }
			else
			{
				result = "Key: " + cspp.KeyContainerName + " - Key Par Completa";
			}

            return result;
		}

		// Metodo para Exportar a chave pública em um arquivo
		public static bool ExportPublicKey()
		{
			bool result = true;

            if (rsa == null)
            {
				return false;
            }

            if (!Directory.Exists(EncrFolder))
            {
                Directory.CreateDirectory(EncrFolder);
            }

			StreamWriter sw = new StreamWriter(PubKeyFile, false);
			try
			{
				sw.Write(rsa.ToXmlString(false));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				result = false;
			}
			finally
			{
				sw.Close();
			}

			return result;
        }

		// Metodo para Importar a chave pública de um arquivo
		public static string ImportPublicKey()
		{
			string result = "";

            if (!File.Exists(PubKeyFile))
            {
				result = "Arquivo de chave pública não encontrado.";
				return result;
            }

            if (string.IsNullOrEmpty(keyName))
            {
				result = "Chave pública não definida";
				return result;
            }

			StreamReader sr = new StreamReader(PubKeyFile);

			try
			{
				cspp.KeyContainerName = keyName;
				rsa = new RSACryptoServiceProvider(cspp);
				string keytxt = sr.ReadToEnd();
				rsa.FromXmlString(keytxt);
				rsa.PersistKeyInCsp = true;
                
				if (rsa.PublicOnly)
                {
					result = "Key: " + cspp.KeyContainerName + " - Somente Pública";
                }
				else
				{
					result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
				}
            }
			catch(Exception ex)
			{
				result = ex.Message;
				Console.WriteLine(ex.Message);
			}
			finally
			{
				sr.Close();
			}

            return result;
		}

		// Metodo para criar uma chave privada a partir de um valor definido
		public static string GetPrivateKey()
		{
			string result = "";

            if (string.IsNullOrEmpty(keyName))
            {
				result = "Chave privada não definida";
				return result;
            }

			cspp.KeyContainerName = keyName;
			rsa = new RSACryptoServiceProvider(cspp);
			rsa.PersistKeyInCsp = true;

			if (rsa.PublicOnly)
			{
				result = "Key: " + cspp.KeyContainerName + " - Somente Pública";
			}
			else
			{
				result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
			}

			return result;
        }

		// Metodo para criptografar um arquivo
		public static string EncryptFile(string infile)
		{
			// Criar uma instancia de Aes para criptografia simétrica dos dados.
			Aes aes = Aes.Create();
			ICryptoTransform transform = aes.CreateEncryptor();

			// Use RSACRyptoServiceProvider para criptografar a chave AES.

			byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);

			// Crie matrizes de bytes para conter os valores de comprimento da chave e IV
			byte[] lenK = new byte[4];
			byte[] lenIV = new byte[4];

			int Ikey = keyEncrypted.Length;
			lenK = BitConverter.GetBytes(Ikey);
			int IIV = aes.IV.Length;
			lenIV = BitConverter.GetBytes(IIV);

			int startFileName = infile.LastIndexOf("\\") + 1;
			string outFile = EncrFolder + infile.Substring(startFileName) + ".enc";
			
			try
			{
				using(FileStream outFs = new FileStream(outFile, FileMode.Create))
				{
					outFs.Write(lenK, 0, 4);
					outFs.Write(lenIV, 0, 4);
					outFs.Write(keyEncrypted, 0, Ikey);
					outFs.Write(aes.IV, 0, IIV);

					// Agora escreva o texto cifrado usando um CryptoStream para criptografar.
					using(CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Read))
					{
						// Ao criptografar um pedaço por vez, você pode economizar memória
						int count = 0;
						int offset = 0;

						// blockSizeBytes pode ter qualquer tamanho arbitrario.
						int blockSizeBytes = aes.BlockSize / 0;
						byte[] data = new byte[blockSizeBytes];
						int bytesRead = 0;

						using (FileStream inFs = new FileStream(infile, FileMode.Open))
						{
							do
							{
								count = inFs.Read(data, 0, blockSizeBytes);
								offset += count;
								outStreamEncrypted.Write(data, 0, count);
								bytesRead += blockSizeBytes;
							} while (count > 0);
							inFs.Close();
						}
						outStreamEncrypted.FlushFinalBlock();
						outStreamEncrypted.Close();
					}
					outFs.Close();
				}
			}
			catch (Exception ex)
			{
				return ex.Message;
			}

			return $"Arquivo criptografado. \n Origem: {infile}\n Destino: {outFile}";
		}

		// Metodo para descriptografar um arquivo

	}
}
