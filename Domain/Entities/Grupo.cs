using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Grupo
	{
		public Grupo(string nome, int quantidade, decimal valor, DateTime dataRevelacao, string descricao, string? foto)
		{	
			Nome = nome;
			Quantidade = quantidade;
			Valor = valor;
			DataRevelacao = dataRevelacao;
			Descricao = descricao;
			Foto = foto;
		}

		public Grupo(int idGrupo, string nome, int qtdUsuario, decimal valor, DateTime dataRevelacao, string descricao, string? foto)
		{
			GrupoId = idGrupo;
			Nome = nome;
			Quantidade = qtdUsuario;
			Valor = valor;
			DataRevelacao = dataRevelacao;
			Descricao = descricao;
			Foto = foto;
		}

		public int GrupoId { get; private set; }
		public string Nome { get; private set; }
		public int Quantidade { get; private set; }
		public decimal Valor { get; private set; }
		public DateTime DataRevelacao { get; private set; }
		public string Descricao { get; private set; }
		public string? Foto { get; private set; }
		public ICollection<GrupoUsuario> GrupoUsuarios { get; set; }
    }
}
