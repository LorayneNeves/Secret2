using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Grupo
	{
		public Grupo(string? foto, string nome, int quantidade, decimal valor, DateTime dataRevelacao, string descricao)
		{
			Foto = foto;
			Nome = nome;
			Quantidade = quantidade;
			Valor = valor;
			DataRevelacao = dataRevelacao;
			Descricao = descricao;			
		}

		public Grupo(int idGrupo, string? imagem, string nome, int qtdUsuario, decimal valor, DateTime dataRevelacao, string descricao)
		{
			GrupoId = idGrupo;
			Foto = imagem;
			Nome = nome;
			Quantidade = qtdUsuario;
			Valor = valor;
			DataRevelacao = dataRevelacao;
			Descricao = descricao;
		}

		public int GrupoId { get; private set; }
		public string? Foto { get; private set; }
		public string Nome { get; private set; }
		public int Quantidade { get; private set; }
		public decimal Valor { get; private set; }
		public DateTime DataRevelacao { get; private set; }
		public string Descricao { get; private set; }
        public ICollection<GrupoUsuario> GrupoUsuarios { get; set; }
    }
}
