using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoServer
{
	class FTServer
	{
		static IPEndPoint ipEnd_servidor;
		static Socket sock_Servidor;
		public static string EnderecoIP = "127.0.0.1";
		public static int PortaHost  = 1000;
		public static string PastaRepepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/";
		public static ListBox ListaMensagem;

		public static void IniciarServidor()
		{
			try
			{
				ipEnd_servidor = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);
				sock_Servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
				sock_Servidor.Bind(ipEnd_servidor);
			}
			catch (Exception ex)
			{
				ListaMensagem.Invoke(new Action(() =>
				{
					ListaMensagem.Items.Add("Erro ao iniciar servidor : " + ex.Message);
					ListaMensagem.SetSelected(ListaMensagem.Items.Count -1, true);
				}));

				return;
			}

			try
			{
				sock_Servidor.Listen(1000);
				ListaMensagem.Invoke(new Action(() =>
				{
					ListaMensagem.Items.Add("Servidor em atendimento e aguardando para receber arquivo... ");
					ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
				}));

				Socket clientSock = sock_Servidor.Accept();
				clientSock.ReceiveBufferSize = 16384;

				byte[] dadosCliene = new byte[1024 * 50000];
				int tamanhoBytesRecebidos = clientSock.Receive(dadosCliene, dadosCliene.Length, 0);
				int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliene, 0);
				string nomeArquivo = Encoding.UTF8.GetString(dadosCliene, 4, tamanhoNomeArquivo);

				BinaryWriter bWriter = new BinaryWriter(File.Open(PastaRepepcaoArquivos + nomeArquivo, FileMode.Append));
				bWriter.Write(dadosCliene, 4 + tamanhoNomeArquivo, tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo);

				while (tamanhoBytesRecebidos > 0)
				{
					tamanhoBytesRecebidos = clientSock.Receive(dadosCliene, dadosCliene.Length, 0);

                    if (tamanhoBytesRecebidos == 0)
                    {
						bWriter.Close();
                    }
					else
					{
						bWriter.Write(dadosCliene, 0, tamanhoBytesRecebidos);
					}

					ListaMensagem.Invoke(new Action(() =>
					{
						ListaMensagem.Items.Add("Arquivo recebido e arquivado! [" + nomeArquivo + "]");
						ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
					}));

					bWriter.Close();
					clientSock.Close();
				}
			}
			catch (SocketException ex)
			{
				ListaMensagem.Invoke(new Action(() =>
				{
					ListaMensagem.Items.Add("Erro ao receber arquivo: " + ex.Message);
					ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
				}));
			}
			finally
			{
				sock_Servidor.Close();
				sock_Servidor.Dispose();
				IniciarServidor();
			}
		}
	}
}
