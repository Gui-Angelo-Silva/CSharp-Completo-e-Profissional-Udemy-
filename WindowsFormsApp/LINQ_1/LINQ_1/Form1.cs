using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
	public partial class Form1 : Form
	{
		List<string> lista_nome;
		List<int> lista_numeros;
		Dictionary<string, double> lista_produtos;
		Dictionary<string, string> lista_estado;

		public Form1()
		{
			InitializeComponent();

			#region Lista de Nomes
			lista_nome = new List<string>();
			lista_nome.Add("Guilherme");
			lista_nome.Add("Bernardo");
			lista_nome.Add("Carlos");
			lista_nome.Add("Diego");
			lista_nome.Add("Eduardo");
			lista_nome.Add("Fernando");
			lista_nome.Add("Gustavo");
			lista_nome.Add("Hugo");
			lista_nome.Add("Igor");
			lista_nome.Add("João");
			lista_nome.Add("Lucas");
			lista_nome.Add("Mateus");
			lista_nome.Add("Nuno");
			lista_nome.Add("Paulo");
			lista_nome.Add("Rodrigo");
			#endregion

			#region Lista de Números
			lista_numeros = new List<int>();
			lista_numeros.Add(10);
			lista_numeros.Add(25);
			lista_numeros.Add(30);
			lista_numeros.Add(45);
			lista_numeros.Add(50);
			lista_numeros.Add(65);
			lista_numeros.Add(70);
			lista_numeros.Add(85);
			lista_numeros.Add(90);
			lista_numeros.Add(105);
			lista_numeros.Add(110);
			lista_numeros.Add(120);
			lista_numeros.Add(130);
			lista_numeros.Add(140);
			lista_numeros.Add(150);
			#endregion

			#region Lista de Produtos
			lista_produtos = new Dictionary<string, double>();
			lista_produtos.Add("Maçã", 2.50);
			lista_produtos.Add("Banana", 1.80);
			lista_produtos.Add("Laranja", 3.00);
			lista_produtos.Add("Abacaxi", 5.50);
			lista_produtos.Add("Melancia", 8.00);
			lista_produtos.Add("Uva", 4.20);
			lista_produtos.Add("Pera", 3.50);
			lista_produtos.Add("Morango", 6.00);
			lista_produtos.Add("Limão", 2.00);
			lista_produtos.Add("Manga", 4.50);
			lista_produtos.Add("Kiwi", 3.80);
			lista_produtos.Add("Pêssego", 5.20);
			lista_produtos.Add("Cereja", 7.50);
			lista_produtos.Add("Ameixa", 4.80);
			lista_produtos.Add("Pitaya", 6.50);
			#endregion

			#region Lista de Estado
			lista_estado = new Dictionary<string, string>();
			lista_estado.Add("Rio de Janeiro", "Brasil");
			lista_estado.Add("New York", "Estados Unidos");
			lista_estado.Add("São Paulo", "Brasil");
			lista_estado.Add("Porto", "Portugal");
			lista_estado.Add("Lisboa", "Portugal");
			lista_estado.Add("Bahia", "Brasil");
			lista_estado.Add("Washington", "Estados Unidos");
			lista_estado.Add("Algarve", "Portugal");
			#endregion

		}

		private void btnExecutar_Click(object sender, EventArgs e)
		{
			lista.Items.Clear();

			// Método Comum

			//foreach (int num in lista_numeros)
			//{
			//	if (num % 2 == 0)
			//	{
			//		lista.Items.Add(num);
			//	}
			//}

			// Obter a fonte dos dados.
			// Criar a consulta.
			// Executar a consulta.

			// Utilizando o LINQ

			//IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;

			//foreach (int n in res)
			//{
			//	lista.Items.Add(n);
			//}

			string txt = txtConsultar.Text;

			IEnumerable<string> res2 = from nome in lista_nome
									   where nome.StartsWith(txt)
									   select nome;

			// Converte o retorno para Array
			lista.Items.AddRange(res2.ToArray());
		}

		private void btnWhere_Click(object sender, EventArgs e)
		{
			lista.Items.Clear();
			// Operador de Filtragem, a clausula where

			string txt = txtConsultar.Text.ToLower();

			var res = from nome in lista_nome
					  where nome.ToLower().Contains(txt)
					  select nome;

			foreach (var n in res)
			{
				lista.Items.Add(n);
			}
		}

		private void btnOrderBy_Click(object sender, EventArgs e)
		{
			// Operador de ordenação
			lista.Items.Clear();
			string txt = txtConsultar.Text;

			//var res = from num in lista_numeros 
			//		  orderby num descending // ascending
			//		  where num <= 10 
			//		  select num;

			//var res = from num in lista_numeros
			//		  orderby num descending // ascending
			//		  select num;

			//var res = from num in lista_numeros
			//		  select num;

			//var res = from nome in lista_nome
			//		  orderby nome
			//		  select nome;

			//foreach (var n in res)
			//         {
			//	lista.Items.Add(n);
			//         }

			var res = from produto in lista_produtos
					  orderby produto.Key
					  select produto;

			foreach (KeyValuePair<string, double> item in res)
			{
				lista.Items.Add(item.Key + " R$ " + item.Value);
			}
		}

		private void btnGroupBy_Click(object sender, EventArgs e)
		{
			// Operadores de Agrupamento
			lista.Items.Clear();
			txtConsultar.Text = "";

			var res = from estado in lista_estado
					  group estado by estado.Value;

			foreach (var grupo in res)
			{
				lista.Items.Add(grupo.Key);

				foreach (var estado in grupo)
				{
					lista.Items.Add("       " + estado.Key);
				}
			}
		}

		private void btnAgregacao_Click(object sender, EventArgs e)
		{
			#region Contagem
			//int cont1 = lista_nome.Count();
			//int cont2 = (from nome in lista_nome 
			//			where nome.StartsWith("G") 
			//			select nome).Count();

			//lista.Items.Add(cont1 + " nomes.");
			//lista.Items.Add(cont2 + " nomes começados com a letra G.");

			//long contagem = lista_numeros.LongCount();
			#endregion

			#region Média
			//double media1 = lista_numeros.Average();
			//lista.Items.Add(media1 + " média dos valores na lista de números.");

			//var res1 = from num in lista_numeros 
			//		   where num < 10 
			//		   select num;

			//double media2 = res1.Average();
			//lista.Items.Add(media2 + " média menores que 10.");
			#endregion

			#region Soma
			//int soma1 = lista_numeros.Sum();
			//lista.Items.Add(soma1 + " soma dos valores.");

			//var res2 = from num in lista_numeros
			//		   where num < 10
			//		   select num;

			//int soma2 = res2.Sum();
			//lista.Items.Add(soma2 + " soma dos valores < 10.");
			#endregion

			#region Mínimo e Máximo
			// Também aplicados nas consultas.
			//lista.Items.Add(lista_numeros.Min() + " valor mínimo em lista números.");
			//lista.Items.Add(lista_numeros.Max() + " valor máximo em lista números.");
			#endregion

			string maiorNome = lista_nome.Aggregate((maior, proximo) =>
			{
				if (maior.Length > proximo.Length)
				{
					return maior;
				}
				else
				{
					return proximo;
				}
			});

			lista.Items.Add(maiorNome + " é o maior nome da lista.");
		}
	}
}
