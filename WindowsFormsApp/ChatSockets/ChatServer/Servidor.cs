using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
	// Este delegate é necessário para especificar os parâmetros que estamos passando com o nosso evento
	public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

	class Servidor
	{
		// Esta hash table armazena os usuários e as conexões (acessados/consultado por usuário)
		public static Hashtable htUsuarios = new Hashtable(30); // Limite definido de 30 usuários
		// Esta hash table armazena os usuários e as conexões (acessados/consultado por conexão)
		public static Hashtable htConexoes = new Hashtable(30); // Limite definido de 30 conexões

		// Armazena o endereço IP passado
		private IPAddress enderecoIP;
		private int portaHost;
		private TcpClient tcpCliente;

		// O evento e o seu argumento irá notificar o formulário quando um usuário se conecta, desconecta, etc...
		public static event StatusChangedEventHandler StatusChanged;
		private static StatusChangedEventArgs e;

		// O construtor define o endereço IP para aquele retornado pela instanciação do objeto
		public Servidor(IPAddress endereco, int porta)
		{
			enderecoIP = endereco;
			portaHost = porta;
		}

		// A thread que ira tratar o escutdador de conexões
		private Thread thrListener;

		// O objeto TCP object que escuta as conexões
		private TcpListener tlsCliente;

		// Ira dizer ao laço while para manter o monitoramento das conexões
		bool ServRodando = false;

		public static void IncluiUsuario(TcpClient tcpUsuario, string strUsername)
		{
			// Primeiro inclui o nome e conexão associada para ambas as hash tables
			Servidor.htUsuarios.Add(strUsername, tcpUsuario);
			Servidor.htConexoes.Add(tcpUsuario, strUsername);

			// Informa a nova conexão para todos os usuários e para o formulário do servidor
			EnviaMensagemAdmin(htConexoes[tcpUsuario] + " entrou...");
		}

		// Remove o uuário das tabelas (hashtables)
		public static void RemoveUsuario(TcpClient tcpUsuario)
		{
            // Se o usuário existir
            if (htConexoes[tcpUsuario] != null)
            {
				// Primeiro mostra a informação e informa os outros usuários sobre a conexão
				EnviaMensagemAdmin(htConexoes[tcpUsuario] + " saiu...");

				// Remove o usuário da hash table
				Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
				Servidor.htConexoes.Remove(tcpUsuario);
			}
        }

		// Este evento é chamado quando queremos disparar o evento StatusChanged
		public static void OnStatusChanged(StatusChangedEventArgs e)
		{
			StatusChangedEventHandler statusHandler = StatusChanged;

            if (statusHandler != null)
            {
				// invoca o delegate
				statusHandler(null, e);
            }
        }

		// Envia mensagens administrativas
		public static void EnviaMensagemAdmin(string Mensagem)
		{
			StreamWriter swSenderSender;

			// Exibe primeiro na aplicação
			e = new StatusChangedEventArgs("Administrador: " + Mensagem);
			OnStatusChanged(e);

			// Cria um array de clientes TCPs do tamanho do número de clientes existentes
			TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];

			// Copia os objetos TcpCliente no array
			Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);
		
			// Percorre a lista de clientes TCP
			for (int i = 0; i < tcpClientes.Length; i++)
			{
				// Tenta enviar uma mensagem para cada cliente
				try
				{
                    // Se a mensagem estiver em branco ou a conexão for nula sai...
                    if (Mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
						continue;
                    }

					// Envia a mensagem para o usuário atual no laço
					swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
					swSenderSender.WriteLine("Administrador: " + Mensagem);	
					swSenderSender.Flush();
					swSenderSender = null;
				}
				catch 
				{
					// Se houver um problema, o usuário não existe, então remove-o
					RemoveUsuario(tcpClientes[i]);
				}
			}
		}

		// Envia mensagens de um usuário para todos os outros
		public static void EnviaMensagem(string Origem, string Mensagem)
		{
			StreamWriter swSenderSender;

			// Primeiro exibe a mensagem na aplicação
			e = new StatusChangedEventArgs(Origem + " disse: " + Mensagem);
			OnStatusChanged(e);

			// Cria um array de clientes TCPs do tamanho do número de clientes existentes
			TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];

			// Copia os objetos TcpClient no array
			Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

			// Percorre a lista de clientes TCP
			for (int i = 0; i < tcpClientes.Length; i++)
			{
				// Tenta enviar uma mensagem para cada cliente
				try
				{
					// Se a mensagem estiver em branco ou a conexão for nula sai...
					if (Mensagem.Trim() == "" || tcpClientes[i] == null)
					{
						continue;
					}

					// Envia a mensagem para o usuário atual no laço
					swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
					swSenderSender.WriteLine(Origem + " disse: " + Mensagem);
					swSenderSender.Flush();
					swSenderSender = null;
				}
				catch 
				{
					// Se houver um problema, o usuário não existe, então remove-o
					RemoveUsuario(tcpClientes[i]);
				}
			}
		}

		public void IniciaAtendimento()
		{
			try
			{
				// Pega o IP
				IPAddress ipaLocal = enderecoIP;
				int portaLocal = portaHost;

				// Cria um objeto TCP listener usando o IP do servidor e porta definidas
				tlsCliente = new TcpListener(ipaLocal, portaLocal);
				
				// Inicia o TCP listener e escuta as conexões
				tlsCliente.Start();

				// O laço while verifica se o servidor esta rodando antes de checar as conexões
				ServRodando = true;

				// Inicia um nova tread que hospeda o listener 
				thrListener = new Thread(MantemAtendimento);
			}
			catch (Exception ex)
			{

			}
		}

		private void MantemAtendimento()
		{
            // Enquanto o servidor estiver rodando
            while (ServRodando)
            {
                // Aceita uma conexão pendente
				tcpCliente = tlsCliente.AcceptTcpClient();

				// Cria uma nova instância da conexão
				// Conexao new Connection = new Conexao(tcpCliente);
            }
        }
	}
}
